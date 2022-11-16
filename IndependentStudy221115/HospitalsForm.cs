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
	public partial class HospitalsForm : Form
	{
		private HospitalIndexVM[] hospitals = null;
		public HospitalsForm()
		{
			InitializeComponent();
			DisplayHospitals();
		}

		private void DisplayHospitals()
		{
			hospitals = new HospitalService().GetAll().ToArray();
			BindData(hospitals);
		}

		private void BindData(HospitalIndexVM[] hospitals)
		{
			dataGridView1.DataSource = hospitals;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateHospitalForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayHospitals();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			HospitalIndexVM row = this.hospitals[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditHospitalForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayHospitals();
			}
		}
	}
}
