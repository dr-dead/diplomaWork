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
			PopulateTreeView(patient);
		}

		/// <summary>
		/// Fills the nodes in TreeView control with health log cases and entries. Every node's tag is filled with ObjectId of according record.
		/// </summary>
		/// <param name="patient">Patient instance for who to populate TreeView</param>
		private void PopulateTreeView(Patient patient)
		{
			//TODO: Make population process fail-safe.

			var rootNode = treeHealthLog.Nodes.Add(patient.GetFullName());
			rootNode.Tag = patient;
			if(patient.HealthLog != null)
			{
				TreeNode currentNode;
				var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
				var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
				foreach(var caseItem in ((Patient)rootNode.Tag).HealthLog)
				{
					var currentCase = caseCollection.FindOneById(caseItem);
					currentNode = rootNode.Nodes.Add(currentCase.number);
					currentNode.Tag = currentCase.Id;
					if(currentCase.HealthLogEntries != null)
					{
						foreach(var entryItem in currentCase.HealthLogEntries)
						{
							var currentEntry = entryCollection.FindOneById(entryItem);
							currentNode.Nodes.Add(currentEntry.number).Tag = currentEntry.Id;
						}
					}
				}
			}
		}

		private void btAddCase_Click(object sender, EventArgs e)
		{
			var healthCase = new HealthLogCase();
			healthCase.number = DateTime.Now.ToString();
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			caseCollection.Save<HealthLogCase>(healthCase);

			var patientCollection = ServerConnection.GetCollection<Patient>();
			//var patient = patientCollection.FindOneById((ObjectId)treeHealthLog.TopNode.Tag);
			patientCollection.Update(Query.EQ("_id", ((Patient)treeHealthLog.TopNode.Tag).Id), MongoDB.Driver.Builders.Update.Push("HealthLog", healthCase.Id));
			var currentCase = treeHealthLog.TopNode.Nodes.Add(healthCase.number);
			currentCase.Tag = healthCase.Id;
			currentCase.Select();
		}

		private void btAddEntry_Click(object sender, EventArgs e)
		{			
			var selectedTreeNode = treeHealthLog.SelectedNode;
			var healthEntry = CreateEntryAndSaveInDB();
			TreeNode currentEntry;
			if(!selectedTreeNode.IsTopBranch())
			{
				currentEntry = treeHealthLog.SelectedNode.Parent.Nodes.Add(healthEntry.number);
			}
			else
			{
				currentEntry = treeHealthLog.SelectedNode.Nodes.Add(healthEntry.number);
				treeHealthLog.SelectedNode.Expand();
			}
			PushEntryToCase(healthEntry.Id, (ObjectId)currentEntry.Parent.Tag);
			currentEntry.Tag = healthEntry.Id;
			currentEntry.Select();
		}

		/// <summary>
		/// Creates an instance of HealthLogEntry class and saves it in database.
		/// </summary>
		/// <returns>Empty HealthLogEntry instance with filled Id property.</returns>
		private HealthLogEntry CreateEntryAndSaveInDB()
		{
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var healthEntry = new HealthLogEntry();
			healthEntry.number = DateTime.Now.ToString();
			entryCollection.Save<HealthLogEntry>(healthEntry);
			return healthEntry;
		}

		/// <summary>
		/// Appends HealthLogEntry's ObjectId to the array of the HealthLogCase object. 
		/// </summary>
		/// <param name="entryId">MongoDB.Bson.ObjectId instance of the HealthLogEntry object to append.</param>
		/// <param name="caseId">MongoDB.Bson.ObjectId of the HealthLogCase object to append to.</param>
		private void PushEntryToCase(ObjectId entryId, ObjectId caseId)
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
					RemoveCase((ObjectId)selectedTreeNode.Tag);
				}
				else
				{
					RemoveEntry((ObjectId)selectedTreeNode.Tag);
				}
				treeHealthLog.SelectedNode.Remove();
			}
		}

		/// <summary>
		/// Removes HealthLogCase and all nested HealthLogEntry objects from the database. Also removes HealthLogCase from Patient's array of cases.
		/// </summary>
		/// <param name="caseId">MongoDB.Bson.ObjectId of HealthLogCase.</param>
		private void RemoveCase(ObjectId caseId)
		{
			var patientCollection = ServerConnection.GetCollection<Patient>();
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var selectedCase = caseCollection.FindOneById(caseId);
			if(selectedCase.HealthLogEntries != null)
			{
				entryCollection.Remove(Query.In("_id", new BsonArray(selectedCase.HealthLogEntries)));
			}			
			patientCollection.Update(Query.EQ("_id", ((Patient)treeHealthLog.TopNode.Tag).Id), MongoDB.Driver.Builders.Update.Pull("HealthLog", selectedCase.Id));
			caseCollection.Remove(Query.EQ("_id", selectedCase.Id));
		}

		/// <summary>
		/// Removes HealthLogEntry and pulls its ObjectId from HealthLogCase.
		/// </summary>
		/// <param name="entryId">MongoDB.Bson.ObjectId of HealthLogEntry</param>
		private void RemoveEntry(ObjectId entryId)
		{
			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var selectedEntry = entryCollection.FindOneById(entryId);
			//caseCollection.Update(Query.EQ("_id", caseOfEntry.Id), MongoDB.Driver.Builders.Update.Pull("HealthLogEntries", selectedEntry.Id));
			caseCollection.Update(Query.Null, MongoDB.Driver.Builders.Update.Pull("HealthLogEntries", selectedEntry.Id));
			entryCollection.Remove(Query.EQ("_id", selectedEntry.Id));	
		}
	}
}
