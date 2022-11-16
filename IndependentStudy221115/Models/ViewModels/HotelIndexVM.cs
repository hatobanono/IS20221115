using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class HotelIndexVM
	{
		public int Id { get; set; }
		public string HotelName { get; set; }
		public string Address { get; set; }
		public string Telephone { get; set; }
		public string Capacity { get; set; }

	}
	public class HotelVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "名稱必填")]
		public string HotelName { get; set; }

		[Required(ErrorMessage = "地址必填")]
		public string Address { get; set; }

		[Required(ErrorMessage = "電話必填")]
		public string Telephone { get; set; }

		[Required(ErrorMessage = "容納人數必填")]
		public int Capacity { get; set; }
	}
}
