using IndependentStudy221115.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.Services
{
	public class VaccineService
	{
		public IEnumerable<VaccineIndexVM> GetAll()
		{
			string sql = "SELECT * FROM Vaccines";

			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}

		public void Create(VaccineVM model)
		{
			bool isExists = AccountExists(model.VaccineName);
			if (isExists) throw new Exception("疫苗已存在");

			string sql = "INSERT INTO Vaccines(VaccineName, Country) VALUES (@VaccineName, @Country)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, model.VaccineName)
				.AddNVarchar("Country", 50, model.Country)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(string vaccineName)
		{
			string sql = "SELECT COUNT(*) AS count FROM Vaccines WHERE VaccineName = @VaccineName";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, vaccineName)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private VaccineIndexVM ParseToIndexVM(DataRow row)
		{
			return new VaccineIndexVM
			{
				Id = row.Field<int>("Id"),
				VaccineName = row.Field<string>("VaccineName"),
				Country = row.Field<string>("Country")
			};
		}

		public void Update(VaccineVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("疫苗已存在");

			string sql = @"UPDATE Vaccines 
						   SET VaccineName = @VaccineName,
							   Country = @Country 
						   WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, model.VaccineName)
				.AddNVarchar("Country", 50, model.Country)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(VaccineVM model)
		{
			string sql = "SELECT COUNT(*) AS count FROM Vaccines WHERE VaccineName = @VaccineName AND Id != @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, model.VaccineName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		internal VaccineVM Get(int id)
		{
			string sql = "SELECT * FROM Vaccines WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
				//MessageBox.Show("抱歉, 找不到要編輯的記錄");
				//this.DialogResult = DialogResult.Abort;


				//return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToVaccineVM(data.Rows[0]);
		}

		private VaccineVM ToVaccineVM(DataRow dataRow)
		{
			return new VaccineVM
			{
				Id = dataRow.Field<int>("Id"),
				VaccineName = dataRow.Field<string>("VaccineName"),
				Country = dataRow.Field<string>("Country"),
			};
		}

		public void Delete(int id)
		{
			string sql = "DELETE FROM Vaccines WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
