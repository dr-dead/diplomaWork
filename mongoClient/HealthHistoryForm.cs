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
	public partial class HealthHistoryForm : Form
	{
		public HealthHistoryForm(ObjectId patientId)
		{
			InitializeComponent();
			var patient = ServerConnection.GetCollection<Patient>().FindOneById(patientId);
			this.Text = patient.GetFullName() + " - Health Log";
			populateTreeView(patient);
		}

		/// <summary>
		/// Fills the nodes in TreeView control with health log cases and entries. Every node's tag is filled with ObjectId of according record.
		/// </summary>
		/// <param name="patient">Patient instance for who to populate TreeView</param>
		private void populateTreeView(Patient patient)
		{
			//TODO: Make population process fail-safe.

			var rootNode = treeHealthLog.Nodes.Add(patient.GetFullName());
			rootNode.Tag = patient.Id;
			if(patient.HealthLog != null)
			{
				TreeNode currentNode;
				var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
				var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
				foreach(var caseItem in patient.HealthLog)
				{
					var currentCase = caseCollection.FindOneById(caseItem);
					currentNode = rootNode.Nodes.Add(currentCase.StartDate.ToString("d"));
					currentNode.Tag = currentCase.Id;
					if(currentCase.HealthLogEntries != null)
					{
						foreach(var entryItem in currentCase.HealthLogEntries)
						{
							var currentEntry = entryCollection.FindOneById(entryItem);
							currentNode.Nodes.Add(currentEntry.AppointmentTime.ToString()).Tag = currentEntry.Id;
						}
					}
				}
			}
		}

		private void btAddCase_Click(object sender, EventArgs e)
		{
			var healthCase = createCaseAndSaveInDB();
			pushCaseToPatient(healthCase.Id, (ObjectId)treeHealthLog.TopNode.Tag);
			var currentCase = treeHealthLog.TopNode.Nodes.Add(healthCase.StartDate.Date.ToString("d"));
			currentCase.Tag = healthCase.Id;
			currentCase.Select();
		}

		/// <summary>
		/// Creates an instance of HealthLogCase class and saves it in database.
		/// </summary>
		/// <returns>Empty HealthLogCase instance with filled Id property.</returns>
		private HealthLogCase createCaseAndSaveInDB()
		{
			var healthCase = new HealthLogCase();
			healthCase.StartDate = DateTime.Now.Date;
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			caseCollection.Save<HealthLogCase>(healthCase);
			return healthCase;
		}

		/// <summary>
		/// Appends HealthCaseEntry's ObjectId to the HealthLog property array of the Patient object.
		/// </summary>
		/// <param name="caseId">MongoDB.Bson.ObjectId instance of the HealthCaseEntry object to append.</param>
		/// <param name="patientId">MongoDB.Bson.ObjectId of the Patient object to append to.</param>
		private void pushCaseToPatient(ObjectId caseId, ObjectId patientId)
		{
			var patientCollection = ServerConnection.GetCollection<Patient>();
			patientCollection.Update(Query.EQ("_id", patientId), MongoDB.Driver.Builders.Update.Push("HealthLog", caseId));
		}

		private void btAddEntry_Click(object sender, EventArgs e)
		{			
			var selectedTreeNode = treeHealthLog.SelectedNode;
			var healthEntry = createEntryAndSaveInDB();
			TreeNode currentEntry;
			if(!selectedTreeNode.IsTopBranch())
			{
				currentEntry = treeHealthLog.SelectedNode.Parent.Nodes.Add(healthEntry.AppointmentTime.ToString());
			}
			else
			{
				currentEntry = treeHealthLog.SelectedNode.Nodes.Add(healthEntry.AppointmentTime.ToString());
				treeHealthLog.SelectedNode.Expand();
			}
			pushEntryToCase(healthEntry.Id, (ObjectId)currentEntry.Parent.Tag);
			currentEntry.Tag = healthEntry.Id;
			currentEntry.Select();
		}

		/// <summary>
		/// Creates an instance of HealthLogEntry class and saves it in database.
		/// </summary>
		/// <returns>Empty HealthLogEntry instance with filled Id property.</returns>
		private HealthLogEntry createEntryAndSaveInDB()
		{
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var healthEntry = new HealthLogEntry();
			healthEntry.AppointmentTime = DateTime.Now;
			entryCollection.Save<HealthLogEntry>(healthEntry);
			return healthEntry;
		}

		/// <summary>
		/// Appends HealthLogEntry's ObjectId to the "HealthLogEntries" property array of the HealthLogCase object. 
		/// </summary>
		/// <param name="entryId">MongoDB.Bson.ObjectId instance of the HealthLogEntry object to append.</param>
		/// <param name="caseId">MongoDB.Bson.ObjectId of the HealthLogCase object to append to.</param>
		private void pushEntryToCase(ObjectId entryId, ObjectId caseId)
		{
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			caseCollection.Update(Query.EQ("_id", caseId), MongoDB.Driver.Builders.Update.Push("HealthLogEntries", entryId));
		}

		private void btDelete_Click(object sender, EventArgs e)
		{
			if(treeHealthLog.SelectedNode != null && treeHealthLog.SelectedNode != treeHealthLog.TopNode)
			{
				var selectedTreeNode = treeHealthLog.SelectedNode;
				if(selectedTreeNode.IsTopBranch())
				{
					removeCase((ObjectId)selectedTreeNode.Tag);
				}
				else
				{
					removeEntry((ObjectId)selectedTreeNode.Tag);
				}
				treeHealthLog.SelectedNode.Remove();
			}
		}

		/// <summary>
		/// Removes HealthLogCase and all nested HealthLogEntry objects from the database. Also removes HealthLogCase from Patient's array of cases.
		/// </summary>
		/// <param name="caseId">MongoDB.Bson.ObjectId of HealthLogCase.</param>
		private void removeCase(ObjectId caseId)
		{
			var patientCollection = ServerConnection.GetCollection<Patient>();
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var selectedCase = caseCollection.FindOneById(caseId);
			if(selectedCase.HealthLogEntries != null)
			{
				entryCollection.Remove(Query.In("_id", new BsonArray(selectedCase.HealthLogEntries)));
			}
			patientCollection.Update(Query.EQ("_id", (ObjectId)treeHealthLog.TopNode.Tag), MongoDB.Driver.Builders.Update.Pull("HealthLog", selectedCase.Id));
			caseCollection.Remove(Query.EQ("_id", selectedCase.Id));
		}

		/// <summary>
		/// Removes HealthLogEntry and pulls its ObjectId from HealthLogCase.
		/// </summary>
		/// <param name="entryId">MongoDB.Bson.ObjectId of HealthLogEntry</param>
		private void removeEntry(ObjectId entryId)
		{
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var selectedEntry = entryCollection.FindOneById(entryId);
			//caseCollection.Update(Query.EQ("_id", caseOfEntry.Id), MongoDB.Driver.Builders.Update.Pull("HealthLogEntries", selectedEntry.Id));
			caseCollection.Update(Query.Null, MongoDB.Driver.Builders.Update.Pull("HealthLogEntries", selectedEntry.Id));
			entryCollection.Remove(Query.EQ("_id", selectedEntry.Id));
		}

		private void treeHealthLog_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			treeHealthLog.SelectedNode = e.Node;
			if(e.Node != treeHealthLog.TopNode)
			{
				if(e.Node.IsTopBranch())
				{
					//TODO: case handler
					loadCaseGUI();
					fillControlsWithCaseObject((ObjectId)e.Node.Tag);
				}
				else
				{
					//TODO: entry handler
					loadEntryGUI();
					fillControlsWithEntryObject((ObjectId)e.Node.Tag);
				}
			}
		}

		private void loadCaseGUI()
		{
			lbComplaints.Visible = true;
			lbDiag.Visible = true;
			lbHeight.Visible = true;
			lbWeight.Visible = true;
			lbStart.Visible = true;
			lbEnd.Visible = true;
			lbCm.Visible = true;
			lbKg.Visible = true;
			tbComplaints.Visible = true;
			tbDiagnosis.Visible = true;
			tbHeight.Visible = true;
			tbWeight.Visible = true;
			dtpStartDate.Visible = true;
			dtpEndDate.Visible = true;

			lbDirection.Visible = false;
			lbAppointment.Visible = false;
			lbStatus.Visible = false;
			tbDirection.Visible = false;
			dtpAppointment.Visible = false;
			tbStatus.Visible = false;
		}

		private void fillControlsWithCaseObject(ObjectId caseObjectId)
		{
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			var medicCollection = ServerConnection.GetCollection<Medic>();
			var queriedCase = caseCollection.FindOneById(caseObjectId);
			if(queriedCase.ManagingMedic != null)
			{
				var managingMedic = medicCollection.FindOneById(queriedCase.ManagingMedic);
				tbMedic.Tag = managingMedic.Id;
				tbMedic.Text = managingMedic.GetFullName() + " - " + managingMedic.Profession;
			}
			else
			{
				tbMedic.Text = String.Empty;
				tbMedic.Tag = null;
			}
			tbComplaints.Text = queriedCase.Complaints;
			tbDiagnosis.Text = queriedCase.Diagnosis;
			tbHeight.Text = queriedCase.Height.ToString();
			tbWeight.Text = queriedCase.Weight.ToString();
			dtpStartDate.Value = queriedCase.StartDate;
			dtpEndDate.TryToAssignValue(queriedCase.EndDate);
		}

		private void loadEntryGUI()
		{
			lbDirection.Visible = true;
			lbAppointment.Visible = true;
			lbStatus.Visible = true;
			dtpAppointment.Visible = true;
			tbDirection.Visible = true;
			tbStatus.Visible = true;

			lbComplaints.Visible = false;
			lbDiag.Visible = false;
			lbHeight.Visible = false;
			lbWeight.Visible = false;
			lbStart.Visible = false;
			lbEnd.Visible = false;
			lbCm.Visible = false;
			lbKg.Visible = false;
			tbComplaints.Visible = false;
			tbDiagnosis.Visible = false;
			tbHeight.Visible = false;
			tbWeight.Visible = false;
			dtpStartDate.Visible = false;
			dtpEndDate.Visible = false;
		}

		private void fillControlsWithEntryObject(ObjectId entryObjectId)
		{
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var medicCollection = ServerConnection.GetCollection<Medic>();
			var queriedEntry = entryCollection.FindOneById(entryObjectId);
			if(queriedEntry.ManagingMedic != null)
			{
				var managingMedic = medicCollection.FindOneById(queriedEntry.ManagingMedic);
				tbMedic.Tag = managingMedic.Id;
				tbMedic.Text = managingMedic.GetFullName() + " - " + managingMedic.Profession;
			}
			else
			{
				tbMedic.Text = String.Empty;
				tbMedic.Tag = null;
			}
			dtpAppointment.Value = queriedEntry.AppointmentTime;
			tbDirection.Text = queriedEntry.Direction;
			tbStatus.Text = queriedEntry.Status;
		}

		private void btMedicSelect_Click(object sender, EventArgs e)
		{
			var medicListForm = new MedicListForm(true);
			medicListForm.MedicInsertionEvent +=new MedicListForm.MedicInsertionHandler(medicListForm_MedicInsertionEvent);
			medicListForm.ShowDialog();
		}

		void medicListForm_MedicInsertionEvent(object sender, ObjectId obj)
		{
			tbMedic.Tag = obj;
			var medicCollection = ServerConnection.GetCollection<Medic>();
			var queriedMedic = medicCollection.FindOneById(obj);
			tbMedic.Text = queriedMedic.GetFullName() + " - " + queriedMedic.Profession;
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			if(treeHealthLog.SelectedNode != null && treeHealthLog.SelectedNode != treeHealthLog.TopNode)
			{
				var selectedTreeNode = treeHealthLog.SelectedNode;
				if(selectedTreeNode.IsTopBranch())
				{
					saveCase((ObjectId)selectedTreeNode.Tag);
				}
				else
				{
					saveEntry((ObjectId)selectedTreeNode.Tag);
				}
				//TODO: node updated
			}
		}

		private void saveCase(ObjectId caseId)
		{
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			var queriedCase = caseCollection.FindOneById(caseId);
			queriedCase.Complaints = tbComplaints.Text;
			queriedCase.Diagnosis = tbDiagnosis.Text;
			queriedCase.Height = int.Parse(tbHeight.Text);
			queriedCase.Weight = int.Parse(tbWeight.Text);
			queriedCase.StartDate = dtpStartDate.Value;
			queriedCase.EndDate = dtpEndDate.GetNullOrValue();
			queriedCase.ManagingMedic = tbMedic.Tag as ObjectId?;
			caseCollection.Save<HealthLogCase>(queriedCase);
		}

		private void saveEntry(ObjectId entryId)
		{
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var queriedEntry = entryCollection.FindOneById(entryId);
			queriedEntry.AppointmentTime = dtpAppointment.Value;
			queriedEntry.Direction = tbDirection.Text;
			queriedEntry.Status = tbStatus.Text;
			queriedEntry.ManagingMedic = tbMedic.Tag as ObjectId?;
			entryCollection.Save<HealthLogEntry>(queriedEntry);
		}
	}
}
