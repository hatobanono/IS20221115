using IndependentStudy221115.Infra;
using IndependentStudy221115.Models.Services;
using IndependentStudy221115.Models.ViewModels;
using ISpan.Utility;
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
	public partial class EditVaccineForm : Form
	{
		private int id;
		public EditVaccineForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void EditVaccineForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			VaccineVM model = new VaccineService().Get(id);

			// 再將 viewModel值繫結到各控制項
			vcnNameTextBox.Text = model.VaccineName;
			countryTextBox.Text = model.Country;
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			string name =vcnNameTextBox.Text;
			string country = countryTextBox.Text;

			VaccineVM model = new VaccineVM
			{
				Id = id,
				VaccineName = name,
				Country = country,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"VaccineName", vcnNameTextBox},
				{"Country", countryTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new VaccineService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗 原因: " + ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您確定要刪除嗎?",
								"刪除紀錄",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			

			new VaccineService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
