namespace IndependentStudy221115
{
	partial class CreateHotelForm
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
			this.addNewButton = new System.Windows.Forms.Button();
			this.telephoneTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.hotelNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.capacityTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(126, 156);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 9;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// telephoneTextBox
			// 
			this.telephoneTextBox.Location = new System.Drawing.Point(90, 100);
			this.telephoneTextBox.Name = "telephoneTextBox";
			this.telephoneTextBox.Size = new System.Drawing.Size(170, 22);
			this.telephoneTextBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "電　　話:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(90, 72);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(170, 22);
			this.addressTextBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "地　　址:";
			// 
			// hotelNameTextBox
			// 
			this.hotelNameTextBox.Location = new System.Drawing.Point(90, 44);
			this.hotelNameTextBox.Name = "hotelNameTextBox";
			this.hotelNameTextBox.Size = new System.Drawing.Size(170, 22);
			this.hotelNameTextBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "防疫旅館:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "容納人數:";
			// 
			// capacityTextBox
			// 
			this.capacityTextBox.Location = new System.Drawing.Point(90, 128);
			this.capacityTextBox.Name = "capacityTextBox";
			this.capacityTextBox.Size = new System.Drawing.Size(170, 22);
			this.capacityTextBox.TabIndex = 6;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateHotelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 210);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.capacityTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.telephoneTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hotelNameTextBox);
			this.Controls.Add(this.label1);
			this.Name = "CreateHotelForm";
			this.Text = "新增防疫旅館";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.TextBox telephoneTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox hotelNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox capacityTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}