
namespace StarCarsManagement
{
	partial class frmCreateNewReceipt
	{

		#region "Upgrade Support "
		private static frmCreateNewReceipt m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCreateNewReceipt DefInstance
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
		public static frmCreateNewReceipt CreateInstance()
		{
			frmCreateNewReceipt theInstance = new frmCreateNewReceipt();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 20);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtQuantity", "txtID", "chk3PersonInsurance", "btnCreate", "btnReset", "txtTotal", "txtSubTotal", "cmbSeller", "chkVehicleInsurance", "Label4", "cmbModel", "cmbManufacturer", "txtLastName", "txtName", "lblTitle", "lblName", "lblLastName", "lblManufacturer", "lblModel", "lblQuantity", "lblSeller", "Label8", "Label9", "Label10", "listBoxComboBoxHelper1", "commandButtonHelper1", "checkBoxHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtQuantity;
		public System.Windows.Forms.TextBox txtID;
		public System.Windows.Forms.CheckBox chk3PersonInsurance;
		public System.Windows.Forms.Button btnCreate;
		public System.Windows.Forms.Button btnReset;
		public System.Windows.Forms.TextBox txtTotal;
		public System.Windows.Forms.TextBox txtSubTotal;
		public System.Windows.Forms.ComboBox cmbSeller;
		public System.Windows.Forms.CheckBox chkVehicleInsurance;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.ComboBox cmbModel;
		public System.Windows.Forms.ComboBox cmbManufacturer;
		public System.Windows.Forms.TextBox txtLastName;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label lblLastName;
		public System.Windows.Forms.Label lblManufacturer;
		public System.Windows.Forms.Label lblModel;
		public System.Windows.Forms.Label lblQuantity;
		public System.Windows.Forms.Label lblSeller;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label10;
		public UpgradeHelpers.Gui.Controls.ListControlHelper listBoxComboBoxHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		public UpgradeHelpers.Gui.Controls.CheckBoxHelper checkBoxHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewReceipt));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			txtQuantity = new System.Windows.Forms.TextBox();
			txtID = new System.Windows.Forms.TextBox();
			chk3PersonInsurance = new System.Windows.Forms.CheckBox();
			btnCreate = new System.Windows.Forms.Button();
			btnReset = new System.Windows.Forms.Button();
			txtTotal = new System.Windows.Forms.TextBox();
			txtSubTotal = new System.Windows.Forms.TextBox();
			cmbSeller = new System.Windows.Forms.ComboBox();
			chkVehicleInsurance = new System.Windows.Forms.CheckBox();
			Label4 = new System.Windows.Forms.Label();
			cmbModel = new System.Windows.Forms.ComboBox();
			cmbManufacturer = new System.Windows.Forms.ComboBox();
			txtLastName = new System.Windows.Forms.TextBox();
			txtName = new System.Windows.Forms.TextBox();
			lblTitle = new System.Windows.Forms.Label();
			lblName = new System.Windows.Forms.Label();
			lblLastName = new System.Windows.Forms.Label();
			lblManufacturer = new System.Windows.Forms.Label();
			lblModel = new System.Windows.Forms.Label();
			lblQuantity = new System.Windows.Forms.Label();
			lblSeller = new System.Windows.Forms.Label();
			Label8 = new System.Windows.Forms.Label();
			Label9 = new System.Windows.Forms.Label();
			Label10 = new System.Windows.Forms.Label();
			SuspendLayout();
			listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(components);
			((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			checkBoxHelper1 = new UpgradeHelpers.Gui.Controls.CheckBoxHelper(components);
			// 
			// txtQuantity
			// 
			txtQuantity.AllowDrop = true;
			txtQuantity.BackColor = System.Drawing.SystemColors.Window;
			txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtQuantity.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
			txtQuantity.Location = new System.Drawing.Point(24, 264);
			txtQuantity.MaxLength = 6;
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new System.Drawing.Size(209, 33);
			txtQuantity.TabIndex = 23;
			txtQuantity.Leave += new System.EventHandler(txtQuantity_Leave);
			// 
			// txtID
			// 
			txtID.AllowDrop = true;
			txtID.BackColor = System.Drawing.SystemColors.Window;
			txtID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtID.Enabled = false;
			txtID.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtID.ForeColor = System.Drawing.SystemColors.WindowText;
			txtID.Location = new System.Drawing.Point(24, 80);
			txtID.Name = "txtID";
			txtID.Size = new System.Drawing.Size(209, 33);
			txtID.TabIndex = 21;
			txtID.Text = "ID";
			txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chk3PersonInsurance
			// 
			chk3PersonInsurance.AllowDrop = true;
			chk3PersonInsurance.BackColor = System.Drawing.SystemColors.Control;
			chk3PersonInsurance.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chk3PersonInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			chk3PersonInsurance.ForeColor = System.Drawing.SystemColors.ControlText;
			chk3PersonInsurance.Location = new System.Drawing.Point(24, 368);
			chk3PersonInsurance.Name = "chk3PersonInsurance";
			chk3PersonInsurance.Size = new System.Drawing.Size(217, 25);
			chk3PersonInsurance.TabIndex = 20;
			chk3PersonInsurance.Text = "Third Person Insurance";
			chk3PersonInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chk3PersonInsurance.CheckStateChanged += new System.EventHandler(chk3PersonInsurance_CheckStateChanged);
			// 
			// btnCreate
			// 
			btnCreate.AllowDrop = true;
			btnCreate.BackColor = System.Drawing.SystemColors.Control;
			btnCreate.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnCreate.ForeColor = System.Drawing.Color.Empty;
			btnCreate.Location = new System.Drawing.Point(72, 448);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new System.Drawing.Size(169, 65);
			btnCreate.TabIndex = 19;
			btnCreate.Text = "&Create";
			btnCreate.Click += new System.EventHandler(btnCreate_Click);
			// 
			// btnReset
			// 
			btnReset.AllowDrop = true;
			btnReset.BackColor = System.Drawing.SystemColors.Control;
			btnReset.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnReset.ForeColor = System.Drawing.Color.Empty;
			btnReset.Location = new System.Drawing.Point(280, 448);
			btnReset.Name = "btnReset";
			btnReset.Size = new System.Drawing.Size(169, 65);
			btnReset.TabIndex = 18;
			btnReset.Text = "&Reset";
			btnReset.Click += new System.EventHandler(btnReset_Click);
			// 
			// txtTotal
			// 
			txtTotal.AllowDrop = true;
			txtTotal.BackColor = System.Drawing.SystemColors.Window;
			txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtTotal.Enabled = false;
			txtTotal.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			txtTotal.Location = new System.Drawing.Point(280, 392);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new System.Drawing.Size(209, 33);
			txtTotal.TabIndex = 16;
			// 
			// txtSubTotal
			// 
			txtSubTotal.AllowDrop = true;
			txtSubTotal.BackColor = System.Drawing.SystemColors.Window;
			txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtSubTotal.Enabled = false;
			txtSubTotal.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtSubTotal.ForeColor = System.Drawing.Color.Red;
			txtSubTotal.Location = new System.Drawing.Point(280, 328);
			txtSubTotal.Name = "txtSubTotal";
			txtSubTotal.Size = new System.Drawing.Size(209, 33);
			txtSubTotal.TabIndex = 14;
			// 
			// cmbSeller
			// 
			cmbSeller.AllowDrop = true;
			cmbSeller.BackColor = System.Drawing.SystemColors.Window;
			cmbSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbSeller.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbSeller.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbSeller.Location = new System.Drawing.Point(280, 264);
			cmbSeller.Name = "cmbSeller";
			cmbSeller.Size = new System.Drawing.Size(209, 26);
			cmbSeller.TabIndex = 12;
			cmbSeller.Text = "cmbSeller";
			// 
			// chkVehicleInsurance
			// 
			chkVehicleInsurance.AllowDrop = true;
			chkVehicleInsurance.BackColor = System.Drawing.SystemColors.Control;
			chkVehicleInsurance.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkVehicleInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			chkVehicleInsurance.ForeColor = System.Drawing.SystemColors.ControlText;
			chkVehicleInsurance.Location = new System.Drawing.Point(24, 328);
			chkVehicleInsurance.Name = "chkVehicleInsurance";
			chkVehicleInsurance.Size = new System.Drawing.Size(217, 25);
			chkVehicleInsurance.TabIndex = 10;
			chkVehicleInsurance.Text = "Vehicle Insurance";
			chkVehicleInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkVehicleInsurance.CheckStateChanged += new System.EventHandler(chkVehicleInsurance_CheckStateChanged);
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label4.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(24, 312);
			Label4.MinimumSize = new System.Drawing.Size(217, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label4.Size = new System.Drawing.Size(217, 17);
			Label4.TabIndex = 9;
			Label4.Text = "Extras";
			// 
			// cmbModel
			// 
			cmbModel.AllowDrop = true;
			cmbModel.BackColor = System.Drawing.SystemColors.Window;
			cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbModel.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbModel.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbModel.Location = new System.Drawing.Point(280, 208);
			cmbModel.Name = "cmbModel";
			cmbModel.Size = new System.Drawing.Size(209, 26);
			cmbModel.TabIndex = 7;
			cmbModel.Text = "cmbModel";
			cmbModel.Items.AddRange(new object[]{"Select a Manufacturer"});
			cmbModel.SelectedIndexChanged += new System.EventHandler(cmbModel_SelectedIndexChanged);
			// 
			// cmbManufacturer
			// 
			cmbManufacturer.AllowDrop = true;
			cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbManufacturer.Location = new System.Drawing.Point(24, 208);
			cmbManufacturer.Name = "cmbManufacturer";
			cmbManufacturer.Size = new System.Drawing.Size(209, 26);
			cmbManufacturer.TabIndex = 5;
			cmbManufacturer.Text = "cmbManufacturer";
			cmbManufacturer.SelectedIndexChanged += new System.EventHandler(cmbManufacturer_SelectedIndexChanged);
			// 
			// txtLastName
			// 
			txtLastName.AllowDrop = true;
			txtLastName.BackColor = System.Drawing.SystemColors.Window;
			txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtLastName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtLastName.Location = new System.Drawing.Point(280, 144);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new System.Drawing.Size(209, 33);
			txtLastName.TabIndex = 3;
			// 
			// txtName
			// 
			txtName.AllowDrop = true;
			txtName.BackColor = System.Drawing.SystemColors.Window;
			txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			txtName.Location = new System.Drawing.Point(24, 144);
			txtName.Name = "txtName";
			txtName.Size = new System.Drawing.Size(209, 33);
			txtName.TabIndex = 1;
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
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Receipt";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblName
			// 
			lblName.AllowDrop = true;
			lblName.BackColor = System.Drawing.SystemColors.Control;
			lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblName.Location = new System.Drawing.Point(24, 128);
			lblName.MinimumSize = new System.Drawing.Size(209, 17);
			lblName.Name = "lblName";
			lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblName.Size = new System.Drawing.Size(209, 17);
			lblName.TabIndex = 2;
			lblName.Text = "Name";
			// 
			// lblLastName
			// 
			lblLastName.AllowDrop = true;
			lblLastName.BackColor = System.Drawing.SystemColors.Control;
			lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblLastName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
			lblLastName.Location = new System.Drawing.Point(280, 128);
			lblLastName.MinimumSize = new System.Drawing.Size(209, 17);
			lblLastName.Name = "lblLastName";
			lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblLastName.Size = new System.Drawing.Size(209, 17);
			lblLastName.TabIndex = 4;
			lblLastName.Text = "Last Name";
			// 
			// lblManufacturer
			// 
			lblManufacturer.AllowDrop = true;
			lblManufacturer.BackColor = System.Drawing.SystemColors.Control;
			lblManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblManufacturer.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblManufacturer.ForeColor = System.Drawing.SystemColors.ControlText;
			lblManufacturer.Location = new System.Drawing.Point(24, 192);
			lblManufacturer.MinimumSize = new System.Drawing.Size(209, 17);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblManufacturer.Size = new System.Drawing.Size(209, 17);
			lblManufacturer.TabIndex = 6;
			lblManufacturer.Text = "Manufacturer";
			// 
			// lblModel
			// 
			lblModel.AllowDrop = true;
			lblModel.BackColor = System.Drawing.SystemColors.Control;
			lblModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblModel.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblModel.ForeColor = System.Drawing.SystemColors.ControlText;
			lblModel.Location = new System.Drawing.Point(280, 192);
			lblModel.MinimumSize = new System.Drawing.Size(209, 17);
			lblModel.Name = "lblModel";
			lblModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblModel.Size = new System.Drawing.Size(209, 17);
			lblModel.TabIndex = 8;
			lblModel.Text = "Model";
			// 
			// lblQuantity
			// 
			lblQuantity.AllowDrop = true;
			lblQuantity.BackColor = System.Drawing.SystemColors.Control;
			lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblQuantity.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			lblQuantity.Location = new System.Drawing.Point(24, 248);
			lblQuantity.MinimumSize = new System.Drawing.Size(209, 17);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblQuantity.Size = new System.Drawing.Size(209, 17);
			lblQuantity.TabIndex = 11;
			lblQuantity.Text = "Quantity";
			// 
			// lblSeller
			// 
			lblSeller.AllowDrop = true;
			lblSeller.BackColor = System.Drawing.SystemColors.Control;
			lblSeller.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblSeller.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblSeller.ForeColor = System.Drawing.SystemColors.ControlText;
			lblSeller.Location = new System.Drawing.Point(280, 248);
			lblSeller.MinimumSize = new System.Drawing.Size(209, 17);
			lblSeller.Name = "lblSeller";
			lblSeller.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblSeller.Size = new System.Drawing.Size(209, 17);
			lblSeller.TabIndex = 13;
			lblSeller.Text = "Seller";
			// 
			// Label8
			// 
			Label8.AllowDrop = true;
			Label8.BackColor = System.Drawing.SystemColors.Control;
			Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label8.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			Label8.Location = new System.Drawing.Point(280, 312);
			Label8.MinimumSize = new System.Drawing.Size(209, 17);
			Label8.Name = "Label8";
			Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label8.Size = new System.Drawing.Size(209, 17);
			Label8.TabIndex = 15;
			Label8.Text = "SubTotal";
			// 
			// Label9
			// 
			Label9.AllowDrop = true;
			Label9.BackColor = System.Drawing.SystemColors.Control;
			Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label9.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			Label9.Location = new System.Drawing.Point(280, 376);
			Label9.MinimumSize = new System.Drawing.Size(209, 17);
			Label9.Name = "Label9";
			Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label9.Size = new System.Drawing.Size(209, 17);
			Label9.TabIndex = 17;
			Label9.Text = "Total";
			// 
			// Label10
			// 
			Label10.AllowDrop = true;
			Label10.BackColor = System.Drawing.SystemColors.Control;
			Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label10.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			Label10.Location = new System.Drawing.Point(24, 64);
			Label10.MinimumSize = new System.Drawing.Size(209, 17);
			Label10.Name = "Label10";
			Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label10.Size = new System.Drawing.Size(209, 17);
			Label10.TabIndex = 22;
			Label10.Text = "Receipt ID";
			// 
			// frmCreateNewReceipt
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(515, 525);
			Controls.Add(txtQuantity);
			Controls.Add(txtID);
			Controls.Add(chk3PersonInsurance);
			Controls.Add(btnCreate);
			Controls.Add(btnReset);
			Controls.Add(txtTotal);
			Controls.Add(txtSubTotal);
			Controls.Add(cmbSeller);
			Controls.Add(chkVehicleInsurance);
			Controls.Add(Label4);
			Controls.Add(cmbModel);
			Controls.Add(cmbManufacturer);
			Controls.Add(txtLastName);
			Controls.Add(txtName);
			Controls.Add(lblTitle);
			Controls.Add(lblName);
			Controls.Add(lblLastName);
			Controls.Add(lblManufacturer);
			Controls.Add(lblModel);
			Controls.Add(lblQuantity);
			Controls.Add(lblSeller);
			Controls.Add(Label8);
			Controls.Add(Label9);
			Controls.Add(Label10);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewReceipt.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmCreateNewReceipt";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Create New Receipt";
			checkBoxHelper1.SetStyle(chk3PersonInsurance, 0);
			checkBoxHelper1.SetStyle(chkVehicleInsurance, 0);
			commandButtonHelper1.SetStyle(btnCreate, 0);
			commandButtonHelper1.SetStyle(btnReset, 0);
			listBoxComboBoxHelper1.SetItemData(cmbModel, new int[]{0});
			ToolTipMain.SetToolTip(txtQuantity, "Name of the client");
			ToolTipMain.SetToolTip(txtID, "Receipt ID");
			ToolTipMain.SetToolTip(chk3PersonInsurance, "Insurance in case of accidents with people");
			ToolTipMain.SetToolTip(txtTotal, "Total (Includes 13% taxes)");
			ToolTipMain.SetToolTip(txtSubTotal, "Subtotal to pay");
			ToolTipMain.SetToolTip(cmbSeller, "Seller");
			ToolTipMain.SetToolTip(chkVehicleInsurance, "Insurance in case of crashes");
			ToolTipMain.SetToolTip(cmbModel, "Model");
			ToolTipMain.SetToolTip(cmbManufacturer, "Manufacturer");
			ToolTipMain.SetToolTip(txtLastName, "Last name of the client");
			ToolTipMain.SetToolTip(txtName, "Name of the client");
			Activated += new System.EventHandler(frmCreateNewReceipt_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).EndInit();
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}