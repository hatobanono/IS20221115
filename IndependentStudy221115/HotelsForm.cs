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
	public partial class HotelsForm : Form
	{
		private HotelIndexVM[] hotels = null;
		public HotelsForm()
		{
			InitializeComponent();
			DisplayHotels();
		}

		private void DisplayHotels()
		{
			hotels = new HotelService().GetAll().ToArray();
			BindData(hotels);
		}

		private void BindData(HotelIndexVM[] hotels)
		{
			dataGridView1.DataSource = hotels;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateHotelForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayHotels();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			HotelIndexVM row = this.hotels[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditHotelForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayHotels();
			}
		}
	}
}
