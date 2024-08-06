
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			MainMenu1 = new System.Windows.Forms.MenuStrip();
			mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			mnuChangeUser = new System.Windows.Forms.ToolStripMenuItem();
			mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			mnuManage = new System.Windows.Forms.ToolStripMenuItem();
			mnuBrands = new System.Windows.Forms.ToolStripMenuItem();
			mnuCreateBrand = new System.Windows.Forms.ToolStripMenuItem();
			mnuDeleteBrand = new System.Windows.Forms.ToolStripMenuItem();
			mnuVehicles = new System.Windows.Forms.ToolStripMenuItem();
			mnuCreateVehicle = new System.Windows.Forms.ToolStripMenuItem();
			mnuDeleteVehicle = new System.Windows.Forms.ToolStripMenuItem();
			mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
			mnuCreateStaff = new System.Windows.Forms.ToolStripMenuItem();
			mnuDeleteStaff = new System.Windows.Forms.ToolStripMenuItem();
			mnuReceipts = new System.Windows.Forms.ToolStripMenuItem();
			menuCreateReceipts = new System.Windows.Forms.ToolStripMenuItem();
			mnuConsults = new System.Windows.Forms.ToolStripMenuItem();
			mnuShowBrands = new System.Windows.Forms.ToolStripMenuItem();
			mnuShowVehicles = new System.Windows.Forms.ToolStripMenuItem();
			mnuShowStaff = new System.Windows.Forms.ToolStripMenuItem();
			mnuShowReceipts = new System.Windows.Forms.ToolStripMenuItem();
			mnuDetailedInformation = new System.Windows.Forms.ToolStripMenuItem();
			mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			lblRole = new System.Windows.Forms.Label();
			lblUser = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// MainMenu1
			// 
			MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuFile, mnuManage, mnuConsults, mnuHelp});
			// 
			// mnuFile
			// 
			mnuFile.Available = true;
			mnuFile.Checked = false;
			mnuFile.Enabled = true;
			mnuFile.Name = "mnuFile";
			mnuFile.Text = "File";
			mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuChangeUser, mnuExit});
			// 
			// mnuChangeUser
			// 
			mnuChangeUser.Available = true;
			mnuChangeUser.Checked = false;
			mnuChangeUser.Enabled = true;
			mnuChangeUser.Name = "mnuChangeUser";
			mnuChangeUser.Text = "Change User";
			mnuChangeUser.Click += new System.EventHandler(mnuChangeUser_Click);
			// 
			// mnuExit
			// 
			mnuExit.Available = true;
			mnuExit.Checked = false;
			mnuExit.Enabled = true;
			mnuExit.Name = "mnuExit";
			mnuExit.Text = "Exit";
			mnuExit.Click += new System.EventHandler(mnuExit_Click);
			// 
			// mnuManage
			// 
			mnuManage.Available = true;
			mnuManage.Checked = false;
			mnuManage.Enabled = true;
			mnuManage.Name = "mnuManage";
			mnuManage.Text = "Manage";
			mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuBrands, mnuVehicles, mnuStaff, mnuReceipts});
			// 
			// mnuBrands
			// 
			mnuBrands.Available = true;
			mnuBrands.Checked = false;
			mnuBrands.Enabled = true;
			mnuBrands.Name = "mnuBrands";
			mnuBrands.Text = "Brands";
			mnuBrands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuCreateBrand, mnuDeleteBrand});
			// 
			// mnuCreateBrand
			// 
			mnuCreateBrand.Available = true;
			mnuCreateBrand.Checked = false;
			mnuCreateBrand.Enabled = true;
			mnuCreateBrand.Name = "mnuCreateBrand";
			mnuCreateBrand.Text = "Create new";
			mnuCreateBrand.Click += new System.EventHandler(mnuCreateBrand_Click);
			// 
			// mnuDeleteBrand
			// 
			mnuDeleteBrand.Available = true;
			mnuDeleteBrand.Checked = false;
			mnuDeleteBrand.Enabled = true;
			mnuDeleteBrand.Name = "mnuDeleteBrand";
			mnuDeleteBrand.Text = "Delete";
			mnuDeleteBrand.Click += new System.EventHandler(mnuDeleteBrand_Click);
			// 
			// mnuVehicles
			// 
			mnuVehicles.Available = true;
			mnuVehicles.Checked = false;
			mnuVehicles.Enabled = true;
			mnuVehicles.Name = "mnuVehicles";
			mnuVehicles.Text = "Vehicles";
			mnuVehicles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuCreateVehicle, mnuDeleteVehicle});
			// 
			// mnuCreateVehicle
			// 
			mnuCreateVehicle.Available = true;
			mnuCreateVehicle.Checked = false;
			mnuCreateVehicle.Enabled = true;
			mnuCreateVehicle.Name = "mnuCreateVehicle";
			mnuCreateVehicle.Text = "Create new";
			mnuCreateVehicle.Click += new System.EventHandler(mnuCreateVehicle_Click);
			// 
			// mnuDeleteVehicle
			// 
			mnuDeleteVehicle.Available = true;
			mnuDeleteVehicle.Checked = false;
			mnuDeleteVehicle.Enabled = true;
			mnuDeleteVehicle.Name = "mnuDeleteVehicle";
			mnuDeleteVehicle.Text = "Delete";
			mnuDeleteVehicle.Click += new System.EventHandler(mnuDeleteVehicle_Click);
			// 
			// mnuStaff
			// 
			mnuStaff.Available = true;
			mnuStaff.Checked = false;
			mnuStaff.Enabled = true;
			mnuStaff.Name = "mnuStaff";
			mnuStaff.Text = "Staff";
			mnuStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuCreateStaff, mnuDeleteStaff});
			// 
			// mnuCreateStaff
			// 
			mnuCreateStaff.Available = true;
			mnuCreateStaff.Checked = false;
			mnuCreateStaff.Enabled = true;
			mnuCreateStaff.Name = "mnuCreateStaff";
			mnuCreateStaff.Text = "Create new";
			mnuCreateStaff.Click += new System.EventHandler(mnuCreateStaff_Click);
			// 
			// mnuDeleteStaff
			// 
			mnuDeleteStaff.Available = true;
			mnuDeleteStaff.Checked = false;
			mnuDeleteStaff.Enabled = true;
			mnuDeleteStaff.Name = "mnuDeleteStaff";
			mnuDeleteStaff.Text = "Delete";
			mnuDeleteStaff.Click += new System.EventHandler(mnuDeleteStaff_Click);
			// 
			// mnuReceipts
			// 
			mnuReceipts.Available = true;
			mnuReceipts.Checked = false;
			mnuReceipts.Enabled = true;
			mnuReceipts.Name = "mnuReceipts";
			mnuReceipts.Text = "Receipts";
			mnuReceipts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{menuCreateReceipts});
			// 
			// menuCreateReceipts
			// 
			menuCreateReceipts.Available = true;
			menuCreateReceipts.Checked = false;
			menuCreateReceipts.Enabled = true;
			menuCreateReceipts.Name = "menuCreateReceipts";
			menuCreateReceipts.Text = "Create new";
			menuCreateReceipts.Click += new System.EventHandler(menuCreateReceipts_Click);
			// 
			// mnuConsults
			// 
			mnuConsults.Available = true;
			mnuConsults.Checked = false;
			mnuConsults.Enabled = true;
			mnuConsults.Name = "mnuConsults";
			mnuConsults.Text = "Consults";
			mnuConsults.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuShowBrands, mnuShowVehicles, mnuShowStaff, mnuShowReceipts, mnuDetailedInformation});
			// 
			// mnuShowBrands
			// 
			mnuShowBrands.Available = true;
			mnuShowBrands.Checked = false;
			mnuShowBrands.Enabled = true;
			mnuShowBrands.Name = "mnuShowBrands";
			mnuShowBrands.Text = "Brands";
			mnuShowBrands.Click += new System.EventHandler(mnuShowBrands_Click);
			// 
			// mnuShowVehicles
			// 
			mnuShowVehicles.Available = true;
			mnuShowVehicles.Checked = false;
			mnuShowVehicles.Enabled = true;
			mnuShowVehicles.Name = "mnuShowVehicles";
			mnuShowVehicles.Text = "Vehicles";
			mnuShowVehicles.Click += new System.EventHandler(mnuShowVehicles_Click);
			// 
			// mnuShowStaff
			// 
			mnuShowStaff.Available = true;
			mnuShowStaff.Checked = false;
			mnuShowStaff.Enabled = true;
			mnuShowStaff.Name = "mnuShowStaff";
			mnuShowStaff.Text = "Staff";
			mnuShowStaff.Click += new System.EventHandler(mnuShowStaff_Click);
			// 
			// mnuShowReceipts
			// 
			mnuShowReceipts.Available = true;
			mnuShowReceipts.Checked = false;
			mnuShowReceipts.Enabled = true;
			mnuShowReceipts.Name = "mnuShowReceipts";
			mnuShowReceipts.Text = "Receipts";
			mnuShowReceipts.Click += new System.EventHandler(mnuShowReceipts_Click);
			// 
			// mnuDetailedInformation
			// 
			mnuDetailedInformation.Available = true;
			mnuDetailedInformation.Checked = false;
			mnuDetailedInformation.Enabled = true;
			mnuDetailedInformation.Name = "mnuDetailedInformation";
			mnuDetailedInformation.Text = "Detailed Information";
			mnuDetailedInformation.Click += new System.EventHandler(mnuDetailedInformation_Click);
			// 
			// mnuHelp
			// 
			mnuHelp.Available = true;
			mnuHelp.Checked = false;
			mnuHelp.Enabled = true;
			mnuHelp.Name = "mnuHelp";
			mnuHelp.Text = "Help";
			mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{mnuAbout});
			// 
			// mnuAbout
			// 
			mnuAbout.Available = true;
			mnuAbout.Checked = false;
			mnuAbout.Enabled = true;
			mnuAbout.Name = "mnuAbout";
			mnuAbout.Text = "About";
			mnuAbout.Click += new System.EventHandler(mnuAbout_Click);
			// 
			// lblRole
			// 
			lblRole.AllowDrop = true;
			lblRole.BackColor = System.Drawing.SystemColors.Control;
			lblRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblRole.Font = new System.Drawing.Font("Consolas", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
			lblRole.Location = new System.Drawing.Point(72, 224);
			lblRole.MinimumSize = new System.Drawing.Size(521, 105);
			lblRole.Name = "lblRole";
			lblRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblRole.Size = new System.Drawing.Size(521, 105);
			lblRole.TabIndex = 1;
			lblRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblUser
			// 
			lblUser.AllowDrop = true;
			lblUser.BackColor = System.Drawing.SystemColors.Control;
			lblUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblUser.Font = new System.Drawing.Font("Consolas", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
			lblUser.Location = new System.Drawing.Point(72, 112);
			lblUser.MinimumSize = new System.Drawing.Size(521, 105);
			lblUser.Name = "lblUser";
			lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblUser.Size = new System.Drawing.Size(521, 105);
			lblUser.TabIndex = 0;
			lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmMain
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(676, 423);
			Controls.Add(lblRole);
			Controls.Add(lblUser);
			Controls.Add(MainMenu1);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmMain.Icon");
			Location = new System.Drawing.Point(10, 33);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmMain";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Main Menu";
			Activated += new System.EventHandler(frmMain_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}