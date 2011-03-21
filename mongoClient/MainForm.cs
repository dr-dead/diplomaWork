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
using MongoDB.Driver.Builders;

namespace mongoClient
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			SearchPatients(Query.Null);
		}

		/// <summary>
		/// Fills Patients' ListView with the query results.
		/// </summary>
		/// <param name="query">Query that implements IMongoQuery interface.</param>
		private void SearchPatients(IMongoQuery query)
		{
			PatientList.Items.Clear();
			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName);
			var coll = db.GetCollection<Patient>("Patient");
			foreach(var item in coll.Find(query))
			{
				string[] test = { item.Id.ToString(), item.name, item.number.ToString() };
				PatientList.Items.Add(new ListViewItem(test));
			}
		}

		private void OnColumnClick(object sender, ColumnClickEventArgs e)
		{
			// TODO: column sorter will be here
		}

		private void PatientList_ItemActivate(object sender, EventArgs e)
		{
			// TODO: Fill the right panel with values
		}
	}
}
