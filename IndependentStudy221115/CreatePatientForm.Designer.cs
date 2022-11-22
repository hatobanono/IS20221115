namespace IndependentStudy221115
{
	partial class CreatePatientForm
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
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.gender1RadioButton = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.gender0RadioButton = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.vaccineVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.vaccineVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "姓名:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(136, 31);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextBox.MaxLength = 50;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(132, 25);
			this.nameTextBox.TabIndex = 0;
			// 
			// gender1RadioButton
			// 
			this.gender1RadioButton.AutoSize = true;
			this.gender1RadioButton.Location = new System.Drawing.Point(136, 71);
			this.gender1RadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.gender1RadioButton.Name = "gender1RadioButton";
			this.gender1RadioButton.Size = new System.Drawing.Size(39, 21);
			this.gender1RadioButton.TabIndex = 1;
			this.gender1RadioButton.Tag = "1";
			this.gender1RadioButton.Text = "男";
			this.gender1RadioButton.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(84, 71);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "性別";
			// 
			// gender0RadioButton
			// 
			this.gender0RadioButton.AutoSize = true;
			this.gender0RadioButton.Location = new System.Drawing.Point(223, 71);
			this.gender0RadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.gender0RadioButton.Name = "gender0RadioButton";
			this.gender0RadioButton.Size = new System.Drawing.Size(39, 21);
			this.gender0RadioButton.TabIndex = 2;
			this.gender0RadioButton.Tag = "0";
			this.gender0RadioButton.Text = "女";
			this.gender0RadioButton.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "年齡:";
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(136, 102);
			this.ageTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.ageTextBox.MaxLength = 50;
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(132, 25);
			this.ageTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 146);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "第一劑疫苗:";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.vaccineVMBindingSource;
			this.comboBox1.DisplayMember = "VaccineName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(136, 142);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 25);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.ValueMember = "Id";
			// 
			// vaccineVMBindingSource
			// 
			this.vaccineVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.VaccineVM);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 183);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "第二劑疫苗:";
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.vaccineVMBindingSource;
			this.comboBox2.DisplayMember = "VaccineName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(136, 178);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(160, 25);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.ValueMember = "Id";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 220);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 17);
			this.label6.TabIndex = 4;
			this.label6.Text = "第三劑疫苗:";
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.vaccineVMBindingSource;
			this.comboBox3.DisplayMember = "VaccineName";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(136, 215);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(160, 25);
			this.comboBox3.TabIndex = 5;
			this.comboBox3.ValueMember = "Id";
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(149, 252);
			this.saveButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(100, 33);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "新增";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreatePatientForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 312);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gender0RadioButton);
			this.Controls.Add(this.gender1RadioButton);
			this.Controls.Add(this.ageTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreatePatientForm";
			this.Text = "新增病患";
			((System.ComponentModel.ISupportInitialize)(this.vaccineVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.RadioButton gender1RadioButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton gender0RadioButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.BindingSource vaccineVMBindingSource;
	}
}