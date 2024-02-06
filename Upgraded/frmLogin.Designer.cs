
namespace StarCarsManagement
{
	partial class frmLogin
	{

		#region "Upgrade Support "
		private static frmLogin m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmLogin DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmLogin CreateInstance()
		{
			frmLogin theInstance = new frmLogin();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 10);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtUsername", "cmdOK", "cmdCancel", "txtPassword", "_lblLabels_0", "_lblLabels_1", "lblLabels", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtUsername;
		public System.Windows.Forms.Button cmdOK;
		public System.Windows.Forms.Button cmdCancel;
		public System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label _lblLabels_0;
		private System.Windows.Forms.Label _lblLabels_1;
		public System.Windows.Forms.Label[] lblLabels = new System.Windows.Forms.Label[2];
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this._lblLabels_0 = new System.Windows.Forms.Label();
			this._lblLabels_1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// txtUsername
			// 
			this.txtUsername.AcceptsReturn = true;
			this.txtUsername.AllowDrop = true;
			this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtUsername.Location = new System.Drawing.Point(86, 9);
			this.txtUsername.MaxLength = 0;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtUsername.Size = new System.Drawing.Size(155, 23);
			this.txtUsername.TabIndex = 1;
			// 
			// cmdOK
			// 
			this.cmdOK.AllowDrop = true;
			this.cmdOK.BackColor = System.Drawing.SystemColors.Control;
			this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdOK.Location = new System.Drawing.Point(33, 68);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdOK.Size = new System.Drawing.Size(76, 26);
			this.cmdOK.TabIndex = 4;
			this.cmdOK.Text = "&OK";
			this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdOK.UseVisualStyleBackColor = false;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.AllowDrop = true;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCancel.Location = new System.Drawing.Point(140, 68);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCancel.Size = new System.Drawing.Size(76, 26);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "&Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.AcceptsReturn = true;
			this.txtPassword.AllowDrop = true;
			this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtPassword.Location = new System.Drawing.Point(86, 35);
			this.txtPassword.MaxLength = 0;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = (char) 42;
			this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPassword.Size = new System.Drawing.Size(155, 23);
			this.txtPassword.TabIndex = 3;
			// 
			// _lblLabels_0
			// 
			this._lblLabels_0.AllowDrop = true;
			this._lblLabels_0.BackColor = System.Drawing.SystemColors.Control;
			this._lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lblLabels_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lblLabels_0.Location = new System.Drawing.Point(7, 10);
			this._lblLabels_0.Name = "_lblLabels_0";
			this._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lblLabels_0.Size = new System.Drawing.Size(72, 18);
			this._lblLabels_0.TabIndex = 0;
			this._lblLabels_0.Text = "&User Name:";
			// 
			// _lblLabels_1
			// 
			this._lblLabels_1.AllowDrop = true;
			this._lblLabels_1.BackColor = System.Drawing.SystemColors.Control;
			this._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._lblLabels_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._lblLabels_1.Location = new System.Drawing.Point(7, 36);
			this._lblLabels_1.Name = "_lblLabels_1";
			this._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._lblLabels_1.Size = new System.Drawing.Size(72, 18);
			this._lblLabels_1.TabIndex = 2;
			this._lblLabels_1.Text = "&Password:";
			// 
			// frmLogin
			// 
			this.AcceptButton = this.cmdOK;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(250, 103);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this._lblLabels_0);
			this.Controls.Add(this._lblLabels_1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmLogin.Icon");
			this.Location = new System.Drawing.Point(189, 232);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.commandButtonHelper1.SetStyle(this.cmdOK, 0);
			this.commandButtonHelper1.SetStyle(this.cmdCancel, 0);
			this.Activated += new System.EventHandler(this.frmLogin_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
			InitializelblLabels();
		}
		void InitializelblLabels()
		{
			this.lblLabels = new System.Windows.Forms.Label[2];
			this.lblLabels[0] = _lblLabels_0;
			this.lblLabels[1] = _lblLabels_1;
		}
		#endregion
	}
}