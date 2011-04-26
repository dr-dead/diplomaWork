namespace mongoClient
{
	partial class MedicForm
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
			this.cbProfessions = new System.Windows.Forms.ComboBox();
			this.cbCategory = new System.Windows.Forms.ComboBox();
			this.cbDegree = new System.Windows.Forms.ComboBox();
			this.cbDepartment = new System.Windows.Forms.ComboBox();
			this.btSave = new System.Windows.Forms.Button();
			this.tbCabinet = new System.Windows.Forms.TextBox();
			this.lbBirth = new System.Windows.Forms.Label();
			this.lbPatronymic = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbSurname = new System.Windows.Forms.Label();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.tbPatronymic = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbProfessions
			// 
			this.cbProfessions.FormattingEnabled = true;
			this.cbProfessions.Location = new System.Drawing.Point(97, 144);
			this.cbProfessions.Name = "cbProfessions";
			this.cbProfessions.Size = new System.Drawing.Size(165, 21);
			this.cbProfessions.TabIndex = 4;
			// 
			// cbCategory
			// 
			this.cbCategory.FormattingEnabled = true;
			this.cbCategory.Location = new System.Drawing.Point(97, 171);
			this.cbCategory.Name = "cbCategory";
			this.cbCategory.Size = new System.Drawing.Size(165, 21);
			this.cbCategory.TabIndex = 5;
			// 
			// cbDegree
			// 
			this.cbDegree.FormattingEnabled = true;
			this.cbDegree.Location = new System.Drawing.Point(97, 198);
			this.cbDegree.Name = "cbDegree";
			this.cbDegree.Size = new System.Drawing.Size(165, 21);
			this.cbDegree.TabIndex = 6;
			// 
			// cbDepartment
			// 
			this.cbDepartment.FormattingEnabled = true;
			this.cbDepartment.Location = new System.Drawing.Point(97, 225);
			this.cbDepartment.Name = "cbDepartment";
			this.cbDepartment.Size = new System.Drawing.Size(165, 21);
			this.cbDepartment.TabIndex = 7;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(33, 312);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(96, 26);
			this.btSave.TabIndex = 9;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// tbCabinet
			// 
			this.tbCabinet.Location = new System.Drawing.Point(97, 252);
			this.tbCabinet.Name = "tbCabinet";
			this.tbCabinet.Size = new System.Drawing.Size(90, 20);
			this.tbCabinet.TabIndex = 8;
			// 
			// lbBirth
			// 
			this.lbBirth.AutoSize = true;
			this.lbBirth.Location = new System.Drawing.Point(20, 122);
			this.lbBirth.Name = "lbBirth";
			this.lbBirth.Size = new System.Drawing.Size(55, 13);
			this.lbBirth.TabIndex = 40;
			this.lbBirth.Text = "Birth date:";
			// 
			// lbPatronymic
			// 
			this.lbPatronymic.AutoSize = true;
			this.lbPatronymic.Location = new System.Drawing.Point(20, 93);
			this.lbPatronymic.Name = "lbPatronymic";
			this.lbPatronymic.Size = new System.Drawing.Size(62, 13);
			this.lbPatronymic.TabIndex = 39;
			this.lbPatronymic.Text = "Patronymic:";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(20, 67);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(38, 13);
			this.lbName.TabIndex = 38;
			this.lbName.Text = "Name:";
			// 
			// lbSurname
			// 
			this.lbSurname.AutoSize = true;
			this.lbSurname.Location = new System.Drawing.Point(20, 44);
			this.lbSurname.Name = "lbSurname";
			this.lbSurname.Size = new System.Drawing.Size(52, 13);
			this.lbSurname.TabIndex = 37;
			this.lbSurname.Text = "Surname:";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Checked = false;
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(97, 118);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.ShowCheckBox = true;
			this.dtpBirthDate.Size = new System.Drawing.Size(126, 20);
			this.dtpBirthDate.TabIndex = 3;
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(97, 90);
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(165, 20);
			this.tbPatronymic.TabIndex = 2;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(97, 64);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(165, 20);
			this.tbName.TabIndex = 1;
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(97, 41);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(165, 20);
			this.tbSurname.TabIndex = 0;
			// 
			// tbId
			// 
			this.tbId.Enabled = false;
			this.tbId.Location = new System.Drawing.Point(97, 15);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(165, 20);
			this.tbId.TabIndex = 41;
			// 
			// MedicForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 357);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.lbBirth);
			this.Controls.Add(this.lbPatronymic);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbSurname);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.tbPatronymic);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.tbCabinet);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.cbDepartment);
			this.Controls.Add(this.cbDegree);
			this.Controls.Add(this.cbCategory);
			this.Controls.Add(this.cbProfessions);
			this.Name = "MedicForm";
			this.Text = "MedicForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbProfessions;
		private System.Windows.Forms.ComboBox cbCategory;
		private System.Windows.Forms.ComboBox cbDegree;
		private System.Windows.Forms.ComboBox cbDepartment;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.TextBox tbCabinet;
		private System.Windows.Forms.Label lbBirth;
		private System.Windows.Forms.Label lbPatronymic;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbSurname;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.TextBox tbPatronymic;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbId;
	}
}