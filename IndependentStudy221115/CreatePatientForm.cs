using IndependentStudy221115.Infra;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentStudy221115
{
	public partial class CreatePatientForm : Form
	{
		public CreatePatientForm()
		{
			InitializeComponent();
			InitForm();
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

		private void saveButton_Click(object sender, EventArgs e)
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
				//{"Gender", gender0RadioButton}
				{"Age", ageTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			PatientDTO dto = model.ToDTO();

			try
			{
				new PatientService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
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
	}
}
