﻿namespace IndependentStudy221115
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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(162, 196);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 20;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.DisplayMember = "VaccineName";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(116, 170);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 17;
			this.comboBox3.ValueMember = "Id";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 173);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 12);
			this.label6.TabIndex = 14;
			this.label6.Text = "第三劑疫苗:";
			// 
			// comboBox2
			// 
			this.comboBox2.DisplayMember = "VaccineName";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(116, 144);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 18;
			this.comboBox2.ValueMember = "Id";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 12);
			this.label5.TabIndex = 15;
			this.label5.Text = "第二劑疫苗:";
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "VaccineName";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(116, 118);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 19;
			this.comboBox1.ValueMember = "Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(42, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 12);
			this.label4.TabIndex = 16;
			this.label4.Text = "第一劑疫苗:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 13;
			this.label2.Text = "性別";
			// 
			// gender0RadioButton
			// 
			this.gender0RadioButton.AutoSize = true;
			this.gender0RadioButton.Location = new System.Drawing.Point(181, 68);
			this.gender0RadioButton.Name = "gender0RadioButton";
			this.gender0RadioButton.Size = new System.Drawing.Size(35, 16);
			this.gender0RadioButton.TabIndex = 11;
			this.gender0RadioButton.Tag = "0";
			this.gender0RadioButton.Text = "女";
			this.gender0RadioButton.UseVisualStyleBackColor = true;
			// 
			// gender1RadioButton
			// 
			this.gender1RadioButton.AutoSize = true;
			this.gender1RadioButton.Location = new System.Drawing.Point(116, 68);
			this.gender1RadioButton.Name = "gender1RadioButton";
			this.gender1RadioButton.Size = new System.Drawing.Size(35, 16);
			this.gender1RadioButton.TabIndex = 12;
			this.gender1RadioButton.Tag = "1";
			this.gender1RadioButton.Text = "男";
			this.gender1RadioButton.UseVisualStyleBackColor = true;
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(116, 90);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(100, 22);
			this.ageTextBox.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "年齡:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(116, 40);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 22);
			this.nameTextBox.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "姓名:";
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(60, 196);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 21;
			this.editButton.Text = "修改";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditPatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 263);
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
			this.Name = "EditPatientForm";
			this.Text = "EditPatientForm";
			this.Load += new System.EventHandler(this.EditPatientForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
	}
}