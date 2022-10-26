using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Message_label_in_2lines
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = string.Empty;
		}

		private void greetingButton_Click(object sender, EventArgs e)
		{
			//取得姓氏
			string firstName;
			string lastName;

			try
			{
				lastName = GetLastName();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			try
			{
				firstName = GetFirstName();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//取得現在系統時間
			DateTime now = DateTime.Now;

			//打招呼用Label
			resultLabel.Text = GreetingInLabel2(lastName, firstName, now);
		}

		private string GreetingInLabel2(string lastName, string firstName, DateTime now)
		{
			return $"您好，{lastName} {firstName}同學！\r\n現在時間是{now: yyyy/MM/dd HH:mm:ss}";
		}

		private string GetLastName()
		{
			string lastName = lastNameTextBox.Text.ToString();
			if (string.IsNullOrEmpty(lastName))
			{
				throw new Exception("您必須輸入姓氏");
			}

			return lastName;
		}

		private string GetFirstName()
		{
			string firstName = firstNameTextBox.Text.ToString();
			if (string.IsNullOrEmpty(firstName))
			{
				throw new Exception("您必須輸入名字");
			}
			return firstName;
		}
	}
}
