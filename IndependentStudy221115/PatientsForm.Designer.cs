﻿namespace IndependentStudy221115
{
	partial class PatientsForm
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
			this.addNewButton = new System.Windows.Forms.Button();
			this.patientIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secondVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thirdVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.patientIndexVMBindingSource)).BeginInit();
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
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.firstVcnDataGridViewTextBoxColumn,
            this.secondVcnDataGridViewTextBoxColumn,
            this.thirdVcnDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.patientIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 292);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(713, 400);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "新增病患";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// patientIndexVMBindingSource
			// 
			this.patientIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.PatientIndexVM);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ageDataGridViewTextBoxColumn
			// 
			this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
			this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
			this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
			this.ageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstVcnDataGridViewTextBoxColumn
			// 
			this.firstVcnDataGridViewTextBoxColumn.DataPropertyName = "FirstVcn";
			this.firstVcnDataGridViewTextBoxColumn.HeaderText = "FirstVcn";
			this.firstVcnDataGridViewTextBoxColumn.Name = "firstVcnDataGridViewTextBoxColumn";
			this.firstVcnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// secondVcnDataGridViewTextBoxColumn
			// 
			this.secondVcnDataGridViewTextBoxColumn.DataPropertyName = "SecondVcn";
			this.secondVcnDataGridViewTextBoxColumn.HeaderText = "SecondVcn";
			this.secondVcnDataGridViewTextBoxColumn.Name = "secondVcnDataGridViewTextBoxColumn";
			this.secondVcnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// thirdVcnDataGridViewTextBoxColumn
			// 
			this.thirdVcnDataGridViewTextBoxColumn.DataPropertyName = "ThirdVcn";
			this.thirdVcnDataGridViewTextBoxColumn.HeaderText = "ThirdVcn";
			this.thirdVcnDataGridViewTextBoxColumn.Name = "thirdVcnDataGridViewTextBoxColumn";
			this.thirdVcnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// PatientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "PatientsForm";
			this.Text = "PatientsForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.patientIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstVcnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn secondVcnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thirdVcnDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource patientIndexVMBindingSource;
	}
}