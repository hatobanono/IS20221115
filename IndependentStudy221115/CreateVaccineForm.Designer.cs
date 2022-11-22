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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.vcnNameTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(94, 120);
			this.addNewButton.Margin = new System.Windows.Forms.Padding(4);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(100, 33);
			this.addNewButton.TabIndex = 2;
			this.addNewButton.Text = "新增";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "製造國家:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "疫苗名稱: ";
			// 
			// countryTextBox
			// 
			this.countryTextBox.Location = new System.Drawing.Point(108, 69);
			this.countryTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.countryTextBox.MaxLength = 50;
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(132, 25);
			this.countryTextBox.TabIndex = 1;
			// 
			// vcnNameTextBox
			// 
			this.vcnNameTextBox.Location = new System.Drawing.Point(108, 29);
			this.vcnNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.vcnNameTextBox.MaxLength = 50;
			this.vcnNameTextBox.Name = "vcnNameTextBox";
			this.vcnNameTextBox.Size = new System.Drawing.Size(132, 25);
			this.vcnNameTextBox.TabIndex = 0;
			// 
			// CreateVaccineForm
			// 
			this.AcceptButton = this.addNewButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 174);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.countryTextBox);
			this.Controls.Add(this.vcnNameTextBox);
			this.Controls.Add(this.addNewButton);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateVaccineForm";
			this.Text = "新增疫苗";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.Windows.Forms.TextBox vcnNameTextBox;
	}
}