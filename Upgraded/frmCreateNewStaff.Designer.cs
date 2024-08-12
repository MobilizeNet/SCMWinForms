
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewStaff));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			dtDateBirth = new System.Windows.Forms.DateTimePicker();
			txtDNI = new System.Windows.Forms.MaskedTextBox();
			txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			btnCreate = new System.Windows.Forms.Button();
			btnReset = new System.Windows.Forms.Button();
			txtPassword = new System.Windows.Forms.TextBox();
			txtUsername = new System.Windows.Forms.TextBox();
			cmbRole = new System.Windows.Forms.ComboBox();
			Label5 = new System.Windows.Forms.Label();
			lblPhoneNumber = new System.Windows.Forms.Label();
			txtLastName = new System.Windows.Forms.TextBox();
			txtName = new System.Windows.Forms.TextBox();
			lblTitle = new System.Windows.Forms.Label();
			lblName = new System.Windows.Forms.Label();
			lblLastName = new System.Windows.Forms.Label();
			lblDNI = new System.Windows.Forms.Label();
			lblRole = new System.Windows.Forms.Label();
			lblUsername = new System.Windows.Forms.Label();
			lblPassword = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// dtDateBirth
			// 
			dtDateBirth.AllowDrop = true;
			dtDateBirth.Checked = false;
			dtDateBirth.CustomFormat = "MM/dd/yyyy";
			dtDateBirth.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dtDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			dtDateBirth.Location = new System.Drawing.Point(24, 208);
			dtDateBirth.Name = "dtDateBirth";
			dtDateBirth.Size = new System.Drawing.Size(209, 33);
			dtDateBirth.TabIndex = 4;
			// 
			// txtDNI
			// 
			txtDNI.AllowDrop = true;
			txtDNI.AllowPromptAsInput = false;
			txtDNI.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtDNI.Location = new System.Drawing.Point(24, 144);
			txtDNI.Name = "txtDNI";
			txtDNI.PromptChar = '_';
			txtDNI.Size = new System.Drawing.Size(209, 33);
			txtDNI.TabIndex = 2;
			txtDNI.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			txtDNI.Enter += new System.EventHandler(txtDNI_Enter);
			txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtDNI_KeyPress);
			txtDNI.Leave += new System.EventHandler(txtDNI_Leave);
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.AllowDrop = true;
			txtPhoneNumber.AllowPromptAsInput = false;
			txtPhoneNumber.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPhoneNumber.Location = new System.Drawing.Point(280, 144);
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.PromptChar = '_';
			txtPhoneNumber.Size = new System.Drawing.Size(209, 33);
			txtPhoneNumber.TabIndex = 3;
			txtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			txtPhoneNumber.Enter += new System.EventHandler(txtPhoneNumber_Enter);
			txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPhoneNumber_KeyPress);
			txtPhoneNumber.Leave += new System.EventHandler(txtPhoneNumber_Leave);
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
			// txtPassword
			// 
			txtPassword.AllowDrop = true;
			txtPassword.BackColor = System.Drawing.SystemColors.Window;
			txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtPassword.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			txtPassword.Location = new System.Drawing.Point(280, 272);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = (char) 42;
			txtPassword.Size = new System.Drawing.Size(209, 33);
			txtPassword.TabIndex = 7;
			// 
			// txtUsername
			// 
			txtUsername.AllowDrop = true;
			txtUsername.BackColor = System.Drawing.SystemColors.Window;
			txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtUsername.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
			txtUsername.Location = new System.Drawing.Point(24, 272);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new System.Drawing.Size(209, 33);
			txtUsername.TabIndex = 6;
			// 
			// cmbRole
			// 
			cmbRole.AllowDrop = true;
			cmbRole.BackColor = System.Drawing.SystemColors.Window;
			cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbRole.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbRole.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbRole.Location = new System.Drawing.Point(280, 208);
			cmbRole.Name = "cmbRole";
			cmbRole.Size = new System.Drawing.Size(209, 26);
			cmbRole.TabIndex = 5;
			cmbRole.Text = "cmbRole";
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label5.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(24, 192);
			Label5.MinimumSize = new System.Drawing.Size(81, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label5.Size = new System.Drawing.Size(81, 17);
			Label5.TabIndex = 15;
			Label5.Text = "Date of birth";
			// 
			// lblPhoneNumber
			// 
			lblPhoneNumber.AllowDrop = true;
			lblPhoneNumber.BackColor = System.Drawing.SystemColors.Control;
			lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPhoneNumber.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
			lblPhoneNumber.Location = new System.Drawing.Point(280, 128);
			lblPhoneNumber.MinimumSize = new System.Drawing.Size(81, 17);
			lblPhoneNumber.Name = "lblPhoneNumber";
			lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPhoneNumber.Size = new System.Drawing.Size(81, 17);
			lblPhoneNumber.TabIndex = 14;
			lblPhoneNumber.Text = "Phone Number";
			// 
			// txtLastName
			// 
			txtLastName.AllowDrop = true;
			txtLastName.BackColor = System.Drawing.SystemColors.Window;
			txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtLastName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtLastName.Location = new System.Drawing.Point(280, 80);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new System.Drawing.Size(209, 33);
			txtLastName.TabIndex = 1;
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
			lblTitle.Text = "Staff";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblName
			// 
			lblName.AllowDrop = true;
			lblName.BackColor = System.Drawing.SystemColors.Control;
			lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblName.Location = new System.Drawing.Point(24, 64);
			lblName.MinimumSize = new System.Drawing.Size(81, 17);
			lblName.Name = "lblName";
			lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblName.Size = new System.Drawing.Size(81, 17);
			lblName.TabIndex = 11;
			lblName.Text = "Name";
			// 
			// lblLastName
			// 
			lblLastName.AllowDrop = true;
			lblLastName.BackColor = System.Drawing.SystemColors.Control;
			lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblLastName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblLastName.Location = new System.Drawing.Point(280, 64);
			lblLastName.MinimumSize = new System.Drawing.Size(81, 17);
			lblLastName.Name = "lblLastName";
			lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblLastName.Size = new System.Drawing.Size(81, 17);
			lblLastName.TabIndex = 12;
			lblLastName.Text = "Last Name";
			// 
			// lblDNI
			// 
			lblDNI.AllowDrop = true;
			lblDNI.BackColor = System.Drawing.SystemColors.Control;
			lblDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblDNI.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblDNI.ForeColor = System.Drawing.SystemColors.ControlText;
			lblDNI.Location = new System.Drawing.Point(24, 128);
			lblDNI.MinimumSize = new System.Drawing.Size(81, 17);
			lblDNI.Name = "lblDNI";
			lblDNI.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblDNI.Size = new System.Drawing.Size(81, 17);
			lblDNI.TabIndex = 13;
			lblDNI.Text = "DNI";
			// 
			// lblRole
			// 
			lblRole.AllowDrop = true;
			lblRole.BackColor = System.Drawing.SystemColors.Control;
			lblRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblRole.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblRole.ForeColor = System.Drawing.SystemColors.ControlText;
			lblRole.Location = new System.Drawing.Point(280, 192);
			lblRole.MinimumSize = new System.Drawing.Size(81, 17);
			lblRole.Name = "lblRole";
			lblRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblRole.Size = new System.Drawing.Size(81, 17);
			lblRole.TabIndex = 16;
			lblRole.Text = "Role";
			// 
			// lblUsername
			// 
			lblUsername.AllowDrop = true;
			lblUsername.BackColor = System.Drawing.SystemColors.Control;
			lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblUsername.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
			lblUsername.Location = new System.Drawing.Point(24, 256);
			lblUsername.MinimumSize = new System.Drawing.Size(81, 17);
			lblUsername.Name = "lblUsername";
			lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblUsername.Size = new System.Drawing.Size(81, 17);
			lblUsername.TabIndex = 17;
			lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			lblPassword.AllowDrop = true;
			lblPassword.BackColor = System.Drawing.SystemColors.Control;
			lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPassword.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			lblPassword.Location = new System.Drawing.Point(280, 256);
			lblPassword.MinimumSize = new System.Drawing.Size(81, 17);
			lblPassword.Name = "lblPassword";
			lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPassword.Size = new System.Drawing.Size(81, 17);
			lblPassword.TabIndex = 18;
			lblPassword.Text = "Password";
			// 
			// frmCreateNewStaff
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(514, 406);
			Controls.Add(dtDateBirth);
			Controls.Add(txtDNI);
			Controls.Add(txtPhoneNumber);
			Controls.Add(btnCreate);
			Controls.Add(btnReset);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(cmbRole);
			Controls.Add(Label5);
			Controls.Add(lblPhoneNumber);
			Controls.Add(txtLastName);
			Controls.Add(txtName);
			Controls.Add(lblTitle);
			Controls.Add(lblName);
			Controls.Add(lblLastName);
			Controls.Add(lblDNI);
			Controls.Add(lblRole);
			Controls.Add(lblUsername);
			Controls.Add(lblPassword);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewStaff.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmCreateNewStaff";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Create New Employee";
			commandButtonHelper1.SetStyle(btnCreate, 0);
			commandButtonHelper1.SetStyle(btnReset, 0);
			ToolTipMain.SetToolTip(txtDNI, "DNI of the new employee");
			ToolTipMain.SetToolTip(txtPhoneNumber, "Phone number of the new employee");
			ToolTipMain.SetToolTip(txtPassword, "Password to enter the application");
			ToolTipMain.SetToolTip(txtUsername, "Username to enter the application");
			ToolTipMain.SetToolTip(cmbRole, "Role of the new employee");
			ToolTipMain.SetToolTip(txtLastName, "Last name of the new employee");
			ToolTipMain.SetToolTip(txtName, "Name of the new employee");
			Activated += new System.EventHandler(frmCreateNewStaff_Activated);
			Closed += new System.EventHandler(Form_Closed);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}