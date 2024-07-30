
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteVehicle));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			frameFilters = new System.Windows.Forms.Panel();
			pnlResults = new System.Windows.Forms.GroupBox();
			lstResults = new System.Windows.Forms.ListView();
			lstResults_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_8_ = new System.Windows.Forms.ColumnHeader();
			pnlFilters = new System.Windows.Forms.GroupBox();
			cmbYear = new System.Windows.Forms.ComboBox();
			cmbManufacturer = new System.Windows.Forms.ComboBox();
			cmdResetFilters = new System.Windows.Forms.Button();
			Label11 = new System.Windows.Forms.Label();
			cmbPrice = new System.Windows.Forms.ComboBox();
			Label5 = new System.Windows.Forms.Label();
			cmbTransmission = new System.Windows.Forms.ComboBox();
			Label4 = new System.Windows.Forms.Label();
			cmbBodyStyle = new System.Windows.Forms.ComboBox();
			cmbClass = new System.Windows.Forms.ComboBox();
			Label3 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label2 = new System.Windows.Forms.Label();
			chkUseAllFilters = new System.Windows.Forms.CheckBox();
			chkFilters = new System.Windows.Forms.CheckBox();
			cmbModel = new System.Windows.Forms.ComboBox();
			btnDelete = new System.Windows.Forms.Button();
			Label6 = new System.Windows.Forms.Label();
			lblTitle = new System.Windows.Forms.Label();
			frameFilters.SuspendLayout();
			pnlResults.SuspendLayout();
			lstResults.SuspendLayout();
			pnlFilters.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			checkBoxHelper1 = new UpgradeHelpers.Gui.Controls.CheckBoxHelper(components);
			listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.Controls.ListControlHelper(components);
			((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// frameFilters
			// 
			frameFilters.AllowDrop = true;
			frameFilters.BackColor = System.Drawing.SystemColors.Control;
			frameFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			frameFilters.Controls.Add(pnlResults);
			frameFilters.Controls.Add(pnlFilters);
			frameFilters.Enabled = true;
			frameFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			frameFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			frameFilters.Location = new System.Drawing.Point(24, 120);
			frameFilters.Name = "frameFilters";
			frameFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			frameFilters.Size = new System.Drawing.Size(465, 409);
			frameFilters.TabIndex = 5;
			frameFilters.Visible = true;
			// 
			// pnlResults
			// 
			pnlResults.AllowDrop = true;
			pnlResults.BackColor = System.Drawing.SystemColors.Control;
			pnlResults.Controls.Add(lstResults);
			pnlResults.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			pnlResults.Enabled = true;
			pnlResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			pnlResults.ForeColor = System.Drawing.SystemColors.ControlText;
			pnlResults.Location = new System.Drawing.Point(8, 232);
			pnlResults.Name = "pnlResults";
			pnlResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
			pnlResults.Size = new System.Drawing.Size(449, 169);
			pnlResults.TabIndex = 19;
			pnlResults.Text = "Results";
			pnlResults.Visible = true;
			// 
			// lstResults
			// 
			lstResults.AllowDrop = true;
			lstResults.BackColor = System.Drawing.SystemColors.Window;
			lstResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lstResults.Font = new System.Drawing.Font("Consolas", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lstResults.ForeColor = System.Drawing.SystemColors.WindowText;
			lstResults.HideSelection = true;
			lstResults.LabelEdit = true;
			lstResults.Location = new System.Drawing.Point(16, 16);
			lstResults.MultiSelect = false;
			lstResults.Name = "lstResults";
			lstResults.Size = new System.Drawing.Size(417, 145);
			lstResults.TabIndex = 20;
			lstResults.View = System.Windows.Forms.View.Details;
			lstResults.Columns.Add(lstResults_ColumnHeader_1_);
			lstResults.Columns.Add(lstResults_ColumnHeader_2_);
			lstResults.Columns.Add(lstResults_ColumnHeader_3_);
			lstResults.Columns.Add(lstResults_ColumnHeader_4_);
			lstResults.Columns.Add(lstResults_ColumnHeader_5_);
			lstResults.Columns.Add(lstResults_ColumnHeader_6_);
			lstResults.Columns.Add(lstResults_ColumnHeader_7_);
			lstResults.Columns.Add(lstResults_ColumnHeader_8_);
			// 
			// lstResults_ColumnHeader_1_
			// 
			lstResults_ColumnHeader_1_.Text = "Model";
			lstResults_ColumnHeader_1_.Width = 101;
			// 
			// lstResults_ColumnHeader_2_
			// 
			lstResults_ColumnHeader_2_.Text = "Manufacturer";
			lstResults_ColumnHeader_2_.Width = 101;
			// 
			// lstResults_ColumnHeader_3_
			// 
			lstResults_ColumnHeader_3_.Text = "Class";
			lstResults_ColumnHeader_3_.Width = 101;
			// 
			// lstResults_ColumnHeader_4_
			// 
			lstResults_ColumnHeader_4_.Text = "Body Style";
			lstResults_ColumnHeader_4_.Width = 101;
			// 
			// lstResults_ColumnHeader_5_
			// 
			lstResults_ColumnHeader_5_.Text = "Transmission";
			lstResults_ColumnHeader_5_.Width = 97;
			// 
			// lstResults_ColumnHeader_6_
			// 
			lstResults_ColumnHeader_6_.Text = "Price";
			lstResults_ColumnHeader_6_.Width = 97;
			// 
			// lstResults_ColumnHeader_7_
			// 
			lstResults_ColumnHeader_7_.Text = "Year of Production";
			lstResults_ColumnHeader_7_.Width = 97;
			// 
			// lstResults_ColumnHeader_8_
			// 
			lstResults_ColumnHeader_8_.Text = "Quantity";
			lstResults_ColumnHeader_8_.Width = 97;
			// 
			// pnlFilters
			// 
			pnlFilters.AllowDrop = true;
			pnlFilters.BackColor = System.Drawing.SystemColors.Control;
			pnlFilters.Controls.Add(cmbYear);
			pnlFilters.Controls.Add(cmbManufacturer);
			pnlFilters.Controls.Add(cmdResetFilters);
			pnlFilters.Controls.Add(Label11);
			pnlFilters.Controls.Add(cmbPrice);
			pnlFilters.Controls.Add(Label5);
			pnlFilters.Controls.Add(cmbTransmission);
			pnlFilters.Controls.Add(Label4);
			pnlFilters.Controls.Add(cmbBodyStyle);
			pnlFilters.Controls.Add(cmbClass);
			pnlFilters.Controls.Add(Label3);
			pnlFilters.Controls.Add(Label1);
			pnlFilters.Controls.Add(Label2);
			pnlFilters.Controls.Add(chkUseAllFilters);
			pnlFilters.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			pnlFilters.Enabled = true;
			pnlFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			pnlFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			pnlFilters.Location = new System.Drawing.Point(8, 0);
			pnlFilters.Name = "pnlFilters";
			pnlFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			pnlFilters.Size = new System.Drawing.Size(449, 217);
			pnlFilters.TabIndex = 6;
			pnlFilters.Text = "Filters";
			pnlFilters.Visible = true;
			// 
			// cmbYear
			// 
			cmbYear.AllowDrop = true;
			cmbYear.BackColor = System.Drawing.SystemColors.Window;
			cmbYear.CausesValidation = true;
			cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbYear.Enabled = true;
			cmbYear.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbYear.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbYear.IntegralHeight = true;
			cmbYear.Location = new System.Drawing.Point(264, 176);
			cmbYear.Name = "cmbYear";
			cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmbYear.Size = new System.Drawing.Size(169, 26);
			cmbYear.Sorted = false;
			cmbYear.TabIndex = 22;
			cmbYear.TabStop = true;
			cmbYear.Visible = true;
			cmbYear.SelectedIndexChanged += new System.EventHandler(cmbYear_SelectedIndexChanged);
			// 
			// cmbManufacturer
			// 
			cmbManufacturer.AllowDrop = true;
			cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			cmbManufacturer.CausesValidation = true;
			cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbManufacturer.Enabled = true;
			cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbManufacturer.IntegralHeight = true;
			cmbManufacturer.Location = new System.Drawing.Point(16, 64);
			cmbManufacturer.Name = "cmbManufacturer";
			cmbManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmbManufacturer.Size = new System.Drawing.Size(177, 26);
			cmbManufacturer.Sorted = false;
			cmbManufacturer.TabIndex = 8;
			cmbManufacturer.TabStop = true;
			cmbManufacturer.Visible = true;
			cmbManufacturer.SelectedIndexChanged += new System.EventHandler(cmbManufacturer_SelectedIndexChanged);
			// 
			// cmdResetFilters
			// 
			cmdResetFilters.AllowDrop = true;
			cmdResetFilters.BackColor = System.Drawing.SystemColors.Control;
			cmdResetFilters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdResetFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdResetFilters.Location = new System.Drawing.Point(280, 16);
			cmdResetFilters.Name = "cmdResetFilters";
			cmdResetFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdResetFilters.Size = new System.Drawing.Size(137, 25);
			cmdResetFilters.TabIndex = 7;
			cmdResetFilters.Text = "Reset Filters";
			cmdResetFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdResetFilters.UseVisualStyleBackColor = false;
			cmdResetFilters.Click += new System.EventHandler(cmdResetFilters_Click);
			// 
			// Label11
			// 
			Label11.AllowDrop = true;
			Label11.BackColor = System.Drawing.SystemColors.Control;
			Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label11.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			Label11.Location = new System.Drawing.Point(264, 160);
			Label11.MinimumSize = new System.Drawing.Size(161, 17);
			Label11.Name = "Label11";
			Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label11.Size = new System.Drawing.Size(161, 17);
			Label11.TabIndex = 21;
			Label11.Text = "Year of Production";
			// 
			// cmbPrice
			// 
			cmbPrice.AllowDrop = true;
			cmbPrice.BackColor = System.Drawing.SystemColors.Window;
			cmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbPrice.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbPrice.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbPrice.Location = new System.Drawing.Point(16, 176);
			cmbPrice.Name = "cmbPrice";
			cmbPrice.Size = new System.Drawing.Size(177, 26);
			cmbPrice.TabIndex = 18;
			cmbPrice.Text = "cmbPrice";
			cmbPrice.SelectedIndexChanged += new System.EventHandler(cmbPrice_SelectedIndexChanged);
			// 
			// Label5
			// 
			Label5.AllowDrop = true;
			Label5.BackColor = System.Drawing.SystemColors.Control;
			Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label5.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			Label5.Location = new System.Drawing.Point(16, 160);
			Label5.MinimumSize = new System.Drawing.Size(177, 17);
			Label5.Name = "Label5";
			Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label5.Size = new System.Drawing.Size(177, 17);
			Label5.TabIndex = 17;
			Label5.Text = "Price Range";
			// 
			// cmbTransmission
			// 
			cmbTransmission.AllowDrop = true;
			cmbTransmission.BackColor = System.Drawing.SystemColors.Window;
			cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbTransmission.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbTransmission.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbTransmission.Location = new System.Drawing.Point(264, 120);
			cmbTransmission.Name = "cmbTransmission";
			cmbTransmission.Size = new System.Drawing.Size(169, 26);
			cmbTransmission.TabIndex = 16;
			cmbTransmission.Text = "cmbTransmission";
			cmbTransmission.Items.AddRange(new object[]{"Automatic", "Manual"});
			cmbTransmission.SelectedIndexChanged += new System.EventHandler(cmbTransmission_SelectedIndexChanged);
			// 
			// Label4
			// 
			Label4.AllowDrop = true;
			Label4.BackColor = System.Drawing.SystemColors.Control;
			Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label4.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			Label4.Location = new System.Drawing.Point(264, 104);
			Label4.MinimumSize = new System.Drawing.Size(177, 17);
			Label4.Name = "Label4";
			Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label4.Size = new System.Drawing.Size(177, 17);
			Label4.TabIndex = 15;
			Label4.Text = "Transmission";
			// 
			// cmbBodyStyle
			// 
			cmbBodyStyle.AllowDrop = true;
			cmbBodyStyle.BackColor = System.Drawing.SystemColors.Window;
			cmbBodyStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbBodyStyle.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbBodyStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbBodyStyle.Location = new System.Drawing.Point(16, 120);
			cmbBodyStyle.Name = "cmbBodyStyle";
			cmbBodyStyle.Size = new System.Drawing.Size(177, 26);
			cmbBodyStyle.TabIndex = 14;
			cmbBodyStyle.Text = "cmbBodyStyle";
			cmbBodyStyle.SelectedIndexChanged += new System.EventHandler(cmbBodyStyle_SelectedIndexChanged);
			// 
			// cmbClass
			// 
			cmbClass.AllowDrop = true;
			cmbClass.BackColor = System.Drawing.SystemColors.Window;
			cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbClass.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbClass.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbClass.Location = new System.Drawing.Point(264, 64);
			cmbClass.Name = "cmbClass";
			cmbClass.Size = new System.Drawing.Size(169, 26);
			cmbClass.TabIndex = 13;
			cmbClass.Text = "cmbClass";
			cmbClass.SelectedIndexChanged += new System.EventHandler(cmbClass_SelectedIndexChanged);
			// 
			// Label3
			// 
			Label3.AllowDrop = true;
			Label3.BackColor = System.Drawing.SystemColors.Control;
			Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label3.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			Label3.Location = new System.Drawing.Point(16, 104);
			Label3.MinimumSize = new System.Drawing.Size(177, 17);
			Label3.Name = "Label3";
			Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label3.Size = new System.Drawing.Size(177, 17);
			Label3.TabIndex = 12;
			Label3.Text = "Body Style";
			// 
			// Label1
			// 
			Label1.AllowDrop = true;
			Label1.BackColor = System.Drawing.SystemColors.Control;
			Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label1.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			Label1.Location = new System.Drawing.Point(16, 48);
			Label1.MinimumSize = new System.Drawing.Size(169, 17);
			Label1.Name = "Label1";
			Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label1.Size = new System.Drawing.Size(169, 17);
			Label1.TabIndex = 11;
			Label1.Text = "Manufacturer";
			// 
			// Label2
			// 
			Label2.AllowDrop = true;
			Label2.BackColor = System.Drawing.SystemColors.Control;
			Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label2.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			Label2.Location = new System.Drawing.Point(264, 48);
			Label2.MinimumSize = new System.Drawing.Size(169, 17);
			Label2.Name = "Label2";
			Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label2.Size = new System.Drawing.Size(169, 17);
			Label2.TabIndex = 10;
			Label2.Text = "Class";
			// 
			// chkUseAllFilters
			// 
			chkUseAllFilters.AllowDrop = true;
			chkUseAllFilters.BackColor = System.Drawing.SystemColors.Control;
			chkUseAllFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkUseAllFilters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			chkUseAllFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			chkUseAllFilters.Location = new System.Drawing.Point(16, 16);
			chkUseAllFilters.Name = "chkUseAllFilters";
			chkUseAllFilters.Size = new System.Drawing.Size(177, 25);
			chkUseAllFilters.TabIndex = 9;
			chkUseAllFilters.Text = "Use all filters?";
			chkUseAllFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkUseAllFilters.CheckStateChanged += new System.EventHandler(chkUseAllFilters_CheckStateChanged);
			// 
			// chkFilters
			// 
			chkFilters.AllowDrop = true;
			chkFilters.Appearance = System.Windows.Forms.Appearance.Normal;
			chkFilters.BackColor = System.Drawing.SystemColors.Control;
			chkFilters.CausesValidation = true;
			chkFilters.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkFilters.CheckState = System.Windows.Forms.CheckState.Unchecked;
			chkFilters.Enabled = true;
			chkFilters.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			chkFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			chkFilters.Location = new System.Drawing.Point(288, 80);
			chkFilters.Name = "chkFilters";
			chkFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			chkFilters.Size = new System.Drawing.Size(193, 25);
			chkFilters.TabIndex = 1;
			chkFilters.TabStop = true;
			chkFilters.Text = "Show filters";
			chkFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkFilters.Visible = true;
			chkFilters.CheckStateChanged += new System.EventHandler(chkFilters_CheckStateChanged);
			// 
			// cmbModel
			// 
			cmbModel.AllowDrop = true;
			cmbModel.BackColor = System.Drawing.SystemColors.Window;
			cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbModel.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbModel.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbModel.Location = new System.Drawing.Point(24, 80);
			cmbModel.Name = "cmbModel";
			cmbModel.Size = new System.Drawing.Size(209, 26);
			cmbModel.TabIndex = 2;
			cmbModel.Text = "cmbModel";
			// 
			// btnDelete
			// 
			btnDelete.AllowDrop = true;
			btnDelete.BackColor = System.Drawing.SystemColors.Control;
			btnDelete.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnDelete.ForeColor = System.Drawing.Color.Empty;
			btnDelete.Location = new System.Drawing.Point(168, 544);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new System.Drawing.Size(169, 65);
			btnDelete.TabIndex = 4;
			btnDelete.Text = "&Delete";
			btnDelete.Click += new System.EventHandler(btnDelete_Click);
			// 
			// Label6
			// 
			Label6.AllowDrop = true;
			Label6.BackColor = System.Drawing.SystemColors.Control;
			Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			Label6.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			Label6.Location = new System.Drawing.Point(24, 64);
			Label6.MinimumSize = new System.Drawing.Size(209, 17);
			Label6.Name = "Label6";
			Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			Label6.Size = new System.Drawing.Size(209, 17);
			Label6.TabIndex = 3;
			Label6.Text = "Model Name";
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
			lblTitle.Text = "Vehicle";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmDeleteVehicle
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(517, 623);
			Controls.Add(frameFilters);
			Controls.Add(chkFilters);
			Controls.Add(cmbModel);
			Controls.Add(btnDelete);
			Controls.Add(Label6);
			Controls.Add(lblTitle);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmDeleteVehicle.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmDeleteVehicle";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Delete Vehicle Model";
			checkBoxHelper1.SetStyle(chkUseAllFilters, 0);
			commandButtonHelper1.SetStyle(cmdResetFilters, 0);
			commandButtonHelper1.SetStyle(btnDelete, 0);
			listBoxComboBoxHelper1.SetItemData(cmbTransmission, new int[]{0, 1});
			ToolTipMain.SetToolTip(cmbPrice, "Manufacturer");
			ToolTipMain.SetToolTip(cmbTransmission, "Manufacturer");
			ToolTipMain.SetToolTip(cmbBodyStyle, "Manufacturer");
			ToolTipMain.SetToolTip(cmbClass, "Manufacturer");
			ToolTipMain.SetToolTip(cmbModel, "Manufacturer");
			Activated += new System.EventHandler(frmDeleteVehicle_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			((System.ComponentModel.ISupportInitialize) listBoxComboBoxHelper1).EndInit();
			frameFilters.ResumeLayout(false);
			pnlResults.ResumeLayout(false);
			lstResults.ResumeLayout(false);
			pnlFilters.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}