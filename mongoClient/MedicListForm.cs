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
	public partial class MedicListForm : Form
	{
		public delegate void MedicInsertionHandler(object sender, ObjectId obj);
		public event MedicInsertionHandler MedicInsertionEvent;
		public MedicListForm(bool isInserting = false)
		{
			InitializeComponent();
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);	
			fillControlsWithConstants();
			if(isInserting)
			{
				enableInsertingGUI();
			}
		}

		private void enableInsertingGUI()
		{
			btAddMedic.Visible = false;
			medicList.ItemActivate -=new EventHandler(medicList_ItemActivate);
			medicList.ItemActivate +=new EventHandler(medicList_ItemActivateForInsertion);
		}

		private void medicList_ItemActivateForInsertion(object sender, EventArgs e)
		{
			MedicInsertionEvent(this, new ObjectId(medicList.SelectedItems[0].Text));
			this.Close();
		}

		private void fillControlsWithConstants()
		{
			foreach(var professionItem in Constants.MedicProfessions)
			{
				medicList.Groups.Add(professionItem, professionItem);
			}
		}

		private void fillListWithMedics(IMongoQuery query)
		{
			medicList.InvokeIfRequired(c => { c.Items.Clear(); });
			medicList.InvokeIfRequired(c => { c.BeginUpdate(); });
			var collection = ServerConnection.GetCollection<Medic>();
			foreach(var medicItem in collection.Find(query))
			{
				string[] medicAttributesArray = new string[] { medicItem.Id.ToString(), medicItem.Surname, medicItem.Name, medicItem.Patronymic, medicItem.Profession, medicItem.Category, medicItem.Degree, medicItem.Department };
				medicList.InvokeIfRequired(c => { c.Items.Add(new ListViewItem(medicAttributesArray)).Group = medicList.Groups[medicItem.Profession]; });
			}
			medicList.InvokeIfRequired(c => { c.EndUpdate(); });
		}

		private void btAddMedic_Click(object sender, EventArgs e)
		{
			var addMedicForm = new MedicForm();
			addMedicForm.MedicAddEvent +=new MedicForm.MedicAddHandler(addMedicForm_MedicAddEvent);
			addMedicForm.ShowDialog();
		}

		void addMedicForm_MedicAddEvent(object sender, MedicIdentityEventArgs e)
		{
			var medicAttributesArray = new string[] { e.Id, e.Surname, e.Name, e.Patronymic, e.Profession, e.Category, e.Degree, e.Department };
			var medicItem = new ListViewItem(medicAttributesArray);
			medicList.Items.Add(medicItem);
			medicItem.Group = medicList.Groups[e.Profession];
			medicItem.EnsureVisible();
			medicItem.Selected = true;
			medicList.Focus();
		}

		private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			fillListWithMedics((IMongoQuery)e.Argument);
		}

		private void MedicListForm_Load(object sender, EventArgs e)
		{
			bgWorker.RunWorkerAsync(Query.NE("IsWorking", false));
		}

		private void MedicListForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			bgWorker.CancelAsync();
		}

		private void medicList_ItemActivate(object sender, EventArgs e)
		{
			var medicId = new ObjectId(medicList.SelectedItems[0].Text);
			var addMedicForm = new MedicForm(medicId);
			addMedicForm.ShowDialog();
		}		
	}
}
