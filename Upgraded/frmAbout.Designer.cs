
namespace StarCarsManagement
{
	partial class frmAbout
	{

		#region "Upgrade Support "
		private static frmAbout m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAbout DefInstance
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
		public static frmAbout CreateInstance()
		{
			frmAbout theInstance = new frmAbout();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "picIcon", "cmdOK", "cmdSysInfo", "_Line1_1", "lblDescription", "lblTitle", "_Line1_0", "lblVersion", "lblDisclaimer", "Line1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.PictureBox picIcon;
		public System.Windows.Forms.Button cmdOK;
		public System.Windows.Forms.Button cmdSysInfo;
		private System.Windows.Forms.Label _Line1_1;
		public System.Windows.Forms.Label lblDescription;
		public System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label _Line1_0;
		public System.Windows.Forms.Label lblVersion;
		public System.Windows.Forms.Label lblDisclaimer;
		public System.Windows.Forms.Label[] Line1 = new System.Windows.Forms.Label[2];
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdSysInfo = new System.Windows.Forms.Button();
			this._Line1_1 = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this._Line1_0 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblDisclaimer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// picIcon
			// 
			this.picIcon.AllowDrop = true;
			this.picIcon.BackColor = System.Drawing.SystemColors.Control;
			this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picIcon.CausesValidation = true;
			this.picIcon.Dock = System.Windows.Forms.DockStyle.None;
			this.picIcon.Enabled = true;
			this.picIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.picIcon.Image = (System.Drawing.Image) resources.GetObject("picIcon.Image");
			this.picIcon.Location = new System.Drawing.Point(0, 0);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(80, 60);
			this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picIcon.TabIndex = 1;
			this.picIcon.TabStop = true;
			this.picIcon.Visible = true;
			// 
			// cmdOK
			// 
			this.cmdOK.AllowDrop = true;
			this.cmdOK.BackColor = System.Drawing.SystemColors.Control;
			this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdOK.Location = new System.Drawing.Point(283, 175);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdOK.Size = new System.Drawing.Size(84, 23);
			this.cmdOK.TabIndex = 0;
			this.cmdOK.Text = "OK";
			this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdOK.UseVisualStyleBackColor = false;
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// cmdSysInfo
			// 
			this.cmdSysInfo.AllowDrop = true;
			this.cmdSysInfo.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSysInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSysInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSysInfo.Location = new System.Drawing.Point(284, 205);
			this.cmdSysInfo.Name = "cmdSysInfo";
			this.cmdSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSysInfo.Size = new System.Drawing.Size(83, 23);
			this.cmdSysInfo.TabIndex = 2;
			this.cmdSysInfo.Text = "&System Info...";
			this.cmdSysInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSysInfo.UseVisualStyleBackColor = false;
			this.cmdSysInfo.Click += new System.EventHandler(this.cmdSysInfo_Click);
			// 
			// _Line1_1
			// 
			this._Line1_1.AllowDrop = true;
			this._Line1_1.BackColor = System.Drawing.Color.Gray;
			this._Line1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._Line1_1.Enabled = false;
			this._Line1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Line1_1.Location = new System.Drawing.Point(5, 147);
			this._Line1_1.Name = "_Line1_1";
			this._Line1_1.Size = new System.Drawing.Size(303, 1);
			this._Line1_1.Visible = true;
			// 
			// lblDescription
			// 
			this.lblDescription.AllowDrop = true;
			this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblDescription.ForeColor = System.Drawing.Color.Black;
			this.lblDescription.Location = new System.Drawing.Point(88, 75);
			this.lblDescription.MinimumSize = new System.Drawing.Size(259, 78);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescription.Size = new System.Drawing.Size(259, 78);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "App Description";
			// 
			// lblTitle
			// 
			this.lblTitle.AllowDrop = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = System.Drawing.Color.Black;
			this.lblTitle.Location = new System.Drawing.Point(88, 16);
			this.lblTitle.MinimumSize = new System.Drawing.Size(259, 32);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTitle.Size = new System.Drawing.Size(259, 32);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Application Title";
			// 
			// _Line1_0
			// 
			this._Line1_0.AllowDrop = true;
			this._Line1_0.BackColor = System.Drawing.Color.White;
			this._Line1_0.Enabled = false;
			this._Line1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Line1_0.Location = new System.Drawing.Point(6, 148);
			this._Line1_0.Name = "_Line1_0";
			this._Line1_0.Size = new System.Drawing.Size(303, 1);
			this._Line1_0.Visible = true;
			// 
			// lblVersion
			// 
			this.lblVersion.AllowDrop = true;
			this.lblVersion.BackColor = System.Drawing.SystemColors.Control;
			this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblVersion.Location = new System.Drawing.Point(88, 52);
			this.lblVersion.MinimumSize = new System.Drawing.Size(259, 15);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblVersion.Size = new System.Drawing.Size(259, 15);
			this.lblVersion.TabIndex = 6;
			this.lblVersion.Text = "Version";
			// 
			// lblDisclaimer
			// 
			this.lblDisclaimer.AllowDrop = true;
			this.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control;
			this.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblDisclaimer.ForeColor = System.Drawing.Color.Black;
			this.lblDisclaimer.Location = new System.Drawing.Point(17, 176);
			this.lblDisclaimer.MinimumSize = new System.Drawing.Size(258, 55);
			this.lblDisclaimer.Name = "lblDisclaimer";
			this.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDisclaimer.Size = new System.Drawing.Size(258, 55);
			this.lblDisclaimer.TabIndex = 4;
			this.lblDisclaimer.Text = "Warning: ...";
			// 
			// frmAbout
			// 
			this.AcceptButton = this.cmdOK;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = (System.Drawing.Image) resources.GetObject("frmAbout.BackgroundImage");
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CancelButton = this.cmdOK;
			this.ClientSize = new System.Drawing.Size(382, 237);
			this.Controls.Add(this.picIcon);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.cmdSysInfo);
			this.Controls.Add(this._Line1_1);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this._Line1_0);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblDisclaimer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmAbout.Icon");
			this.Location = new System.Drawing.Point(156, 129);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About MyApp";
			this.commandButtonHelper1.SetStyle(this.cmdOK, 0);
			this.commandButtonHelper1.SetStyle(this.cmdSysInfo, 0);
			this.Activated += new System.EventHandler(this.frmAbout_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
			InitializeLine1();
		}
		void InitializeLine1()
		{
			this.Line1 = new System.Windows.Forms.Label[2];
			this.Line1[1] = _Line1_1;
			this.Line1[0] = _Line1_0;
		}
		#endregion
	}
}