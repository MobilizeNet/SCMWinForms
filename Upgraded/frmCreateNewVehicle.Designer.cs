
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewVehicle));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtLength = new System.Windows.Forms.TextBox();
			this.txtWidth = new System.Windows.Forms.TextBox();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.dtProductionStarted = new System.Windows.Forms.DateTimePicker();
			this.dtProductionEnded = new System.Windows.Forms.DateTimePicker();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblYearProduction = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblWidth = new System.Windows.Forms.Label();
			this.lblLength = new System.Windows.Forms.Label();
			this._optTransmission_1 = new System.Windows.Forms.RadioButton();
			this._optTransmission_0 = new System.Windows.Forms.RadioButton();
			this.lblPrice = new System.Windows.Forms.Label();
			this.cmbManufacturer = new System.Windows.Forms.ComboBox();
			this.cmbBodyStyle = new System.Windows.Forms.ComboBox();
			this.cmbClass = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lblClass = new System.Windows.Forms.Label();
			this.lblBodyStyle = new System.Windows.Forms.Label();
			this.lblManufacturer = new System.Windows.Forms.Label();
			this.lblTransmission = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).BeginInit();
			this.optionButtonHelper1 = new UpgradeHelpers.Gui.Controls.OptionButtonHelper(this.components);
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// txtLength
			// 
			this.txtLength.AcceptsReturn = true;
			this.txtLength.AllowDrop = true;
			this.txtLength.BackColor = System.Drawing.SystemColors.Window;
			this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtLength.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLength.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtLength.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtLength.Location = new System.Drawing.Point(24, 392);
			this.txtLength.MaxLength = 0;
			this.txtLength.Name = "txtLength";
			this.txtLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtLength.Size = new System.Drawing.Size(209, 32);
			this.txtLength.TabIndex = 11;
			this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
			this.txtLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLength_KeyPress);
			this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
			// 
			// txtWidth
			// 
			this.txtWidth.AcceptsReturn = true;
			this.txtWidth.AllowDrop = true;
			this.txtWidth.BackColor = System.Drawing.SystemColors.Window;
			this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtWidth.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtWidth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtWidth.Location = new System.Drawing.Point(280, 392);
			this.txtWidth.MaxLength = 0;
			this.txtWidth.Name = "txtWidth";
			this.txtWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtWidth.Size = new System.Drawing.Size(209, 32);
			this.txtWidth.TabIndex = 12;
			this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
			this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
			this.txtWidth.Leave += new System.EventHandler(this.txtWidth_Leave);
			// 
			// txtQuantity
			// 
			this.txtQuantity.AcceptsReturn = true;
			this.txtQuantity.AllowDrop = true;
			this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
			this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtQuantity.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtQuantity.Location = new System.Drawing.Point(280, 208);
			this.txtQuantity.MaxLength = 0;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtQuantity.Size = new System.Drawing.Size(209, 32);
			this.txtQuantity.TabIndex = 5;
			this.txtQuantity.Click += new System.EventHandler(this.txtQuantity_Click);
			this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
			this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
			this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
			// 
			// txtYear
			// 
			this.txtYear.AcceptsReturn = true;
			this.txtYear.AllowDrop = true;
			this.txtYear.BackColor = System.Drawing.SystemColors.Window;
			this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtYear.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtYear.Location = new System.Drawing.Point(24, 208);
			this.txtYear.MaxLength = 0;
			this.txtYear.Name = "txtYear";
			this.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtYear.Size = new System.Drawing.Size(209, 32);
			this.txtYear.TabIndex = 4;
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
			// 
			// dtProductionStarted
			// 
			this.dtProductionStarted.AllowDrop = true;
			this.dtProductionStarted.Checked = false;
			this.dtProductionStarted.CustomFormat = "MM/yyyy";
			this.dtProductionStarted.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtProductionStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtProductionStarted.Location = new System.Drawing.Point(24, 144);
			this.dtProductionStarted.Name = "dtProductionStarted";
			this.dtProductionStarted.Size = new System.Drawing.Size(209, 33);
			this.dtProductionStarted.TabIndex = 2;
			// 
			// dtProductionEnded
			// 
			this.dtProductionEnded.AllowDrop = true;
			this.dtProductionEnded.Checked = false;
			this.dtProductionEnded.CustomFormat = "MM/yyyy";
			this.dtProductionEnded.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtProductionEnded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtProductionEnded.Location = new System.Drawing.Point(280, 144);
			this.dtProductionEnded.Name = "dtProductionEnded";
			this.dtProductionEnded.Size = new System.Drawing.Size(209, 33);
			this.dtProductionEnded.TabIndex = 3;
			// 
			// txtPrice
			// 
			this.txtPrice.AllowDrop = true;
			this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
			this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPrice.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPrice.Location = new System.Drawing.Point(24, 272);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(209, 33);
			this.txtPrice.TabIndex = 6;
			this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
			this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AllowDrop = true;
			this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
			this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblQuantity.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblQuantity.Location = new System.Drawing.Point(280, 192);
			this.lblQuantity.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblQuantity.Size = new System.Drawing.Size(209, 17);
			this.lblQuantity.TabIndex = 27;
			this.lblQuantity.Text = "Quantity";
			// 
			// lblYearProduction
			// 
			this.lblYearProduction.AllowDrop = true;
			this.lblYearProduction.BackColor = System.Drawing.SystemColors.Control;
			this.lblYearProduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblYearProduction.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblYearProduction.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblYearProduction.Location = new System.Drawing.Point(24, 192);
			this.lblYearProduction.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblYearProduction.Name = "lblYearProduction";
			this.lblYearProduction.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblYearProduction.Size = new System.Drawing.Size(209, 17);
			this.lblYearProduction.TabIndex = 26;
			this.lblYearProduction.Text = "Year of Production";
			// 
			// btnReset
			// 
			this.btnReset.AllowDrop = true;
			this.btnReset.BackColor = System.Drawing.SystemColors.Control;
			this.btnReset.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnReset.ForeColor = System.Drawing.Color.Empty;
			this.btnReset.Location = new System.Drawing.Point(272, 448);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(169, 65);
			this.btnReset.TabIndex = 14;
			this.btnReset.Text = "&Reset";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.AllowDrop = true;
			this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
			this.btnCreate.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCreate.ForeColor = System.Drawing.Color.Empty;
			this.btnCreate.Location = new System.Drawing.Point(64, 448);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(169, 65);
			this.btnCreate.TabIndex = 13;
			this.btnCreate.Text = "&Create";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblWidth
			// 
			this.lblWidth.AllowDrop = true;
			this.lblWidth.BackColor = System.Drawing.SystemColors.Control;
			this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblWidth.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblWidth.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblWidth.Location = new System.Drawing.Point(280, 376);
			this.lblWidth.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblWidth.Size = new System.Drawing.Size(209, 17);
			this.lblWidth.TabIndex = 25;
			this.lblWidth.Text = "Width";
			// 
			// lblLength
			// 
			this.lblLength.AllowDrop = true;
			this.lblLength.BackColor = System.Drawing.SystemColors.Control;
			this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblLength.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLength.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLength.Location = new System.Drawing.Point(24, 376);
			this.lblLength.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblLength.Name = "lblLength";
			this.lblLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLength.Size = new System.Drawing.Size(209, 17);
			this.lblLength.TabIndex = 24;
			this.lblLength.Text = "Length";
			// 
			// _optTransmission_1
			// 
			this._optTransmission_1.AllowDrop = true;
			this._optTransmission_1.BackColor = System.Drawing.SystemColors.Control;
			this._optTransmission_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optTransmission_1.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._optTransmission_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optTransmission_1.Location = new System.Drawing.Point(400, 272);
			this._optTransmission_1.Name = "_optTransmission_1";
			this._optTransmission_1.Size = new System.Drawing.Size(89, 33);
			this._optTransmission_1.TabIndex = 8;
			this._optTransmission_1.Text = "Manual";
			this._optTransmission_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _optTransmission_0
			// 
			this._optTransmission_0.AllowDrop = true;
			this._optTransmission_0.BackColor = System.Drawing.SystemColors.Control;
			this._optTransmission_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._optTransmission_0.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._optTransmission_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._optTransmission_0.Location = new System.Drawing.Point(280, 272);
			this._optTransmission_0.Name = "_optTransmission_0";
			this._optTransmission_0.Size = new System.Drawing.Size(105, 33);
			this._optTransmission_0.TabIndex = 7;
			this._optTransmission_0.Text = "Automatic";
			this._optTransmission_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPrice
			// 
			this.lblPrice.AllowDrop = true;
			this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
			this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPrice.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPrice.Location = new System.Drawing.Point(24, 256);
			this.lblPrice.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPrice.Size = new System.Drawing.Size(209, 17);
			this.lblPrice.TabIndex = 23;
			this.lblPrice.Text = "Price";
			// 
			// cmbManufacturer
			// 
			this.cmbManufacturer.AllowDrop = true;
			this.cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbManufacturer.Location = new System.Drawing.Point(280, 80);
			this.cmbManufacturer.Name = "cmbManufacturer";
			this.cmbManufacturer.Size = new System.Drawing.Size(209, 26);
			this.cmbManufacturer.TabIndex = 1;
			this.cmbManufacturer.Text = "cmbManufacturer";
			// 
			// cmbBodyStyle
			// 
			this.cmbBodyStyle.AllowDrop = true;
			this.cmbBodyStyle.BackColor = System.Drawing.SystemColors.Window;
			this.cmbBodyStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBodyStyle.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbBodyStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbBodyStyle.Location = new System.Drawing.Point(280, 336);
			this.cmbBodyStyle.Name = "cmbBodyStyle";
			this.cmbBodyStyle.Size = new System.Drawing.Size(209, 26);
			this.cmbBodyStyle.TabIndex = 10;
			this.cmbBodyStyle.Text = "cmbBodyStyle";
			this.cmbBodyStyle.Items.AddRange(new object[]{"Buggy", "Convertible", "Coupé", "Flower Car / Hearse", "Hatchback", "Limousine", "Microvan", "Minivan", "Panel van", "Panel truck", "Pickup truck", "Roadster", "Sedan", "Shooting-brake", "SUV", "Station wagon", "Targa top", "Ute / Coupe utility"});
			// 
			// cmbClass
			// 
			this.cmbClass.AllowDrop = true;
			this.cmbClass.BackColor = System.Drawing.SystemColors.Window;
			this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClass.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbClass.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbClass.Location = new System.Drawing.Point(24, 336);
			this.cmbClass.Name = "cmbClass";
			this.cmbClass.Size = new System.Drawing.Size(209, 26);
			this.cmbClass.TabIndex = 9;
			this.cmbClass.Text = "cmbClass";
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(280, 128);
			this.Label3.MinimumSize = new System.Drawing.Size(209, 17);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(209, 17);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "Production Ended";
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
			this.lblTitle.TabIndex = 15;
			this.lblTitle.Text = "Vehicle";
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
			this.lblName.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblName.Name = "lblName";
			this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblName.Size = new System.Drawing.Size(209, 17);
			this.lblName.TabIndex = 16;
			this.lblName.Text = "Name";
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(24, 128);
			this.Label2.MinimumSize = new System.Drawing.Size(209, 17);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(209, 17);
			this.Label2.TabIndex = 17;
			this.Label2.Text = "Production Started";
			// 
			// lblClass
			// 
			this.lblClass.AllowDrop = true;
			this.lblClass.BackColor = System.Drawing.SystemColors.Control;
			this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblClass.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblClass.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblClass.Location = new System.Drawing.Point(24, 320);
			this.lblClass.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblClass.Name = "lblClass";
			this.lblClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblClass.Size = new System.Drawing.Size(209, 17);
			this.lblClass.TabIndex = 20;
			this.lblClass.Text = "Class";
			// 
			// lblBodyStyle
			// 
			this.lblBodyStyle.AllowDrop = true;
			this.lblBodyStyle.BackColor = System.Drawing.SystemColors.Control;
			this.lblBodyStyle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblBodyStyle.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblBodyStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBodyStyle.Location = new System.Drawing.Point(280, 320);
			this.lblBodyStyle.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblBodyStyle.Name = "lblBodyStyle";
			this.lblBodyStyle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblBodyStyle.Size = new System.Drawing.Size(209, 17);
			this.lblBodyStyle.TabIndex = 19;
			this.lblBodyStyle.Text = "Body Style";
			// 
			// lblManufacturer
			// 
			this.lblManufacturer.AllowDrop = true;
			this.lblManufacturer.BackColor = System.Drawing.SystemColors.Control;
			this.lblManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblManufacturer.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblManufacturer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblManufacturer.Location = new System.Drawing.Point(280, 64);
			this.lblManufacturer.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblManufacturer.Name = "lblManufacturer";
			this.lblManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblManufacturer.Size = new System.Drawing.Size(209, 17);
			this.lblManufacturer.TabIndex = 21;
			this.lblManufacturer.Text = "Manufacturer";
			// 
			// lblTransmission
			// 
			this.lblTransmission.AllowDrop = true;
			this.lblTransmission.BackColor = System.Drawing.SystemColors.Control;
			this.lblTransmission.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTransmission.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTransmission.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTransmission.Location = new System.Drawing.Point(280, 256);
			this.lblTransmission.MinimumSize = new System.Drawing.Size(209, 17);
			this.lblTransmission.Name = "lblTransmission";
			this.lblTransmission.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTransmission.Size = new System.Drawing.Size(209, 17);
			this.lblTransmission.TabIndex = 22;
			this.lblTransmission.Text = "Transmission";
			// 
			// frmCreateNewVehicle
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(517, 525);
			this.Controls.Add(this.txtLength);
			this.Controls.Add(this.txtWidth);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.dtProductionStarted);
			this.Controls.Add(this.dtProductionEnded);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.lblYearProduction);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.lblWidth);
			this.Controls.Add(this.lblLength);
			this.Controls.Add(this._optTransmission_1);
			this.Controls.Add(this._optTransmission_0);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.cmbManufacturer);
			this.Controls.Add(this.cmbBodyStyle);
			this.Controls.Add(this.cmbClass);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lblClass);
			this.Controls.Add(this.lblBodyStyle);
			this.Controls.Add(this.lblManufacturer);
			this.Controls.Add(this.lblTransmission);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmCreateNewVehicle.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreateNewVehicle";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Vehicle";
			this.commandButtonHelper1.SetStyle(this.btnReset, 0);
			this.commandButtonHelper1.SetStyle(this.btnCreate, 0);
			this.listBoxComboBoxHelper1.SetItemData(this.cmbBodyStyle, new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17});
			this.optionButtonHelper1.SetStyle(this._optTransmission_1, 0);
			this.optionButtonHelper1.SetStyle(this._optTransmission_0, 0);
			this.ToolTipMain.SetToolTip(this.dtProductionStarted, "Year when the production started");
			this.ToolTipMain.SetToolTip(this.dtProductionEnded, "Year when the production ended");
			this.ToolTipMain.SetToolTip(this.txtPrice, "Price per unit");
			this.ToolTipMain.SetToolTip(this._optTransmission_1, "Manual transmission");
			this.ToolTipMain.SetToolTip(this._optTransmission_0, "Automatic or CVT tansmission");
			this.ToolTipMain.SetToolTip(this.cmbManufacturer, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbBodyStyle, "Body Style");
			this.ToolTipMain.SetToolTip(this.cmbClass, "Class");
			this.ToolTipMain.SetToolTip(this.txtName, "Name of the vehicle model");
			this.Activated += new System.EventHandler(this.frmCreateNewVehicle_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).EndInit();
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
			InitializeoptTransmission();
		}
		void InitializeoptTransmission()
		{
			this.optTransmission = new System.Windows.Forms.RadioButton[2];
			this.optTransmission[1] = _optTransmission_1;
			this.optTransmission[0] = _optTransmission_0;
		}
		#endregion
	}
}