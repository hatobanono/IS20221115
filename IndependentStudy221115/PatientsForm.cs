using IndependentStudy221115.Infra.DAOs;
using IndependentStudy221115.Models.DTOs;
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
	public partial class PatientsForm : Form
	{
		private PatientIndexVM[] patients = null;
		public PatientsForm(string account)
		{
			InitializeComponent();
			DisplayPatients();
			var dto = new UserDAO().Get(account);
			label1.Text = $"歡迎，{dto.NickName}";
		}

		private void DisplayPatients()
		{
			patients = new PatientDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(patients);
		}

		private void BindData(PatientIndexVM[] patients)
		{
			dataGridView1.DataSource = patients;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			PatientIndexVM row = this.patients[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditPatientForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayPatients();
			}
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreatePatientForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayPatients();
			}
		}

		private void 管理使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new UsersForm();
			frm.Show();
		}

		private void 管理疫苗ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new VaccinesForm();
			frm.Show();
		}

		private void 防疫旅館管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new HotelsForm();
			frm.Show();
		}

		private void 醫院管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new HospitalsForm();
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PatientsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
