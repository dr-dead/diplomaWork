﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongoClient
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btConnect_Click(object sender, EventArgs e)
		{
			if(!ServerConnection.Connected)
			{
				try
				{
					var connectionString = new MongoConnectionStringBuilder();
					connectionString.Server = new MongoServerAddress(tbServerAddress.Text);
					connectionString.Username = tbUser.Text;
					connectionString.Password = tbPassword.Text;
					connectionString.DatabaseName = "test";
					//new ServerConnection(tbServerAddress.Text);
					new ServerConnection(connectionString);
					//FillComboboxWithDatabaseNames(ServerConnection.Server);
					SetConnectedState();
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					tbServerAddress.Focus();
				}
			}
			else
			{
				//ServerConnection.DatabaseName = cbDatabases.Text;
				ServerConnection.DatabaseName = "test";
				CloseLoginFormOpenMain();
			}
		}

		/// <summary>
		/// Filling combobox with database names that server stores.
		/// </summary>
		/// <param name="server">MongoDB.Driver.MongoServer instance to connect to.</param>
		private void FillComboboxWithDatabaseNames(MongoServer server)
		{
			cbDatabases.Items.Clear();
			cbDatabases.Items.AddRange(server.GetDatabaseNames().ToArray());
			if(cbDatabases.Items.Count > 0)
			{
				cbDatabases.SelectedIndex = 0;
			}
		}

		/// <summary>
		/// Sets GUI to the connected mode.
		/// </summary>
		private void SetConnectedState()
		{
			btConnect.Text = LocalizableStrings.Launch;
			btCancel.Text = LocalizableStrings.Disconnect;
			cbDatabases.Enabled = true;
			tbServerAddress.Enabled = false;
			tbUser.Enabled = false;
			tbPassword.Enabled = false;
			ServerConnection.Connected = true;
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			if(!ServerConnection.Connected)
			{
				this.Close();
			}
			else
			{
				SetDisconnectedState();
			}
		}

		/// <summary>
		/// Sets GUI to the non-connected mode.
		/// </summary>
		private void SetDisconnectedState()
		{
			btConnect.Text = LocalizableStrings.Connect;
			btCancel.Text = LocalizableStrings.Exit;
			cbDatabases.Enabled = false;
			cbDatabases.Items.Clear();
			tbServerAddress.Enabled = true;
			tbUser.Enabled = true;
			tbPassword.Enabled = true;
			ServerConnection.Connected = false;
			tbServerAddress.Focus();
		}

		private void tbServerAddress_OnKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				btConnect.Focus();
				e.SuppressKeyPress = true;
				btConnect_Click(this, e);				
			}
		}

		private void CloseLoginFormOpenMain()
		{
			//MainForm mainForm = new MainForm();
			//this.Visible = false;
			//mainForm.ShowDialog();
			this.Close();
		}
	}
}
