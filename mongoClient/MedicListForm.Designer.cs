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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicListForm));
			this.medicList = new System.Windows.Forms.ListView();
			this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.surnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.partonymicHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.profHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.categoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.degreeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.deptHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btAddMedic = new System.Windows.Forms.Button();
			this.bgWorker = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// medicList
			// 
			resources.ApplyResources(this.medicList, "medicList");
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
			this.medicList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("medicList.Groups"))),
            ((System.Windows.Forms.ListViewGroup)(resources.GetObject("medicList.Groups1")))});
			this.medicList.HideSelection = false;
			this.medicList.MultiSelect = false;
			this.medicList.Name = "medicList";
			this.medicList.UseCompatibleStateImageBehavior = false;
			this.medicList.View = System.Windows.Forms.View.Details;
			this.medicList.ItemActivate += new System.EventHandler(this.medicList_ItemActivate);
			// 
			// idHeader
			// 
			resources.ApplyResources(this.idHeader, "idHeader");
			// 
			// surnameHeader
			// 
			resources.ApplyResources(this.surnameHeader, "surnameHeader");
			// 
			// nameHeader
			// 
			resources.ApplyResources(this.nameHeader, "nameHeader");
			// 
			// partonymicHeader
			// 
			resources.ApplyResources(this.partonymicHeader, "partonymicHeader");
			// 
			// profHeader
			// 
			resources.ApplyResources(this.profHeader, "profHeader");
			// 
			// categoryHeader
			// 
			resources.ApplyResources(this.categoryHeader, "categoryHeader");
			// 
			// degreeHeader
			// 
			resources.ApplyResources(this.degreeHeader, "degreeHeader");
			// 
			// deptHeader
			// 
			resources.ApplyResources(this.deptHeader, "deptHeader");
			// 
			// btAddMedic
			// 
			resources.ApplyResources(this.btAddMedic, "btAddMedic");
			this.btAddMedic.Name = "btAddMedic";
			this.btAddMedic.UseVisualStyleBackColor = true;
			this.btAddMedic.Click += new System.EventHandler(this.btAddMedic_Click);
			// 
			// bgWorker
			// 
			this.bgWorker.WorkerSupportsCancellation = true;
			this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
			// 
			// MedicListForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btAddMedic);
			this.Controls.Add(this.medicList);
			this.Name = "MedicListForm";
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