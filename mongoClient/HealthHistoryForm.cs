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
			var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
			var healthEntry = new HealthLogEntry();
			healthEntry.number = DateTime.Now.ToString();
			entryCollection.Save<HealthLogEntry>(healthEntry);

			var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
			TreeNode currentEntry;
			if(selectedTreeNode.Parent != treeHealthLog.TopNode)
			{
				caseCollection.Update(Query.EQ("_id", (ObjectId)selectedTreeNode.Parent.Tag), MongoDB.Driver.Builders.Update.Push("HealthLogEntries", healthEntry.Id));
				currentEntry = treeHealthLog.SelectedNode.Parent.Nodes.Add(healthEntry.number);
				currentEntry.Select();
			}
			else
			{
				caseCollection.Update(Query.EQ("_id", (ObjectId)selectedTreeNode.Tag), MongoDB.Driver.Builders.Update.Push("HealthLogEntries", healthEntry.Id));
				currentEntry = treeHealthLog.SelectedNode.Nodes.Add(healthEntry.number);
				currentEntry.Select();
				treeHealthLog.SelectedNode.Expand();
			}
			currentEntry.Tag = healthEntry.Id;
		}

		private void btDelete_Click(object sender, EventArgs e)
		{
			if(treeHealthLog.SelectedNode != null && treeHealthLog.SelectedNode != treeHealthLog.TopNode)
			{
				var selectedTreeNode = treeHealthLog.SelectedNode;
				var caseCollection = ServerConnection.GetCollection<HealthLogCase>();
				var entryCollection = ServerConnection.GetCollection<HealthLogEntry>();
				if(selectedTreeNode.Parent == treeHealthLog.TopNode)
				{
					//TODO: remove case

					var selectedCase = caseCollection.FindOneById((ObjectId)selectedTreeNode.Tag);
					if(selectedCase.HealthLogEntries != null)
					{
						entryCollection.Remove(Query.In("_id", new BsonArray(selectedCase.HealthLogEntries)));
					}					
					var patientCollection = ServerConnection.GetCollection<Patient>();
					patientCollection.Update(Query.EQ("_id", ((Patient)treeHealthLog.TopNode.Tag).Id), MongoDB.Driver.Builders.Update.Pull("HealthLog", selectedCase.Id));
					caseCollection.Remove(Query.EQ("_id", selectedCase.Id));
				}
				else
				{
					//TODO: remove entry
					var selectedEntry = entryCollection.FindOneById((ObjectId)selectedTreeNode.Tag);
					var caseOfEntry = caseCollection.FindOneById((ObjectId)selectedTreeNode.Parent.Tag);
					caseCollection.Update(Query.EQ("_id", caseOfEntry.Id), MongoDB.Driver.Builders.Update.Pull("HealthLogEntries", selectedEntry.Id));
					entryCollection.Remove(Query.EQ("_id", selectedEntry.Id));					
				}
				treeHealthLog.SelectedNode.Remove();
			}
		}
	}
}
