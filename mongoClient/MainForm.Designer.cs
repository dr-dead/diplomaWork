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
			this.PatientList.Name = "PatientList";
			this.PatientList.Size = new System.Drawing.Size(558, 388);
			this.PatientList.TabIndex = 3;
			this.PatientList.UseCompatibleStateImageBehavior = false;
			this.PatientList.View = System.Windows.Forms.View.Details;
			this.PatientList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnColumnClick);
			this.PatientList.ItemActivate += new System.EventHandler(this.PatientList_ItemActivate);
			// 
			// headerId
			// 
			this.headerId.Text = "Id";
			this.headerId.Width = 112;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 568);
			this.Controls.Add(this.PatientList);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView PatientList;
		private System.Windows.Forms.ColumnHeader headerId;
		private System.Windows.Forms.ColumnHeader headerName;
		private System.Windows.Forms.ColumnHeader headerNumber;
	}
}