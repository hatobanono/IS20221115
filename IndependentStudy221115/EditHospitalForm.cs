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
	public partial class EditHospitalForm : Form
	{
		private int id;
		public EditHospitalForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void EditHospitalForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			HospitalVM model = new HospitalService().Get(id);

			// 再將 viewModel值繫結到各控制項
			hospitalNameTextBox.Text = model.HospitalName;
			addressTextBox.Text = model.Address;
			telephoneTextBox.Text = model.Telephone;
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string hospitalName = hospitalNameTextBox.Text;
			string address = addressTextBox.Text;
			string telephone = telephoneTextBox.Text;

			// 將它們繫結到ViewModel
			HospitalVM model = new HospitalVM
			{
				Id = this.id,
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

			// update record
			try
			{
				new HospitalService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new HospitalService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
