using IndependentStudy221115.Infra;
using IndependentStudy221115.Infra.Extensions;
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
	public partial class CreateHotelForm : Form
	{
		public CreateHotelForm()
		{
			InitializeComponent();
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string hotelName = hotelNameTextBox.Text;
			string address = addressTextBox.Text;
			string telephone = telephoneTextBox.Text;
			int capacity = capacityTextBox.Text.ToInt(-1);
			//todo 驗證

			// 將它們繫結到ViewModel
			HotelVM model = new HotelVM
			{
				HotelName = hotelName,
				Address = address,
				Telephone = telephone,
				Capacity = capacity,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"HospitalName", hotelNameTextBox},
				{"Address", addressTextBox},
				{"Telephone", telephoneTextBox},
				{"Capacity", capacityTextBox}
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			try
			{
				new HotelService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
