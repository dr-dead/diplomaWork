namespace mongoClient
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PatientList = new System.Windows.Forms.ListView();
			this.headerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.headerSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.headerPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.tbID = new System.Windows.Forms.TextBox();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbPatronymic = new System.Windows.Forms.TextBox();
			this.btSave = new System.Windows.Forms.Button();
			this.btQuickSearch = new System.Windows.Forms.Button();
			this.tbSearchText = new System.Windows.Forms.TextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.dtpDeathDate = new System.Windows.Forms.DateTimePicker();
			this.btHealthLog = new System.Windows.Forms.Button();
			this.btAddPatient = new System.Windows.Forms.Button();
			this.btDeletePatient = new System.Windows.Forms.Button();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbTelephone = new System.Windows.Forms.TextBox();
			this.lbId = new System.Windows.Forms.Label();
			this.lbSurname = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbPatronymic = new System.Windows.Forms.Label();
			this.lbAddress = new System.Windows.Forms.Label();
			this.lbTelephone = new System.Windows.Forms.Label();
			this.lbBirth = new System.Windows.Forms.Label();
			this.lbDeath = new System.Windows.Forms.Label();
			this.btMedicList = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PatientList
			// 
			resources.ApplyResources(this.PatientList, "PatientList");
			this.PatientList.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.PatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerSurname,
            this.headerName,
            this.headerPatronymic});
			this.PatientList.FullRowSelect = true;
			this.PatientList.GridLines = true;
			this.PatientList.HideSelection = false;
			this.PatientList.MultiSelect = false;
			this.PatientList.Name = "PatientList";
			this.PatientList.UseCompatibleStateImageBehavior = false;
			this.PatientList.View = System.Windows.Forms.View.Details;
			this.PatientList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnColumnClick);
			this.PatientList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PatientList_ColumnWidthChanging);
			this.PatientList.ItemActivate += new System.EventHandler(this.PatientList_ItemActivate);
			this.PatientList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PatientList_ItemSelectionChanged);
			// 
			// headerId
			// 
			resources.ApplyResources(this.headerId, "headerId");
			// 
			// headerSurname
			// 
			resources.ApplyResources(this.headerSurname, "headerSurname");
			// 
			// headerName
			// 
			resources.ApplyResources(this.headerName, "headerName");
			// 
			// headerPatronymic
			// 
			resources.ApplyResources(this.headerPatronymic, "headerPatronymic");
			// 
			// bgWorker
			// 
			this.bgWorker.WorkerSupportsCancellation = true;
			this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
			this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
			// 
			// tbID
			// 
			resources.ApplyResources(this.tbID, "tbID");
			this.tbID.Name = "tbID";
			// 
			// tbSurname
			// 
			resources.ApplyResources(this.tbSurname, "tbSurname");
			this.tbSurname.Name = "tbSurname";
			// 
			// tbName
			// 
			resources.ApplyResources(this.tbName, "tbName");
			this.tbName.Name = "tbName";
			// 
			// tbPatronymic
			// 
			resources.ApplyResources(this.tbPatronymic, "tbPatronymic");
			this.tbPatronymic.Name = "tbPatronymic";
			// 
			// btSave
			// 
			resources.ApplyResources(this.btSave, "btSave");
			this.btSave.Name = "btSave";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btQuickSearch
			// 
			resources.ApplyResources(this.btQuickSearch, "btQuickSearch");
			this.btQuickSearch.Name = "btQuickSearch";
			this.btQuickSearch.UseVisualStyleBackColor = true;
			this.btQuickSearch.Click += new System.EventHandler(this.btQuickSearch_Click);
			// 
			// tbSearchText
			// 
			resources.ApplyResources(this.tbSearchText, "tbSearchText");
			this.tbSearchText.Name = "tbSearchText";
			this.tbSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchText_KeyDown);
			// 
			// dtpBirthDate
			// 
			resources.ApplyResources(this.dtpBirthDate, "dtpBirthDate");
			this.dtpBirthDate.Checked = false;
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.ShowCheckBox = true;
			this.dtpBirthDate.Tag = "";
			this.dtpBirthDate.Value = new System.DateTime(2011, 3, 25, 0, 0, 0, 0);
			this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpFormat_DropDown);
			this.dtpBirthDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpCheckboxHack_MouseUp);
			// 
			// dtpDeathDate
			// 
			resources.ApplyResources(this.dtpDeathDate, "dtpDeathDate");
			this.dtpDeathDate.Checked = false;
			this.dtpDeathDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDeathDate.Name = "dtpDeathDate";
			this.dtpDeathDate.ShowCheckBox = true;
			this.dtpDeathDate.Value = new System.DateTime(2011, 4, 3, 0, 0, 0, 0);
			this.dtpDeathDate.ValueChanged += new System.EventHandler(this.dtpFormat_DropDown);
			this.dtpDeathDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpCheckboxHack_MouseUp);
			// 
			// btHealthLog
			// 
			resources.ApplyResources(this.btHealthLog, "btHealthLog");
			this.btHealthLog.Name = "btHealthLog";
			this.btHealthLog.UseVisualStyleBackColor = true;
			this.btHealthLog.Click += new System.EventHandler(this.btHealthLog_Click);
			// 
			// btAddPatient
			// 
			resources.ApplyResources(this.btAddPatient, "btAddPatient");
			this.btAddPatient.Name = "btAddPatient";
			this.btAddPatient.UseVisualStyleBackColor = true;
			this.btAddPatient.Click += new System.EventHandler(this.btAddPatient_Click);
			// 
			// btDeletePatient
			// 
			resources.ApplyResources(this.btDeletePatient, "btDeletePatient");
			this.btDeletePatient.Name = "btDeletePatient";
			this.btDeletePatient.UseVisualStyleBackColor = true;
			this.btDeletePatient.Click += new System.EventHandler(this.btDeletePatient_Click);
			// 
			// tbAddress
			// 
			resources.ApplyResources(this.tbAddress, "tbAddress");
			this.tbAddress.Name = "tbAddress";
			// 
			// tbTelephone
			// 
			resources.ApplyResources(this.tbTelephone, "tbTelephone");
			this.tbTelephone.Name = "tbTelephone";
			// 
			// lbId
			// 
			resources.ApplyResources(this.lbId, "lbId");
			this.lbId.Name = "lbId";
			// 
			// lbSurname
			// 
			resources.ApplyResources(this.lbSurname, "lbSurname");
			this.lbSurname.Name = "lbSurname";
			// 
			// lbName
			// 
			resources.ApplyResources(this.lbName, "lbName");
			this.lbName.Name = "lbName";
			// 
			// lbPatronymic
			// 
			resources.ApplyResources(this.lbPatronymic, "lbPatronymic");
			this.lbPatronymic.Name = "lbPatronymic";
			// 
			// lbAddress
			// 
			resources.ApplyResources(this.lbAddress, "lbAddress");
			this.lbAddress.Name = "lbAddress";
			// 
			// lbTelephone
			// 
			resources.ApplyResources(this.lbTelephone, "lbTelephone");
			this.lbTelephone.Name = "lbTelephone";
			// 
			// lbBirth
			// 
			resources.ApplyResources(this.lbBirth, "lbBirth");
			this.lbBirth.Name = "lbBirth";
			// 
			// lbDeath
			// 
			resources.ApplyResources(this.lbDeath, "lbDeath");
			this.lbDeath.Name = "lbDeath";
			// 
			// btMedicList
			// 
			resources.ApplyResources(this.btMedicList, "btMedicList");
			this.btMedicList.Name = "btMedicList";
			this.btMedicList.UseVisualStyleBackColor = true;
			this.btMedicList.Click += new System.EventHandler(this.btMedicList_Click);
			// 
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btMedicList);
			this.Controls.Add(this.lbDeath);
			this.Controls.Add(this.lbBirth);
			this.Controls.Add(this.lbTelephone);
			this.Controls.Add(this.lbAddress);
			this.Controls.Add(this.lbPatronymic);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbSurname);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.tbTelephone);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.btDeletePatient);
			this.Controls.Add(this.btAddPatient);
			this.Controls.Add(this.btHealthLog);
			this.Controls.Add(this.dtpDeathDate);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.tbSearchText);
			this.Controls.Add(this.btQuickSearch);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.tbPatronymic);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbID);
			this.Controls.Add(this.PatientList);
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView PatientList;
		private System.Windows.Forms.ColumnHeader headerId;
		private System.Windows.Forms.ColumnHeader headerName;
		private System.ComponentModel.BackgroundWorker bgWorker;
		private System.Windows.Forms.TextBox tbID;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbPatronymic;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btQuickSearch;
		private System.Windows.Forms.TextBox tbSearchText;
		private System.Windows.Forms.ColumnHeader headerSurname;
		private System.Windows.Forms.ColumnHeader headerPatronymic;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.DateTimePicker dtpDeathDate;
		private System.Windows.Forms.Button btHealthLog;
		private System.Windows.Forms.Button btAddPatient;
		private System.Windows.Forms.Button btDeletePatient;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbTelephone;
		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbSurname;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbPatronymic;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label lbTelephone;
		private System.Windows.Forms.Label lbBirth;
		private System.Windows.Forms.Label lbDeath;
		private System.Windows.Forms.Button btMedicList;
	}
}