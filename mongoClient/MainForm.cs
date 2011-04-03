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
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			bgWorker.RunWorkerAsync(Query.Null);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			bgWorker.CancelAsync();
		}

		/// <summary>
		/// Fills Patients' ListView with the query results.
		/// </summary>
		/// <param name="query">Query that implements IMongoQuery interface.</param>
		private void SearchPatients(IMongoQuery query)
		{
			PatientList.InvokeIfRequired(c => { c.Items.Clear(); });
			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName);
			var coll = db.GetCollection<Patient>("Patient");
			foreach(var patientItem in coll.Find(query))
			{
				string[] patientAttributesArray = new string[]{ patientItem.Id.ToString(), patientItem.Surname, patientItem.Name, patientItem.Patronymic };
				PatientList.InvokeIfRequired(c => { c.Items.Add(new ListViewItem(patientAttributesArray)); });
			}
			PatientList.InvokeIfRequired(c => { c.ListViewItemSorter = new ListViewSorter(); });
		}

		private void OnColumnClick(object sender, ColumnClickEventArgs e)
		{
			// TODO: Improve sorting. Asc and desc sorting to be done.

			PatientList.ListViewItemSorter = new ListViewSorter(e.Column);
		}

		private void PatientList_ItemActivate(object sender, EventArgs e)
		{
			// TODO: Fill the right panel with values.
			
			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName);
			var coll = db.GetCollection<Patient>("Patient");
			var queriedPatient = coll.FindOneById(new ObjectId(PatientList.SelectedItems[0].Text));
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
			tbName.Text = patient.Name;
			tbPatronymic.Text = patient.Patronymic;			
			dtpBirthDate.TryToAssignValue(patient.DateOfBirth);
			dtpDeathDate.TryToAssignValue(patient.DateOfDeath);
		}

		private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			DisableGUI();
			SearchPatients((IMongoQuery)e.Argument);
		}

		private void DisableGUI()
		{
			tbSearchText.InvokeIfRequired(c => {c.Enabled = false;});
			btQuickSearch.InvokeIfRequired(c => { c.Enabled = false; });
			PatientList.InvokeIfRequired(c => { c.Visible = false;});
			this.InvokeIfRequired(c => { c.Cursor = Cursors.WaitCursor; });
		}

		private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			EnableGUI();
		}

		private void EnableGUI()
		{
			tbSearchText.InvokeIfRequired(c => { c.Enabled = true; });
			btQuickSearch.InvokeIfRequired(c => { c.Enabled = true; });
			PatientList.InvokeIfRequired(c => { c.Visible = true; });
			this.InvokeIfRequired(c => { c.Cursor = Cursors.Default; });
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

		private void btSave_Click(object sender, EventArgs e)
		{
			// TODO: Rewrite this function so it actually works.

			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName);
			var coll = db.GetCollection<Patient>("Patient");
			var queriedPatient = coll.FindOneById(new ObjectId(tbID.Text));
			FillPatientObjectWithData(ref queriedPatient);
			coll.Save<Patient>(queriedPatient);
			UpdateSelectedItem();
		}

		private void FillPatientObjectWithData(ref Patient patient)
		{
			patient.Surname = tbSurname.Text;
			patient.Name = tbName.Text;
			patient.Patronymic = tbPatronymic.Text;
			patient.DateOfBirth = GetNullOrValueFromDateTimePicker(dtpBirthDate);
			patient.DateOfDeath = GetNullOrValueFromDateTimePicker(dtpDeathDate);			
		}

		/// <summary>
		/// Returns null or DateTime instance depending on the state of the checkbox of the DateTimePicker control.
		/// </summary>
		/// <param name="dateTimePicker">DateTimePicker control to check.</param>
		/// <returns>Null or DateTime instance.</returns>
		private DateTime? GetNullOrValueFromDateTimePicker(DateTimePicker dateTimePicker)
		{
			if(dateTimePicker.Checked)
			{
				return dateTimePicker.Value.Date;
			}
			return null;
		}

		private void UpdateSelectedItem()
		{
			PatientList.SelectedItems[0].SubItems[1].Text = tbSurname.Text;
			PatientList.SelectedItems[0].SubItems[2].Text = tbName.Text;
			PatientList.SelectedItems[0].SubItems[3].Text = tbPatronymic.Text;
			PatientList.Sort();
			PatientList.SelectedItems[0].EnsureVisible();
			PatientList.Focus();
		}

		private void btQuickSearch_Click(object sender, EventArgs e)
		{
			PatientList.ListViewItemSorter = null;
			bgWorker.RunWorkerAsync(BuildQuery());
		}

		private IMongoQuery BuildQuery()
		{
			// TODO: Build fast query depending on the input text.
			if(String.IsNullOrWhiteSpace(tbSearchText.Text))
			{
				return Query.Null;
			}
			var regexToSearch = new BsonRegularExpression("^" + tbSearchText.Text);
			return Query.Or(Query.Matches("Surname", regexToSearch), Query.Matches("Name", regexToSearch), Query.Matches("Patronymic", regexToSearch));
		}

		private void tbSearchText_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btQuickSearch_Click(this, e);
			}
		}
	}
}
