using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class DiagnosedIndexVM
	{
		public string Name { get; set; }
		public string Hotel { get; set; }

		public string HotelAddress { get; set; }
		public string HotelTelephone { get; set; }
		public string Hospital { get; set; }
		public string HospitalAddress { get; set; }
		public string HospitalTelephone { get; set; }
	}
	public class DiagnosedVM
	{
		public int Id { get; set; }
		public int PatientId { get; set; }
		[Required(ErrorMessage = "時間必填")]
		public DateTime Date { get; set; }
		[Required(ErrorMessage = "旅館必填")]
		public int HotelId { get; set; }
		[Required(ErrorMessage = "醫院必填")]
		public int HospitalId { get; set; }
	}
}
