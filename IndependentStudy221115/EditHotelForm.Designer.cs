namespace IndependentStudy221115
{
	partial class EditHotelForm
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
			this.deleteButton = new System.Windows.Forms.Button();
			this.capacityTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.telephoneTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.hotelNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.editButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(264, 198);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(100, 33);
			this.deleteButton.TabIndex = 5;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// capacityTextBox
			// 
			this.capacityTextBox.Location = new System.Drawing.Point(137, 159);
			this.capacityTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.capacityTextBox.MaxLength = 50;
			this.capacityTextBox.Name = "capacityTextBox";
			this.capacityTextBox.Size = new System.Drawing.Size(225, 25);
			this.capacityTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 163);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "容納人數:";
			// 
			// telephoneTextBox
			// 
			this.telephoneTextBox.Location = new System.Drawing.Point(137, 119);
			this.telephoneTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.telephoneTextBox.MaxLength = 50;
			this.telephoneTextBox.Name = "telephoneTextBox";
			this.telephoneTextBox.Size = new System.Drawing.Size(225, 25);
			this.telephoneTextBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 123);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "電　　話:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(137, 79);
			this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.addressTextBox.MaxLength = 50;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(225, 25);
			this.addressTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 84);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "地　　址:";
			// 
			// hotelNameTextBox
			// 
			this.hotelNameTextBox.Location = new System.Drawing.Point(137, 40);
			this.hotelNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.hotelNameTextBox.MaxLength = 50;
			this.hotelNameTextBox.Name = "hotelNameTextBox";
			this.hotelNameTextBox.Size = new System.Drawing.Size(225, 25);
			this.hotelNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 44);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "防疫旅館:";
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(137, 198);
			this.editButton.Margin = new System.Windows.Forms.Padding(4);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(100, 33);
			this.editButton.TabIndex = 4;
			this.editButton.Text = "修改";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditHotelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 271);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.capacityTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.telephoneTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hotelNameTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditHotelForm";
			this.Text = "編輯防疫旅館";
			this.Load += new System.EventHandler(this.EditHotelForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox capacityTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox telephoneTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox hotelNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}