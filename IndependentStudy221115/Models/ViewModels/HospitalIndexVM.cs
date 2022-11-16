using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class HospitalIndexVM
	{
		public int Id { get; set; }
		public string HospitalName { get; set; }
		public string Address { get; set; }
		public string Telephone { get; set; }

	}
	public class HospitalVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "名稱必填")]
		public string HospitalName { get; set; }

		[Required(ErrorMessage = "地址必填")]
		public string Address { get; set; }

		[Required(ErrorMessage = "電話必填")]
		public string Telephone { get; set; }
	}
}
