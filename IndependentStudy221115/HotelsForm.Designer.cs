namespace IndependentStudy221115
{
	partial class HotelsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hotelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hotelIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addNewButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hotelNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.hotelIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(16, 17);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(729, 415);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 40;
			// 
			// hotelNameDataGridViewTextBoxColumn
			// 
			this.hotelNameDataGridViewTextBoxColumn.DataPropertyName = "HotelName";
			this.hotelNameDataGridViewTextBoxColumn.HeaderText = "旅館名稱";
			this.hotelNameDataGridViewTextBoxColumn.Name = "hotelNameDataGridViewTextBoxColumn";
			this.hotelNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.hotelNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "旅館地址";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressDataGridViewTextBoxColumn.Width = 200;
			// 
			// telephoneDataGridViewTextBoxColumn
			// 
			this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
			this.telephoneDataGridViewTextBoxColumn.HeaderText = "旅館電話";
			this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
			this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// capacityDataGridViewTextBoxColumn
			// 
			this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
			this.capacityDataGridViewTextBoxColumn.HeaderText = "容納人數";
			this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
			this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hotelIndexVMBindingSource
			// 
			this.hotelIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.HotelIndexVM);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(575, 489);
			this.addNewButton.Margin = new System.Windows.Forms.Padding(4);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(127, 33);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "新增防疫旅館";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// HotelsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(761, 568);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HotelsForm";
			this.Text = "防疫旅館清單";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource hotelIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hotelNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
	}
}