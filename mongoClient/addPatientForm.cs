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
	public partial class AddPatientForm : Form
	{
		public AddPatientForm()
		{
			InitializeComponent();
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			var patient = new Patient();
			FillPatientObjectWithData(patient);
			var collection = ServerConnection.GetCollection<Patient>();
			collection.Save<Patient>(patient);
			// It appears reference makes the object to be filled with id
			// TODO: Handle the form after saving the object
			this.Close();
		}

		private void FillPatientObjectWithData(Patient patient)
		{
			patient.Surname = tbSurname.Text;
			patient.Name = tbName.Text;
			patient.Patronymic = tbPatronymic.Text;
			patient.DateOfBirth = dtpBirthDate.GetNullOrValue();
			patient.DateOfDeath = dtpDeathDate.GetNullOrValue();
		}
	}
}
