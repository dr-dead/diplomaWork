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
			this.tbDiagnosis = new System.Windows.Forms.TextBox();
			this.tbDirection = new System.Windows.Forms.TextBox();
			this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
			this.btSave = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
			this.btAddCase.Location = new System.Drawing.Point(12, 441);
			this.btAddCase.Name = "btAddCase";
			this.btAddCase.Size = new System.Drawing.Size(71, 22);
			this.btAddCase.TabIndex = 1;
			this.btAddCase.Text = "Add Case";
			this.btAddCase.UseVisualStyleBackColor = true;
			this.btAddCase.Click += new System.EventHandler(this.btAddCase_Click);
			// 
			// btAddEntry
			// 
			this.btAddEntry.Location = new System.Drawing.Point(89, 441);
			this.btAddEntry.Name = "btAddEntry";
			this.btAddEntry.Size = new System.Drawing.Size(78, 22);
			this.btAddEntry.TabIndex = 2;
			this.btAddEntry.Text = "Add Entry";
			this.btAddEntry.UseVisualStyleBackColor = true;
			this.btAddEntry.Click += new System.EventHandler(this.btAddEntry_Click);
			// 
			// tbMedic
			// 
			this.tbMedic.BackColor = System.Drawing.SystemColors.Window;
			this.tbMedic.Location = new System.Drawing.Point(271, 136);
			this.tbMedic.Name = "tbMedic";
			this.tbMedic.ReadOnly = true;
			this.tbMedic.Size = new System.Drawing.Size(131, 20);
			this.tbMedic.TabIndex = 3;
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(173, 441);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(66, 22);
			this.btDelete.TabIndex = 4;
			this.btDelete.Text = "Delete";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// btMedicSelect
			// 
			this.btMedicSelect.Location = new System.Drawing.Point(408, 136);
			this.btMedicSelect.Name = "btMedicSelect";
			this.btMedicSelect.Size = new System.Drawing.Size(78, 20);
			this.btMedicSelect.TabIndex = 5;
			this.btMedicSelect.Text = "Assign medic";
			this.btMedicSelect.UseVisualStyleBackColor = true;
			this.btMedicSelect.Click += new System.EventHandler(this.btMedicSelect_Click);
			// 
			// tbDiagnosis
			// 
			this.tbDiagnosis.Location = new System.Drawing.Point(260, 377);
			this.tbDiagnosis.Multiline = true;
			this.tbDiagnosis.Name = "tbDiagnosis";
			this.tbDiagnosis.Size = new System.Drawing.Size(361, 58);
			this.tbDiagnosis.TabIndex = 6;
			// 
			// tbDirection
			// 
			this.tbDirection.Location = new System.Drawing.Point(260, 85);
			this.tbDirection.Name = "tbDirection";
			this.tbDirection.Size = new System.Drawing.Size(124, 20);
			this.tbDirection.TabIndex = 7;
			// 
			// dtpAppointment
			// 
			this.dtpAppointment.CustomFormat = "MM\'.\'dd\'.\'yyyy hh\':\'mm tt";
			this.dtpAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAppointment.Location = new System.Drawing.Point(262, 200);
			this.dtpAppointment.Name = "dtpAppointment";
			this.dtpAppointment.Size = new System.Drawing.Size(122, 20);
			this.dtpAppointment.TabIndex = 8;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(260, 441);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 22);
			this.btSave.TabIndex = 9;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(539, 441);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(81, 22);
			this.btCancel.TabIndex = 10;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(424, 199);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
			this.dateTimePicker1.TabIndex = 11;
			// 
			// HealthHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 472);
			this.Controls.Add(this.dateTimePicker1);
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
		private System.Windows.Forms.TextBox tbDiagnosis;
		private System.Windows.Forms.TextBox tbDirection;
		private System.Windows.Forms.DateTimePicker dtpAppointment;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}