
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewBrand));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			dtFounded = new System.Windows.Forms.DateTimePicker();
			cmbParent = new System.Windows.Forms.ComboBox();
			txtNumberEmployees = new System.Windows.Forms.TextBox();
			btnReset = new System.Windows.Forms.Button();
			txtName = new System.Windows.Forms.TextBox();
			Label9 = new System.Windows.Forms.Label();
			btnCreate = new System.Windows.Forms.Button();
			txtWebsite = new System.Windows.Forms.TextBox();
			txtAreaServed = new System.Windows.Forms.TextBox();
			txtHeadquarters = new System.Windows.Forms.TextBox();
			txtOwner = new System.Windows.Forms.TextBox();
			lblTitle = new System.Windows.Forms.Label();
			lblOwner = new System.Windows.Forms.Label();
			lblHeadquarter = new System.Windows.Forms.Label();
			lblAreaServed = new System.Windows.Forms.Label();
			Label6 = new System.Windows.Forms.Label();
			lblWebsite = new System.Windows.Forms.Label();
			lblNumberEmployees = new System.Windows.Forms.Label();
			lblName = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// dtFounded
			// 
			dtFounded.AllowDrop = true;
			dtFounded.Checked = false;
			dtFounded.CustomFormat = "MM/dd/yyyy";
			dtFounded.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dtFounded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			dtFounded.Location = new System.Drawing.Point(280, 208);
			dtFounded.Name = "dtFounded";
			dtFounded.Size = new System.Drawing.Size(209, 33);
			dtFounded.TabIndex = 5;
			// 
			// cmbParent
			// 
			cmbParent.AllowDrop = true;
			cmbParent.BackColor = System.Drawing.SystemColors.Window;
			cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbParent.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbParent.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbParent.Location = new System.Drawing.Point(24, 272);
			cmbParent.Name = "cmbParent";
			cmbParent.Size = new System.Drawing.Size(209, 26);
			cmbParent.TabIndex = 6;
			cmbParent.Text = "cmbParent";
			// 
			// txtNumberEmployees
			// 
			txtNumberEmployees.AllowDrop = true;
			txtNumberEmployees.BackColor = System.Drawing.SystemColors.Window;
			txtNumberEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtNumberEmployees.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtNumberEmployees.ForeColor = System.Drawing.SystemColors.WindowText;
			txtNumberEmployees.Location = new System.Drawing.Point(280, 272);
			txtNumberEmployees.Name = "txtNumberEmployees";
			txtNumberEmployees.Size = new System.Drawing.Size(209, 33);
			txtNumberEmployees.TabIndex = 7;
			txtNumberEmployees.Enter += new System.EventHandler(txtNumberEmployees_Enter);
			txtNumberEmployees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNumberEmployees_KeyPress);
			txtNumberEmployees.Leave += new System.EventHandler(txtNumberEmployees_Leave);
			// 
			// btnReset
			// 
			btnReset.AllowDrop = true;
			btnReset.BackColor = System.Drawing.SystemColors.Control;
			btnReset.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnReset.ForeColor = System.Drawing.Color.Empty;
			btnReset.Location = new System.Drawing.Point(280, 328);
			btnReset.Name = "btnReset";
			btnReset.Size = new System.Drawing.Size(169, 65);
			btnReset.TabIndex = 9;
			btnReset.Text = "&Reset";
			btnReset.Click += new System.EventHandler(btnReset_Click);
			// 
			// txtName
			// 
			txtName.AllowDrop = true;
			txtName.BackColor = System.Drawing.SystemColors.Window;
			txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtName.Location = new System.Drawing.Point(24, 80);
			txtName.Name = "txtName";
			txtName.Size = new System.Drawing.Size(209, 33);
			txtName.TabIndex = 0;
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label9.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(24, 256);
			Label9.MinimumSize = new System.Drawing.Size(209, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label9.Size = new System.Drawing.Size(209, 17);
			Label9.TabIndex = 17;
			Label9.Text = "Parent Company";
			// 
			// btnCreate
			// 
			btnCreate.AllowDrop = true;
			btnCreate.BackColor = System.Drawing.SystemColors.Control;
			btnCreate.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnCreate.ForeColor = System.Drawing.Color.Empty;
			btnCreate.Location = new System.Drawing.Point(64, 328);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new System.Drawing.Size(169, 65);
			btnCreate.TabIndex = 8;
			btnCreate.Text = "&Create";
			btnCreate.Click += new System.EventHandler(btnCreate_Click);
			// 
			// txtWebsite
			// 
			txtWebsite.AllowDrop = true;
			txtWebsite.BackColor = System.Drawing.SystemColors.Window;
			txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtWebsite.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtWebsite.ForeColor = System.Drawing.SystemColors.WindowText;
			txtWebsite.Location = new System.Drawing.Point(24, 208);
			txtWebsite.Name = "txtWebsite";
			txtWebsite.Size = new System.Drawing.Size(209, 33);
			txtWebsite.TabIndex = 4;
			// 
			// txtAreaServed
			// 
			txtAreaServed.AllowDrop = true;
			txtAreaServed.BackColor = System.Drawing.SystemColors.Window;
			txtAreaServed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtAreaServed.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtAreaServed.ForeColor = System.Drawing.SystemColors.WindowText;
			txtAreaServed.Location = new System.Drawing.Point(280, 144);
			txtAreaServed.Name = "txtAreaServed";
			txtAreaServed.Size = new System.Drawing.Size(209, 33);
			txtAreaServed.TabIndex = 3;
			// 
			// txtHeadquarters
			// 
			txtHeadquarters.AllowDrop = true;
			txtHeadquarters.BackColor = System.Drawing.SystemColors.Window;
			txtHeadquarters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtHeadquarters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtHeadquarters.ForeColor = System.Drawing.SystemColors.WindowText;
			txtHeadquarters.Location = new System.Drawing.Point(24, 144);
			txtHeadquarters.Name = "txtHeadquarters";
			txtHeadquarters.Size = new System.Drawing.Size(209, 33);
			txtHeadquarters.TabIndex = 2;
			// 
			// txtOwner
			// 
			txtOwner.AllowDrop = true;
			txtOwner.BackColor = System.Drawing.SystemColors.Window;
			txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtOwner.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOwner.ForeColor = System.Drawing.SystemColors.WindowText;
			txtOwner.Location = new System.Drawing.Point(280, 80);
			txtOwner.Name = "txtOwner";
			txtOwner.Size = new System.Drawing.Size(209, 33);
			txtOwner.TabIndex = 1;
			// 
			// lblTitle
			// 
			lblTitle.AllowDrop = true;
			lblTitle.BackColor = System.Drawing.SystemColors.Control;
			lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			lblTitle.Location = new System.Drawing.Point(16, 0);
			lblTitle.MinimumSize = new System.Drawing.Size(481, 49);
			lblTitle.Name = "lblTitle";
			lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTitle.Size = new System.Drawing.Size(481, 49);
			lblTitle.TabIndex = 10;
			lblTitle.Text = "Brand";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblOwner
			// 
			lblOwner.AllowDrop = true;
			lblOwner.BackColor = System.Drawing.SystemColors.Control;
			lblOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblOwner.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblOwner.ForeColor = System.Drawing.SystemColors.ControlText;
			lblOwner.Location = new System.Drawing.Point(280, 64);
			lblOwner.MinimumSize = new System.Drawing.Size(209, 17);
			lblOwner.Name = "lblOwner";
			lblOwner.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblOwner.Size = new System.Drawing.Size(209, 17);
			lblOwner.TabIndex = 11;
			lblOwner.Text = "Owner";
			// 
			// lblHeadquarter
			// 
			lblHeadquarter.AllowDrop = true;
			lblHeadquarter.BackColor = System.Drawing.SystemColors.Control;
			lblHeadquarter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblHeadquarter.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblHeadquarter.ForeColor = System.Drawing.SystemColors.ControlText;
			lblHeadquarter.Location = new System.Drawing.Point(24, 128);
			lblHeadquarter.MinimumSize = new System.Drawing.Size(209, 17);
			lblHeadquarter.Name = "lblHeadquarter";
			lblHeadquarter.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblHeadquarter.Size = new System.Drawing.Size(209, 17);
			lblHeadquarter.TabIndex = 12;
			lblHeadquarter.Text = "Headquarter";
			// 
			// lblAreaServed
			// 
			lblAreaServed.AllowDrop = true;
			lblAreaServed.BackColor = System.Drawing.SystemColors.Control;
			lblAreaServed.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblAreaServed.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblAreaServed.ForeColor = System.Drawing.SystemColors.ControlText;
			lblAreaServed.Location = new System.Drawing.Point(280, 128);
			lblAreaServed.MinimumSize = new System.Drawing.Size(209, 17);
			lblAreaServed.Name = "lblAreaServed";
			lblAreaServed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblAreaServed.Size = new System.Drawing.Size(209, 17);
			lblAreaServed.TabIndex = 13;
			lblAreaServed.Text = "Area Served";
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(280, 192);
			Label6.MinimumSize = new System.Drawing.Size(209, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(209, 17);
			Label6.TabIndex = 14;
			Label6.Text = "Founded";
			// 
			// lblWebsite
			// 
			lblWebsite.AllowDrop = true;
			lblWebsite.BackColor = System.Drawing.SystemColors.Control;
			lblWebsite.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblWebsite.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblWebsite.ForeColor = System.Drawing.SystemColors.ControlText;
			lblWebsite.Location = new System.Drawing.Point(24, 192);
			lblWebsite.MinimumSize = new System.Drawing.Size(209, 17);
			lblWebsite.Name = "lblWebsite";
			lblWebsite.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblWebsite.Size = new System.Drawing.Size(209, 17);
			lblWebsite.TabIndex = 15;
			lblWebsite.Text = "Website";
			// 
			// lblNumberEmployees
			// 
			lblNumberEmployees.AllowDrop = true;
			lblNumberEmployees.BackColor = System.Drawing.SystemColors.Control;
			lblNumberEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblNumberEmployees.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblNumberEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
			lblNumberEmployees.Location = new System.Drawing.Point(280, 256);
			lblNumberEmployees.MinimumSize = new System.Drawing.Size(209, 17);
			lblNumberEmployees.Name = "lblNumberEmployees";
			lblNumberEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblNumberEmployees.Size = new System.Drawing.Size(209, 17);
			lblNumberEmployees.TabIndex = 16;
			lblNumberEmployees.Text = "Number of Employees";
			// 
			// lblName
			// 
			lblName.AllowDrop = true;
			lblName.BackColor = System.Drawing.SystemColors.Control;
			lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblName.Location = new System.Drawing.Point(24, 64);
			lblName.MinimumSize = new System.Drawing.Size(209, 17);
			lblName.Name = "lblName";
			lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblName.Size = new System.Drawing.Size(209, 17);
			lblName.TabIndex = 18;
			lblName.Text = "Name";
			// 
			// frmCreateNewBrand
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(514, 406);
			Controls.Add(dtFounded);
			Controls.Add(cmbParent);
			Controls.Add(txtNumberEmployees);
			Controls.Add(btnReset);
			Controls.Add(txtName);
			Controls.Add(Label9);
			Controls.Add(btnCreate);
			Controls.Add(txtWebsite);
			Controls.Add(txtAreaServed);
			Controls.Add(txtHeadquarters);
			Controls.Add(txtOwner);
			Controls.Add(lblTitle);
			Controls.Add(lblOwner);
			Controls.Add(lblHeadquarter);
			Controls.Add(lblAreaServed);
			Controls.Add(Label6);
			Controls.Add(lblWebsite);
			Controls.Add(lblNumberEmployees);
			Controls.Add(lblName);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewBrand.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmCreateNewBrand";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Create New Brand";
			commandButtonHelper1.SetStyle(btnReset, 0);
			commandButtonHelper1.SetStyle(btnCreate, 0);
			ToolTipMain.SetToolTip(dtFounded, "Date when the brand was created");
			ToolTipMain.SetToolTip(cmbParent, "Manufacturer");
			ToolTipMain.SetToolTip(txtNumberEmployees, "Number of employees working there");
			ToolTipMain.SetToolTip(txtName, "Name of the brand");
			ToolTipMain.SetToolTip(txtWebsite, "Website");
			ToolTipMain.SetToolTip(txtAreaServed, "Countries where this brand is selling products");
			ToolTipMain.SetToolTip(txtHeadquarters, "Country where the headquarter is located");
			ToolTipMain.SetToolTip(txtOwner, "Name of the brand owner");
			Activated += new System.EventHandler(frmCreateNewBrand_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}