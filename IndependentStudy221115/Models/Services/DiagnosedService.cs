using IndependentStudy221115.Infra.DAOs;
using IndependentStudy221115.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IndependentStudy221115.Models.Services
{
	public class DiagnosedService
	{
		public DiagnosedIndexVM Get(int id)
		{
			string sql = @"SELECT p.[Name], HospitalName, h.[Address] ha, h.Telephone ht, HotelName, m.[Address] ma, m.Telephone mt
FROM Diagnoseds d
JOIN Patients p
ON d.PatientId = p.Id
JOIN Hospitals h
ON d.HospitalId = h.Id
JOIN Hotels m
ON d.HotelId = m.Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("PatientId", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToDiagnosedIndexVM(data.Rows[0]);
		}

		private DiagnosedIndexVM ToDiagnosedIndexVM(DataRow dataRow)
		{
			return new DiagnosedIndexVM()
			{
				Name = dataRow.Field<string>("Name"),
				Hospital = dataRow.Field<string>("HospitalName"),
				HospitalAddress = dataRow.Field<string>("ha"),
				HospitalTelephone = dataRow.Field<string>("ht"),
				Hotel = dataRow.Field<string>("HotelName"),
				HotelAddress = dataRow.Field<string>("ma"),
				HotelTelephone = dataRow.Field<string>("mt"),
			};
		}

		public void Create(DiagnosedVM model)
		{
			if(model.Date > DateTime.Now) { throw new Exception("日期不能大於今日"); }
			bool isExists = AccountExists(model.PatientId);
			if (isExists)
			{
				string sql = @"UPDATE Diagnoseds
SET Date = @Date, HospitalId = @HospitalId, HotelId = @HotelId
WHERE PatientId = @PatientId";

				var parameters = new SqlParameterBuilder()
					.AddInt("PatientId", model.PatientId)
					.AddDateTime("Date", model.Date)
					.AddInt("HospitalId", model.HospitalId)
					.AddInt("HotelId", model.HotelId)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			}
			else
			{
				string sql = @"INSERT INTO Diagnoseds
(PatientId, Date, HospitalId, HotelId)
VALUES
(@PatientId, @Date, @HospitalId, @HotelId)";

				var parameters = new SqlParameterBuilder()
					.AddInt("PatientId", model.PatientId)
					.AddDateTime("Date", model.Date)
					.AddInt("HospitalId", model.HospitalId)
					.AddInt("HotelId", model.HotelId)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			}
		}

		public bool AccountExists(int patientId)
		{
			string sql = @"SELECT Count(*) as count FROM Diagnoseds WHERE PatientId = @PatientId";

			var parameters = new SqlParameterBuilder()
				.AddInt("PatientId", patientId)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public bool IsStillDiagnosed(int id)
		{
			DateTime dt = GetDate(id);
			TimeSpan ts = DateTime.Now - dt;
			return ts.TotalDays <= 7;
		}

		private DateTime GetDate(int id)
		{
			string sql = "SELECT * FROM Diagnoseds WHERE PatientId = @PatientId";
			var parameters = new SqlParameterBuilder()
				.AddInt("PatientId", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<DateTime>("Date");
		}
	}
}
