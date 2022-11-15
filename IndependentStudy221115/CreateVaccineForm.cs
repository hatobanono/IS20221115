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
	public partial class CreateVaccineForm : Form
	{
		public CreateVaccineForm()
		{
			InitializeComponent();
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			string vaccine = addNewTextBox.Text;

			VaccineVM model = new VaccineVM
			{
				VaccineName = vaccine,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"VaccineName", addNewTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new VaccineService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗 原因: " + ex.Message);
			}
		}
	}
}
