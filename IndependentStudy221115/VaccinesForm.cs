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
	public partial class VaccinesForm : Form
	{
		private VaccineIndexVM[] vaccines = null;
		public VaccinesForm()
		{
			InitializeComponent();
			DisplayVaccines();
		}

		private void DisplayVaccines()
		{
			vaccines = new VaccineService().GetAll().ToArray();
			BindData(vaccines);
		}

		private void BindData(VaccineIndexVM[] vaccines)
		{
			dataGridView1.DataSource = vaccines;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateVaccineForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayVaccines();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			var row = this.vaccines[rowIndx];
			int id = row.Id;

			var frm = new EditVaccineForm(id);

			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayVaccines();
			}
		}
	}
}
