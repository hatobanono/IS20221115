using IndependentStudy221115.Infra;
using IndependentStudy221115.Models.DTOs;
using IndependentStudy221115.Models.Services;
using IndependentStudy221115.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentStudy221115
{
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click_1(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string nickName = nickNameTextBox.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				NickName = nickName,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"NickName", nickNameTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			UserDTO dto = model.ToDTO();


			try
			{
				// new UserService().Create(model);
				new UserService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
