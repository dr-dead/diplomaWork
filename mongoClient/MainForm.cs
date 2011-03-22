using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
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
			
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			//SearchPatients(Query.Null);

			//Treaded version
			//PatientList.Enabled = false;
			//PatientList.Visible = false;
			//Thread crap = new Thread(ThreadedQuery);
			//crap.Start(Query.Null);	

			PatientList.Visible = false;
			bgWorker.RunWorkerAsync(Query.Null);			
		}

		private void ThreadedQuery(object objQuery)
		{
			SearchPatients((IMongoQuery)objQuery);
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
				string[] test = new string[]{ item.Id.ToString(), item.Surname, item.number.ToString() };

				//Non-threaded
				//PatientList.Items.Add(new ListViewItem(test));

				//Threaded version
				Invoke(new Action(() => { PatientList.Items.Add(new ListViewItem(test)); }));
			}
			//Threaded version
			//PatientList.Enabled = true;
			//Invoke(new Action(() => { PatientList.Visible = true; }));
		}

		private void OnColumnClick(object sender, ColumnClickEventArgs e)
		{
			// TODO: column sorter will be here.
		}

		private void PatientList_ItemActivate(object sender, EventArgs e)
		{
			// TODO: Fill the right panel with values.
			
			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName);
			var coll = db.GetCollection<Patient>("Patient");
			Patient queriedPatient = coll.FindOneById(new ObjectId(PatientList.SelectedItems[0].Text));
			FillRightPanelWithPatientInfo(queriedPatient);
		}

		/// <summary>
		/// Fills the right panel with patient's data.
		/// </summary>
		/// <param name="patient">mongoClient.Patient instance to get the info from.</param>
		private void FillRightPanelWithPatientInfo(Patient patient)
		{
			// TODO: Fill all the fields after class is done.

			tbID.Text = patient.Id.ToString();
			tbSurname.Text = patient.Surname;
		}

		private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			SearchPatients((IMongoQuery)e.Argument);
		}

		private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			PatientList.Visible = true;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			bgWorker.CancelAsync();
		}

		private void PatientList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			// HACK: Don't show the column which stores id's of the patients. Prevents from column resize.
			if(e.ColumnIndex == 0)
			{
				e.NewWidth = 0;
				e.Cancel = true;
			}
		}
	}
}
