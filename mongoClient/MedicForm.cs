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
	public partial class MedicForm : Form
	{
		private bool isNew;
		public delegate void MedicAddHandler(object sender, MedicIdentityEventArgs e);
		public event MedicAddHandler MedicAddEvent;

		public MedicForm()
		{
			InitializeComponent();
			fillControlsWithConstants();
			isNew = true;
			enableAddingGUI();
		}

		private void enableAddingGUI()
		{
			lbId.Visible = false;
			tbId.Visible = false;
			lbIsWorking.Visible = false;
			chbIsWorking.Visible = false;
		}

		public MedicForm(ObjectId medicId)
		{
			InitializeComponent();
			fillControlsWithConstants();			
			fillFormWithMedicInfo(medicId);
			isNew = false;
		}

		private void fillControlsWithConstants()
		{
			cbProfessions.Items.Add(String.Empty);
			cbProfessions.Items.AddRange(Constants.MedicProfessions);
			cbCategory.Items.Add(String.Empty);
			cbCategory.Items.AddRange(Constants.MedicCategories);
			cbDegree.Items.Add(String.Empty);
			cbDegree.Items.AddRange(Constants.MedicDegrees);
		}

		private void fillFormWithMedicInfo(ObjectId medicId)
		{
			var queriedMedic = ServerConnection.GetCollection<Medic>().FindOneById(medicId);
			tbId.Text = queriedMedic.Id.ToString();
			tbSurname.Text = queriedMedic.Surname;
			tbName.Text = queriedMedic.Name;
			tbPatronymic.Text = queriedMedic.Patronymic;
			dtpBirthDate.TryToAssignValue(queriedMedic.DateOfBirth);
			cbProfessions.Text = queriedMedic.Profession;
			cbCategory.Text = queriedMedic.Category;
			cbDegree.Text = queriedMedic.Degree;
			cbDepartment.Text = queriedMedic.Department;
			tbCabinet.Text = queriedMedic.Cabinet.ToString();
			chbIsWorking.Checked = queriedMedic.IsWorking;
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			if(isNew)
			{
				AddNewMedic();
			}
			else
			{
				SaveChanges();
			}
			this.Close();
		}

		private void AddNewMedic()
		{
			var newMedic = new Medic();
			var medicCollection = ServerConnection.GetCollection<Medic>();
			FillMedicObjectWithInfo(newMedic);
			medicCollection.Save<Medic>(newMedic);
			//TODO: get rid of this disaster
			var medicArgs = new MedicIdentityEventArgs(newMedic.Id.ToString(), newMedic.Surname, newMedic.Name, newMedic.Patronymic, newMedic.Profession, newMedic.Category, newMedic.Degree, newMedic.Department);
			MedicAddEvent(this, medicArgs);
		}

		private void FillMedicObjectWithInfo(Medic medic)
		{
			medic.Surname = tbSurname.Text;
			medic.Name = tbName.Text;
			medic.Patronymic = tbPatronymic.Text;
			medic.DateOfBirth = dtpBirthDate.GetNullOrValue();
			medic.Profession = cbProfessions.Text;
			medic.Category = cbCategory.Text;
			medic.Degree = cbDegree.Text;
			medic.Department = cbDepartment.Text;
			if(String.IsNullOrWhiteSpace(tbCabinet.Text))
			{
				medic.Cabinet = null;
			}
			else
			{
				medic.Cabinet = int.Parse(tbCabinet.Text);
			}
			medic.IsWorking = chbIsWorking.Checked;
		}

		private void SaveChanges()
		{
			var medicCollection = ServerConnection.GetCollection<Medic>();
			var queriedMedic = medicCollection.FindOneById(new ObjectId(tbId.Text));
			FillMedicObjectWithInfo(queriedMedic);
			medicCollection.Save<Medic>(queriedMedic);
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
