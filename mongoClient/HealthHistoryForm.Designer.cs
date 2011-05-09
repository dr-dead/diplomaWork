namespace mongoClient
{
	partial class HealthHistoryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthHistoryForm));
			this.treeHealthLog = new System.Windows.Forms.TreeView();
			this.btAddCase = new System.Windows.Forms.Button();
			this.btAddEntry = new System.Windows.Forms.Button();
			this.tbMedic = new System.Windows.Forms.TextBox();
			this.btDelete = new System.Windows.Forms.Button();
			this.btMedicSelect = new System.Windows.Forms.Button();
			this.tbDiagnosis = new System.Windows.Forms.TextBox();
			this.tbDirection = new System.Windows.Forms.TextBox();
			this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
			this.btSave = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.tbComplaints = new System.Windows.Forms.TextBox();
			this.tbStatus = new System.Windows.Forms.TextBox();
			this.tbWeight = new System.Windows.Forms.TextBox();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.lbDirection = new System.Windows.Forms.Label();
			this.lbWeight = new System.Windows.Forms.Label();
			this.lbKg = new System.Windows.Forms.Label();
			this.lbHeight = new System.Windows.Forms.Label();
			this.lbCm = new System.Windows.Forms.Label();
			this.lbAppointment = new System.Windows.Forms.Label();
			this.lbStart = new System.Windows.Forms.Label();
			this.lbEnd = new System.Windows.Forms.Label();
			this.lbDiag = new System.Windows.Forms.Label();
			this.lbComplaints = new System.Windows.Forms.Label();
			this.lbStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// treeHealthLog
			// 
			resources.ApplyResources(this.treeHealthLog, "treeHealthLog");
			this.treeHealthLog.HideSelection = false;
			this.treeHealthLog.Name = "treeHealthLog";
			this.treeHealthLog.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeHealthLog_NodeMouseClick);
			// 
			// btAddCase
			// 
			resources.ApplyResources(this.btAddCase, "btAddCase");
			this.btAddCase.Name = "btAddCase";
			this.btAddCase.UseVisualStyleBackColor = true;
			this.btAddCase.Click += new System.EventHandler(this.btAddCase_Click);
			// 
			// btAddEntry
			// 
			resources.ApplyResources(this.btAddEntry, "btAddEntry");
			this.btAddEntry.Name = "btAddEntry";
			this.btAddEntry.UseVisualStyleBackColor = true;
			this.btAddEntry.Click += new System.EventHandler(this.btAddEntry_Click);
			// 
			// tbMedic
			// 
			resources.ApplyResources(this.tbMedic, "tbMedic");
			this.tbMedic.BackColor = System.Drawing.SystemColors.Window;
			this.tbMedic.Name = "tbMedic";
			this.tbMedic.ReadOnly = true;
			// 
			// btDelete
			// 
			resources.ApplyResources(this.btDelete, "btDelete");
			this.btDelete.Name = "btDelete";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// btMedicSelect
			// 
			resources.ApplyResources(this.btMedicSelect, "btMedicSelect");
			this.btMedicSelect.Name = "btMedicSelect";
			this.btMedicSelect.UseVisualStyleBackColor = true;
			this.btMedicSelect.Click += new System.EventHandler(this.btMedicSelect_Click);
			// 
			// tbDiagnosis
			// 
			resources.ApplyResources(this.tbDiagnosis, "tbDiagnosis");
			this.tbDiagnosis.Name = "tbDiagnosis";
			// 
			// tbDirection
			// 
			resources.ApplyResources(this.tbDirection, "tbDirection");
			this.tbDirection.Name = "tbDirection";
			// 
			// dtpAppointment
			// 
			resources.ApplyResources(this.dtpAppointment, "dtpAppointment");
			this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAppointment.Name = "dtpAppointment";
			// 
			// btSave
			// 
			resources.ApplyResources(this.btSave, "btSave");
			this.btSave.Name = "btSave";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btCancel
			// 
			resources.ApplyResources(this.btCancel, "btCancel");
			this.btCancel.Name = "btCancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// dtpStartDate
			// 
			resources.ApplyResources(this.dtpStartDate, "dtpStartDate");
			this.dtpStartDate.Checked = false;
			this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.ShowCheckBox = true;
			// 
			// tbComplaints
			// 
			resources.ApplyResources(this.tbComplaints, "tbComplaints");
			this.tbComplaints.Name = "tbComplaints";
			// 
			// tbStatus
			// 
			resources.ApplyResources(this.tbStatus, "tbStatus");
			this.tbStatus.Name = "tbStatus";
			// 
			// tbWeight
			// 
			resources.ApplyResources(this.tbWeight, "tbWeight");
			this.tbWeight.Name = "tbWeight";
			// 
			// tbHeight
			// 
			resources.ApplyResources(this.tbHeight, "tbHeight");
			this.tbHeight.Name = "tbHeight";
			// 
			// dtpEndDate
			// 
			resources.ApplyResources(this.dtpEndDate, "dtpEndDate");
			this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEndDate.Name = "dtpEndDate";
			// 
			// lbDirection
			// 
			resources.ApplyResources(this.lbDirection, "lbDirection");
			this.lbDirection.Name = "lbDirection";
			// 
			// lbWeight
			// 
			resources.ApplyResources(this.lbWeight, "lbWeight");
			this.lbWeight.Name = "lbWeight";
			// 
			// lbKg
			// 
			resources.ApplyResources(this.lbKg, "lbKg");
			this.lbKg.Name = "lbKg";
			// 
			// lbHeight
			// 
			resources.ApplyResources(this.lbHeight, "lbHeight");
			this.lbHeight.Name = "lbHeight";
			// 
			// lbCm
			// 
			resources.ApplyResources(this.lbCm, "lbCm");
			this.lbCm.Name = "lbCm";
			// 
			// lbAppointment
			// 
			resources.ApplyResources(this.lbAppointment, "lbAppointment");
			this.lbAppointment.Name = "lbAppointment";
			// 
			// lbStart
			// 
			resources.ApplyResources(this.lbStart, "lbStart");
			this.lbStart.Name = "lbStart";
			// 
			// lbEnd
			// 
			resources.ApplyResources(this.lbEnd, "lbEnd");
			this.lbEnd.Name = "lbEnd";
			// 
			// lbDiag
			// 
			resources.ApplyResources(this.lbDiag, "lbDiag");
			this.lbDiag.Name = "lbDiag";
			// 
			// lbComplaints
			// 
			resources.ApplyResources(this.lbComplaints, "lbComplaints");
			this.lbComplaints.Name = "lbComplaints";
			// 
			// lbStatus
			// 
			resources.ApplyResources(this.lbStatus, "lbStatus");
			this.lbStatus.Name = "lbStatus";
			// 
			// HealthHistoryForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.lbComplaints);
			this.Controls.Add(this.lbDiag);
			this.Controls.Add(this.lbEnd);
			this.Controls.Add(this.lbAppointment);
			this.Controls.Add(this.lbCm);
			this.Controls.Add(this.lbHeight);
			this.Controls.Add(this.lbKg);
			this.Controls.Add(this.lbWeight);
			this.Controls.Add(this.lbDirection);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.tbHeight);
			this.Controls.Add(this.tbWeight);
			this.Controls.Add(this.tbStatus);
			this.Controls.Add(this.tbComplaints);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.dtpAppointment);
			this.Controls.Add(this.tbDirection);
			this.Controls.Add(this.tbDiagnosis);
			this.Controls.Add(this.btMedicSelect);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.tbMedic);
			this.Controls.Add(this.btAddEntry);
			this.Controls.Add(this.btAddCase);
			this.Controls.Add(this.treeHealthLog);
			this.Controls.Add(this.lbStart);
			this.Name = "HealthHistoryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeHealthLog;
		private System.Windows.Forms.Button btAddCase;
		private System.Windows.Forms.Button btAddEntry;
		private System.Windows.Forms.TextBox tbMedic;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Button btMedicSelect;
		private System.Windows.Forms.TextBox tbDiagnosis;
		private System.Windows.Forms.TextBox tbDirection;
		private System.Windows.Forms.DateTimePicker dtpAppointment;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.TextBox tbComplaints;
		private System.Windows.Forms.TextBox tbStatus;
		private System.Windows.Forms.TextBox tbWeight;
		private System.Windows.Forms.TextBox tbHeight;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.Label lbDirection;
		private System.Windows.Forms.Label lbWeight;
		private System.Windows.Forms.Label lbKg;
		private System.Windows.Forms.Label lbHeight;
		private System.Windows.Forms.Label lbCm;
		private System.Windows.Forms.Label lbAppointment;
		private System.Windows.Forms.Label lbStart;
		private System.Windows.Forms.Label lbEnd;
		private System.Windows.Forms.Label lbDiag;
		private System.Windows.Forms.Label lbComplaints;
		private System.Windows.Forms.Label lbStatus;
	}
}