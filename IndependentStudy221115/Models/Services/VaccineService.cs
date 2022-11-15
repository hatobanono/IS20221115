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
			if (isExists) throw new Exception("帳號已存在");

			string sql = "INSERT INTO Vaccines(VaccineName) VALUES (@VaccineName)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, model.VaccineName)
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
			};
		}

		public void Update(VaccineVM model)
		{
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			string sql = @"UPDATE Vaccines 
						   SET VaccineName = @VaccineName 
						   WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, model.VaccineName)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(VaccineVM model)
		{
			string sql = "SELECT COUNT(*) AS count FROM Vaccines WHERE VaccineName = @VaccineName AND Id <> @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("VaccineName", 50, model.VaccineName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
	}
}
