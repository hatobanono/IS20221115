using IndependentStudy221115.Infra;
using IndependentStudy221115.Infra.DAOs;
using IndependentStudy221115.Infra.Extensions;
using IndependentStudy221115.Models.DTOs;
using IndependentStudy221115.Models.Services;
using IndependentStudy221115.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentStudy221115
{
	public partial class EditPatientForm : Form
	{
		public int id;
		public EditPatientForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

			List<VaccineVM> vaccines1 = GetVaccines();
			List<VaccineVM> vaccines2 = GetVaccines();
			List<VaccineVM> vaccines3 = GetVaccines();

			this.comboBox1.DataSource = vaccines1;
			this.comboBox2.DataSource = vaccines2;
			this.comboBox3.DataSource = vaccines3;
		}

		private List<VaccineVM> GetVaccines()
		{
			var sql = "SELECT * FROM Vaccines";
			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToVaccineVM(row))
				.ToList();
		}

		private VaccineVM ToVaccineVM(DataRow row)
		{
			return new VaccineVM
			{
				Id = row.Field<int>("Id"),
				VaccineName = row.Field<string>("VaccineName"),
			};
		}

		private void EditPatientForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			PatientDTO dto = new PatientDAO().Get(id);

			label7.Text = "健康";
			label8.Text = string.Empty;
			label9.Text = string.Empty;
			if (new DiagnosedService().AccountExists(id))
			{
				label7.Text = "確診隔離中";
				var ds = new DiagnosedService().Get(id);
				label8.Text = $"{ds.Hospital}\r\n{ds.HospitalAddress}\r\n{ds.HospitalTelephone}";
				label9.Text = $"{ds.Hotel}\r\n{ds.HotelAddress}\r\n{ds.HotelTelephone}";
			}

			// 把DTO轉型為ViewModel
			PatientVM model = dto.ToVM();

			// 再將 viewModel值繫結到各控制項
			nameTextBox.Text = model.Name;
			SetGender(model);
			ageTextBox.Text = model.Age.ToString();
			comboBox1.SelectedItem = ((List<VaccineVM>)comboBox1.DataSource)
												.FirstOrDefault(x => x.Id == model.FirstVcn);
			comboBox2.SelectedItem = ((List<VaccineVM>)comboBox2.DataSource)
												.FirstOrDefault(x => x.Id == model.SecondVcn);
			comboBox3.SelectedItem = ((List<VaccineVM>)comboBox3.DataSource)
												.FirstOrDefault(x => x.Id == model.ThirdVcn);
		}

		private void SetGender(PatientVM model)
		{
			RadioButton[] controls = new RadioButton[] { gender0RadioButton, gender1RadioButton };

			//先清空所有 radio button被勾選的狀態
			foreach (RadioButton item in controls)
			{
				item.Checked = false;
			}

			//根據 value,決定哪一個radio button 要被選取
			foreach (RadioButton item in controls)
			{
				int controlTag = Convert.ToInt32(item.Tag);
				if (controlTag == model.Gender)
				{
					item.Checked = true;
					break;
				}
			}
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string name = nameTextBox.Text;
			int gender = GetGender();
			int age = ageTextBox.Text.ToInt(-1);
			int firstVcn = ((VaccineVM)this.comboBox1.SelectedItem).Id;
			int secondVcn = ((VaccineVM)this.comboBox2.SelectedItem).Id;
			int thirdVcn = ((VaccineVM)this.comboBox3.SelectedItem).Id;

			// 將它們繫結到ViewModel
			PatientVM model = new PatientVM
			{
				Id = this.id,
				Name = name,
				Gender = gender,
				Age = age,
				FirstVcn = firstVcn,
				SecondVcn = secondVcn,
				ThirdVcn = thirdVcn,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", nameTextBox},
				//{"Gender", passwordTextBox},
				{"Age", ageTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			PatientDTO dto = model.ToDTO();


			// update record
			try
			{
				new PatientService().Update(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int GetGender()
		{
			RadioButton[] controls = new RadioButton[] { gender0RadioButton, gender1RadioButton };

			int value = -1;
			foreach (RadioButton item in controls)
			{
				if (item.Checked == true)
				{
					value = Convert.ToInt32(item.Tag);
					break;
				}
			}
			return value;
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

			new PatientService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}

		private void addDiagnosedbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateDiagnosedForm(id);
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
