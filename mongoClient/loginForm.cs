using System;
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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
			if(!ServerConnection.Connected)
			{
				try
				{
					new ServerConnection(tbServerAddress.Text);
					SetConnectedState();
					FillComboboxWithDatabaseNames(ServerConnection.Server);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				ServerConnection.DatabaseName = cbDatabases.Text;
				CloseLoginFormOpenMain();
			}
        }

        private void FillComboboxWithDatabaseNames(MongoServer server)
        {
            cbDatabases.Items.Clear();
            cbDatabases.Items.AddRange(server.GetDatabaseNames().ToArray());
            if (cbDatabases.Items.Count > 0)
            {
                cbDatabases.SelectedIndex = 0;
            }
        }

		private void SetConnectedState()
		{
			btConnect.Text = "Launch";
			btCancel.Text = "Disconnect";
			cbDatabases.Enabled = true;
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

		private void SetDisconnectedState()
		{
			btConnect.Text = "Connect";
			btCancel.Text = "Exit";
			cbDatabases.Enabled = false;
			cbDatabases.Items.Clear();
			ServerConnection.Connected = false;
		}

        private void tbServerAddress_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;				
                btConnect_Click(this, e);
				btConnect.Focus();
            }
        }

        private void CloseLoginFormOpenMain()
        {
            MainForm mainForm = new MainForm();
            this.Visible = false;
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
