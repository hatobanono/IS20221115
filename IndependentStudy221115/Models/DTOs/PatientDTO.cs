using IndependentStudy221115.Models.Services;
using IndependentStudy221115.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
		public int? IsDiagnosed { get; set; }
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
			var check = new Bitmap(@"..\..\Infra\images\463574.png");
			var cross = new Bitmap(@"..\..\Infra\images\2569174.png");

			string result = string.Empty;
			if (dto.IsDiagnosed.HasValue)
			{
				if (new DiagnosedService().IsStillDiagnosed(dto.Id))
				{
					result = "確診隔離中";
				}
				else
				{
					result = "已解除隔離";
				}
			}
			else
			{
				result = "健康狀態";
			}

				return new PatientIndexVM
				{
					Id = dto.Id,
					Name = dto.Name,
					Gender = (dto.Gender == 1) ? "男" : "女",
					Age = dto.Age,
					FirstVcn = dto.V1Name,
					SecondVcn = dto.V2Name,
					ThirdVcn = dto.V3Name,
					StrIsDiagnosed = result,
					Image = (result == "確診隔離中") ? new Bitmap(cross, 20, 20) : new Bitmap(check, 20, 20) ,
			};
		}
	}
}
