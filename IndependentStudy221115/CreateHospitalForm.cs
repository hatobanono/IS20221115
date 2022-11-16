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
	public partial class CreateHospitalForm : Form
	{
		public CreateHospitalForm()
		{
			InitializeComponent();
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string hospitalName = hospitalNameTextBox.Text;
			string address = addressTextBox.Text;
			string telephone = telephoneTextBox.Text;

			// 將它們繫結到ViewModel
			HospitalVM model = new HospitalVM
			{
				HospitalName = hospitalName,
				Address = address,
				Telephone = telephone,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"HospitalName", hospitalNameTextBox},
				{"Address", addressTextBox},
				{"Telephone", telephoneTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			try
			{
				new HospitalService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
