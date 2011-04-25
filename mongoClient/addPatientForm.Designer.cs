namespace mongoClient
{
	partial class AddPatientForm
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
			this.btSave = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbPatronymic = new System.Windows.Forms.TextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbTelephone = new System.Windows.Forms.TextBox();
			this.lbBirth = new System.Windows.Forms.Label();
			this.lbTelephone = new System.Windows.Forms.Label();
			this.lbAddress = new System.Windows.Forms.Label();
			this.lbPatronymic = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbSurname = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(12, 282);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(82, 25);
			this.btSave.TabIndex = 0;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(198, 282);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(82, 25);
			this.btCancel.TabIndex = 1;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// tbSurname
			// 
			this.tbSurname.Location = new System.Drawing.Point(86, 50);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(165, 20);
			this.tbSurname.TabIndex = 2;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(86, 73);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(165, 20);
			this.tbName.TabIndex = 3;
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(86, 99);
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(165, 20);
			this.tbPatronymic.TabIndex = 4;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Checked = false;
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(86, 127);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.ShowCheckBox = true;
			this.dtpBirthDate.Size = new System.Drawing.Size(126, 20);
			this.dtpBirthDate.TabIndex = 5;
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(86, 153);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(118, 20);
			this.tbAddress.TabIndex = 7;
			// 
			// tbTelephone
			// 
			this.tbTelephone.Location = new System.Drawing.Point(86, 179);
			this.tbTelephone.Name = "tbTelephone";
			this.tbTelephone.Size = new System.Drawing.Size(117, 20);
			this.tbTelephone.TabIndex = 8;
			// 
			// lbBirth
			// 
			this.lbBirth.AutoSize = true;
			this.lbBirth.Location = new System.Drawing.Point(9, 131);
			this.lbBirth.Name = "lbBirth";
			this.lbBirth.Size = new System.Drawing.Size(55, 13);
			this.lbBirth.TabIndex = 32;
			this.lbBirth.Text = "Birth date:";
			// 
			// lbTelephone
			// 
			this.lbTelephone.AutoSize = true;
			this.lbTelephone.Location = new System.Drawing.Point(9, 182);
			this.lbTelephone.Name = "lbTelephone";
			this.lbTelephone.Size = new System.Drawing.Size(43, 13);
			this.lbTelephone.TabIndex = 31;
			this.lbTelephone.Text = "Tel. no.";
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.Location = new System.Drawing.Point(9, 156);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(48, 13);
			this.lbAddress.TabIndex = 30;
			this.lbAddress.Text = "Address:";
			// 
			// lbPatronymic
			// 
			this.lbPatronymic.AutoSize = true;
			this.lbPatronymic.Location = new System.Drawing.Point(9, 102);
			this.lbPatronymic.Name = "lbPatronymic";
			this.lbPatronymic.Size = new System.Drawing.Size(62, 13);
			this.lbPatronymic.TabIndex = 29;
			this.lbPatronymic.Text = "Patronymic:";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(9, 76);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(38, 13);
			this.lbName.TabIndex = 28;
			this.lbName.Text = "Name:";
			// 
			// lbSurname
			// 
			this.lbSurname.AutoSize = true;
			this.lbSurname.Location = new System.Drawing.Point(9, 53);
			this.lbSurname.Name = "lbSurname";
			this.lbSurname.Size = new System.Drawing.Size(52, 13);
			this.lbSurname.TabIndex = 27;
			this.lbSurname.Text = "Surname:";
			// 
			// AddPatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 319);
			this.Controls.Add(this.lbBirth);
			this.Controls.Add(this.lbTelephone);
			this.Controls.Add(this.lbAddress);
			this.Controls.Add(this.lbPatronymic);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbSurname);
			this.Controls.Add(this.tbTelephone);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.tbPatronymic);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btSave);
			this.Name = "AddPatientForm";
			this.Text = "New patient";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox tbSurname;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbPatronymic;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbTelephone;
		private System.Windows.Forms.Label lbBirth;
		private System.Windows.Forms.Label lbTelephone;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label lbPatronymic;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbSurname;
	}
}