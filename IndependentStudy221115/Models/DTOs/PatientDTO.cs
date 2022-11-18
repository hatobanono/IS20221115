using IndependentStudy221115.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.DTOs
{
	public class PatientDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Gender { get; set; }
		public int Age { get; set; }
		public string V1Name { get; set; }
		public string V2Name { get; set; }
		public string V3Name { get; set; }
		public int FirstVcn { get; set; }
		public int SecondVcn { get; set; }
		public int ThirdVcn { get; set; }
	}

	public static class PatientDTOExts
	{
		public static PatientVM ToVM(this PatientDTO dto)
		{
			return new PatientVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Gender = dto.Gender,
				Age = dto.Age,
				FirstVcn = dto.FirstVcn,
				SecondVcn = dto.SecondVcn,
				ThirdVcn = dto.ThirdVcn,
			};
		}

		public static PatientIndexVM ToIndexVM(this PatientDTO dto)
		{
			return new PatientIndexVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Gender = (dto.Gender==1) ? "男":"女",
				Age = dto.Age,
				FirstVcn = dto.V1Name,
				SecondVcn = dto.V2Name,
				ThirdVcn = dto.V3Name,
			};
		}
	}
}
