using IndependentStudy221115.Infra;
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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM
			{
				Account = accountTextBox.Text,
				Password = passwordTextBox.Text,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			accountTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;

			var frm = new PatientsForm();
			frm.Owner = this;

			frm.Show();
			this.Hide();
		}
	}
}
