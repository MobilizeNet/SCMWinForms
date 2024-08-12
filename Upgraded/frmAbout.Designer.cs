
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			picIcon = new System.Windows.Forms.PictureBox();
			cmdOK = new System.Windows.Forms.Button();
			cmdSysInfo = new System.Windows.Forms.Button();
			_Line1_1 = new System.Windows.Forms.Label();
			lblDescription = new System.Windows.Forms.Label();
			lblTitle = new System.Windows.Forms.Label();
			_Line1_0 = new System.Windows.Forms.Label();
			lblVersion = new System.Windows.Forms.Label();
			lblDisclaimer = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// picIcon
			// 
			picIcon.AllowDrop = true;
			picIcon.BackColor = System.Drawing.SystemColors.Control;
			picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			picIcon.CausesValidation = true;
			picIcon.Dock = System.Windows.Forms.DockStyle.None;
			picIcon.Enabled = true;
			picIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			picIcon.Image = (System.Drawing.Image) resources.GetObject("picIcon.Image");
			picIcon.Location = new System.Drawing.Point(0, 0);
			picIcon.Name = "picIcon";
			picIcon.Size = new System.Drawing.Size(80, 60);
			picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			picIcon.TabIndex = 1;
			picIcon.TabStop = true;
			picIcon.Visible = true;
			// 
			// cmdOK
			// 
			cmdOK.AllowDrop = true;
			cmdOK.BackColor = System.Drawing.SystemColors.Control;
			cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdOK.Location = new System.Drawing.Point(283, 175);
			cmdOK.Name = "cmdOK";
			cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdOK.Size = new System.Drawing.Size(84, 23);
			cmdOK.TabIndex = 0;
			cmdOK.Text = "OK";
			cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdOK.UseVisualStyleBackColor = false;
			cmdOK.Click += new System.EventHandler(cmdOK_Click);
			// 
			// cmdSysInfo
			// 
			cmdSysInfo.AllowDrop = true;
			cmdSysInfo.BackColor = System.Drawing.SystemColors.Control;
			cmdSysInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSysInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSysInfo.Location = new System.Drawing.Point(284, 205);
			cmdSysInfo.Name = "cmdSysInfo";
			cmdSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSysInfo.Size = new System.Drawing.Size(83, 23);
			cmdSysInfo.TabIndex = 2;
			cmdSysInfo.Text = "&System Info...";
			cmdSysInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSysInfo.UseVisualStyleBackColor = false;
			cmdSysInfo.Click += new System.EventHandler(cmdSysInfo_Click);
			// 
			// _Line1_1
			// 
			_Line1_1.AllowDrop = true;
			_Line1_1.BackColor = System.Drawing.Color.Gray;
			_Line1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			_Line1_1.Enabled = false;
			_Line1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_Line1_1.Location = new System.Drawing.Point(5, 147);
			_Line1_1.Name = "_Line1_1";
			_Line1_1.Size = new System.Drawing.Size(303, 1);
			_Line1_1.Visible = true;
			// 
			// lblDescription
			// 
			lblDescription.AllowDrop = true;
			lblDescription.BackColor = System.Drawing.SystemColors.Control;
			lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblDescription.ForeColor = System.Drawing.Color.Black;
			lblDescription.Location = new System.Drawing.Point(88, 75);
			lblDescription.MinimumSize = new System.Drawing.Size(259, 78);
			lblDescription.Name = "lblDescription";
			lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblDescription.Size = new System.Drawing.Size(259, 78);
			lblDescription.TabIndex = 3;
			lblDescription.Text = "App Description";
			// 
			// lblTitle
			// 
			lblTitle.AllowDrop = true;
			lblTitle.BackColor = System.Drawing.SystemColors.Control;
			lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTitle.ForeColor = System.Drawing.Color.Black;
			lblTitle.Location = new System.Drawing.Point(88, 16);
			lblTitle.MinimumSize = new System.Drawing.Size(259, 32);
			lblTitle.Name = "lblTitle";
			lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTitle.Size = new System.Drawing.Size(259, 32);
			lblTitle.TabIndex = 5;
			lblTitle.Text = "Application Title";
			// 
			// _Line1_0
			// 
			_Line1_0.AllowDrop = true;
			_Line1_0.BackColor = System.Drawing.Color.White;
			_Line1_0.Enabled = false;
			_Line1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_Line1_0.Location = new System.Drawing.Point(6, 148);
			_Line1_0.Name = "_Line1_0";
			_Line1_0.Size = new System.Drawing.Size(303, 1);
			_Line1_0.Visible = true;
			// 
			// lblVersion
			// 
			lblVersion.AllowDrop = true;
			lblVersion.BackColor = System.Drawing.SystemColors.Control;
			lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
			lblVersion.Location = new System.Drawing.Point(88, 52);
			lblVersion.MinimumSize = new System.Drawing.Size(259, 15);
			lblVersion.Name = "lblVersion";
			lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblVersion.Size = new System.Drawing.Size(259, 15);
			lblVersion.TabIndex = 6;
			lblVersion.Text = "Version";
			// 
			// lblDisclaimer
			// 
			lblDisclaimer.AllowDrop = true;
			lblDisclaimer.BackColor = System.Drawing.SystemColors.Control;
			lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblDisclaimer.ForeColor = System.Drawing.Color.Black;
			lblDisclaimer.Location = new System.Drawing.Point(17, 176);
			lblDisclaimer.MinimumSize = new System.Drawing.Size(258, 55);
			lblDisclaimer.Name = "lblDisclaimer";
			lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblDisclaimer.Size = new System.Drawing.Size(258, 55);
			lblDisclaimer.TabIndex = 4;
			lblDisclaimer.Text = "Warning: ...";
			// 
			// frmAbout
			// 
			AcceptButton = cmdOK;
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			BackgroundImage = (System.Drawing.Image) resources.GetObject("frmAbout.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			CancelButton = cmdOK;
			ClientSize = new System.Drawing.Size(382, 237);
			Controls.Add(picIcon);
			Controls.Add(cmdOK);
			Controls.Add(cmdSysInfo);
			Controls.Add(_Line1_1);
			Controls.Add(lblDescription);
			Controls.Add(lblTitle);
			Controls.Add(_Line1_0);
			Controls.Add(lblVersion);
			Controls.Add(lblDisclaimer);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Icon = (System.Drawing.Icon) resources.GetObject("frmAbout.Icon");
			Location = new System.Drawing.Point(156, 129);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmAbout";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "About MyApp";
			commandButtonHelper1.SetStyle(cmdOK, 0);
			commandButtonHelper1.SetStyle(cmdSysInfo, 0);
			Activated += new System.EventHandler(frmAbout_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
			InitializeLine1();
		}
		void InitializeLine1()
		{
			Line1 = new System.Windows.Forms.Label[2];
			Line1[1] = _Line1_1;
			Line1[0] = _Line1_0;
		}
		#endregion
	}
}