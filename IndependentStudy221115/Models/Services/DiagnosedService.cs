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
		public void Create(DiagnosedVM model)
		{
			bool isExists = AccountExists(model.PatientId);
			if (isExists)
			{
				throw new Exception("病人已存在");
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

		private bool AccountExists(int patientId)
		{
			string sql = @"SELECT Count(*) as count FROM Diagnoseds WHERE PatientId = @PatientId";

			var parameters = new SqlParameterBuilder()
				.AddInt("PatientId", patientId)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
	}
}
