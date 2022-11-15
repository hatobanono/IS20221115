namespace IndependentStudy221115
{
	partial class CreateVaccineForm
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
			this.addNewButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.addNewTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(106, 52);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 0;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "新增疫苗名稱";
			// 
			// addNewTextBox
			// 
			this.addNewTextBox.Location = new System.Drawing.Point(56, 24);
			this.addNewTextBox.Name = "addNewTextBox";
			this.addNewTextBox.Size = new System.Drawing.Size(105, 22);
			this.addNewTextBox.TabIndex = 2;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateVaccineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 88);
			this.Controls.Add(this.addNewTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addNewButton);
			this.Name = "CreateVaccineForm";
			this.Text = "新增疫苗";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox addNewTextBox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}