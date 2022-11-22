namespace IndependentStudy221115
{
	partial class EditVaccineForm
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
			this.editButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.vcnNameTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(49, 142);
			this.editButton.Margin = new System.Windows.Forms.Padding(4);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(100, 33);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "修改";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(166, 142);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(100, 33);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// vcnNameTextBox
			// 
			this.vcnNameTextBox.Location = new System.Drawing.Point(133, 32);
			this.vcnNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.vcnNameTextBox.MaxLength = 50;
			this.vcnNameTextBox.Name = "vcnNameTextBox";
			this.vcnNameTextBox.Size = new System.Drawing.Size(132, 25);
			this.vcnNameTextBox.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "疫苗名稱: ";
			// 
			// countryTextBox
			// 
			this.countryTextBox.Location = new System.Drawing.Point(133, 71);
			this.countryTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.countryTextBox.MaxLength = 50;
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(132, 25);
			this.countryTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "製造國家:";
			// 
			// EditVaccineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 200);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.countryTextBox);
			this.Controls.Add(this.vcnNameTextBox);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.editButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditVaccineForm";
			this.Text = "編輯疫苗";
			this.Load += new System.EventHandler(this.EditVaccineForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox vcnNameTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox countryTextBox;
	}
}