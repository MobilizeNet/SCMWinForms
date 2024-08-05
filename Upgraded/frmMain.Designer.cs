
namespace StarCarsManagement
{
	partial class frmMain
	{

		#region "Upgrade Support "
		private static frmMain m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmMain DefInstance
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
		public static frmMain CreateInstance()
		{
			frmMain theInstance = new frmMain();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 10);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "mnuChangeUser", "mnuExit", "mnuFile", "mnuCreateBrand", "mnuDeleteBrand", "mnuBrands", "mnuCreateVehicle", "mnuDeleteVehicle", "mnuVehicles", "mnuCreateStaff", "mnuDeleteStaff", "mnuStaff", "menuCreateReceipts", "mnuReceipts", "mnuManage", "mnuShowBrands", "mnuShowVehicles", "mnuShowStaff", "mnuShowReceipts", "mnuDetailedInformation", "mnuConsults", "mnuAbout", "mnuHelp", "MainMenu1", "lblRole", "lblUser"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ToolStripMenuItem mnuChangeUser;
		public System.Windows.Forms.ToolStripMenuItem mnuExit;
		public System.Windows.Forms.ToolStripMenuItem mnuFile;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateBrand;
		public System.Windows.Forms.ToolStripMenuItem mnuDeleteBrand;
		public System.Windows.Forms.ToolStripMenuItem mnuBrands;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateVehicle;
		public System.Windows.Forms.ToolStripMenuItem mnuDeleteVehicle;
		public System.Windows.Forms.ToolStripMenuItem mnuVehicles;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateStaff;
		public System.Windows.Forms.ToolStripMenuItem mnuDeleteStaff;
		public System.Windows.Forms.ToolStripMenuItem mnuStaff;
		public System.Windows.Forms.ToolStripMenuItem menuCreateReceipts;
		public System.Windows.Forms.ToolStripMenuItem mnuReceipts;
		public System.Windows.Forms.ToolStripMenuItem mnuManage;
		public System.Windows.Forms.ToolStripMenuItem mnuShowBrands;
		public System.Windows.Forms.ToolStripMenuItem mnuShowVehicles;
		public System.Windows.Forms.ToolStripMenuItem mnuShowStaff;
		public System.Windows.Forms.ToolStripMenuItem mnuShowReceipts;
		public System.Windows.Forms.ToolStripMenuItem mnuDetailedInformation;
		public System.Windows.Forms.ToolStripMenuItem mnuConsults;
		public System.Windows.Forms.ToolStripMenuItem mnuAbout;
		public System.Windows.Forms.ToolStripMenuItem mnuHelp;
		public System.Windows.Forms.MenuStrip MainMenu1;
		public System.Windows.Forms.Label lblRole;
		public System.Windows.Forms.Label lblUser;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.MainMenu1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuChangeUser = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuBrands = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCreateBrand = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDeleteBrand = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVehicles = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCreateVehicle = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDeleteVehicle = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCreateStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDeleteStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuReceipts = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCreateReceipts = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuConsults = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowBrands = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowVehicles = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowStaff = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuShowReceipts = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDetailedInformation = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.lblRole = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MainMenu1
			// 
			this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuFile, this.mnuManage, this.mnuConsults, this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Available = true;
			this.mnuFile.Checked = false;
			this.mnuFile.Enabled = true;
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Text = "File";
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuChangeUser, this.mnuExit});
			// 
			// mnuChangeUser
			// 
			this.mnuChangeUser.Available = true;
			this.mnuChangeUser.Checked = false;
			this.mnuChangeUser.Enabled = true;
			this.mnuChangeUser.Name = "mnuChangeUser";
			this.mnuChangeUser.Text = "Change User";
			this.mnuChangeUser.Click += new System.EventHandler(this.mnuChangeUser_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Available = true;
			this.mnuExit.Checked = false;
			this.mnuExit.Enabled = true;
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuManage
			// 
			this.mnuManage.Available = true;
			this.mnuManage.Checked = false;
			this.mnuManage.Enabled = true;
			this.mnuManage.Name = "mnuManage";
			this.mnuManage.Text = "Manage";
			this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuBrands, this.mnuVehicles, this.mnuStaff, this.mnuReceipts});
			// 
			// mnuBrands
			// 
			this.mnuBrands.Available = true;
			this.mnuBrands.Checked = false;
			this.mnuBrands.Enabled = true;
			this.mnuBrands.Name = "mnuBrands";
			this.mnuBrands.Text = "Brands";
			this.mnuBrands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuCreateBrand, this.mnuDeleteBrand});
			// 
			// mnuCreateBrand
			// 
			this.mnuCreateBrand.Available = true;
			this.mnuCreateBrand.Checked = false;
			this.mnuCreateBrand.Enabled = true;
			this.mnuCreateBrand.Name = "mnuCreateBrand";
			this.mnuCreateBrand.Text = "Create new";
			this.mnuCreateBrand.Click += new System.EventHandler(this.mnuCreateBrand_Click);
			// 
			// mnuDeleteBrand
			// 
			this.mnuDeleteBrand.Available = true;
			this.mnuDeleteBrand.Checked = false;
			this.mnuDeleteBrand.Enabled = true;
			this.mnuDeleteBrand.Name = "mnuDeleteBrand";
			this.mnuDeleteBrand.Text = "Delete";
			this.mnuDeleteBrand.Click += new System.EventHandler(this.mnuDeleteBrand_Click);
			// 
			// mnuVehicles
			// 
			this.mnuVehicles.Available = true;
			this.mnuVehicles.Checked = false;
			this.mnuVehicles.Enabled = true;
			this.mnuVehicles.Name = "mnuVehicles";
			this.mnuVehicles.Text = "Vehicles";
			this.mnuVehicles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuCreateVehicle, this.mnuDeleteVehicle});
			// 
			// mnuCreateVehicle
			// 
			this.mnuCreateVehicle.Available = true;
			this.mnuCreateVehicle.Checked = false;
			this.mnuCreateVehicle.Enabled = true;
			this.mnuCreateVehicle.Name = "mnuCreateVehicle";
			this.mnuCreateVehicle.Text = "Create new";
			this.mnuCreateVehicle.Click += new System.EventHandler(this.mnuCreateVehicle_Click);
			// 
			// mnuDeleteVehicle
			// 
			this.mnuDeleteVehicle.Available = true;
			this.mnuDeleteVehicle.Checked = false;
			this.mnuDeleteVehicle.Enabled = true;
			this.mnuDeleteVehicle.Name = "mnuDeleteVehicle";
			this.mnuDeleteVehicle.Text = "Delete";
			this.mnuDeleteVehicle.Click += new System.EventHandler(this.mnuDeleteVehicle_Click);
			// 
			// mnuStaff
			// 
			this.mnuStaff.Available = true;
			this.mnuStaff.Checked = false;
			this.mnuStaff.Enabled = true;
			this.mnuStaff.Name = "mnuStaff";
			this.mnuStaff.Text = "Staff";
			this.mnuStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuCreateStaff, this.mnuDeleteStaff});
			// 
			// mnuCreateStaff
			// 
			this.mnuCreateStaff.Available = true;
			this.mnuCreateStaff.Checked = false;
			this.mnuCreateStaff.Enabled = true;
			this.mnuCreateStaff.Name = "mnuCreateStaff";
			this.mnuCreateStaff.Text = "Create new";
			this.mnuCreateStaff.Click += new System.EventHandler(this.mnuCreateStaff_Click);
			// 
			// mnuDeleteStaff
			// 
			this.mnuDeleteStaff.Available = true;
			this.mnuDeleteStaff.Checked = false;
			this.mnuDeleteStaff.Enabled = true;
			this.mnuDeleteStaff.Name = "mnuDeleteStaff";
			this.mnuDeleteStaff.Text = "Delete";
			this.mnuDeleteStaff.Click += new System.EventHandler(this.mnuDeleteStaff_Click);
			// 
			// mnuReceipts
			// 
			this.mnuReceipts.Available = true;
			this.mnuReceipts.Checked = false;
			this.mnuReceipts.Enabled = true;
			this.mnuReceipts.Name = "mnuReceipts";
			this.mnuReceipts.Text = "Receipts";
			this.mnuReceipts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.menuCreateReceipts});
			// 
			// menuCreateReceipts
			// 
			this.menuCreateReceipts.Available = true;
			this.menuCreateReceipts.Checked = false;
			this.menuCreateReceipts.Enabled = true;
			this.menuCreateReceipts.Name = "menuCreateReceipts";
			this.menuCreateReceipts.Text = "Create new";
			this.menuCreateReceipts.Click += new System.EventHandler(this.menuCreateReceipts_Click);
			// 
			// mnuConsults
			// 
			this.mnuConsults.Available = true;
			this.mnuConsults.Checked = false;
			this.mnuConsults.Enabled = true;
			this.mnuConsults.Name = "mnuConsults";
			this.mnuConsults.Text = "Consults";
			this.mnuConsults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuShowBrands, this.mnuShowVehicles, this.mnuShowStaff, this.mnuShowReceipts, this.mnuDetailedInformation});
			// 
			// mnuShowBrands
			// 
			this.mnuShowBrands.Available = true;
			this.mnuShowBrands.Checked = false;
			this.mnuShowBrands.Enabled = true;
			this.mnuShowBrands.Name = "mnuShowBrands";
			this.mnuShowBrands.Text = "Brands";
			this.mnuShowBrands.Click += new System.EventHandler(this.mnuShowBrands_Click);
			// 
			// mnuShowVehicles
			// 
			this.mnuShowVehicles.Available = true;
			this.mnuShowVehicles.Checked = false;
			this.mnuShowVehicles.Enabled = true;
			this.mnuShowVehicles.Name = "mnuShowVehicles";
			this.mnuShowVehicles.Text = "Vehicles";
			this.mnuShowVehicles.Click += new System.EventHandler(this.mnuShowVehicles_Click);
			// 
			// mnuShowStaff
			// 
			this.mnuShowStaff.Available = true;
			this.mnuShowStaff.Checked = false;
			this.mnuShowStaff.Enabled = true;
			this.mnuShowStaff.Name = "mnuShowStaff";
			this.mnuShowStaff.Text = "Staff";
			this.mnuShowStaff.Click += new System.EventHandler(this.mnuShowStaff_Click);
			// 
			// mnuShowReceipts
			// 
			this.mnuShowReceipts.Available = true;
			this.mnuShowReceipts.Checked = false;
			this.mnuShowReceipts.Enabled = true;
			this.mnuShowReceipts.Name = "mnuShowReceipts";
			this.mnuShowReceipts.Text = "Receipts";
			this.mnuShowReceipts.Click += new System.EventHandler(this.mnuShowReceipts_Click);
			// 
			// mnuDetailedInformation
			// 
			this.mnuDetailedInformation.Available = true;
			this.mnuDetailedInformation.Checked = false;
			this.mnuDetailedInformation.Enabled = true;
			this.mnuDetailedInformation.Name = "mnuDetailedInformation";
			this.mnuDetailedInformation.Text = "Detailed Information";
			this.mnuDetailedInformation.Click += new System.EventHandler(this.mnuDetailedInformation_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Available = true;
			this.mnuHelp.Checked = false;
			this.mnuHelp.Enabled = true;
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Text = "Help";
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuAbout});
			// 
			// mnuAbout
			// 
			this.mnuAbout.Available = true;
			this.mnuAbout.Checked = false;
			this.mnuAbout.Enabled = true;
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Text = "About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// lblRole
			// 
			this.lblRole.AllowDrop = true;
			this.lblRole.BackColor = System.Drawing.SystemColors.Control;
			this.lblRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblRole.Font = new System.Drawing.Font("Consolas", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblRole.Location = new System.Drawing.Point(72, 224);
			this.lblRole.MinimumSize = new System.Drawing.Size(521, 105);
			this.lblRole.Name = "lblRole";
			this.lblRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblRole.Size = new System.Drawing.Size(521, 105);
			this.lblRole.TabIndex = 1;
			this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblUser
			// 
			this.lblUser.AllowDrop = true;
			this.lblUser.BackColor = System.Drawing.SystemColors.Control;
			this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblUser.Font = new System.Drawing.Font("Consolas", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUser.Location = new System.Drawing.Point(72, 112);
			this.lblUser.MinimumSize = new System.Drawing.Size(521, 105);
			this.lblUser.Name = "lblUser";
			this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUser.Size = new System.Drawing.Size(521, 105);
			this.lblUser.TabIndex = 0;
			this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(676, 423);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(MainMenu1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmMain.Icon");
			this.Location = new System.Drawing.Point(10, 33);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu";
			this.Activated += new System.EventHandler(this.frmMain_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}