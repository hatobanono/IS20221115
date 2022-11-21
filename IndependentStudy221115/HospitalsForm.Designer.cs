﻿namespace IndependentStudy221115
{
	partial class HospitalsForm
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
			this.hospitalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hospitalIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addNewButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hospitalIndexVMBindingSource)).BeginInit();
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
            this.hospitalNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.hospitalIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(489, 304);
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
			// hospitalNameDataGridViewTextBoxColumn
			// 
			this.hospitalNameDataGridViewTextBoxColumn.DataPropertyName = "HospitalName";
			this.hospitalNameDataGridViewTextBoxColumn.HeaderText = "HospitalName";
			this.hospitalNameDataGridViewTextBoxColumn.Name = "hospitalNameDataGridViewTextBoxColumn";
			this.hospitalNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressDataGridViewTextBoxColumn.Width = 150;
			// 
			// telephoneDataGridViewTextBoxColumn
			// 
			this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
			this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
			this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
			this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hospitalIndexVMBindingSource
			// 
			this.hospitalIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.HospitalIndexVM);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(408, 362);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "新增醫院";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// HospitalsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 414);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HospitalsForm";
			this.Text = "醫院清單";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hospitalIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource hospitalIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hospitalNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
	}
}