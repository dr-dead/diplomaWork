﻿namespace mongoClient
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
			this.headerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.tbID = new System.Windows.Forms.TextBox();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbPatronymic = new System.Windows.Forms.TextBox();
			this.btSave = new System.Windows.Forms.Button();
			this.btQuickSearch = new System.Windows.Forms.Button();
			this.tbSearchText = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// PatientList
			// 
			this.PatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerSurname,
            this.headerName,
            this.headerPatronymic,
            this.headerNumber});
			this.PatientList.FullRowSelect = true;
			this.PatientList.GridLines = true;
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
			// headerNumber
			// 
			this.headerNumber.Text = "Number";
			this.headerNumber.Width = 65;
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
			this.tbID.Location = new System.Drawing.Point(660, 131);
			this.tbID.Name = "tbID";
			this.tbID.Size = new System.Drawing.Size(249, 20);
			this.tbID.TabIndex = 4;
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(660, 170);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(207, 20);
			this.tbSurname.TabIndex = 5;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(660, 207);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(207, 20);
			this.tbName.TabIndex = 6;
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(660, 242);
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(207, 20);
			this.tbPatronymic.TabIndex = 7;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(660, 495);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
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
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(660, 279);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
			this.dateTimePicker1.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 568);
			this.Controls.Add(this.dateTimePicker1);
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
		private System.Windows.Forms.ColumnHeader headerNumber;
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
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}