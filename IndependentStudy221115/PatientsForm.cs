using IndependentStudy221115.Infra.DAOs;
using IndependentStudy221115.Models.DTOs;
using IndependentStudy221115.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
			var usersIcon = new Bitmap(@"..\..\Infra\images\3394785.png");
			var vaccineIcon = new Bitmap(@"..\..\Infra\images\1086932.png");
			var hotelIcon = new Bitmap(@"..\..\Infra\images\905462.png");
			var hospitalIcon = new Bitmap(@"..\..\Infra\images\33777.png");
			var logoutIcon = new Bitmap(@"..\..\Infra\images\660350.png");
			InitializeComponent();
			DisplayPatients();
			var dto = new UserDAO().Get(account);
			label1.Text = $"歡迎，{dto.NickName}";
			this.usersFormButton.Image = new Bitmap(usersIcon, 20, 20);
			this.vaccinesFormButton.Image = new Bitmap(vaccineIcon, 20, 20);
			this.hotelsFormButton.Image = new Bitmap(hotelIcon, 20, 20);
			this.hospitalsFormButton.Image = new Bitmap(hospitalIcon, 20, 20);
			this.logoutButton.Image = new Bitmap(logoutIcon, 20, 20);

			this.usersFormButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.vaccinesFormButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.hospitalsFormButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.hotelsFormButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
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

		private void PatientsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
		
		private void usersFormButton_Click(object sender, EventArgs e)
		{
			var frm = new UsersForm();
			frm.Show();
		}

		private void vaccinesFormButton_Click(object sender, EventArgs e)
		{
			var frm = new VaccinesForm();
			frm.Show();
		}

		private void hotelsFormButton_Click(object sender, EventArgs e)
		{
			var frm = new HotelsForm();
			frm.Show();
		}

		private void hospitalsFormButton_Click(object sender, EventArgs e)
		{
			var frm = new HospitalsForm();
			frm.Show();
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
