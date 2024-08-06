
namespace StarCarsManagement
{
	partial class frmCreateNewVehicle
	{

		#region "Upgrade Support "
		private static frmCreateNewVehicle m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCreateNewVehicle DefInstance
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
		public static frmCreateNewVehicle CreateInstance()
		{
			frmCreateNewVehicle theInstance = new frmCreateNewVehicle();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 20);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtLength", "txtWidth", "txtQuantity", "txtYear", "dtProductionStarted", "dtProductionEnded", "txtPrice", "lblQuantity", "lblYearProduction", "btnReset", "btnCreate", "lblWidth", "lblLength", "_optTransmission_1", "_optTransmission_0", "lblPrice", "cmbManufacturer", "cmbBodyStyle", "cmbClass", "Label3", "txtName", "lblTitle", "lblName", "Label2", "lblClass", "lblBodyStyle", "lblManufacturer", "lblTransmission", "optTransmission", "listBoxComboBoxHelper1", "optionButtonHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtLength;
		public System.Windows.Forms.TextBox txtWidth;
		public System.Windows.Forms.TextBox txtQuantity;
		public System.Windows.Forms.TextBox txtYear;
		public System.Windows.Forms.DateTimePicker dtProductionStarted;
		public System.Windows.Forms.DateTimePicker dtProductionEnded;
		public System.Windows.Forms.TextBox txtPrice;
		public System.Windows.Forms.Label lblQuantity;
		public System.Windows.Forms.Label lblYearProduction;
		public System.Windows.Forms.Button btnReset;
		public System.Windows.Forms.Button btnCreate;
		public System.Windows.Forms.Label lblWidth;
		public System.Windows.Forms.Label lblLength;
		private System.Windows.Forms.RadioButton _optTransmission_1;
		private System.Windows.Forms.RadioButton _optTransmission_0;
		public System.Windows.Forms.Label lblPrice;
		public System.Windows.Forms.ComboBox cmbManufacturer;
		public System.Windows.Forms.ComboBox cmbBodyStyle;
		public System.Windows.Forms.ComboBox cmbClass;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Label lblTitle;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label lblClass;
		public System.Windows.Forms.Label lblBodyStyle;
		public System.Windows.Forms.Label lblManufacturer;
		public System.Windows.Forms.Label lblTransmission;
		public System.Windows.Forms.RadioButton[] optTransmission = new System.Windows.Forms.RadioButton[2];
		public UpgradeHelpers.Gui.Controls.ListControlHelper listBoxComboBoxHelper1;
		public UpgradeHelpers.Gui.Controls.OptionButtonHelper optionButtonHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewVehicle));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			txtLength = new System.Windows.Forms.TextBox();
			txtWidth = new System.Windows.Forms.TextBox();
			txtQuantity = new System.Windows.Forms.TextBox();
			txtYear = new System.Windows.Forms.TextBox();
			dtProductionStarted = new System.Windows.Forms.DateTimePicker();
			dtProductionEnded = new System.Windows.Forms.DateTimePicker();
			txtPrice = new System.Windows.Forms.TextBox();
			lblQuantity = new System.Windows.Forms.Label();
			lblYearProduction = new System.Windows.Forms.Label();
			btnReset = new System.Windows.Forms.Button();
			btnCreate = new System.Windows.Forms.Button();
			lblWidth = new System.Windows.Forms.Label();
			lblLength = new System.Windows.Forms.Label();
			_optTransmission_1 = new System.Windows.Forms.RadioButton();
			_optTransmission_0 = new System.Windows.Forms.RadioButton();
			lblPrice = new System.Windows.Forms.Label();
			cmbManufacturer = new System.Windows.Forms.ComboBox();
			cmbBodyStyle = new System.Windows.Forms.ComboBox();
			cmbClass = new System.Windows.Forms.ComboBox();
			Label3 = new System.Windows.Forms.Label();
			txtName = new System.Windows.Forms.TextBox();
			lblTitle = new System.Windows.Forms.Label();
			lblName = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			lblClass = new System.Windows.Forms.Label();
			lblBodyStyle = new System.Windows.Forms.Label();
			lblManufacturer = new System.Windows.Forms.Label();
			lblTransmission = new System.Windows.Forms.Label();
			SuspendLayout();
			listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(components);
			((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).BeginInit();
			optionButtonHelper1 = new UpgradeHelpers.Gui.Controls.OptionButtonHelper(components);
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// txtLength
			// 
			txtLength.AcceptsReturn = true;
			txtLength.AllowDrop = true;
			txtLength.BackColor = System.Drawing.SystemColors.Window;
			txtLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtLength.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtLength.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtLength.ForeColor = System.Drawing.SystemColors.WindowText;
			txtLength.Location = new System.Drawing.Point(24, 392);
			txtLength.MaxLength = 0;
			txtLength.Name = "txtLength";
			txtLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtLength.Size = new System.Drawing.Size(209, 32);
			txtLength.TabIndex = 11;
			txtLength.Enter += new System.EventHandler(txtLength_Enter);
			txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtLength_KeyPress);
			txtLength.Leave += new System.EventHandler(txtLength_Leave);
			// 
			// txtWidth
			// 
			txtWidth.AcceptsReturn = true;
			txtWidth.AllowDrop = true;
			txtWidth.BackColor = System.Drawing.SystemColors.Window;
			txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtWidth.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtWidth.ForeColor = System.Drawing.SystemColors.WindowText;
			txtWidth.Location = new System.Drawing.Point(280, 392);
			txtWidth.MaxLength = 0;
			txtWidth.Name = "txtWidth";
			txtWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtWidth.Size = new System.Drawing.Size(209, 32);
			txtWidth.TabIndex = 12;
			txtWidth.Enter += new System.EventHandler(txtWidth_Enter);
			txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtWidth_KeyPress);
			txtWidth.Leave += new System.EventHandler(txtWidth_Leave);
			// 
			// txtQuantity
			// 
			txtQuantity.AcceptsReturn = true;
			txtQuantity.AllowDrop = true;
			txtQuantity.BackColor = System.Drawing.SystemColors.Window;
			txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtQuantity.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
			txtQuantity.Location = new System.Drawing.Point(280, 208);
			txtQuantity.MaxLength = 0;
			txtQuantity.Name = "txtQuantity";
			txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtQuantity.Size = new System.Drawing.Size(209, 32);
			txtQuantity.TabIndex = 5;
			txtQuantity.Click += new System.EventHandler(txtQuantity_Click);
			txtQuantity.Enter += new System.EventHandler(txtQuantity_Enter);
			txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtQuantity_KeyPress);
			txtQuantity.Leave += new System.EventHandler(txtQuantity_Leave);
			// 
			// txtYear
			// 
			txtYear.AcceptsReturn = true;
			txtYear.AllowDrop = true;
			txtYear.BackColor = System.Drawing.SystemColors.Window;
			txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtYear.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
			txtYear.Location = new System.Drawing.Point(24, 208);
			txtYear.MaxLength = 0;
			txtYear.Name = "txtYear";
			txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtYear.Size = new System.Drawing.Size(209, 32);
			txtYear.TabIndex = 4;
			txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtYear_KeyPress);
			// 
			// dtProductionStarted
			// 
			dtProductionStarted.AllowDrop = true;
			dtProductionStarted.Checked = false;
			dtProductionStarted.CustomFormat = "MM/yyyy";
			dtProductionStarted.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dtProductionStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			dtProductionStarted.Location = new System.Drawing.Point(24, 144);
			dtProductionStarted.Name = "dtProductionStarted";
			dtProductionStarted.Size = new System.Drawing.Size(209, 33);
			dtProductionStarted.TabIndex = 2;
			// 
			// dtProductionEnded
			// 
			dtProductionEnded.AllowDrop = true;
			dtProductionEnded.Checked = false;
			dtProductionEnded.CustomFormat = "MM/yyyy";
			dtProductionEnded.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dtProductionEnded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			dtProductionEnded.Location = new System.Drawing.Point(280, 144);
			dtProductionEnded.Name = "dtProductionEnded";
			dtProductionEnded.Size = new System.Drawing.Size(209, 33);
			dtProductionEnded.TabIndex = 3;
			// 
			// txtPrice
			// 
			txtPrice.AllowDrop = true;
			txtPrice.BackColor = System.Drawing.SystemColors.Window;
			txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtPrice.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPrice.ForeColor = System.Drawing.SystemColors.WindowText;
			txtPrice.Location = new System.Drawing.Point(24, 272);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new System.Drawing.Size(209, 33);
			txtPrice.TabIndex = 6;
			txtPrice.Enter += new System.EventHandler(txtPrice_Enter);
			txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPrice_KeyPress);
			txtPrice.Leave += new System.EventHandler(txtPrice_Leave);
			// 
			// lblQuantity
			// 
			lblQuantity.AllowDrop = true;
			lblQuantity.BackColor = System.Drawing.SystemColors.Control;
			lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblQuantity.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			lblQuantity.Location = new System.Drawing.Point(280, 192);
			lblQuantity.MinimumSize = new System.Drawing.Size(209, 17);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblQuantity.Size = new System.Drawing.Size(209, 17);
			lblQuantity.TabIndex = 27;
			lblQuantity.Text = "Quantity";
			// 
			// lblYearProduction
			// 
			lblYearProduction.AllowDrop = true;
			lblYearProduction.BackColor = System.Drawing.SystemColors.Control;
			lblYearProduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblYearProduction.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblYearProduction.ForeColor = System.Drawing.SystemColors.ControlText;
			lblYearProduction.Location = new System.Drawing.Point(24, 192);
			lblYearProduction.MinimumSize = new System.Drawing.Size(209, 17);
			lblYearProduction.Name = "lblYearProduction";
			lblYearProduction.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblYearProduction.Size = new System.Drawing.Size(209, 17);
			lblYearProduction.TabIndex = 26;
			lblYearProduction.Text = "Year of Production";
			// 
			// btnReset
			// 
			btnReset.AllowDrop = true;
			btnReset.BackColor = System.Drawing.SystemColors.Control;
			btnReset.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnReset.ForeColor = System.Drawing.Color.Empty;
			btnReset.Location = new System.Drawing.Point(272, 448);
			btnReset.Name = "btnReset";
			btnReset.Size = new System.Drawing.Size(169, 65);
			btnReset.TabIndex = 14;
			btnReset.Text = "&Reset";
			btnReset.Click += new System.EventHandler(btnReset_Click);
			// 
			// btnCreate
			// 
			btnCreate.AllowDrop = true;
			btnCreate.BackColor = System.Drawing.SystemColors.Control;
			btnCreate.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnCreate.ForeColor = System.Drawing.Color.Empty;
			btnCreate.Location = new System.Drawing.Point(64, 448);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new System.Drawing.Size(169, 65);
			btnCreate.TabIndex = 13;
			btnCreate.Text = "&Create";
			btnCreate.Click += new System.EventHandler(btnCreate_Click);
			// 
			// lblWidth
			// 
			lblWidth.AllowDrop = true;
			lblWidth.BackColor = System.Drawing.SystemColors.Control;
			lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblWidth.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblWidth.ForeColor = System.Drawing.SystemColors.ControlText;
			lblWidth.Location = new System.Drawing.Point(280, 376);
			lblWidth.MinimumSize = new System.Drawing.Size(209, 17);
			lblWidth.Name = "lblWidth";
			lblWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblWidth.Size = new System.Drawing.Size(209, 17);
			lblWidth.TabIndex = 25;
			lblWidth.Text = "Width";
			// 
			// lblLength
			// 
			lblLength.AllowDrop = true;
			lblLength.BackColor = System.Drawing.SystemColors.Control;
			lblLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblLength.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblLength.ForeColor = System.Drawing.SystemColors.ControlText;
			lblLength.Location = new System.Drawing.Point(24, 376);
			lblLength.MinimumSize = new System.Drawing.Size(209, 17);
			lblLength.Name = "lblLength";
			lblLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblLength.Size = new System.Drawing.Size(209, 17);
			lblLength.TabIndex = 24;
			lblLength.Text = "Length";
			// 
			// _optTransmission_1
			// 
			_optTransmission_1.AllowDrop = true;
			_optTransmission_1.BackColor = System.Drawing.SystemColors.Control;
			_optTransmission_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			_optTransmission_1.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_optTransmission_1.ForeColor = System.Drawing.SystemColors.ControlText;
			_optTransmission_1.Location = new System.Drawing.Point(400, 272);
			_optTransmission_1.Name = "_optTransmission_1";
			_optTransmission_1.Size = new System.Drawing.Size(89, 33);
			_optTransmission_1.TabIndex = 8;
			_optTransmission_1.Text = "Manual";
			_optTransmission_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _optTransmission_0
			// 
			_optTransmission_0.AllowDrop = true;
			_optTransmission_0.BackColor = System.Drawing.SystemColors.Control;
			_optTransmission_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			_optTransmission_0.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			_optTransmission_0.ForeColor = System.Drawing.SystemColors.ControlText;
			_optTransmission_0.Location = new System.Drawing.Point(280, 272);
			_optTransmission_0.Name = "_optTransmission_0";
			_optTransmission_0.Size = new System.Drawing.Size(105, 33);
			_optTransmission_0.TabIndex = 7;
			_optTransmission_0.Text = "Automatic";
			_optTransmission_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPrice
			// 
			lblPrice.AllowDrop = true;
			lblPrice.BackColor = System.Drawing.SystemColors.Control;
			lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblPrice.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
			lblPrice.Location = new System.Drawing.Point(24, 256);
			lblPrice.MinimumSize = new System.Drawing.Size(209, 17);
			lblPrice.Name = "lblPrice";
			lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblPrice.Size = new System.Drawing.Size(209, 17);
			lblPrice.TabIndex = 23;
			lblPrice.Text = "Price";
			// 
			// cmbManufacturer
			// 
			cmbManufacturer.AllowDrop = true;
			cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbManufacturer.Location = new System.Drawing.Point(280, 80);
			cmbManufacturer.Name = "cmbManufacturer";
			cmbManufacturer.Size = new System.Drawing.Size(209, 26);
			cmbManufacturer.TabIndex = 1;
			cmbManufacturer.Text = "cmbManufacturer";
			// 
			// cmbBodyStyle
			// 
			cmbBodyStyle.AllowDrop = true;
			cmbBodyStyle.BackColor = System.Drawing.SystemColors.Window;
			cmbBodyStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbBodyStyle.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbBodyStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbBodyStyle.Location = new System.Drawing.Point(280, 336);
			cmbBodyStyle.Name = "cmbBodyStyle";
			cmbBodyStyle.Size = new System.Drawing.Size(209, 26);
			cmbBodyStyle.TabIndex = 10;
			cmbBodyStyle.Text = "cmbBodyStyle";
			cmbBodyStyle.Items.AddRange(new object[]{"Buggy", "Convertible", "Coupé", "Flower Car / Hearse", "Hatchback", "Limousine", "Microvan", "Minivan", "Panel van", "Panel truck", "Pickup truck", "Roadster", "Sedan", "Shooting-brake", "SUV", "Station wagon", "Targa top", "Ute / Coupe utility"});
			// 
			// cmbClass
			// 
			cmbClass.AllowDrop = true;
			cmbClass.BackColor = System.Drawing.SystemColors.Window;
			cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbClass.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbClass.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbClass.Location = new System.Drawing.Point(24, 336);
			cmbClass.Name = "cmbClass";
			cmbClass.Size = new System.Drawing.Size(209, 26);
			cmbClass.TabIndex = 9;
			cmbClass.Text = "cmbClass";
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label3.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(280, 128);
			Label3.MinimumSize = new System.Drawing.Size(209, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label3.Size = new System.Drawing.Size(209, 17);
			Label3.TabIndex = 18;
			Label3.Text = "Production Ended";
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
			lblTitle.TabIndex = 15;
			lblTitle.Text = "Vehicle";
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
			lblName.MinimumSize = new System.Drawing.Size(209, 17);
			lblName.Name = "lblName";
			lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblName.Size = new System.Drawing.Size(209, 17);
			lblName.TabIndex = 16;
			lblName.Text = "Name";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(24, 128);
			Label2.MinimumSize = new System.Drawing.Size(209, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(209, 17);
			Label2.TabIndex = 17;
			Label2.Text = "Production Started";
			// 
			// lblClass
			// 
			lblClass.AllowDrop = true;
			lblClass.BackColor = System.Drawing.SystemColors.Control;
			lblClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblClass.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblClass.ForeColor = System.Drawing.SystemColors.ControlText;
			lblClass.Location = new System.Drawing.Point(24, 320);
			lblClass.MinimumSize = new System.Drawing.Size(209, 17);
			lblClass.Name = "lblClass";
			lblClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblClass.Size = new System.Drawing.Size(209, 17);
			lblClass.TabIndex = 20;
			lblClass.Text = "Class";
			// 
			// lblBodyStyle
			// 
			lblBodyStyle.AllowDrop = true;
			lblBodyStyle.BackColor = System.Drawing.SystemColors.Control;
			lblBodyStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblBodyStyle.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblBodyStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			lblBodyStyle.Location = new System.Drawing.Point(280, 320);
			lblBodyStyle.MinimumSize = new System.Drawing.Size(209, 17);
			lblBodyStyle.Name = "lblBodyStyle";
			lblBodyStyle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblBodyStyle.Size = new System.Drawing.Size(209, 17);
			lblBodyStyle.TabIndex = 19;
			lblBodyStyle.Text = "Body Style";
			// 
			// lblManufacturer
			// 
			lblManufacturer.AllowDrop = true;
			lblManufacturer.BackColor = System.Drawing.SystemColors.Control;
			lblManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblManufacturer.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblManufacturer.ForeColor = System.Drawing.SystemColors.ControlText;
			lblManufacturer.Location = new System.Drawing.Point(280, 64);
			lblManufacturer.MinimumSize = new System.Drawing.Size(209, 17);
			lblManufacturer.Name = "lblManufacturer";
			lblManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblManufacturer.Size = new System.Drawing.Size(209, 17);
			lblManufacturer.TabIndex = 21;
			lblManufacturer.Text = "Manufacturer";
			// 
			// lblTransmission
			// 
			lblTransmission.AllowDrop = true;
			lblTransmission.BackColor = System.Drawing.SystemColors.Control;
			lblTransmission.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTransmission.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTransmission.ForeColor = System.Drawing.SystemColors.ControlText;
			lblTransmission.Location = new System.Drawing.Point(280, 256);
			lblTransmission.MinimumSize = new System.Drawing.Size(209, 17);
			lblTransmission.Name = "lblTransmission";
			lblTransmission.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTransmission.Size = new System.Drawing.Size(209, 17);
			lblTransmission.TabIndex = 22;
			lblTransmission.Text = "Transmission";
			// 
			// frmCreateNewVehicle
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(517, 525);
			Controls.Add(txtLength);
			Controls.Add(txtWidth);
			Controls.Add(txtQuantity);
			Controls.Add(txtYear);
			Controls.Add(dtProductionStarted);
			Controls.Add(dtProductionEnded);
			Controls.Add(txtPrice);
			Controls.Add(lblQuantity);
			Controls.Add(lblYearProduction);
			Controls.Add(btnReset);
			Controls.Add(btnCreate);
			Controls.Add(lblWidth);
			Controls.Add(lblLength);
			Controls.Add(_optTransmission_1);
			Controls.Add(_optTransmission_0);
			Controls.Add(lblPrice);
			Controls.Add(cmbManufacturer);
			Controls.Add(cmbBodyStyle);
			Controls.Add(cmbClass);
			Controls.Add(Label3);
			Controls.Add(txtName);
			Controls.Add(lblTitle);
			Controls.Add(lblName);
			Controls.Add(Label2);
			Controls.Add(lblClass);
			Controls.Add(lblBodyStyle);
			Controls.Add(lblManufacturer);
			Controls.Add(lblTransmission);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewVehicle.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmCreateNewVehicle";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Create New Vehicle";
			commandButtonHelper1.SetStyle(btnReset, 0);
			commandButtonHelper1.SetStyle(btnCreate, 0);
			listBoxComboBoxHelper1.SetItemData(cmbBodyStyle, new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17});
			optionButtonHelper1.SetStyle(_optTransmission_1, 0);
			optionButtonHelper1.SetStyle(_optTransmission_0, 0);
			ToolTipMain.SetToolTip(dtProductionStarted, "Year when the production started");
			ToolTipMain.SetToolTip(dtProductionEnded, "Year when the production ended");
			ToolTipMain.SetToolTip(txtPrice, "Price per unit");
			ToolTipMain.SetToolTip(_optTransmission_1, "Manual transmission");
			ToolTipMain.SetToolTip(_optTransmission_0, "Automatic or CVT tansmission");
			ToolTipMain.SetToolTip(cmbManufacturer, "Manufacturer");
			ToolTipMain.SetToolTip(cmbBodyStyle, "Body Style");
			ToolTipMain.SetToolTip(cmbClass, "Class");
			ToolTipMain.SetToolTip(txtName, "Name of the vehicle model");
			Activated += new System.EventHandler(frmCreateNewVehicle_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).EndInit();
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
			InitializeoptTransmission();
		}
		void InitializeoptTransmission()
		{
			optTransmission = new System.Windows.Forms.RadioButton[2];
			optTransmission[1] = _optTransmission_1;
			optTransmission[0] = _optTransmission_0;
		}
		#endregion
	}
}