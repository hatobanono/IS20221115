using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class VaccineIndexVM
	{
		public int Id { get; set; }
		public string VaccineName { get; set; }

	}
	public class VaccineVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "名稱必填")]
		public string VaccineName { get; set; }

	}
}
