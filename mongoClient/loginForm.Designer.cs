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
			this.btConnect.Location = new System.Drawing.Point(42, 206);
			this.btConnect.Name = "btConnect";
			this.btConnect.Size = new System.Drawing.Size(102, 30);
			this.btConnect.TabIndex = 2;
			this.btConnect.Text = "Connect";
			this.btConnect.UseVisualStyleBackColor = true;
			this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
			// 
			// tbServerAddress
			// 
			this.tbServerAddress.Location = new System.Drawing.Point(98, 29);
			this.tbServerAddress.Name = "tbServerAddress";
			this.tbServerAddress.Size = new System.Drawing.Size(139, 20);
			this.tbServerAddress.TabIndex = 0;
			this.tbServerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbServerAddress_OnKeyDown);
			// 
			// cbDatabases
			// 
			this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDatabases.Enabled = false;
			this.cbDatabases.FormattingEnabled = true;
			this.cbDatabases.Location = new System.Drawing.Point(98, 155);
			this.cbDatabases.Name = "cbDatabases";
			this.cbDatabases.Size = new System.Drawing.Size(139, 21);
			this.cbDatabases.TabIndex = 1;
			// 
			// bwProgress
			// 
			this.bwProgress.WorkerReportsProgress = true;
			// 
			// labelServer
			// 
			this.labelServer.AutoSize = true;
			this.labelServer.Location = new System.Drawing.Point(35, 32);
			this.labelServer.Name = "labelServer";
			this.labelServer.Size = new System.Drawing.Size(41, 13);
			this.labelServer.TabIndex = 3;
			this.labelServer.Text = "Server:";
			// 
			// labelDatabase
			// 
			this.labelDatabase.AutoSize = true;
			this.labelDatabase.Location = new System.Drawing.Point(35, 158);
			this.labelDatabase.Name = "labelDatabase";
			this.labelDatabase.Size = new System.Drawing.Size(56, 13);
			this.labelDatabase.TabIndex = 4;
			this.labelDatabase.Text = "Database:";
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(172, 208);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(98, 27);
			this.btCancel.TabIndex = 5;
			this.btCancel.Text = "Exit";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(98, 72);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(139, 20);
			this.tbUser.TabIndex = 6;
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(98, 98);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(139, 20);
			this.tbPassword.TabIndex = 7;
			// 
			// lbUser
			// 
			this.lbUser.AutoSize = true;
			this.lbUser.Location = new System.Drawing.Point(35, 75);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(58, 13);
			this.lbUser.TabIndex = 8;
			this.lbUser.Text = "Username:";
			// 
			// lbPass
			// 
			this.lbPass.AutoSize = true;
			this.lbPass.Location = new System.Drawing.Point(35, 101);
			this.lbPass.Name = "lbPass";
			this.lbPass.Size = new System.Drawing.Size(56, 13);
			this.lbPass.TabIndex = 9;
			this.lbPass.Text = "Password:";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
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
			this.Text = "Connect to database";
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

