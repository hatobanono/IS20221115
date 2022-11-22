namespace IndependentStudy221115
{
	partial class EditUserForm
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
			this.accountTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nickNameTextBox = new System.Windows.Forms.TextBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.editButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號:";
			// 
			// accountTextBox
			// 
			this.accountTextBox.Location = new System.Drawing.Point(100, 23);
			this.accountTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.accountTextBox.MaxLength = 50;
			this.accountTextBox.Name = "accountTextBox";
			this.accountTextBox.Size = new System.Drawing.Size(159, 25);
			this.accountTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 67);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼:";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(100, 62);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.passwordTextBox.MaxLength = 50;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(159, 25);
			this.passwordTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "暱稱:";
			// 
			// nickNameTextBox
			// 
			this.nickNameTextBox.Location = new System.Drawing.Point(100, 102);
			this.nickNameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nickNameTextBox.MaxLength = 50;
			this.nickNameTextBox.Name = "nickNameTextBox";
			this.nickNameTextBox.Size = new System.Drawing.Size(159, 25);
			this.nickNameTextBox.TabIndex = 2;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(160, 142);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(100, 33);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(52, 142);
			this.editButton.Margin = new System.Windows.Forms.Padding(4);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(100, 33);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "修改";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 200);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.nickNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.accountTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditUserForm";
			this.Text = "編輯使用者";
			this.Load += new System.EventHandler(this.EditUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox accountTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nickNameTextBox;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button editButton;
	}
}