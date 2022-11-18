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
			((System.ComponentModel.ISupportInitialize)(this.hospitalIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "確診日期:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(110, 89);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "就診醫院:";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.hospitalIndexVMBindingSource;
			this.comboBox1.DisplayMember = "HospitalName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(110, 117);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.ValueMember = "Id";
			// 
			// hospitalIndexVMBindingSource
			// 
			this.hospitalIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.HospitalIndexVM);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "隔離旅館:";
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.hotelIndexVMBindingSource;
			this.comboBox2.DisplayMember = "HotelName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(110, 143);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.ValueMember = "Id";
			// 
			// hotelIndexVMBindingSource
			// 
			this.hotelIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.HotelIndexVM);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 12);
			this.label4.TabIndex = 4;
			this.label4.Text = "label4";
			// 
			// diagnosedButton
			// 
			this.diagnosedButton.Location = new System.Drawing.Point(235, 183);
			this.diagnosedButton.Name = "diagnosedButton";
			this.diagnosedButton.Size = new System.Drawing.Size(75, 23);
			this.diagnosedButton.TabIndex = 5;
			this.diagnosedButton.Text = "送出";
			this.diagnosedButton.UseVisualStyleBackColor = true;
			this.diagnosedButton.Click += new System.EventHandler(this.diagnosedButton_Click);
			// 
			// CreateDiagnosedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 257);
			this.Controls.Add(this.diagnosedButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Name = "CreateDiagnosedForm";
			this.Text = "CreateDiagnosedForm";
			this.Load += new System.EventHandler(this.CreateDiagnosedForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.hospitalIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotelIndexVMBindingSource)).EndInit();
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
	}
}