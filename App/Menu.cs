﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PlayStationSharp.API;
using PlayStationSharp.Extensions;

namespace PlayStationSharp.TestApp
{
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private Account Account { get; set; }

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var account = Auth.CreateLogin();

			if (account == null) return;

			this.Account = account;
			TokenHandler.Write(account.Client.Tokens);

			SetupLogin(false);
			PopulateFields();
		}

		private void PopulateFields()
		{
			UserId.Text = Account.OnlineId;
			lstFriends.DataSource = Account.Friends.Online();
			lblFriends.Text = $"Friends ({lstFriends.Items.Count})";
		}

		private void SetupLogin(bool needsLogin)
		{
			btnLogin.Visible = needsLogin;

			UserId.Visible = !needsLogin;
			lstFriends.Visible = !needsLogin;
			lblFriends.Visible = !needsLogin;
			btnBackgroundColor.Visible = !needsLogin;
		}

		private void TestForm_Load(object sender, EventArgs e)
		{
			try
			{
				Account = TokenHandler.Check();
				SetupLogin(false);
				PopulateFields();
			}
			catch (Exception)
			{
				SetupLogin(true);
			}
		}

		private void lstFriends_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lstFriends.SelectedItem == null) return;

			new ProfileForm(lstFriends.SelectedItem as User).ShowDialog();
		}

		private void btnBackgroundColor_Click(object sender, EventArgs e)
		{
			if (colorBackgroundColor.ShowDialog() == DialogResult.OK)
			{
				Account.UpdateBackgroundColor(colorBackgroundColor.Color);
			}
		}

		private void btnDeleteInactives_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete all inactive friends?", "Confirm",
					MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				var friends = Account.Friends;
			}
		}

		private void btnBackgroundImage_Click(object sender, EventArgs e)
		{
			using (var fd = new OpenFileDialog())
			{
				if (fd.ShowDialog() == DialogResult.OK)
				{
					Account.UpdateBackgroundImage(Image.FromFile(fd.FileName));
				}
			}
		}
    }
}
