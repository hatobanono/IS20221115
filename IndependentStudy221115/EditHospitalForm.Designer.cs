namespace IndependentStudy221115
{
	partial class EditHospitalForm
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
			this.hospitalNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.telephoneTextBox = new System.Windows.Forms.TextBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "醫院:";
			// 
			// hospitalNameTextBox
			// 
			this.hospitalNameTextBox.Location = new System.Drawing.Point(78, 49);
			this.hospitalNameTextBox.Name = "hospitalNameTextBox";
			this.hospitalNameTextBox.Size = new System.Drawing.Size(170, 22);
			this.hospitalNameTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "地址:";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(78, 77);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(170, 22);
			this.addressTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "電話:";
			// 
			// telephoneTextBox
			// 
			this.telephoneTextBox.Location = new System.Drawing.Point(78, 105);
			this.telephoneTextBox.Name = "telephoneTextBox";
			this.telephoneTextBox.Size = new System.Drawing.Size(170, 22);
			this.telephoneTextBox.TabIndex = 1;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(173, 147);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 2;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(78, 147);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "修改";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditHospitalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 197);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.telephoneTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.hospitalNameTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.label2);
			this.Name = "EditHospitalForm";
			this.Text = "EditHospitalForm";
			this.Load += new System.EventHandler(this.EditHospitalForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox hospitalNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox telephoneTextBox;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}