using IndependentStudy221115.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.DTOs
{
	public class UserDTO
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string NickName { get; set; }
	}

	public static class UserDTOExts
	{
		public static UserVM ToVM(this UserDTO dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				NickName = dto.NickName,
			};
		}

		public static UserIndexVM ToIndexVM(this UserDTO dto)
		{
			return new UserIndexVM
			{
				Id = dto.Id,
				Account = dto.Account,
				// Password = dto.Password,
				NickName = dto.NickName,
			};
		}
	}
}
