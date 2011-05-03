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
			this.treeHealthLog = new System.Windows.Forms.TreeView();
			this.btAddCase = new System.Windows.Forms.Button();
			this.btAddEntry = new System.Windows.Forms.Button();
			this.tbMedic = new System.Windows.Forms.TextBox();
			this.btDelete = new System.Windows.Forms.Button();
			this.btMedicSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeHealthLog
			// 
			this.treeHealthLog.HideSelection = false;
			this.treeHealthLog.Location = new System.Drawing.Point(12, 12);
			this.treeHealthLog.Name = "treeHealthLog";
			this.treeHealthLog.Size = new System.Drawing.Size(227, 423);
			this.treeHealthLog.TabIndex = 0;
			this.treeHealthLog.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeHealthLog_NodeMouseClick);
			// 
			// btAddCase
			// 
			this.btAddCase.Location = new System.Drawing.Point(277, 412);
			this.btAddCase.Name = "btAddCase";
			this.btAddCase.Size = new System.Drawing.Size(100, 22);
			this.btAddCase.TabIndex = 1;
			this.btAddCase.Text = "Add Case";
			this.btAddCase.UseVisualStyleBackColor = true;
			this.btAddCase.Click += new System.EventHandler(this.btAddCase_Click);
			// 
			// btAddEntry
			// 
			this.btAddEntry.Location = new System.Drawing.Point(408, 412);
			this.btAddEntry.Name = "btAddEntry";
			this.btAddEntry.Size = new System.Drawing.Size(106, 21);
			this.btAddEntry.TabIndex = 2;
			this.btAddEntry.Text = "Add Entry";
			this.btAddEntry.UseVisualStyleBackColor = true;
			this.btAddEntry.Click += new System.EventHandler(this.btAddEntry_Click);
			// 
			// tbMedic
			// 
			this.tbMedic.BackColor = System.Drawing.SystemColors.Window;
			this.tbMedic.Location = new System.Drawing.Point(282, 26);
			this.tbMedic.Name = "tbMedic";
			this.tbMedic.ReadOnly = true;
			this.tbMedic.Size = new System.Drawing.Size(131, 20);
			this.tbMedic.TabIndex = 3;
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(549, 412);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(70, 21);
			this.btDelete.TabIndex = 4;
			this.btDelete.Text = "Delete";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// btMedicSelect
			// 
			this.btMedicSelect.Location = new System.Drawing.Point(436, 26);
			this.btMedicSelect.Name = "btMedicSelect";
			this.btMedicSelect.Size = new System.Drawing.Size(78, 20);
			this.btMedicSelect.TabIndex = 5;
			this.btMedicSelect.Text = "Assign medic";
			this.btMedicSelect.UseVisualStyleBackColor = true;
			this.btMedicSelect.Click += new System.EventHandler(this.btMedicSelect_Click);
			// 
			// HealthHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 447);
			this.Controls.Add(this.btMedicSelect);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.tbMedic);
			this.Controls.Add(this.btAddEntry);
			this.Controls.Add(this.btAddCase);
			this.Controls.Add(this.treeHealthLog);
			this.Name = "HealthHistoryForm";
			this.Text = "Health History";
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
	}
}