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
			this.Image = new System.Windows.Forms.DataGridViewImageColumn();
			this.StrIsDiagnosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addNewButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.usersFormButton = new System.Windows.Forms.Button();
			this.vaccinesFormButton = new System.Windows.Forms.Button();
			this.hotelsFormButton = new System.Windows.Forms.Button();
			this.hospitalsFormButton = new System.Windows.Forms.Button();
			this.logoutButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.secondVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.thirdVcnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patientIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.dataGridView1.Location = new System.Drawing.Point(231, 99);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(983, 414);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Image
			// 
			this.Image.DataPropertyName = "Image";
			this.Image.HeaderText = "";
			this.Image.Name = "Image";
			this.Image.ReadOnly = true;
			this.Image.Width = 50;
			// 
			// StrIsDiagnosed
			// 
			this.StrIsDiagnosed.DataPropertyName = "StrIsDiagnosed";
			this.StrIsDiagnosed.HeaderText = "目前狀態";
			this.StrIsDiagnosed.Name = "StrIsDiagnosed";
			this.StrIsDiagnosed.ReadOnly = true;
			// 
			// addNewButton
			// 
			this.addNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addNewButton.Location = new System.Drawing.Point(903, 555);
			this.addNewButton.Margin = new System.Windows.Forms.Padding(4);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(100, 33);
			this.addNewButton.TabIndex = 1;
			this.addNewButton.Text = "新增病患";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(773, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// usersFormButton
			// 
			this.usersFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.usersFormButton.Location = new System.Drawing.Point(0, 24);
			this.usersFormButton.Name = "usersFormButton";
			this.usersFormButton.Size = new System.Drawing.Size(196, 50);
			this.usersFormButton.TabIndex = 4;
			this.usersFormButton.Text = "使用者管理";
			this.usersFormButton.UseVisualStyleBackColor = true;
			this.usersFormButton.Click += new System.EventHandler(this.usersFormButton_Click);
			// 
			// vaccinesFormButton
			// 
			this.vaccinesFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.vaccinesFormButton.Location = new System.Drawing.Point(0, 104);
			this.vaccinesFormButton.Name = "vaccinesFormButton";
			this.vaccinesFormButton.Size = new System.Drawing.Size(196, 50);
			this.vaccinesFormButton.TabIndex = 4;
			this.vaccinesFormButton.Text = "疫苗管理";
			this.vaccinesFormButton.UseVisualStyleBackColor = true;
			this.vaccinesFormButton.Click += new System.EventHandler(this.vaccinesFormButton_Click);
			// 
			// hotelsFormButton
			// 
			this.hotelsFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.hotelsFormButton.Location = new System.Drawing.Point(0, 183);
			this.hotelsFormButton.Name = "hotelsFormButton";
			this.hotelsFormButton.Size = new System.Drawing.Size(196, 50);
			this.hotelsFormButton.TabIndex = 4;
			this.hotelsFormButton.Text = "防疫旅館管理";
			this.hotelsFormButton.UseVisualStyleBackColor = true;
			this.hotelsFormButton.Click += new System.EventHandler(this.hotelsFormButton_Click);
			// 
			// hospitalsFormButton
			// 
			this.hospitalsFormButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.hospitalsFormButton.Location = new System.Drawing.Point(0, 264);
			this.hospitalsFormButton.Name = "hospitalsFormButton";
			this.hospitalsFormButton.Size = new System.Drawing.Size(196, 50);
			this.hospitalsFormButton.TabIndex = 4;
			this.hospitalsFormButton.Text = "醫院管理";
			this.hospitalsFormButton.UseVisualStyleBackColor = true;
			this.hospitalsFormButton.Click += new System.EventHandler(this.hospitalsFormButton_Click);
			// 
			// logoutButton
			// 
			this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.logoutButton.Location = new System.Drawing.Point(0, 343);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Size = new System.Drawing.Size(196, 50);
			this.logoutButton.TabIndex = 4;
			this.logoutButton.Text = "登出";
			this.logoutButton.UseVisualStyleBackColor = true;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.logoutButton);
			this.panel1.Controls.Add(this.usersFormButton);
			this.panel1.Controls.Add(this.hospitalsFormButton);
			this.panel1.Controls.Add(this.vaccinesFormButton);
			this.panel1.Controls.Add(this.hotelsFormButton);
			this.panel1.Location = new System.Drawing.Point(12, 99);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 414);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1202, 87);
			this.panel2.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(211, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(363, 45);
			this.label2.TabIndex = 4;
			this.label2.Text = "防 疫 資 料 管 理 系 統";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 50;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "名字";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "性別";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			this.genderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ageDataGridViewTextBoxColumn
			// 
			this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
			this.ageDataGridViewTextBoxColumn.HeaderText = "年齡";
			this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
			this.ageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstVcnDataGridViewTextBoxColumn
			// 
			this.firstVcnDataGridViewTextBoxColumn.DataPropertyName = "FirstVcn";
			this.firstVcnDataGridViewTextBoxColumn.HeaderText = "第一劑";
			this.firstVcnDataGridViewTextBoxColumn.Name = "firstVcnDataGridViewTextBoxColumn";
			this.firstVcnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// secondVcnDataGridViewTextBoxColumn
			// 
			this.secondVcnDataGridViewTextBoxColumn.DataPropertyName = "SecondVcn";
			this.secondVcnDataGridViewTextBoxColumn.HeaderText = "第二劑";
			this.secondVcnDataGridViewTextBoxColumn.Name = "secondVcnDataGridViewTextBoxColumn";
			this.secondVcnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// thirdVcnDataGridViewTextBoxColumn
			// 
			this.thirdVcnDataGridViewTextBoxColumn.DataPropertyName = "ThirdVcn";
			this.thirdVcnDataGridViewTextBoxColumn.HeaderText = "第三劑";
			this.thirdVcnDataGridViewTextBoxColumn.Name = "thirdVcnDataGridViewTextBoxColumn";
			this.thirdVcnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// patientIndexVMBindingSource
			// 
			this.patientIndexVMBindingSource.DataSource = typeof(IndependentStudy221115.Models.ViewModels.PatientIndexVM);
			// 
			// PatientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1227, 638);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(1243, 677);
			this.Name = "PatientsForm";
			this.Text = "病患清單";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientsForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.patientIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.BindingSource patientIndexVMBindingSource;
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
		private System.Windows.Forms.Button usersFormButton;
		private System.Windows.Forms.Button vaccinesFormButton;
		private System.Windows.Forms.Button hotelsFormButton;
		private System.Windows.Forms.Button hospitalsFormButton;
		private System.Windows.Forms.Button logoutButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
	}
}