namespace IndependentStudy221115
{
	partial class CreateDiagnosedForm
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.hospitalIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.hotelIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.diagnosedButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.hospitalIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 96);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "確診日期:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(112, 86);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(265, 25);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 130);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "就診醫院:";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.hospitalIndexVMBindingSource;
			this.comboBox1.DisplayMember = "HospitalName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(112, 126);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(265, 25);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.ValueMember = "Id";
			// 
			// hospitalIndexVMBindingSource
			// 
			this.hospitalIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.HospitalIndexVM);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 167);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "隔離旅館:";
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.hotelIndexVMBindingSource;
			this.comboBox2.DisplayMember = "HotelName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(112, 163);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(265, 25);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.ValueMember = "Id";
			// 
			// hotelIndexVMBindingSource
			// 
			this.hotelIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.HotelIndexVM);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 28);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "label4";
			// 
			// diagnosedButton
			// 
			this.diagnosedButton.Location = new System.Drawing.Point(279, 220);
			this.diagnosedButton.Margin = new System.Windows.Forms.Padding(4);
			this.diagnosedButton.Name = "diagnosedButton";
			this.diagnosedButton.Size = new System.Drawing.Size(100, 33);
			this.diagnosedButton.TabIndex = 3;
			this.diagnosedButton.Text = "送出";
			this.diagnosedButton.UseVisualStyleBackColor = true;
			this.diagnosedButton.Click += new System.EventHandler(this.diagnosedButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateDiagnosedForm
			// 
			this.AcceptButton = this.diagnosedButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 270);
			this.Controls.Add(this.diagnosedButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateDiagnosedForm";
			this.Text = "確診通報";
			this.Load += new System.EventHandler(this.CreateDiagnosedForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.hospitalIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button diagnosedButton;
		private System.Windows.Forms.BindingSource hospitalIndexVMBindingSource;
		private System.Windows.Forms.BindingSource hotelIndexVMBindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}