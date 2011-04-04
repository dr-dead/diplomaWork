using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;

namespace mongoClient
{
	public partial class addPatientForm : Form
	{
		public addPatientForm()
		{
			InitializeComponent();
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			// TODO: Dispatch "magic button"
			var patient = new Patient();
			patient.Surname = tbSurname.Text;
			patient.Name = tbName.Text;
			patient.Patronymic = tbPatronymic.Text;
			patient.DateOfBirth = dtpBirthDate.GetNullOrValue();
			patient.DateOfDeath = dtpDeathDate.GetNullOrValue();
			var db = ServerConnection.Server.GetDatabase(ServerConnection.DatabaseName);
			var coll = db.GetCollection<Patient>("Patient");
			coll.Save<Patient>(patient);
			// It appears reference makes the object to be filled with id
			// TODO: Handle the form after saving the object
			this.Close();
		}
	}
}
