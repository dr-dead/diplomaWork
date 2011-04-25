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
		public delegate void PatientAddHandler(object sender, PatientIdentityEventArgs e);
		public event PatientAddHandler PatientAddEvent;

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
			var patientArgs = new PatientIdentityEventArgs(patient.Id.ToString(), patient.Name, patient.Surname, patient.Patronymic);
			PatientAddEvent(this, patientArgs);
			this.Close();
		}

		private void FillPatientObjectWithData(Patient patient)
		{
			patient.Surname = tbSurname.Text;
			patient.Name = tbName.Text;
			patient.Patronymic = tbPatronymic.Text;
			patient.DateOfBirth = dtpBirthDate.GetNullOrValue();
			patient.Address = tbAddress.Text;
			patient.Telephone = tbTelephone.Text;
		}
	}
}
