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
	public partial class EditHotelForm : Form
	{
		private int id;
		public EditHotelForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void EditHotelForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			HotelVM model = new HotelService().Get(id);

			// 再將 viewModel值繫結到各控制項
			hotelNameTextBox.Text = model.HotelName;
			addressTextBox.Text = model.Address;
			telephoneTextBox.Text = model.Telephone;
			capacityTextBox.Text = model.Capacity.ToString();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string hotelName = hotelNameTextBox.Text;
			string address = addressTextBox.Text;
			string telephone = telephoneTextBox.Text;
			int capacity = capacityTextBox.Text.ToInt(-1);

			// 將它們繫結到ViewModel
			HotelVM model = new HotelVM
			{
				Id = this.id,
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
				//{"Capacity", capacityTextBox}
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// update record
			try
			{
				new HotelService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
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

			new HotelService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
