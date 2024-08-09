
namespace StarCarsManagement
{
	partial class frmCreateNewStaff
	{

		#region "Upgrade Support "
		private static frmCreateNewStaff m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCreateNewStaff DefInstance
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
		public static frmCreateNewStaff CreateInstance()
		{
			frmCreateNewStaff theInstance = new frmCreateNewStaff();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 20);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "dtDateBirth", "txtDNI", "txtPhoneNumber", "btnCreate", "btnReset", "txtPassword", "txtUsername", "cmbRole", "Label5", "lblPhoneNumber", "txtLastName", "txtName", "lblTitle", "lblName", "lblLastName", "lblDNI", "lblRole", "lblUsername", "lblPassword", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.DateTimePicker dtDateBirth;
		public System.Windows.Forms.MaskedTextBox txtDNI;
		public System.Windows.Forms.MaskedTextBox txtPhoneNumber;
		public System.Windows.Forms.Button btnCreate;
		public System.Windows.Forms.Button btnReset;
		public System.Windows.Forms.TextBox txtPassword;
		public System.Windows.Forms.TextBox txtUsername;
		public System.Windows.Forms.ComboBox cmbRole;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label lblPhoneNumber;
		public System.Windows.Forms.TextBox txtLastName;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label lblLastName;
		public System.Windows.Forms.Label lblDNI;
		public System.Windows.Forms.Label lblRole;
		public System.Windows.Forms.Label lblUsername;
		public System.Windows.Forms.Label lblPassword;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewStaff));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.dtDateBirth = new System.Windows.Forms.DateTimePicker();
			this.txtDNI = new System.Windows.Forms.MaskedTextBox();
			this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.cmbRole = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblDNI = new System.Windows.Forms.Label();
			this.lblRole = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// dtDateBirth
			// 
			this.dtDateBirth.AllowDrop = true;
			this.dtDateBirth.Checked = false;
			this.dtDateBirth.CustomFormat = "MM/dd/yyyy";
			this.dtDateBirth.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDateBirth.Location = new System.Drawing.Point(24, 208);
			this.dtDateBirth.Name = "dtDateBirth";
			this.dtDateBirth.Size = new System.Drawing.Size(209, 33);
			this.dtDateBirth.TabIndex = 4;
			// 
			// txtDNI
			// 
			this.txtDNI.AllowDrop = true;
			this.txtDNI.AllowPromptAsInput = false;
			this.txtDNI.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtDNI.Location = new System.Drawing.Point(24, 144);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.PromptChar = '_';
			this.txtDNI.Size = new System.Drawing.Size(209, 33);
			this.txtDNI.TabIndex = 2;
			this.txtDNI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtDNI.Enter += new System.EventHandler(this.txtDNI_Enter);
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			this.txtDNI.Leave += new System.EventHandler(this.txtDNI_Leave);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.AllowDrop = true;
			this.txtPhoneNumber.AllowPromptAsInput = false;
			this.txtPhoneNumber.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtPhoneNumber.Location = new System.Drawing.Point(280, 144);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.PromptChar = '_';
			this.txtPhoneNumber.Size = new System.Drawing.Size(209, 33);
			this.txtPhoneNumber.TabIndex = 3;
			this.txtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
			this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
			this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
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
			// txtPassword
			// 
			this.txtPassword.AllowDrop = true;
			this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPassword.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPassword.Location = new System.Drawing.Point(280, 272);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = (char) 42;
			this.txtPassword.Size = new System.Drawing.Size(209, 33);
			this.txtPassword.TabIndex = 7;
			// 
			// txtUsername
			// 
			this.txtUsername.AllowDrop = true;
			this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtUsername.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtUsername.Location = new System.Drawing.Point(24, 272);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(209, 33);
			this.txtUsername.TabIndex = 6;
			// 
			// cmbRole
			// 
			this.cmbRole.AllowDrop = true;
			this.cmbRole.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRole.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbRole.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRole.Location = new System.Drawing.Point(280, 208);
			this.cmbRole.Name = "cmbRole";
			this.cmbRole.Size = new System.Drawing.Size(209, 26);
			this.cmbRole.TabIndex = 5;
			this.cmbRole.Text = "cmbRole";
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(24, 192);
			this.Label5.MinimumSize = new System.Drawing.Size(81, 17);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(81, 17);
			this.Label5.TabIndex = 15;
			this.Label5.Text = "Date of birth";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AllowDrop = true;
			this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
			this.lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPhoneNumber.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPhoneNumber.Location = new System.Drawing.Point(280, 128);
			this.lblPhoneNumber.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPhoneNumber.Size = new System.Drawing.Size(81, 17);
			this.lblPhoneNumber.TabIndex = 14;
			this.lblPhoneNumber.Text = "Phone Number";
			// 
			// txtLastName
			// 
			this.txtLastName.AllowDrop = true;
			this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
			this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtLastName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtLastName.Location = new System.Drawing.Point(280, 80);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(209, 33);
			this.txtLastName.TabIndex = 1;
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
			this.lblTitle.Text = "Staff";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblName
			// 
			this.lblName.AllowDrop = true;
			this.lblName.BackColor = System.Drawing.SystemColors.Control;
			this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblName.Location = new System.Drawing.Point(24, 64);
			this.lblName.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblName.Name = "lblName";
			this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblName.Size = new System.Drawing.Size(81, 17);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Name";
			// 
			// lblLastName
			// 
			this.lblLastName.AllowDrop = true;
			this.lblLastName.BackColor = System.Drawing.SystemColors.Control;
			this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblLastName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLastName.Location = new System.Drawing.Point(280, 64);
			this.lblLastName.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLastName.Size = new System.Drawing.Size(81, 17);
			this.lblLastName.TabIndex = 12;
			this.lblLastName.Text = "Last Name";
			// 
			// lblDNI
			// 
			this.lblDNI.AllowDrop = true;
			this.lblDNI.BackColor = System.Drawing.SystemColors.Control;
			this.lblDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblDNI.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblDNI.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDNI.Location = new System.Drawing.Point(24, 128);
			this.lblDNI.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDNI.Size = new System.Drawing.Size(81, 17);
			this.lblDNI.TabIndex = 13;
			this.lblDNI.Text = "DNI";
			// 
			// lblRole
			// 
			this.lblRole.AllowDrop = true;
			this.lblRole.BackColor = System.Drawing.SystemColors.Control;
			this.lblRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblRole.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblRole.Location = new System.Drawing.Point(280, 192);
			this.lblRole.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblRole.Name = "lblRole";
			this.lblRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblRole.Size = new System.Drawing.Size(81, 17);
			this.lblRole.TabIndex = 16;
			this.lblRole.Text = "Role";
			// 
			// lblUsername
			// 
			this.lblUsername.AllowDrop = true;
			this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
			this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblUsername.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUsername.Location = new System.Drawing.Point(24, 256);
			this.lblUsername.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUsername.Size = new System.Drawing.Size(81, 17);
			this.lblUsername.TabIndex = 17;
			this.lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			this.lblPassword.AllowDrop = true;
			this.lblPassword.BackColor = System.Drawing.SystemColors.Control;
			this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPassword.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPassword.Location = new System.Drawing.Point(280, 256);
			this.lblPassword.MinimumSize = new System.Drawing.Size(81, 17);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPassword.Size = new System.Drawing.Size(81, 17);
			this.lblPassword.TabIndex = 18;
			this.lblPassword.Text = "Password";
			// 
			// frmCreateNewStaff
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(514, 406);
			this.Controls.Add(this.dtDateBirth);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.cmbRole);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.lblPassword);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewStaff.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreateNewStaff";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Employee";
			this.commandButtonHelper1.SetStyle(this.btnCreate, 0);
			this.commandButtonHelper1.SetStyle(this.btnReset, 0);
			this.ToolTipMain.SetToolTip(this.txtDNI, "DNI of the new employee");
			this.ToolTipMain.SetToolTip(this.txtPhoneNumber, "Phone number of the new employee");
			this.ToolTipMain.SetToolTip(this.txtPassword, "Password to enter the application");
			this.ToolTipMain.SetToolTip(this.txtUsername, "Username to enter the application");
			this.ToolTipMain.SetToolTip(this.cmbRole, "Role of the new employee");
			this.ToolTipMain.SetToolTip(this.txtLastName, "Last name of the new employee");
			this.ToolTipMain.SetToolTip(this.txtName, "Name of the new employee");
			this.Activated += new System.EventHandler(this.frmCreateNewStaff_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}