namespace IndependentStudy221115
{
	partial class EditPatientForm
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
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gender0RadioButton = new System.Windows.Forms.RadioButton();
			this.gender1RadioButton = new System.Windows.Forms.RadioButton();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.editButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.addDiagnosedbutton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(189, 272);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(100, 33);
			this.deleteButton.TabIndex = 8;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.DisplayMember = "VaccineName";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(128, 235);
			this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(160, 25);
			this.comboBox3.TabIndex = 6;
			this.comboBox3.ValueMember = "Id";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 239);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 17);
			this.label6.TabIndex = 14;
			this.label6.Text = "第三劑疫苗:";
			// 
			// comboBox2
			// 
			this.comboBox2.DisplayMember = "VaccineName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(128, 198);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(160, 25);
			this.comboBox2.TabIndex = 5;
			this.comboBox2.ValueMember = "Id";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 203);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "第二劑疫苗:";
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "VaccineName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(128, 162);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 25);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.ValueMember = "Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 166);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 17);
			this.label4.TabIndex = 16;
			this.label4.Text = "第一劑疫苗:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 91);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 17);
			this.label2.TabIndex = 13;
			this.label2.Text = "性別";
			// 
			// gender0RadioButton
			// 
			this.gender0RadioButton.AutoSize = true;
			this.gender0RadioButton.Location = new System.Drawing.Point(215, 91);
			this.gender0RadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.gender0RadioButton.Name = "gender0RadioButton";
			this.gender0RadioButton.Size = new System.Drawing.Size(39, 21);
			this.gender0RadioButton.TabIndex = 2;
			this.gender0RadioButton.Tag = "0";
			this.gender0RadioButton.Text = "女";
			this.gender0RadioButton.UseVisualStyleBackColor = true;
			// 
			// gender1RadioButton
			// 
			this.gender1RadioButton.AutoSize = true;
			this.gender1RadioButton.Location = new System.Drawing.Point(128, 91);
			this.gender1RadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.gender1RadioButton.Name = "gender1RadioButton";
			this.gender1RadioButton.Size = new System.Drawing.Size(39, 21);
			this.gender1RadioButton.TabIndex = 1;
			this.gender1RadioButton.Tag = "1";
			this.gender1RadioButton.Text = "男";
			this.gender1RadioButton.UseVisualStyleBackColor = true;
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(128, 122);
			this.ageTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.ageTextBox.MaxLength = 50;
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(132, 25);
			this.ageTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 126);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "年齡:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(128, 51);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextBox.MaxLength = 50;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(132, 25);
			this.nameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "姓名:";
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(53, 272);
			this.editButton.Margin = new System.Windows.Forms.Padding(4);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(100, 33);
			this.editButton.TabIndex = 7;
			this.editButton.Text = "修改";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// addDiagnosedbutton
			// 
			this.addDiagnosedbutton.Location = new System.Drawing.Point(115, 317);
			this.addDiagnosedbutton.Margin = new System.Windows.Forms.Padding(4);
			this.addDiagnosedbutton.Name = "addDiagnosedbutton";
			this.addDiagnosedbutton.Size = new System.Drawing.Size(100, 33);
			this.addDiagnosedbutton.TabIndex = 9;
			this.addDiagnosedbutton.Text = "通報確診";
			this.addDiagnosedbutton.UseVisualStyleBackColor = true;
			this.addDiagnosedbutton.Click += new System.EventHandler(this.addDiagnosedbutton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(73, 13);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 17);
			this.label7.TabIndex = 23;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(315, 41);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 17);
			this.label8.TabIndex = 24;
			this.label8.Text = "label8";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(315, 198);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 17);
			this.label9.TabIndex = 25;
			this.label9.Text = "label9";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(16, 13);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(49, 45);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(315, 13);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 17);
			this.label10.TabIndex = 27;
			this.label10.Text = "就診醫院";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(317, 164);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 17);
			this.label11.TabIndex = 28;
			this.label11.Text = "防疫旅館";
			// 
			// EditPatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 366);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.addDiagnosedbutton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.deleteButton);
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
			this.Name = "EditPatientForm";
			this.Text = "編輯病患";
			this.Load += new System.EventHandler(this.EditPatientForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton gender0RadioButton;
		private System.Windows.Forms.RadioButton gender1RadioButton;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button addDiagnosedbutton;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
	}
}