namespace mongoClient
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.btConnect = new System.Windows.Forms.Button();
			this.tbServerAddress = new System.Windows.Forms.TextBox();
			this.cbDatabases = new System.Windows.Forms.ComboBox();
			this.bwProgress = new System.ComponentModel.BackgroundWorker();
			this.labelServer = new System.Windows.Forms.Label();
			this.labelDatabase = new System.Windows.Forms.Label();
			this.btCancel = new System.Windows.Forms.Button();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.lbUser = new System.Windows.Forms.Label();
			this.lbPass = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btConnect
			// 
			resources.ApplyResources(this.btConnect, "btConnect");
			this.btConnect.Name = "btConnect";
			this.btConnect.UseVisualStyleBackColor = true;
			this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
			// 
			// tbServerAddress
			// 
			resources.ApplyResources(this.tbServerAddress, "tbServerAddress");
			this.tbServerAddress.Name = "tbServerAddress";
			this.tbServerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbServerAddress_OnKeyDown);
			// 
			// cbDatabases
			// 
			this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cbDatabases, "cbDatabases");
			this.cbDatabases.FormattingEnabled = true;
			this.cbDatabases.Name = "cbDatabases";
			// 
			// bwProgress
			// 
			this.bwProgress.WorkerReportsProgress = true;
			// 
			// labelServer
			// 
			resources.ApplyResources(this.labelServer, "labelServer");
			this.labelServer.Name = "labelServer";
			// 
			// labelDatabase
			// 
			resources.ApplyResources(this.labelDatabase, "labelDatabase");
			this.labelDatabase.Name = "labelDatabase";
			// 
			// btCancel
			// 
			resources.ApplyResources(this.btCancel, "btCancel");
			this.btCancel.Name = "btCancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// tbUser
			// 
			resources.ApplyResources(this.tbUser, "tbUser");
			this.tbUser.Name = "tbUser";
			// 
			// tbPassword
			// 
			resources.ApplyResources(this.tbPassword, "tbPassword");
			this.tbPassword.Name = "tbPassword";
			// 
			// lbUser
			// 
			resources.ApplyResources(this.lbUser, "lbUser");
			this.lbUser.Name = "lbUser";
			// 
			// lbPass
			// 
			resources.ApplyResources(this.lbPass, "lbPass");
			this.lbPass.Name = "lbPass";
			// 
			// LoginForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbPass);
			this.Controls.Add(this.lbUser);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.labelDatabase);
			this.Controls.Add(this.labelServer);
			this.Controls.Add(this.cbDatabases);
			this.Controls.Add(this.tbServerAddress);
			this.Controls.Add(this.btConnect);
			this.Name = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btConnect;
		private System.Windows.Forms.TextBox tbServerAddress;
		private System.Windows.Forms.ComboBox cbDatabases;
		private System.ComponentModel.BackgroundWorker bwProgress;
		private System.Windows.Forms.Label labelServer;
		private System.Windows.Forms.Label labelDatabase;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label lbUser;
		private System.Windows.Forms.Label lbPass;
	}
}

