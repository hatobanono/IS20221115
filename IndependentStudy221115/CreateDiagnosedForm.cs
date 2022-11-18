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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using IndependentStudy221115.Infra;
using IndependentStudy221115.Models.DTOs;
using IndependentStudy221115.Models.Services;

namespace IndependentStudy221115
{
	public partial class CreateDiagnosedForm : Form
	{
		private int id;
		public CreateDiagnosedForm(int id)
		{
			InitializeComponent();
			InitForm();
			this.id = id;
		}

		private void InitForm()
		{
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

			List<HotelVM> hotels = GetHotels();
			List<HospitalVM> hospitals = GetHospitals();

			this.comboBox1.DataSource = hospitals;
			this.comboBox2.DataSource = hotels;
		}

		private List<HospitalVM> GetHospitals()
		{
			var sql = "SELECT * FROM Hospitals";
			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToHospitalVM(row))
				.ToList();
		}

		private HospitalVM ToHospitalVM(DataRow row)
		{
			return new HospitalVM
			{
				Id = row.Field<int>("Id"),
				HospitalName = row.Field<string>("HospitalName"),
			};
		}

		private List<HotelVM> GetHotels()
		{
			var sql = "SELECT * FROM Hotels";
			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ToHotelVM(row))
				.ToList();
		}

		private HotelVM ToHotelVM(DataRow row)
		{
			return new HotelVM
			{
				Id = row.Field<int>("Id"),
				HotelName = row.Field<string>("HotelName"),
			};
		}

		private void CreateDiagnosedForm_Load(object sender, EventArgs e)
		{
			//BindData(id);
		}

		private void BindData(int id)
		{
			throw new NotImplementedException();
		}

		private void diagnosedButton_Click(object sender, EventArgs e)
		{
			var dt = dateTimePicker1.Value;
			var hospital = ((HospitalVM)this.comboBox1.SelectedItem).Id;
			var hotel = ((HotelVM)this.comboBox2.SelectedItem).Id;

			DiagnosedVM model = new DiagnosedVM
			{
				PatientId = id,
				Date = dt,
				HospitalId = hospital,
				HotelId = hotel,
			};

			//Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			//{
			//	{"Name", nameTextBox},
			//	{"Gender", passwordTextBox},
			//	{"Age", ageTextBox},
			//};

			//bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			//if (!isValid) return;


			try
			{
				new DiagnosedService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
