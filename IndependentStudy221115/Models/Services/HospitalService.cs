using IndependentStudy221115.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.Services
{
	public class HospitalService
	{
		public IEnumerable<HospitalIndexVM> GetAll()
		{
			string sql = "SELECT * FROM Hospitals";

			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}

		public void Create(HospitalVM model)
		{
			bool isExists = AccountExists(model.HospitalName);
			if (isExists) throw new Exception("醫院已存在");

			string sql = "INSERT INTO Hospitals(HospitalName, Address, Telephone) VALUES (@HospitalName, @Address, @Telephone)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HospitalName", 50, model.HospitalName)
				.AddNVarchar("Address", 50, model.Address)
				.AddNVarchar("Telephone", 50, model.Telephone)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(string hospitalName)
		{
			string sql = "SELECT COUNT(*) AS count FROM Hospitals WHERE HospitalName = @HospitalName";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HospitalName", 50, hospitalName)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private HospitalIndexVM ParseToIndexVM(DataRow row)
		{
			return new HospitalIndexVM
			{
				Id = row.Field<int>("Id"),
				HospitalName = row.Field<string>("HospitalName"),
				Address = row.Field<string>("Address"),
				Telephone = row.Field<string>("Telephone"),
			};
		}

		public void Update(HospitalVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("醫院已存在");

			string sql = @"UPDATE Hospitals 
						   SET HospitalName = @HospitalName,
							   Address = @Address,
							   Telephone = @Telephone
						   WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HospitalName", 50, model.HospitalName)
				.AddNVarchar("Address", 50, model.Address)
				.AddNVarchar("Telephone", 50, model.Telephone)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(HospitalVM model)
		{
			string sql = "SELECT COUNT(*) AS count FROM Hospitals WHERE HospitalName = @HospitalName AND Id != @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HospitalName", 50, model.HospitalName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		internal HospitalVM Get(int id)
		{
			string sql = "SELECT * FROM Hospitals WHERE Id=@Id";
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
			return ToHospitalVM(data.Rows[0]);
		}

		private HospitalVM ToHospitalVM(DataRow dataRow)
		{
			return new HospitalVM
			{
				Id = dataRow.Field<int>("Id"),
				HospitalName = dataRow.Field<string>("HospitalName"),
				Address = dataRow.Field<string>("Address"),
				Telephone = dataRow.Field<string>("Telephone"),
			};
		}

		public void Delete(int id)
		{
			string sql = "DELETE FROM Hospitals WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
