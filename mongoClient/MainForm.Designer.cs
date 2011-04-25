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
			this.SuspendLayout();
			// 
			// PatientList
			// 
			this.PatientList.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.PatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerSurname,
            this.headerName,
            this.headerPatronymic});
			this.PatientList.FullRowSelect = true;
			this.PatientList.GridLines = true;
			this.PatientList.HideSelection = false;
			this.PatientList.Location = new System.Drawing.Point(28, 131);
			this.PatientList.MultiSelect = false;
			this.PatientList.Name = "PatientList";
			this.PatientList.Size = new System.Drawing.Size(558, 388);
			this.PatientList.TabIndex = 3;
			this.PatientList.UseCompatibleStateImageBehavior = false;
			this.PatientList.View = System.Windows.Forms.View.Details;
			this.PatientList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnColumnClick);
			this.PatientList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PatientList_ColumnWidthChanging);
			this.PatientList.ItemActivate += new System.EventHandler(this.PatientList_ItemActivate);
			this.PatientList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PatientList_ItemSelectionChanged);
			// 
			// headerId
			// 
			this.headerId.Text = "Id";
			this.headerId.Width = 0;
			// 
			// headerSurname
			// 
			this.headerSurname.Text = "Surname";
			this.headerSurname.Width = 124;
			// 
			// headerName
			// 
			this.headerName.Text = "Name";
			this.headerName.Width = 107;
			// 
			// headerPatronymic
			// 
			this.headerPatronymic.Text = "Patronymic";
			this.headerPatronymic.Width = 110;
			// 
			// bgWorker
			// 
			this.bgWorker.WorkerSupportsCancellation = true;
			this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
			this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
			// 
			// tbID
			// 
			this.tbID.Enabled = false;
			this.tbID.Location = new System.Drawing.Point(666, 131);
			this.tbID.Name = "tbID";
			this.tbID.Size = new System.Drawing.Size(207, 20);
			this.tbID.TabIndex = 4;
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(666, 157);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(207, 20);
			this.tbSurname.TabIndex = 5;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(666, 183);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(207, 20);
			this.tbName.TabIndex = 6;
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(666, 209);
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(207, 20);
			this.tbPatronymic.TabIndex = 7;
			// 
			// btSave
			// 
			this.btSave.Enabled = false;
			this.btSave.Location = new System.Drawing.Point(695, 532);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 20);
			this.btSave.TabIndex = 8;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btQuickSearch
			// 
			this.btQuickSearch.Location = new System.Drawing.Point(476, 533);
			this.btQuickSearch.Name = "btQuickSearch";
			this.btQuickSearch.Size = new System.Drawing.Size(109, 21);
			this.btQuickSearch.TabIndex = 9;
			this.btQuickSearch.Text = "Quick Search";
			this.btQuickSearch.UseVisualStyleBackColor = true;
			this.btQuickSearch.Click += new System.EventHandler(this.btQuickSearch_Click);
			// 
			// tbSearchText
			// 
			this.tbSearchText.Location = new System.Drawing.Point(28, 533);
			this.tbSearchText.Name = "tbSearchText";
			this.tbSearchText.Size = new System.Drawing.Size(429, 20);
			this.tbSearchText.TabIndex = 10;
			this.tbSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchText_KeyDown);
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Checked = false;
			this.dtpBirthDate.CustomFormat = "N\\A";
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthDate.Location = new System.Drawing.Point(666, 235);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.ShowCheckBox = true;
			this.dtpBirthDate.Size = new System.Drawing.Size(115, 20);
			this.dtpBirthDate.TabIndex = 11;
			this.dtpBirthDate.Tag = "";
			this.dtpBirthDate.Value = new System.DateTime(2011, 3, 25, 0, 0, 0, 0);
			this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpFormat_DropDown);
			this.dtpBirthDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpCheckboxHack_MouseUp);
			// 
			// dtpDeathDate
			// 
			this.dtpDeathDate.Checked = false;
			this.dtpDeathDate.CustomFormat = "N\\A";
			this.dtpDeathDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDeathDate.Location = new System.Drawing.Point(666, 261);
			this.dtpDeathDate.Name = "dtpDeathDate";
			this.dtpDeathDate.ShowCheckBox = true;
			this.dtpDeathDate.Size = new System.Drawing.Size(115, 20);
			this.dtpDeathDate.TabIndex = 12;
			this.dtpDeathDate.Value = new System.DateTime(2011, 4, 3, 0, 0, 0, 0);
			this.dtpDeathDate.ValueChanged += new System.EventHandler(this.dtpFormat_DropDown);
			this.dtpDeathDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpCheckboxHack_MouseUp);
			// 
			// btHealthLog
			// 
			this.btHealthLog.Enabled = false;
			this.btHealthLog.Location = new System.Drawing.Point(605, 339);
			this.btHealthLog.Name = "btHealthLog";
			this.btHealthLog.Size = new System.Drawing.Size(101, 22);
			this.btHealthLog.TabIndex = 13;
			this.btHealthLog.Text = "Health Log";
			this.btHealthLog.UseVisualStyleBackColor = true;
			this.btHealthLog.Click += new System.EventHandler(this.btHealthLog_Click);
			// 
			// btAddPatient
			// 
			this.btAddPatient.Location = new System.Drawing.Point(605, 532);
			this.btAddPatient.Name = "btAddPatient";
			this.btAddPatient.Size = new System.Drawing.Size(68, 21);
			this.btAddPatient.TabIndex = 14;
			this.btAddPatient.Text = "Add";
			this.btAddPatient.UseVisualStyleBackColor = true;
			this.btAddPatient.Click += new System.EventHandler(this.btAddPatient_Click);
			// 
			// btDeletePatient
			// 
			this.btDeletePatient.Enabled = false;
			this.btDeletePatient.Location = new System.Drawing.Point(785, 532);
			this.btDeletePatient.Name = "btDeletePatient";
			this.btDeletePatient.Size = new System.Drawing.Size(97, 20);
			this.btDeletePatient.TabIndex = 15;
			this.btDeletePatient.Text = "Delete";
			this.btDeletePatient.UseVisualStyleBackColor = true;
			this.btDeletePatient.Click += new System.EventHandler(this.btDeletePatient_Click);
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(666, 287);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(141, 20);
			this.tbAddress.TabIndex = 16;
			// 
			// tbTelephone
			// 
			this.tbTelephone.Location = new System.Drawing.Point(666, 313);
			this.tbTelephone.Name = "tbTelephone";
			this.tbTelephone.Size = new System.Drawing.Size(141, 20);
			this.tbTelephone.TabIndex = 17;
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.Location = new System.Drawing.Point(602, 131);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(19, 13);
			this.lbId.TabIndex = 18;
			this.lbId.Text = "Id:";
			// 
			// lbSurname
			// 
			this.lbSurname.AutoSize = true;
			this.lbSurname.Location = new System.Drawing.Point(602, 160);
			this.lbSurname.Name = "lbSurname";
			this.lbSurname.Size = new System.Drawing.Size(52, 13);
			this.lbSurname.TabIndex = 19;
			this.lbSurname.Text = "Surname:";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(602, 183);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(38, 13);
			this.lbName.TabIndex = 20;
			this.lbName.Text = "Name:";
			// 
			// lbPatronymic
			// 
			this.lbPatronymic.AutoSize = true;
			this.lbPatronymic.Location = new System.Drawing.Point(602, 212);
			this.lbPatronymic.Name = "lbPatronymic";
			this.lbPatronymic.Size = new System.Drawing.Size(62, 13);
			this.lbPatronymic.TabIndex = 21;
			this.lbPatronymic.Text = "Patronymic:";
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.Location = new System.Drawing.Point(602, 290);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(48, 13);
			this.lbAddress.TabIndex = 22;
			this.lbAddress.Text = "Address:";
			// 
			// lbTelephone
			// 
			this.lbTelephone.AutoSize = true;
			this.lbTelephone.Location = new System.Drawing.Point(602, 316);
			this.lbTelephone.Name = "lbTelephone";
			this.lbTelephone.Size = new System.Drawing.Size(43, 13);
			this.lbTelephone.TabIndex = 23;
			this.lbTelephone.Text = "Tel. no.";
			// 
			// lbBirth
			// 
			this.lbBirth.AutoSize = true;
			this.lbBirth.Location = new System.Drawing.Point(602, 239);
			this.lbBirth.Name = "lbBirth";
			this.lbBirth.Size = new System.Drawing.Size(55, 13);
			this.lbBirth.TabIndex = 24;
			this.lbBirth.Text = "Birth date:";
			// 
			// lbDeath
			// 
			this.lbDeath.AutoSize = true;
			this.lbDeath.Location = new System.Drawing.Point(602, 265);
			this.lbDeath.Name = "lbDeath";
			this.lbDeath.Size = new System.Drawing.Size(63, 13);
			this.lbDeath.TabIndex = 25;
			this.lbDeath.Text = "Death date:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 568);
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
			this.Text = "Medical Information System";
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
	}
}