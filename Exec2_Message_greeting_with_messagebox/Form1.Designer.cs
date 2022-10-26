namespace Exec_Message_greeting_with_messagebox
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.greetingButton = new System.Windows.Forms.Button();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// greetingButton
			// 
			this.greetingButton.Location = new System.Drawing.Point(84, 218);
			this.greetingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.greetingButton.Name = "greetingButton";
			this.greetingButton.Size = new System.Drawing.Size(392, 36);
			this.greetingButton.TabIndex = 10;
			this.greetingButton.Text = "打招呼";
			this.greetingButton.UseVisualStyleBackColor = true;
			this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(85, 155);
			this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.firstNameTextBox.MaxLength = 20;
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(389, 25);
			this.firstNameTextBox.TabIndex = 9;
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.firstNameLabel.Location = new System.Drawing.Point(91, 130);
			this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(52, 25);
			this.firstNameLabel.TabIndex = 8;
			this.firstNameLabel.Text = "名字";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(85, 92);
			this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lastNameTextBox.MaxLength = 20;
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(389, 25);
			this.lastNameTextBox.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(91, 68);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "姓氏";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 399);
			this.Controls.Add(this.greetingButton);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.firstNameLabel);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "打招呼";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button greetingButton;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}

