
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewReceipt));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.chk3PersonInsurance = new System.Windows.Forms.CheckBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.cmbSeller = new System.Windows.Forms.ComboBox();
			this.chkVehicleInsurance = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbModel = new System.Windows.Forms.ComboBox();
			this.cmbManufacturer = new System.Windows.Forms.ComboBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblManufacturer = new System.Windows.Forms.Label();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblSeller = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			this.checkBoxHelper1 = new UpgradeHelpers.Gui.Controls.CheckBoxHelper(this.components);
			// 
			// txtQuantity
			// 
			this.txtQuantity.AllowDrop = true;
			this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
			this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtQuantity.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtQuantity.Location = new System.Drawing.Point(24, 264);
			this.txtQuantity.MaxLength = 6;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(209, 33);
			this.txtQuantity.TabIndex = 23;
			this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
			// 
			// txtID
			// 
			this.txtID.AllowDrop = true;
			this.txtID.BackColor = System.Drawing.SystemColors.Window;
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtID.Enabled = false;
			this.txtID.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtID.Location = new System.Drawing.Point(24, 80);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(209, 33);
			this.txtID.TabIndex = 21;
			this.txtID.Text = "ID";
			this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chk3PersonInsurance
			// 
			this.chk3PersonInsurance.AllowDrop = true;
			this.chk3PersonInsurance.BackColor = System.Drawing.SystemColors.Control;
			this.chk3PersonInsurance.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chk3PersonInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chk3PersonInsurance.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chk3PersonInsurance.Location = new System.Drawing.Point(24, 368);
			this.chk3PersonInsurance.Name = "chk3PersonInsurance";
			this.chk3PersonInsurance.Size = new System.Drawing.Size(217, 25);
			this.chk3PersonInsurance.TabIndex = 20;
			this.chk3PersonInsurance.Text = "Third Person Insurance";
			this.chk3PersonInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chk3PersonInsurance.Click += new System.EventHandler(this.chk3PersonInsurance_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.AllowDrop = true;
			this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
			this.btnCreate.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCreate.ForeColor = System.Drawing.Color.Empty;
			this.btnCreate.Location = new System.Drawing.Point(72, 448);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(169, 65);
			this.btnCreate.TabIndex = 19;
			this.btnCreate.Text = "&Create";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnReset
			// 
			this.btnReset.AllowDrop = true;
			this.btnReset.BackColor = System.Drawing.SystemColors.Control;
			this.btnReset.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnReset.ForeColor = System.Drawing.Color.Empty;
			this.btnReset.Location = new System.Drawing.Point(280, 448);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(169, 65);
			this.btnReset.TabIndex = 18;
			this.btnReset.Text = "&Reset";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// txtTotal
			// 
			this.txtTotal.AllowDrop = true;
			this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtTotal.Enabled = false;
			this.txtTotal.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTotal.Location = new System.Drawing.Point(280, 392);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(209, 33);
			this.txtTotal.TabIndex = 16;
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.AllowDrop = true;
			this.txtSubTotal.BackColor = System.Drawing.SystemColors.Window;
			this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSubTotal.Enabled = false;
			this.txtSubTotal.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSubTotal.ForeColor = System.Drawing.Color.Red;
			this.txtSubTotal.Location = new System.Drawing.Point(280, 328);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.Size = new System.Drawing.Size(209, 33);
			this.txtSubTotal.TabIndex = 14;
			// 
			// cmbSeller
			// 
			this.cmbSeller.AllowDrop = true;
			this.cmbSeller.BackColor = System.Drawing.SystemColors.Window;
			this.cmbSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSeller.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbSeller.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbSeller.Location = new System.Drawing.Point(280, 264);
			this.cmbSeller.Name = "cmbSeller";
			this.cmbSeller.Size = new System.Drawing.Size(209, 26);
			this.cmbSeller.TabIndex = 12;
			this.cmbSeller.Text = "cmbSeller";
			// 
			// chkVehicleInsurance
			// 
			this.chkVehicleInsurance.AllowDrop = true;
			this.chkVehicleInsurance.BackColor = System.Drawing.SystemColors.Control;
			this.chkVehicleInsurance.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkVehicleInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkVehicleInsurance.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkVehicleInsurance.Location = new System.Drawing.Point(24, 328);
			this.chkVehicleInsurance.Name = "chkVehicleInsurance";
			this.chkVehicleInsurance.Size = new System.Drawing.Size(217, 25);
			this.chkVehicleInsurance.TabIndex = 10;
			this.chkVehicleInsurance.Text = "Vehicle Insurance";
			this.chkVehicleInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkVehicleInsurance.Click += new System.EventHandler(this.chkVehicleInsurance_Click);
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(24, 312);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(217, 17);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Extras";
			// 
			// cmbModel
			// 
			this.cmbModel.AllowDrop = true;
			this.cmbModel.BackColor = System.Drawing.SystemColors.Window;
			this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModel.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbModel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbModel.Location = new System.Drawing.Point(280, 208);
			this.cmbModel.Name = "cmbModel";
			this.cmbModel.Size = new System.Drawing.Size(209, 26);
			this.cmbModel.TabIndex = 7;
			this.cmbModel.Text = "cmbModel";
			this.cmbModel.Items.AddRange(new object[]{"Select a Manufacturer"});
			this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
			// 
			// cmbManufacturer
			// 
			this.cmbManufacturer.AllowDrop = true;
			this.cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbManufacturer.Location = new System.Drawing.Point(24, 208);
			this.cmbManufacturer.Name = "cmbManufacturer";
			this.cmbManufacturer.Size = new System.Drawing.Size(209, 26);
			this.cmbManufacturer.TabIndex = 5;
			this.cmbManufacturer.Text = "cmbManufacturer";
			this.cmbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cmbManufacturer_SelectedIndexChanged);
			// 
			// txtLastName
			// 
			this.txtLastName.AllowDrop = true;
			this.txtLastName.BackColor = System.Drawing.SystemColors.Window;
			this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtLastName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtLastName.Location = new System.Drawing.Point(280, 144);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(209, 33);
			this.txtLastName.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.AllowDrop = true;
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtName.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtName.Location = new System.Drawing.Point(24, 144);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(209, 33);
			this.txtName.TabIndex = 1;
			// 
			// lblTitle
			// 
			this.lblTitle.AllowDrop = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitle.Location = new System.Drawing.Point(16, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTitle.Size = new System.Drawing.Size(481, 49);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Receipt";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblName
			// 
			this.lblName.AllowDrop = true;
			this.lblName.BackColor = System.Drawing.SystemColors.Control;
			this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblName.Location = new System.Drawing.Point(24, 128);
			this.lblName.Name = "lblName";
			this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblName.Size = new System.Drawing.Size(209, 17);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name";
			// 
			// lblLastName
			// 
			this.lblLastName.AllowDrop = true;
			this.lblLastName.BackColor = System.Drawing.SystemColors.Control;
			this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblLastName.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLastName.Location = new System.Drawing.Point(280, 128);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLastName.Size = new System.Drawing.Size(209, 17);
			this.lblLastName.TabIndex = 4;
			this.lblLastName.Text = "Last Name";
			// 
			// lblManufacturer
			// 
			this.lblManufacturer.AllowDrop = true;
			this.lblManufacturer.BackColor = System.Drawing.SystemColors.Control;
			this.lblManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblManufacturer.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblManufacturer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblManufacturer.Location = new System.Drawing.Point(24, 192);
			this.lblManufacturer.Name = "lblManufacturer";
			this.lblManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblManufacturer.Size = new System.Drawing.Size(209, 17);
			this.lblManufacturer.TabIndex = 6;
			this.lblManufacturer.Text = "Manufacturer";
			// 
			// lblModel
			// 
			this.lblModel.AllowDrop = true;
			this.lblModel.BackColor = System.Drawing.SystemColors.Control;
			this.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblModel.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblModel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblModel.Location = new System.Drawing.Point(280, 192);
			this.lblModel.Name = "lblModel";
			this.lblModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblModel.Size = new System.Drawing.Size(209, 17);
			this.lblModel.TabIndex = 8;
			this.lblModel.Text = "Model";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AllowDrop = true;
			this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
			this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblQuantity.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblQuantity.Location = new System.Drawing.Point(24, 248);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblQuantity.Size = new System.Drawing.Size(209, 17);
			this.lblQuantity.TabIndex = 11;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblSeller
			// 
			this.lblSeller.AllowDrop = true;
			this.lblSeller.BackColor = System.Drawing.SystemColors.Control;
			this.lblSeller.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblSeller.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblSeller.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSeller.Location = new System.Drawing.Point(280, 248);
			this.lblSeller.Name = "lblSeller";
			this.lblSeller.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSeller.Size = new System.Drawing.Size(209, 17);
			this.lblSeller.TabIndex = 13;
			this.lblSeller.Text = "Seller";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(280, 312);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(209, 17);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "SubTotal";
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(280, 376);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(209, 17);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "Total";
			// 
			// Label10
			// 
			this.Label10.AllowDrop = true;
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label10.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(24, 64);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(209, 17);
			this.Label10.TabIndex = 22;
			this.Label10.Text = "Receipt ID";
			// 
			// frmCreateNewReceipt
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(515, 525);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.chk3PersonInsurance);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtSubTotal);
			this.Controls.Add(this.cmbSeller);
			this.Controls.Add(this.chkVehicleInsurance);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cmbModel);
			this.Controls.Add(this.cmbManufacturer);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblManufacturer);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.lblSeller);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label10);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewReceipt.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreateNewReceipt";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Receipt";
			this.checkBoxHelper1.SetStyle(this.chk3PersonInsurance, 0);
			this.checkBoxHelper1.SetStyle(this.chkVehicleInsurance, 0);
			this.commandButtonHelper1.SetStyle(this.btnCreate, 0);
			this.commandButtonHelper1.SetStyle(this.btnReset, 0);
			this.listBoxComboBoxHelper1.SetItemData(this.cmbModel, new int[]{0});
			this.ToolTipMain.SetToolTip(this.txtQuantity, "Name of the client");
			this.ToolTipMain.SetToolTip(this.txtID, "Receipt ID");
			this.ToolTipMain.SetToolTip(this.chk3PersonInsurance, "Insurance in case of accidents with people");
			this.ToolTipMain.SetToolTip(this.txtTotal, "Total (Includes 13% taxes)");
			this.ToolTipMain.SetToolTip(this.txtSubTotal, "Subtotal to pay");
			this.ToolTipMain.SetToolTip(this.cmbSeller, "Seller");
			this.ToolTipMain.SetToolTip(this.chkVehicleInsurance, "Insurance in case of crashes");
			this.ToolTipMain.SetToolTip(this.cmbModel, "Model");
			this.ToolTipMain.SetToolTip(this.cmbManufacturer, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.txtLastName, "Last name of the client");
			this.ToolTipMain.SetToolTip(this.txtName, "Name of the client");
			this.Activated += new System.EventHandler(this.frmCreateNewReceipt_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).EndInit();
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
		}
		#endregion
	}
}