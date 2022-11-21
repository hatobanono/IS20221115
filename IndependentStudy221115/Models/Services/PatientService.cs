using IndependentStudy221115.Infra.DAOs;
using IndependentStudy221115.Models.DTOs;
using IndependentStudy221115.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.Services
{
	public class PatientService
	{
		private PatientDAO _dao;

		public PatientService()
		{
			_dao = new PatientDAO();
		}

		public void Create(PatientDTO model)
		{
			if (model.Gender == -1) throw new Exception("請選擇性別");
			if (model.Age == -1) throw new Exception("請正確填寫年齡");
			bool isExists = _dao.AccountExists(model.Name);
			if (isExists) throw new Exception("病人已存在");

			new PatientDAO().Create(model);

		}

		internal void Update(PatientDTO model)
		{
			if (model.Age == -1) throw new Exception("請正確填寫年齡");
			bool isExists = _dao.AccountExists(model);
			if (isExists) throw new Exception("病人已存在");

			new PatientDAO().Update(model);
		}

		internal void Delete(int id)
		{
			_dao.Delete(id);
		}
	}
}
