namespace mongoClient
{
	partial class MedicListForm
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			this.medicList = new System.Windows.Forms.ListView();
			this.btAddMedic = new System.Windows.Forms.Button();
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.surnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.partonymicHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.profHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.categoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.degreeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.deptHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// medicList
			// 
			this.medicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.surnameHeader,
            this.nameHeader,
            this.partonymicHeader,
            this.profHeader,
            this.categoryHeader,
            this.degreeHeader,
            this.deptHeader});
			this.medicList.FullRowSelect = true;
			this.medicList.GridLines = true;
			listViewGroup1.Header = "ListViewGroup";
			listViewGroup1.Name = "listViewGroup1";
			listViewGroup2.Header = "ListViewGroup";
			listViewGroup2.Name = "listViewGroup2";
			this.medicList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
			this.medicList.HideSelection = false;
			this.medicList.Location = new System.Drawing.Point(15, 21);
			this.medicList.MultiSelect = false;
			this.medicList.Name = "medicList";
			this.medicList.Size = new System.Drawing.Size(688, 363);
			this.medicList.TabIndex = 0;
			this.medicList.UseCompatibleStateImageBehavior = false;
			this.medicList.View = System.Windows.Forms.View.Details;
			this.medicList.ItemActivate += new System.EventHandler(this.medicList_ItemActivate);
			// 
			// btAddMedic
			// 
			this.btAddMedic.Location = new System.Drawing.Point(22, 408);
			this.btAddMedic.Name = "btAddMedic";
			this.btAddMedic.Size = new System.Drawing.Size(92, 25);
			this.btAddMedic.TabIndex = 1;
			this.btAddMedic.Text = "Add";
			this.btAddMedic.UseVisualStyleBackColor = true;
			this.btAddMedic.Click += new System.EventHandler(this.btAddMedic_Click);
			// 
			// bgWorker
			// 
			this.bgWorker.WorkerSupportsCancellation = true;
			this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
			// 
			// idHeader
			// 
			this.idHeader.Text = "id";
			this.idHeader.Width = 0;
			// 
			// surnameHeader
			// 
			this.surnameHeader.Text = "Surname";
			this.surnameHeader.Width = 114;
			// 
			// nameHeader
			// 
			this.nameHeader.Text = "Name";
			this.nameHeader.Width = 92;
			// 
			// partonymicHeader
			// 
			this.partonymicHeader.Text = "Patronymic";
			this.partonymicHeader.Width = 118;
			// 
			// profHeader
			// 
			this.profHeader.Text = "Profession";
			this.profHeader.Width = 96;
			// 
			// categoryHeader
			// 
			this.categoryHeader.Text = "Category";
			this.categoryHeader.Width = 86;
			// 
			// degreeHeader
			// 
			this.degreeHeader.Text = "Degree";
			this.degreeHeader.Width = 67;
			// 
			// deptHeader
			// 
			this.deptHeader.Text = "Department";
			this.deptHeader.Width = 93;
			// 
			// MedicListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 522);
			this.Controls.Add(this.btAddMedic);
			this.Controls.Add(this.medicList);
			this.Name = "MedicListForm";
			this.Text = "MedicListForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedicListForm_FormClosing);
			this.Load += new System.EventHandler(this.MedicListForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView medicList;
		private System.Windows.Forms.Button btAddMedic;
		private System.ComponentModel.BackgroundWorker bgWorker;
		private System.Windows.Forms.ColumnHeader idHeader;
		private System.Windows.Forms.ColumnHeader surnameHeader;
		private System.Windows.Forms.ColumnHeader nameHeader;
		private System.Windows.Forms.ColumnHeader partonymicHeader;
		private System.Windows.Forms.ColumnHeader profHeader;
		private System.Windows.Forms.ColumnHeader categoryHeader;
		private System.Windows.Forms.ColumnHeader degreeHeader;
		private System.Windows.Forms.ColumnHeader deptHeader;
	}
}