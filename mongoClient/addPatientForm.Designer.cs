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
			this.dtpDeathDate = new System.Windows.Forms.DateTimePicker();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbTelephone = new System.Windows.Forms.TextBox();
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
			this.tbSurname.Location = new System.Drawing.Point(63, 49);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(166, 20);
			this.tbSurname.TabIndex = 2;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(63, 88);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(165, 20);
			this.tbName.TabIndex = 3;
			// 
			// tbPatronymic
			// 
			this.tbPatronymic.Location = new System.Drawing.Point(63, 125);
			this.tbPatronymic.Name = "tbPatronymic";
			this.tbPatronymic.Size = new System.Drawing.Size(165, 20);
			this.tbPatronymic.TabIndex = 4;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Checked = false;
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(12, 170);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.ShowCheckBox = true;
			this.dtpBirthDate.Size = new System.Drawing.Size(126, 20);
			this.dtpBirthDate.TabIndex = 5;
			// 
			// dtpDeathDate
			// 
			this.dtpDeathDate.Checked = false;
			this.dtpDeathDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDeathDate.Location = new System.Drawing.Point(166, 170);
			this.dtpDeathDate.Name = "dtpDeathDate";
			this.dtpDeathDate.ShowCheckBox = true;
			this.dtpDeathDate.Size = new System.Drawing.Size(114, 20);
			this.dtpDeathDate.TabIndex = 6;
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(63, 209);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(118, 20);
			this.tbAddress.TabIndex = 7;
			// 
			// tbTelephone
			// 
			this.tbTelephone.Location = new System.Drawing.Point(63, 244);
			this.tbTelephone.Name = "tbTelephone";
			this.tbTelephone.Size = new System.Drawing.Size(117, 20);
			this.tbTelephone.TabIndex = 8;
			// 
			// AddPatientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 319);
			this.Controls.Add(this.tbTelephone);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.dtpDeathDate);
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
		private System.Windows.Forms.DateTimePicker dtpDeathDate;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbTelephone;
	}
}