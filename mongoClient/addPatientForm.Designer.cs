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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
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
			resources.ApplyResources(this.btSave, "btSave");
			this.btSave.Name = "btSave";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btCancel
			// 
			resources.ApplyResources(this.btCancel, "btCancel");
			this.btCancel.Name = "btCancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// tbSurname
			// 
			resources.ApplyResources(this.tbSurname, "tbSurname");
			this.tbSurname.Name = "tbSurname";
			// 
			// tbName
			// 
			resources.ApplyResources(this.tbName, "tbName");
			this.tbName.Name = "tbName";
			// 
			// tbPatronymic
			// 
			resources.ApplyResources(this.tbPatronymic, "tbPatronymic");
			this.tbPatronymic.Name = "tbPatronymic";
			// 
			// dtpBirthDate
			// 
			resources.ApplyResources(this.dtpBirthDate, "dtpBirthDate");
			this.dtpBirthDate.Checked = false;
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.ShowCheckBox = true;
			// 
			// tbAddress
			// 
			resources.ApplyResources(this.tbAddress, "tbAddress");
			this.tbAddress.Name = "tbAddress";
			// 
			// tbTelephone
			// 
			resources.ApplyResources(this.tbTelephone, "tbTelephone");
			this.tbTelephone.Name = "tbTelephone";
			// 
			// lbBirth
			// 
			resources.ApplyResources(this.lbBirth, "lbBirth");
			this.lbBirth.Name = "lbBirth";
			// 
			// lbTelephone
			// 
			resources.ApplyResources(this.lbTelephone, "lbTelephone");
			this.lbTelephone.Name = "lbTelephone";
			// 
			// lbAddress
			// 
			resources.ApplyResources(this.lbAddress, "lbAddress");
			this.lbAddress.Name = "lbAddress";
			// 
			// lbPatronymic
			// 
			resources.ApplyResources(this.lbPatronymic, "lbPatronymic");
			this.lbPatronymic.Name = "lbPatronymic";
			// 
			// lbName
			// 
			resources.ApplyResources(this.lbName, "lbName");
			this.lbName.Name = "lbName";
			// 
			// lbSurname
			// 
			resources.ApplyResources(this.lbSurname, "lbSurname");
			this.lbSurname.Name = "lbSurname";
			// 
			// AddPatientForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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