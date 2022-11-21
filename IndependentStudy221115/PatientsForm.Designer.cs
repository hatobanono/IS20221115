namespace IndependentStudy221115
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
			this.patientIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addNewButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.管理使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.管理疫苗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.防疫旅館管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.醫院管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Image = new System.Windows.Forms.DataGridViewImageColumn();
			this.StrIsDiagnosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secondVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thirdVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.patientIndexVMBindingSource)).BeginInit();
			this.menuStrip1.SuspendLayout();
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
            this.Image,
            this.StrIsDiagnosed,
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
			this.dataGridView1.Size = new System.Drawing.Size(896, 292);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// patientIndexVMBindingSource
			// 
			this.patientIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.PatientIndexVM);
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(664, 401);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "新增病患";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理使用者ToolStripMenuItem,
            this.管理疫苗ToolStripMenuItem,
            this.防疫旅館管理ToolStripMenuItem,
            this.醫院管理ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(920, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 管理使用者ToolStripMenuItem
			// 
			this.管理使用者ToolStripMenuItem.Name = "管理使用者ToolStripMenuItem";
			this.管理使用者ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.管理使用者ToolStripMenuItem.Text = "使用者管理";
			this.管理使用者ToolStripMenuItem.Click += new System.EventHandler(this.管理使用者ToolStripMenuItem_Click);
			// 
			// 管理疫苗ToolStripMenuItem
			// 
			this.管理疫苗ToolStripMenuItem.Name = "管理疫苗ToolStripMenuItem";
			this.管理疫苗ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.管理疫苗ToolStripMenuItem.Text = "疫苗管理";
			this.管理疫苗ToolStripMenuItem.Click += new System.EventHandler(this.管理疫苗ToolStripMenuItem_Click);
			// 
			// 防疫旅館管理ToolStripMenuItem
			// 
			this.防疫旅館管理ToolStripMenuItem.Name = "防疫旅館管理ToolStripMenuItem";
			this.防疫旅館管理ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
			this.防疫旅館管理ToolStripMenuItem.Text = "防疫旅館管理";
			this.防疫旅館管理ToolStripMenuItem.Click += new System.EventHandler(this.防疫旅館管理ToolStripMenuItem_Click);
			// 
			// 醫院管理ToolStripMenuItem
			// 
			this.醫院管理ToolStripMenuItem.Name = "醫院管理ToolStripMenuItem";
			this.醫院管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.醫院管理ToolStripMenuItem.Text = "醫院管理";
			this.醫院管理ToolStripMenuItem.Click += new System.EventHandler(this.醫院管理ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// Image
			// 
			this.Image.DataPropertyName = "Image";
			this.Image.HeaderText = "Image";
			this.Image.Name = "Image";
			this.Image.ReadOnly = true;
			// 
			// StrIsDiagnosed
			// 
			this.StrIsDiagnosed.DataPropertyName = "StrIsDiagnosed";
			this.StrIsDiagnosed.HeaderText = "StrIsDiagnosed";
			this.StrIsDiagnosed.Name = "StrIsDiagnosed";
			this.StrIsDiagnosed.ReadOnly = true;
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
			this.ClientSize = new System.Drawing.Size(920, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PatientsForm";
			this.Text = "PatientsForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientsForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.patientIndexVMBindingSource)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource patientIndexVMBindingSource;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 管理使用者ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 管理疫苗ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 防疫旅館管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 醫院管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn Image;
		private System.Windows.Forms.DataGridViewTextBoxColumn StrIsDiagnosed;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstVcnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn secondVcnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn thirdVcnDataGridViewTextBoxColumn;
	}
}