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
			this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.headerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.tbID = new System.Windows.Forms.TextBox();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// PatientList
			// 
			this.PatientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerId,
            this.headerName,
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
			// headerName
			// 
			this.headerName.Text = "Name";
			this.headerName.Width = 107;
			// 
			// headerNumber
			// 
			this.headerNumber.Text = "Number";
			this.headerNumber.Width = 103;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 568);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbID);
			this.Controls.Add(this.PatientList);
			this.Name = "MainForm";
			this.Text = "Medical Information System";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
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
	}
}