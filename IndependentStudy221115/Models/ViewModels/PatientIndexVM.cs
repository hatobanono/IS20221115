using IndependentStudy221115.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class PatientIndexVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }
		public string FirstVcn { get; set; }
		public string SecondVcn { get; set; }
		public string ThirdVcn { get; set; }
		public string StrIsDiagnosed { get; set; }
		public Bitmap Image { get; set; }
	}
	public class PatientVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "名字必填")]
		public string Name { get; set; }
		[Required(ErrorMessage = "性別必選")]
		public int Gender { get; set; }
		[Required(ErrorMessage = "年齡必填")]
		public int Age { get; set; }
		public int FirstVcn { get; set; }
		public int SecondVcn { get; set; }
		public int ThirdVcn { get; set; }
	}
	public static class PatientVMExts
	{
		public static PatientDTO ToDTO(this PatientVM vm)
		{
			return new PatientDTO
			{
				Id = vm.Id,
				Name = vm.Name,
				Gender = vm.Gender,
				Age = vm.Age,
				FirstVcn = vm.FirstVcn,
				SecondVcn = vm.SecondVcn,
				ThirdVcn = vm.ThirdVcn,
			};
		}
	}
}
