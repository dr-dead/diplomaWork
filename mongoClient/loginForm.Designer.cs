namespace mongoClient
{
    partial class loginForm
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
            if (disposing && (components != null))
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
			this.tbServerAddress.Location = new System.Drawing.Point(80, 47);
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
			this.cbDatabases.Location = new System.Drawing.Point(134, 156);
			this.cbDatabases.Name = "cbDatabases";
			this.cbDatabases.Size = new System.Drawing.Size(113, 21);
			this.cbDatabases.TabIndex = 1;
			// 
			// bwProgress
			// 
			this.bwProgress.WorkerReportsProgress = true;
			// 
			// labelServer
			// 
			this.labelServer.AutoSize = true;
			this.labelServer.Location = new System.Drawing.Point(39, 50);
			this.labelServer.Name = "labelServer";
			this.labelServer.Size = new System.Drawing.Size(41, 13);
			this.labelServer.TabIndex = 3;
			this.labelServer.Text = "Server:";
			// 
			// labelDatabase
			// 
			this.labelDatabase.AutoSize = true;
			this.labelDatabase.Location = new System.Drawing.Point(72, 159);
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
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.labelDatabase);
			this.Controls.Add(this.labelServer);
			this.Controls.Add(this.cbDatabases);
			this.Controls.Add(this.tbServerAddress);
			this.Controls.Add(this.btConnect);
			this.Name = "loginForm";
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
    }
}

