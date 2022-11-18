using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class DiagnosedVM
	{
		public int Id { get; set; }
		public int PatientId { get; set; }
		public DateTime Date { get; set; }
		public int HotelId { get; set; }
		public int HospitalId { get; set; }
	}
}
