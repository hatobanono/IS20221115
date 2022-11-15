using IndependentStudy221115.Infra;
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
	public partial class EditVaccineForm : Form
	{
		private int id;
		public EditVaccineForm(int id)
		{
			InitializeComponent();
			this.id = id;
		}

		private void EditVaccineForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			string sql = "SELECT * FROM Vaccines WHERE Id = @Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉 找不到紀錄");
				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}

			VaccineVM model = ToVaccineVM(data.Rows[0]);

			textBox1.Text = model.VaccineName;
		}

		private VaccineVM ToVaccineVM(DataRow dataRow)
		{
			return new VaccineVM
			{
				Id = dataRow.Field<int>("Id"),
				VaccineName = dataRow.Field<string>("VaccineName"),
			};
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			string name =textBox1.Text;

			VaccineVM model = new VaccineVM
			{
				Id = id,
				VaccineName = name,
			};

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"VaccineName", textBox1},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			try
			{
				new VaccineService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗 原因: " + ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您確定要刪除嗎?",
								"刪除紀錄",
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = "DELETE FROM Vaccines WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

			this.DialogResult = DialogResult.OK;
		}
	}
}
