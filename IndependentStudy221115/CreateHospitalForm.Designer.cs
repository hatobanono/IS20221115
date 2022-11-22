namespace IndependentStudy221115
{
	partial class CreateHospitalForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.hospitalNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.telephoneTextBox = new System.Windows.Forms.TextBox();
			this.addNewButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "醫院:";
			// 
			// hospitalNameTextBox
			// 
			this.hospitalNameTextBox.Location = new System.Drawing.Point(105, 19);
			this.hospitalNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.hospitalNameTextBox.MaxLength = 50;
			this.hospitalNameTextBox.Name = "hospitalNameTextBox";
			this.hospitalNameTextBox.Size = new System.Drawing.Size(225, 25);
			this.hospitalNameTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 63);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "地址:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(105, 59);
			this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.addressTextBox.MaxLength = 50;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(225, 25);
			this.addressTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 102);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "電話:";
			// 
			// telephoneTextBox
			// 
			this.telephoneTextBox.Location = new System.Drawing.Point(105, 98);
			this.telephoneTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.telephoneTextBox.MaxLength = 50;
			this.telephoneTextBox.Name = "telephoneTextBox";
			this.telephoneTextBox.Size = new System.Drawing.Size(225, 25);
			this.telephoneTextBox.TabIndex = 2;
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(154, 158);
			this.addNewButton.Margin = new System.Windows.Forms.Padding(4);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(100, 33);
			this.addNewButton.TabIndex = 3;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateHospitalForm
			// 
			this.AcceptButton = this.addNewButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 205);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.telephoneTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.hospitalNameTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateHospitalForm";
			this.Text = "新增醫院";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox hospitalNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox telephoneTextBox;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}