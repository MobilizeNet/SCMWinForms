
namespace StarCarsManagement
{
	partial class frmDeleteVehicle
	{

		#region "Upgrade Support "
		private static frmDeleteVehicle m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmDeleteVehicle DefInstance
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
		public static frmDeleteVehicle CreateInstance()
		{
			frmDeleteVehicle theInstance = new frmDeleteVehicle();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 20);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "lstResults_ColumnHeader_1_", "lstResults_ColumnHeader_2_", "lstResults_ColumnHeader_3_", "lstResults_ColumnHeader_4_", "lstResults_ColumnHeader_5_", "lstResults_ColumnHeader_6_", "lstResults_ColumnHeader_7_", "lstResults_ColumnHeader_8_", "lstResults", "pnlResults", "cmbYear", "cmbManufacturer", "cmdResetFilters", "Label11", "cmbPrice", "Label5", "cmbTransmission", "Label4", "cmbBodyStyle", "cmbClass", "Label3", "Label1", "Label2", "chkUseAllFilters", "pnlFilters", "frameFilters", "chkFilters", "cmbModel", "btnDelete", "Label6", "lblTitle", "listViewHelper1", "checkBoxHelper1", "listBoxComboBoxHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_7_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_8_;
		public System.Windows.Forms.ListView lstResults;
		public System.Windows.Forms.GroupBox pnlResults;
		public System.Windows.Forms.ComboBox cmbYear;
		public System.Windows.Forms.ComboBox cmbManufacturer;
		public System.Windows.Forms.Button cmdResetFilters;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.ComboBox cmbPrice;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.ComboBox cmbTransmission;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.ComboBox cmbBodyStyle;
		public System.Windows.Forms.ComboBox cmbClass;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.CheckBox chkUseAllFilters;
		public System.Windows.Forms.GroupBox pnlFilters;
		public System.Windows.Forms.Panel frameFilters;
		public System.Windows.Forms.CheckBox chkFilters;
		public System.Windows.Forms.ComboBox cmbModel;
		public System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label lblTitle;
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CheckBoxHelper checkBoxHelper1;
		public UpgradeHelpers.Gui.Controls.ListControlHelper listBoxComboBoxHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteVehicle));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.frameFilters = new System.Windows.Forms.Panel();
			this.pnlResults = new System.Windows.Forms.GroupBox();
			this.lstResults = new System.Windows.Forms.ListView();
			this.lstResults_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_8_ = new System.Windows.Forms.ColumnHeader();
			this.pnlFilters = new System.Windows.Forms.GroupBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.cmbManufacturer = new System.Windows.Forms.ComboBox();
			this.cmdResetFilters = new System.Windows.Forms.Button();
			this.Label11 = new System.Windows.Forms.Label();
			this.cmbPrice = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cmbTransmission = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbBodyStyle = new System.Windows.Forms.ComboBox();
			this.cmbClass = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.chkUseAllFilters = new System.Windows.Forms.CheckBox();
			this.chkFilters = new System.Windows.Forms.CheckBox();
			this.cmbModel = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.frameFilters.SuspendLayout();
			this.pnlResults.SuspendLayout();
			this.lstResults.SuspendLayout();
			this.pnlFilters.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			this.checkBoxHelper1 = new UpgradeHelpers.Gui.Controls.CheckBoxHelper(this.components);
			this.listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// frameFilters
			// 
			this.frameFilters.AllowDrop = true;
			this.frameFilters.BackColor = System.Drawing.SystemColors.Control;
			this.frameFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.frameFilters.Controls.Add(this.pnlResults);
			this.frameFilters.Controls.Add(this.pnlFilters);
			this.frameFilters.Enabled = true;
			this.frameFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.frameFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frameFilters.Location = new System.Drawing.Point(24, 120);
			this.frameFilters.Name = "frameFilters";
			this.frameFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frameFilters.Size = new System.Drawing.Size(465, 409);
			this.frameFilters.TabIndex = 5;
			this.frameFilters.Visible = true;
			// 
			// pnlResults
			// 
			this.pnlResults.AllowDrop = true;
			this.pnlResults.BackColor = System.Drawing.SystemColors.Control;
			this.pnlResults.Controls.Add(this.lstResults);
			this.pnlResults.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			this.pnlResults.Enabled = true;
			this.pnlResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.pnlResults.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnlResults.Location = new System.Drawing.Point(8, 232);
			this.pnlResults.Name = "pnlResults";
			this.pnlResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pnlResults.Size = new System.Drawing.Size(449, 169);
			this.pnlResults.TabIndex = 19;
			this.pnlResults.Text = "Results";
			this.pnlResults.Visible = true;
			// 
			// lstResults
			// 
			this.lstResults.AllowDrop = true;
			this.lstResults.BackColor = System.Drawing.SystemColors.Window;
			this.lstResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstResults.Font = new System.Drawing.Font("Consolas", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstResults.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstResults.HideSelection = true;
			this.lstResults.LabelEdit = true;
			this.lstResults.Location = new System.Drawing.Point(16, 16);
			this.lstResults.MultiSelect = false;
			this.lstResults.Name = "lstResults";
			this.lstResults.Size = new System.Drawing.Size(417, 145);
			this.lstResults.TabIndex = 20;
			this.lstResults.View = System.Windows.Forms.View.Details;
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_1_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_2_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_3_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_4_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_5_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_6_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_7_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_8_);
			// 
			// lstResults_ColumnHeader_1_
			// 
			this.lstResults_ColumnHeader_1_.Text = "Model";
			this.lstResults_ColumnHeader_1_.Width = 101;
			// 
			// lstResults_ColumnHeader_2_
			// 
			this.lstResults_ColumnHeader_2_.Text = "Manufacturer";
			this.lstResults_ColumnHeader_2_.Width = 101;
			// 
			// lstResults_ColumnHeader_3_
			// 
			this.lstResults_ColumnHeader_3_.Text = "Class";
			this.lstResults_ColumnHeader_3_.Width = 101;
			// 
			// lstResults_ColumnHeader_4_
			// 
			this.lstResults_ColumnHeader_4_.Text = "Body Style";
			this.lstResults_ColumnHeader_4_.Width = 101;
			// 
			// lstResults_ColumnHeader_5_
			// 
			this.lstResults_ColumnHeader_5_.Text = "Transmission";
			this.lstResults_ColumnHeader_5_.Width = 97;
			// 
			// lstResults_ColumnHeader_6_
			// 
			this.lstResults_ColumnHeader_6_.Text = "Price";
			this.lstResults_ColumnHeader_6_.Width = 97;
			// 
			// lstResults_ColumnHeader_7_
			// 
			this.lstResults_ColumnHeader_7_.Text = "Year of Production";
			this.lstResults_ColumnHeader_7_.Width = 97;
			// 
			// lstResults_ColumnHeader_8_
			// 
			this.lstResults_ColumnHeader_8_.Text = "Quantity";
			this.lstResults_ColumnHeader_8_.Width = 97;
			// 
			// pnlFilters
			// 
			this.pnlFilters.AllowDrop = true;
			this.pnlFilters.BackColor = System.Drawing.SystemColors.Control;
			this.pnlFilters.Controls.Add(this.cmbYear);
			this.pnlFilters.Controls.Add(this.cmbManufacturer);
			this.pnlFilters.Controls.Add(this.cmdResetFilters);
			this.pnlFilters.Controls.Add(this.Label11);
			this.pnlFilters.Controls.Add(this.cmbPrice);
			this.pnlFilters.Controls.Add(this.Label5);
			this.pnlFilters.Controls.Add(this.cmbTransmission);
			this.pnlFilters.Controls.Add(this.Label4);
			this.pnlFilters.Controls.Add(this.cmbBodyStyle);
			this.pnlFilters.Controls.Add(this.cmbClass);
			this.pnlFilters.Controls.Add(this.Label3);
			this.pnlFilters.Controls.Add(this.Label1);
			this.pnlFilters.Controls.Add(this.Label2);
			this.pnlFilters.Controls.Add(this.chkUseAllFilters);
			this.pnlFilters.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			this.pnlFilters.Enabled = true;
			this.pnlFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.pnlFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnlFilters.Location = new System.Drawing.Point(8, 0);
			this.pnlFilters.Name = "pnlFilters";
			this.pnlFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pnlFilters.Size = new System.Drawing.Size(449, 217);
			this.pnlFilters.TabIndex = 6;
			this.pnlFilters.Text = "Filters";
			this.pnlFilters.Visible = true;
			// 
			// cmbYear
			// 
			this.cmbYear.AllowDrop = true;
			this.cmbYear.BackColor = System.Drawing.SystemColors.Window;
			this.cmbYear.CausesValidation = true;
			this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbYear.Enabled = true;
			this.cmbYear.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbYear.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbYear.IntegralHeight = true;
			this.cmbYear.Location = new System.Drawing.Point(264, 176);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbYear.Size = new System.Drawing.Size(169, 26);
			this.cmbYear.Sorted = false;
			this.cmbYear.TabIndex = 22;
			this.cmbYear.TabStop = true;
			this.cmbYear.Visible = true;
			this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
			// 
			// cmbManufacturer
			// 
			this.cmbManufacturer.AllowDrop = true;
			this.cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			this.cmbManufacturer.CausesValidation = true;
			this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbManufacturer.Enabled = true;
			this.cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbManufacturer.IntegralHeight = true;
			this.cmbManufacturer.Location = new System.Drawing.Point(16, 64);
			this.cmbManufacturer.Name = "cmbManufacturer";
			this.cmbManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbManufacturer.Size = new System.Drawing.Size(177, 26);
			this.cmbManufacturer.Sorted = false;
			this.cmbManufacturer.TabIndex = 8;
			this.cmbManufacturer.TabStop = true;
			this.cmbManufacturer.Visible = true;
			this.cmbManufacturer.SelectedIndexChanged += new System.EventHandler(this.cmbManufacturer_SelectedIndexChanged);
			// 
			// cmdResetFilters
			// 
			this.cmdResetFilters.AllowDrop = true;
			this.cmdResetFilters.BackColor = System.Drawing.SystemColors.Control;
			this.cmdResetFilters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdResetFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdResetFilters.Location = new System.Drawing.Point(280, 16);
			this.cmdResetFilters.Name = "cmdResetFilters";
			this.cmdResetFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdResetFilters.Size = new System.Drawing.Size(137, 25);
			this.cmdResetFilters.TabIndex = 7;
			this.cmdResetFilters.Text = "Reset Filters";
			this.cmdResetFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdResetFilters.UseVisualStyleBackColor = false;
			this.cmdResetFilters.Click += new System.EventHandler(this.cmdResetFilters_Click);
			// 
			// Label11
			// 
			this.Label11.AllowDrop = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label11.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(264, 160);
			this.Label11.MinimumSize = new System.Drawing.Size(161, 17);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(161, 17);
			this.Label11.TabIndex = 21;
			this.Label11.Text = "Year of Production";
			// 
			// cmbPrice
			// 
			this.cmbPrice.AllowDrop = true;
			this.cmbPrice.BackColor = System.Drawing.SystemColors.Window;
			this.cmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPrice.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbPrice.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbPrice.Location = new System.Drawing.Point(16, 176);
			this.cmbPrice.Name = "cmbPrice";
			this.cmbPrice.Size = new System.Drawing.Size(177, 26);
			this.cmbPrice.TabIndex = 18;
			this.cmbPrice.Text = "cmbPrice";
			this.cmbPrice.SelectedIndexChanged += new System.EventHandler(this.cmbPrice_SelectedIndexChanged);
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(16, 160);
			this.Label5.MinimumSize = new System.Drawing.Size(177, 17);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(177, 17);
			this.Label5.TabIndex = 17;
			this.Label5.Text = "Price Range";
			// 
			// cmbTransmission
			// 
			this.cmbTransmission.AllowDrop = true;
			this.cmbTransmission.BackColor = System.Drawing.SystemColors.Window;
			this.cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTransmission.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbTransmission.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbTransmission.Location = new System.Drawing.Point(264, 120);
			this.cmbTransmission.Name = "cmbTransmission";
			this.cmbTransmission.Size = new System.Drawing.Size(169, 26);
			this.cmbTransmission.TabIndex = 16;
			this.cmbTransmission.Text = "cmbTransmission";
			this.cmbTransmission.Items.AddRange(new object[]{"Automatic", "Manual"});
			this.cmbTransmission.SelectedIndexChanged += new System.EventHandler(this.cmbTransmission_SelectedIndexChanged);
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(264, 104);
			this.Label4.MinimumSize = new System.Drawing.Size(177, 17);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(177, 17);
			this.Label4.TabIndex = 15;
			this.Label4.Text = "Transmission";
			// 
			// cmbBodyStyle
			// 
			this.cmbBodyStyle.AllowDrop = true;
			this.cmbBodyStyle.BackColor = System.Drawing.SystemColors.Window;
			this.cmbBodyStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBodyStyle.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbBodyStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbBodyStyle.Location = new System.Drawing.Point(16, 120);
			this.cmbBodyStyle.Name = "cmbBodyStyle";
			this.cmbBodyStyle.Size = new System.Drawing.Size(177, 26);
			this.cmbBodyStyle.TabIndex = 14;
			this.cmbBodyStyle.Text = "cmbBodyStyle";
			this.cmbBodyStyle.SelectedIndexChanged += new System.EventHandler(this.cmbBodyStyle_SelectedIndexChanged);
			// 
			// cmbClass
			// 
			this.cmbClass.AllowDrop = true;
			this.cmbClass.BackColor = System.Drawing.SystemColors.Window;
			this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbClass.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbClass.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbClass.Location = new System.Drawing.Point(264, 64);
			this.cmbClass.Name = "cmbClass";
			this.cmbClass.Size = new System.Drawing.Size(169, 26);
			this.cmbClass.TabIndex = 13;
			this.cmbClass.Text = "cmbClass";
			this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(16, 104);
			this.Label3.MinimumSize = new System.Drawing.Size(177, 17);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(177, 17);
			this.Label3.TabIndex = 12;
			this.Label3.Text = "Body Style";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(16, 48);
			this.Label1.MinimumSize = new System.Drawing.Size(169, 17);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(169, 17);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Manufacturer";
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(264, 48);
			this.Label2.MinimumSize = new System.Drawing.Size(169, 17);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(169, 17);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Class";
			// 
			// chkUseAllFilters
			// 
			this.chkUseAllFilters.AllowDrop = true;
			this.chkUseAllFilters.BackColor = System.Drawing.SystemColors.Control;
			this.chkUseAllFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkUseAllFilters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkUseAllFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkUseAllFilters.Location = new System.Drawing.Point(16, 16);
			this.chkUseAllFilters.Name = "chkUseAllFilters";
			this.chkUseAllFilters.Size = new System.Drawing.Size(177, 25);
			this.chkUseAllFilters.TabIndex = 9;
			this.chkUseAllFilters.Text = "Use all filters?";
			this.chkUseAllFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkUseAllFilters.CheckStateChanged += new System.EventHandler(this.chkUseAllFilters_CheckStateChanged);
			// 
			// chkFilters
			// 
			this.chkFilters.AllowDrop = true;
			this.chkFilters.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkFilters.BackColor = System.Drawing.SystemColors.Control;
			this.chkFilters.CausesValidation = true;
			this.chkFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkFilters.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkFilters.Enabled = true;
			this.chkFilters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkFilters.Location = new System.Drawing.Point(288, 80);
			this.chkFilters.Name = "chkFilters";
			this.chkFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkFilters.Size = new System.Drawing.Size(193, 25);
			this.chkFilters.TabIndex = 1;
			this.chkFilters.TabStop = true;
			this.chkFilters.Text = "Show filters";
			this.chkFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkFilters.Visible = true;
			this.chkFilters.CheckStateChanged += new System.EventHandler(this.chkFilters_CheckStateChanged);
			// 
			// cmbModel
			// 
			this.cmbModel.AllowDrop = true;
			this.cmbModel.BackColor = System.Drawing.SystemColors.Window;
			this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbModel.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbModel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbModel.Location = new System.Drawing.Point(24, 80);
			this.cmbModel.Name = "cmbModel";
			this.cmbModel.Size = new System.Drawing.Size(209, 26);
			this.cmbModel.TabIndex = 2;
			this.cmbModel.Text = "cmbModel";
			// 
			// btnDelete
			// 
			this.btnDelete.AllowDrop = true;
			this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
			this.btnDelete.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.ForeColor = System.Drawing.Color.Empty;
			this.btnDelete.Location = new System.Drawing.Point(168, 544);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(169, 65);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(24, 64);
			this.Label6.MinimumSize = new System.Drawing.Size(209, 17);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(209, 17);
			this.Label6.TabIndex = 3;
			this.Label6.Text = "Model Name";
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
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Vehicle";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmDeleteVehicle
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(517, 623);
			this.Controls.Add(this.frameFilters);
			this.Controls.Add(this.chkFilters);
			this.Controls.Add(this.cmbModel);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmDeleteVehicle.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDeleteVehicle";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Vehicle Model";
			this.checkBoxHelper1.SetStyle(this.chkUseAllFilters, 0);
			this.commandButtonHelper1.SetStyle(this.cmdResetFilters, 0);
			this.commandButtonHelper1.SetStyle(this.btnDelete, 0);
			this.listBoxComboBoxHelper1.SetItemData(this.cmbTransmission, new int[]{0, 1});
			this.ToolTipMain.SetToolTip(this.cmbPrice, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbTransmission, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbBodyStyle, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbClass, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbModel, "Manufacturer");
			this.Activated += new System.EventHandler(this.frmDeleteVehicle_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).EndInit();
			this.frameFilters.ResumeLayout(false);
			this.pnlResults.ResumeLayout(false);
			this.lstResults.ResumeLayout(false);
			this.pnlFilters.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}