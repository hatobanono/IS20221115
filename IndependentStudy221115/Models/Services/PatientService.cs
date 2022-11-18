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
			bool isExists = _dao.AccountExists(model.Name);
			if (isExists) throw new Exception("病人已存在");

			new PatientDAO().Create(model);

		}

		//private PatientIndexVM ParseToIndexVM(DataRow row)
		//{
		//	return new PatientIndexVM
		//	{
		//		Id = row.Field<int>("Id"),
		//		Name = row.Field<string>("Name"),
		//		Gender = row.Field<string>("Gender"),
		//		Age = row.Field<int>("Age"),
		//	};
		//}

		internal void Update(PatientDTO model)
		{
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
