namespace IndependentStudy221115
{
	partial class CreateUserForm
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
			this.saveButton = new System.Windows.Forms.Button();
			this.nickNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(106, 127);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 9;
			this.saveButton.Text = "新增";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
			// 
			// nickNameTextBox
			// 
			this.nickNameTextBox.Location = new System.Drawing.Point(81, 99);
			this.nickNameTextBox.Name = "nickNameTextBox";
			this.nickNameTextBox.Size = new System.Drawing.Size(100, 22);
			this.nickNameTextBox.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "暱稱:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(81, 71);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
			this.passwordTextBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "密碼:";
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(81, 43);
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(100, 22);
			this.accountTextBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "帳號:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 191);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.nickNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.label1);
			this.Name = "CreateUserForm";
			this.Text = "CreateUserForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox nickNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}