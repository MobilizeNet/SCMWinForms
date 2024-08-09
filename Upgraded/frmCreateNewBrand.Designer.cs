
namespace StarCarsManagement
{
	partial class frmCreateNewBrand
	{

		#region "Upgrade Support "
		private static frmCreateNewBrand m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCreateNewBrand DefInstance
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
		public static frmCreateNewBrand CreateInstance()
		{
			frmCreateNewBrand theInstance = new frmCreateNewBrand();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 20);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "dtFounded", "cmbParent", "txtNumberEmployees", "btnReset", "txtName", "Label9", "btnCreate", "txtWebsite", "txtAreaServed", "txtHeadquarters", "txtOwner", "lblTitle", "lblOwner", "lblHeadquarter", "lblAreaServed", "Label6", "lblWebsite", "lblNumberEmployees", "lblName", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.DateTimePicker dtFounded;
		public System.Windows.Forms.ComboBox cmbParent;
		public System.Windows.Forms.TextBox txtNumberEmployees;
		public System.Windows.Forms.Button btnReset;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Button btnCreate;
		public System.Windows.Forms.TextBox txtWebsite;
		public System.Windows.Forms.TextBox txtAreaServed;
		public System.Windows.Forms.TextBox txtHeadquarters;
		public System.Windows.Forms.TextBox txtOwner;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblOwner;
		public System.Windows.Forms.Label lblHeadquarter;
		public System.Windows.Forms.Label lblAreaServed;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label lblWebsite;
		public System.Windows.Forms.Label lblNumberEmployees;
		public System.Windows.Forms.Label lblName;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewBrand));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.dtFounded = new System.Windows.Forms.DateTimePicker();
			this.cmbParent = new System.Windows.Forms.ComboBox();
			this.txtNumberEmployees = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.txtAreaServed = new System.Windows.Forms.TextBox();
			this.txtHeadquarters = new System.Windows.Forms.TextBox();
			this.txtOwner = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblOwner = new System.Windows.Forms.Label();
			this.lblHeadquarter = new System.Windows.Forms.Label();
			this.lblAreaServed = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblWebsite = new System.Windows.Forms.Label();
			this.lblNumberEmployees = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// dtFounded
			// 
			this.dtFounded.AllowDrop = true;
			this.dtFounded.Checked = false;
			this.dtFounded.CustomFormat = "MM/dd/yyyy";
			this.dtFounded.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtFounded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFounded.Location = new System.Drawing.Point(280, 208);
			this.dtFounded.Name = "dtFounded";
			this.dtFounded.Size = new System.Drawing.Size(209, 33);
			this.dtFounded.TabIndex = 5;
			// 
			// cmbParent
			// 
			this.cmbParent.AllowDrop = true;
			this.cmbParent.BackColor = System.Drawing.SystemColors.Window;
			this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParent.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbParent.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbParent.Location = new System.Drawing.Point(24, 272);
			this.cmbParent.Name = "cmbParent";
			this.cmbParent.Size = new System.Drawing.Size(209, 26);
			this.cmbParent.TabIndex = 6;
			this.cmbParent.Text = "cmbParent";
			// 
			// txtNumberEmployees
			// 
			this.txtNumberEmployees.AllowDrop = true;
			this.txtNumberEmployees.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumberEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtNumberEmployees.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtNumberEmployees.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNumberEmployees.Location = new System.Drawing.Point(280, 272);
			this.txtNumberEmployees.Name = "txtNumberEmployees";
			this.txtNumberEmployees.Size = new System.Drawing.Size(209, 33);
			this.txtNumberEmployees.TabIndex = 7;
			this.txtNumberEmployees.Enter += new System.EventHandler(this.txtNumberEmployees_Enter);
			this.txtNumberEmployees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberEmployees_KeyPress);
			this.txtNumberEmployees.Leave += new System.EventHandler(this.txtNumberEmployees_Leave);
			// 
			// btnReset
			// 
			this.btnReset.AllowDrop = true;
			this.btnReset.BackColor = System.Drawing.SystemColors.Control;
			this.btnReset.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnReset.ForeColor = System.Drawing.Color.Empty;
			this.btnReset.Location = new System.Drawing.Point(280, 328);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(169, 65);
			this.btnReset.TabIndex = 9;
			this.btnReset.Text = "&Reset";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtName
			// 
			this.txtName.AllowDrop = true;
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtName.Location = new System.Drawing.Point(24, 80);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(209, 33);
			this.txtName.TabIndex = 0;
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(24, 256);
			this.Label9.MinimumSize = new System.Drawing.Size(209, 17);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(209, 17);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "Parent Company";
			// 
			// btnCreate
			// 
			this.btnCreate.AllowDrop = true;
			this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
			this.btnCreate.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCreate.ForeColor = System.Drawing.Color.Empty;
			this.btnCreate.Location = new System.Drawing.Point(64, 328);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(169, 65);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "&Create";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtWebsite
			// 
			this.txtWebsite.AllowDrop = true;
			this.txtWebsite.BackColor = System.Drawing.SystemColors.Window;
			this.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtWebsite.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtWebsite.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtWebsite.Location = new System.Drawing.Point(24, 208);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(209, 33);
			this.txtWebsite.TabIndex = 4;
			// 
			// txtAreaServed
			// 
			this.txtAreaServed.AllowDrop = true;
			this.txtAreaServed.BackColor = System.Drawing.SystemColors.Window;
			this.txtAreaServed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtAreaServed.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtAreaServed.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtAreaServed.Location = new System.Drawing.Point(280, 144);
			this.txtAreaServed.Name = "txtAreaServed";
			this.txtAreaServed.Size = new System.Drawing.Size(209, 33);
			this.txtAreaServed.TabIndex = 3;
			// 
			// txtHeadquarters
			// 
			this.txtHeadquarters.AllowDrop = true;
			this.txtHeadquarters.BackColor = System.Drawing.SystemColors.Window;
			this.txtHeadquarters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtHeadquarters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtHeadquarters.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtHeadquarters.Location = new System.Drawing.Point(24, 144);
			this.txtHeadquarters.Name = "txtHeadquarters";
			this.txtHeadquarters.Size = new System.Drawing.Size(209, 33);
			this.txtHeadquarters.TabIndex = 2;
			// 
			// txtOwner
			// 
			this.txtOwner.AllowDrop = true;
			this.txtOwner.BackColor = System.Drawing.SystemColors.Window;
			this.txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtOwner.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtOwner.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOwner.Location = new System.Drawing.Point(280, 80);
			this.txtOwner.Name = "txtOwner";
			this.txtOwner.Size = new System.Drawing.Size(209, 33);
			this.txtOwner.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AllowDrop = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitle.Location = new System.Drawing.Point(16, 0);
			this.lblTitle.MinimumSize = new System.Drawing.Size(481, 49);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTitle.Size = new System.Drawing.Size(481, 49);
			this.lblTitle.TabIndex = 10;
			this.lblTitle.Text = "Brand";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblOwner
			// 
			this.lblOwner.AllowDrop = true;
			this.lblOwner.BackColor = System.Drawing.SystemColors.Control;
			this.lblOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblOwner.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOwner.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblOwner.Location = new System.Drawing.Point(280, 64);
			this.lblOwner.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblOwner.Name = "lblOwner";
			this.lblOwner.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblOwner.Size = new System.Drawing.Size(209, 17);
			this.lblOwner.TabIndex = 11;
			this.lblOwner.Text = "Owner";
			// 
			// lblHeadquarter
			// 
			this.lblHeadquarter.AllowDrop = true;
			this.lblHeadquarter.BackColor = System.Drawing.SystemColors.Control;
			this.lblHeadquarter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblHeadquarter.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeadquarter.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblHeadquarter.Location = new System.Drawing.Point(24, 128);
			this.lblHeadquarter.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblHeadquarter.Name = "lblHeadquarter";
			this.lblHeadquarter.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblHeadquarter.Size = new System.Drawing.Size(209, 17);
			this.lblHeadquarter.TabIndex = 12;
			this.lblHeadquarter.Text = "Headquarter";
			// 
			// lblAreaServed
			// 
			this.lblAreaServed.AllowDrop = true;
			this.lblAreaServed.BackColor = System.Drawing.SystemColors.Control;
			this.lblAreaServed.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblAreaServed.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblAreaServed.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblAreaServed.Location = new System.Drawing.Point(280, 128);
			this.lblAreaServed.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblAreaServed.Name = "lblAreaServed";
			this.lblAreaServed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblAreaServed.Size = new System.Drawing.Size(209, 17);
			this.lblAreaServed.TabIndex = 13;
			this.lblAreaServed.Text = "Area Served";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(280, 192);
			this.Label6.MinimumSize = new System.Drawing.Size(209, 17);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(209, 17);
			this.Label6.TabIndex = 14;
			this.Label6.Text = "Founded";
			// 
			// lblWebsite
			// 
			this.lblWebsite.AllowDrop = true;
			this.lblWebsite.BackColor = System.Drawing.SystemColors.Control;
			this.lblWebsite.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblWebsite.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblWebsite.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblWebsite.Location = new System.Drawing.Point(24, 192);
			this.lblWebsite.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblWebsite.Name = "lblWebsite";
			this.lblWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblWebsite.Size = new System.Drawing.Size(209, 17);
			this.lblWebsite.TabIndex = 15;
			this.lblWebsite.Text = "Website";
			// 
			// lblNumberEmployees
			// 
			this.lblNumberEmployees.AllowDrop = true;
			this.lblNumberEmployees.BackColor = System.Drawing.SystemColors.Control;
			this.lblNumberEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblNumberEmployees.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblNumberEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumberEmployees.Location = new System.Drawing.Point(280, 256);
			this.lblNumberEmployees.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblNumberEmployees.Name = "lblNumberEmployees";
			this.lblNumberEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNumberEmployees.Size = new System.Drawing.Size(209, 17);
			this.lblNumberEmployees.TabIndex = 16;
			this.lblNumberEmployees.Text = "Number of Employees";
			// 
			// lblName
			// 
			this.lblName.AllowDrop = true;
			this.lblName.BackColor = System.Drawing.SystemColors.Control;
			this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblName.Location = new System.Drawing.Point(24, 64);
			this.lblName.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblName.Name = "lblName";
			this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblName.Size = new System.Drawing.Size(209, 17);
			this.lblName.TabIndex = 18;
			this.lblName.Text = "Name";
			// 
			// frmCreateNewBrand
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(514, 406);
			this.Controls.Add(this.dtFounded);
			this.Controls.Add(this.cmbParent);
			this.Controls.Add(this.txtNumberEmployees);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.txtAreaServed);
			this.Controls.Add(this.txtHeadquarters);
			this.Controls.Add(this.txtOwner);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblOwner);
			this.Controls.Add(this.lblHeadquarter);
			this.Controls.Add(this.lblAreaServed);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.lblWebsite);
			this.Controls.Add(this.lblNumberEmployees);
			this.Controls.Add(this.lblName);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewBrand.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreateNewBrand";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Brand";
			this.commandButtonHelper1.SetStyle(this.btnReset, 0);
			this.commandButtonHelper1.SetStyle(this.btnCreate, 0);
			this.ToolTipMain.SetToolTip(this.dtFounded, "Date when the brand was created");
			this.ToolTipMain.SetToolTip(this.cmbParent, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.txtNumberEmployees, "Number of employees working there");
			this.ToolTipMain.SetToolTip(this.txtName, "Name of the brand");
			this.ToolTipMain.SetToolTip(this.txtWebsite, "Website");
			this.ToolTipMain.SetToolTip(this.txtAreaServed, "Countries where this brand is selling products");
			this.ToolTipMain.SetToolTip(this.txtHeadquarters, "Country where the headquarter is located");
			this.ToolTipMain.SetToolTip(this.txtOwner, "Name of the brand owner");
			this.Activated += new System.EventHandler(this.frmCreateNewBrand_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}