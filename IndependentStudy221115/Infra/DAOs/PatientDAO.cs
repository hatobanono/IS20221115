using IndependentStudy221115.Models.DTOs;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Infra.DAOs
{
	public class PatientDAO
	{
		/// <summary>
		/// 傳回所有使用者記錄
		/// </summary>
		/// <returns></returns>
		public IEnumerable<PatientDTO> GetAll()
		{
			string sql = @"SELECT p.Id, p.[Name], p.Gender, p.Age, p.FirstVcn, p.SecondVcn, p.ThirdVcn, 
v.VaccineName [V1Name], v2.VaccineName [V2Name], v3.VaccineName [V3Name] 
FROM Patients p
LEFT JOIN Vaccines v 
ON v.Id = p.FirstVcn
LEFT JOIN Vaccines v2
ON v2.Id = p.SecondVcn
LEFT JOIN Vaccines v3
ON v3.Id = p.ThirdVcn";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new PatientDTO
				{
					Id = row.Field<int>("Id"),
					Name = row.Field<string>("Name"),
					Gender = row.Field<int>("Gender"),
					Age = row.Field<int>("Age"),
					FirstVcn = row.Field<int>("FirstVcn"),
					SecondVcn = row.Field<int>("SecondVcn"),
					ThirdVcn = row.Field<int>("ThirdVcn"),
					V1Name = row.Field<string>("V1Name"),
					V2Name = row.Field<string>("V2Name"),
					V3Name = row.Field<string>("V3Name"),
				}); ;

		}

		public bool AccountExists(string name)
		{
			string sql = @"SELECT Count(*) as count FROM Patients WHERE Name = @Name";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Name", 50, name)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(PatientDTO model)
		{
			string sql = "SELECT Count(*) as count FROM Patients WHERE Name = @Name AND Id != @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Name", 50, model.Name)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Create(PatientDTO model)
		{
			string sql = @"INSERT INTO Patients
(Name, Gender, Age, FirstVcn, SecondVcn, ThirdVcn)
VALUES
(@Name, @Gender, @Age, @FirstVcn, @SecondVcn, @ThirdVcn)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Name", 50, model.Name)
				.AddInt("Gender", model.Gender)
				.AddInt("Age", model.Age)
				.AddInt("FirstVcn", model.FirstVcn)
				.AddInt("SecondVcn", model.SecondVcn)
				.AddInt("ThirdVcn", model.ThirdVcn)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(PatientDTO model)
		{
			string sql = @"UPDATE Patients 
			SET Name = @Name, Gender = @Gender, Age = @Age, FirstVcn = @FirstVcn, SecondVcn = @SecondVcn, ThirdVcn = @ThirdVcn
			WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Name", 50, model.Name)
				.AddInt("Gender", model.Gender)
				.AddInt("Age", model.Age)
				.AddInt("FirstVcn", model.FirstVcn)
				.AddInt("SecondVcn", model.SecondVcn)
				.AddInt("ThirdVcn", model.ThirdVcn)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Patients WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public PatientDTO Get(string name)
		{
			string sql = "SELECT * FROM Patients WHERE Name = @Name";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Name", 50, name)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToPatientDTO(data.Rows[0]);
		}

		public PatientDTO Get(int id)
		{
			string sql = "SELECT * FROM Patients WHERE Id = @Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToPatientDTO(data.Rows[0]);
		}


		private PatientDTO ToPatientDTO(DataRow row)
		{
			return new PatientDTO
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				Gender = row.Field<int>("Gender"),
				Age = row.Field<int>("Age"),
				FirstVcn = row.Field<int>("FirstVcn"),
				SecondVcn = row.Field<int>("SecondVcn"),
				ThirdVcn = row.Field<int>("ThirdVcn"),
			};
		}
	}
}
