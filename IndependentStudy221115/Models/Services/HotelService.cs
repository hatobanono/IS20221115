using IndependentStudy221115.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentStudy221115.Models.Services
{
	public class HotelService
	{
		public IEnumerable<HotelIndexVM> GetAll()
		{
			string sql = "SELECT * FROM Hotels";

			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row));
		}

		public void Create(HotelVM model)
		{
			if (model.Capacity == -1) throw new Exception("容納人數必須填寫");
			bool isExists = AccountExists(model.HotelName);
			if (isExists) throw new Exception("防疫旅館已存在");

			string sql = "INSERT INTO Hotels(HotelName, Address, Telephone, Capacity) VALUES (@HotelName, @Address, @Telephone, @Capacity)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HotelName", 50, model.HotelName)
				.AddNVarchar("Address", 50, model.Address)
				.AddNVarchar("Telephone", 50, model.Telephone)
				.AddInt("Capacity", model.Capacity)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(string hotelName)
		{
			string sql = "SELECT COUNT(*) AS count FROM Hotels WHERE HotelName = @HotelName";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HotelName", 50, hotelName)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		private HotelIndexVM ParseToIndexVM(DataRow row)
		{
			return new HotelIndexVM
			{
				Id = row.Field<int>("Id"),
				HotelName = row.Field<string>("HotelName"),
				Address = row.Field<string>("Address"),
				Telephone = row.Field<string>("Telephone"),
				Capacity = row.Field<int>("Capacity").ToString(),
			};
		}

		public void Update(HotelVM model)
		{
			if (model.Capacity == -1) throw new Exception("容納人數必須填寫");
			bool isExists = AccountExists(model);
			if (isExists) throw new Exception("防疫旅館已存在");

			string sql = @"UPDATE Hotels 
						   SET HotelName = @HotelName,
							   Address = @Address,
							   Telephone = @Telephone,
							   Capacity = @Capacity 
						   WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HotelName", 50, model.HotelName)
				.AddNVarchar("Address", 50, model.Address)
				.AddNVarchar("Telephone", 50, model.Telephone)
				.AddInt("Capacity", model.Capacity)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool AccountExists(HotelVM model)
		{
			string sql = "SELECT COUNT(*) AS count FROM Hotels WHERE HotelName = @HotelName AND Id <> @Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("HotelName", 50, model.HotelName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		internal HotelVM Get(int id)
		{
			string sql = "SELECT * FROM Hotels WHERE Id=@Id";
			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");
				//MessageBox.Show("抱歉, 找不到要編輯的記錄");
				//this.DialogResult = DialogResult.Abort;


				//return;
			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToHotelVM(data.Rows[0]);
		}

		private HotelVM ToHotelVM(DataRow dataRow)
		{
			return new HotelVM
			{
				Id = dataRow.Field<int>("Id"),
				HotelName = dataRow.Field<string>("HotelName"),
				Address = dataRow.Field<string>("Address"),
				Telephone = dataRow.Field<string>("Telephone"),
				Capacity = dataRow.Field<int>("Capacity")
			};
		}

		public void Delete(int id)
		{
			string sql = "DELETE FROM Hotels WHERE Id = @Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
	}
}
