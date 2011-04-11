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
			//TODO: Fill TreeView with data from DB.

			var rootNode = treeHealthLog.Nodes.Add(patient.GetFullName());
		}

		private void btAddCase_Click(object sender, EventArgs e)
		{
			treeHealthLog.TopNode.Nodes.Add("New Case").Select();
		}

		private void btAddEntry_Click(object sender, EventArgs e)
		{			
			var selectedTreeNode = treeHealthLog.SelectedNode;
			if(selectedTreeNode.Parent != treeHealthLog.TopNode)
			{
				treeHealthLog.SelectedNode.Parent.Nodes.Add("New entry").Select();
			}
			else
			{
				treeHealthLog.SelectedNode.Nodes.Add("New entry").Select();
				treeHealthLog.SelectedNode.Expand();
			}
		}
	}
}
