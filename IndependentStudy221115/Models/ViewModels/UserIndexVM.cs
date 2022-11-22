using IndependentStudy221115.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.ViewModels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		// public string Password { get; set; }

		public string NickName { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }


		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }


		[Required(ErrorMessage = "名字必填")]
		public string NickName { get; set; }
	}

	public static class UserVMExts
	{
		public static UserDTO ToDTO(this UserVM vm)
		{
			return new UserDTO
			{
				Id = vm.Id,
				Account = vm.Account,
				Password = vm.Password,
				NickName = vm.NickName
			};
		}
	}
}
