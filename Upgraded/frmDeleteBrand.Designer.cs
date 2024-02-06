
namespace StarCarsManagement
{
	partial class frmDeleteBrand
	{

		#region "Upgrade Support "
		private static frmDeleteBrand m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmDeleteBrand DefInstance
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
		public static frmDeleteBrand CreateInstance()
		{
			frmDeleteBrand theInstance = new frmDeleteBrand();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 20);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdResetFilters", "cmbHeadquarter", "chkUseAllFilters", "cmbParent", "cmbAreaServed", "Label2", "Label1", "Label3", "pnlFilters", "lstResults_ColumnHeader_1_", "lstResults_ColumnHeader_2_", "lstResults_ColumnHeader_3_", "lstResults_ColumnHeader_4_", "lstResults", "pnlResults", "frameFilters", "chkFilters", "cmbManufacturer", "btnDelete", "Label6", "lblTitle", "listViewHelper1", "checkBoxHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdResetFilters;
		public System.Windows.Forms.ComboBox cmbHeadquarter;
		public System.Windows.Forms.CheckBox chkUseAllFilters;
		public System.Windows.Forms.ComboBox cmbParent;
		public System.Windows.Forms.ComboBox cmbAreaServed;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox pnlFilters;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lstResults_ColumnHeader_4_;
		public System.Windows.Forms.ListView lstResults;
		public System.Windows.Forms.GroupBox pnlResults;
		public System.Windows.Forms.Panel frameFilters;
		public System.Windows.Forms.CheckBox chkFilters;
		public System.Windows.Forms.ComboBox cmbManufacturer;
		public System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label lblTitle;
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CheckBoxHelper checkBoxHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteBrand));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.frameFilters = new System.Windows.Forms.Panel();
			this.pnlFilters = new System.Windows.Forms.GroupBox();
			this.cmdResetFilters = new System.Windows.Forms.Button();
			this.cmbHeadquarter = new System.Windows.Forms.ComboBox();
			this.chkUseAllFilters = new System.Windows.Forms.CheckBox();
			this.cmbParent = new System.Windows.Forms.ComboBox();
			this.cmbAreaServed = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.pnlResults = new System.Windows.Forms.GroupBox();
			this.lstResults = new System.Windows.Forms.ListView();
			this.lstResults_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.lstResults_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			this.chkFilters = new System.Windows.Forms.CheckBox();
			this.cmbManufacturer = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.frameFilters.SuspendLayout();
			this.pnlFilters.SuspendLayout();
			this.pnlResults.SuspendLayout();
			this.lstResults.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			this.checkBoxHelper1 = new UpgradeHelpers.Gui.Controls.CheckBoxHelper(this.components);
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// frameFilters
			// 
			this.frameFilters.AllowDrop = true;
			this.frameFilters.BackColor = System.Drawing.SystemColors.Control;
			this.frameFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.frameFilters.Controls.Add(this.pnlFilters);
			this.frameFilters.Controls.Add(this.pnlResults);
			this.frameFilters.Enabled = true;
			this.frameFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.frameFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frameFilters.Location = new System.Drawing.Point(24, 120);
			this.frameFilters.Name = "frameFilters";
			this.frameFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frameFilters.Size = new System.Drawing.Size(465, 393);
			this.frameFilters.TabIndex = 5;
			this.frameFilters.Visible = true;
			// 
			// pnlFilters
			// 
			this.pnlFilters.AllowDrop = true;
			this.pnlFilters.BackColor = System.Drawing.SystemColors.Control;
			this.pnlFilters.Controls.Add(this.cmdResetFilters);
			this.pnlFilters.Controls.Add(this.cmbHeadquarter);
			this.pnlFilters.Controls.Add(this.chkUseAllFilters);
			this.pnlFilters.Controls.Add(this.cmbParent);
			this.pnlFilters.Controls.Add(this.cmbAreaServed);
			this.pnlFilters.Controls.Add(this.Label2);
			this.pnlFilters.Controls.Add(this.Label1);
			this.pnlFilters.Controls.Add(this.Label3);
			this.pnlFilters.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			this.pnlFilters.Enabled = true;
			this.pnlFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.pnlFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnlFilters.Location = new System.Drawing.Point(8, 0);
			this.pnlFilters.Name = "pnlFilters";
			this.pnlFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pnlFilters.Size = new System.Drawing.Size(449, 169);
			this.pnlFilters.TabIndex = 8;
			this.pnlFilters.Text = "Filters";
			this.pnlFilters.Visible = true;
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
			this.cmdResetFilters.TabIndex = 15;
			this.cmdResetFilters.Text = "Reset Filters";
			this.cmdResetFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdResetFilters.UseVisualStyleBackColor = false;
			this.cmdResetFilters.Click += new System.EventHandler(this.cmdResetFilters_Click);
			// 
			// cmbHeadquarter
			// 
			this.cmbHeadquarter.AllowDrop = true;
			this.cmbHeadquarter.BackColor = System.Drawing.SystemColors.Window;
			this.cmbHeadquarter.CausesValidation = true;
			this.cmbHeadquarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHeadquarter.Enabled = true;
			this.cmbHeadquarter.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbHeadquarter.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbHeadquarter.IntegralHeight = true;
			this.cmbHeadquarter.Location = new System.Drawing.Point(16, 64);
			this.cmbHeadquarter.Name = "cmbHeadquarter";
			this.cmbHeadquarter.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbHeadquarter.Size = new System.Drawing.Size(177, 26);
			this.cmbHeadquarter.Sorted = false;
			this.cmbHeadquarter.TabIndex = 9;
			this.cmbHeadquarter.TabStop = true;
			this.cmbHeadquarter.Visible = true;
			this.cmbHeadquarter.SelectedIndexChanged += new System.EventHandler(this.cmbHeadquarter_SelectedIndexChanged);
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
			this.chkUseAllFilters.TabIndex = 16;
			this.chkUseAllFilters.Text = "Use all filters?";
			this.chkUseAllFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbParent
			// 
			this.cmbParent.AllowDrop = true;
			this.cmbParent.BackColor = System.Drawing.SystemColors.Window;
			this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParent.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbParent.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbParent.Location = new System.Drawing.Point(264, 64);
			this.cmbParent.Name = "cmbParent";
			this.cmbParent.Size = new System.Drawing.Size(169, 26);
			this.cmbParent.TabIndex = 10;
			this.cmbParent.Text = "cmbParent";
			this.cmbParent.SelectedIndexChanged += new System.EventHandler(this.cmbParent_SelectedIndexChanged);
			// 
			// cmbAreaServed
			// 
			this.cmbAreaServed.AllowDrop = true;
			this.cmbAreaServed.BackColor = System.Drawing.SystemColors.Window;
			this.cmbAreaServed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAreaServed.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbAreaServed.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbAreaServed.Location = new System.Drawing.Point(16, 120);
			this.cmbAreaServed.Name = "cmbAreaServed";
			this.cmbAreaServed.Size = new System.Drawing.Size(177, 26);
			this.cmbAreaServed.TabIndex = 11;
			this.cmbAreaServed.Text = "cmbAreaServed";
			this.cmbAreaServed.SelectedIndexChanged += new System.EventHandler(this.cmbAreaServed_SelectedIndexChanged);
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(264, 48);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(169, 17);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Parent Company";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(16, 48);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(169, 17);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Headquarter";
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Consolas", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(16, 104);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(177, 17);
			this.Label3.TabIndex = 12;
			this.Label3.Text = "Area Served";
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
			this.pnlResults.Location = new System.Drawing.Point(8, 184);
			this.pnlResults.Name = "pnlResults";
			this.pnlResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.pnlResults.Size = new System.Drawing.Size(449, 201);
			this.pnlResults.TabIndex = 6;
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
			this.lstResults.Size = new System.Drawing.Size(417, 177);
			this.lstResults.TabIndex = 7;
			this.lstResults.View = System.Windows.Forms.View.Details;
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_1_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_2_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_3_);
			this.lstResults.Columns.Add(this.lstResults_ColumnHeader_4_);
			// 
			// lstResults_ColumnHeader_1_
			// 
			this.lstResults_ColumnHeader_1_.Text = "Name";
			this.lstResults_ColumnHeader_1_.Width = 101;
			// 
			// lstResults_ColumnHeader_2_
			// 
			this.lstResults_ColumnHeader_2_.Text = "Headquarter";
			this.lstResults_ColumnHeader_2_.Width = 101;
			// 
			// lstResults_ColumnHeader_3_
			// 
			this.lstResults_ColumnHeader_3_.Text = "Parent Company";
			this.lstResults_ColumnHeader_3_.Width = 114;
			// 
			// lstResults_ColumnHeader_4_
			// 
			this.lstResults_ColumnHeader_4_.Text = "Area Served";
			this.lstResults_ColumnHeader_4_.Width = 101;
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
			this.chkFilters.TabIndex = 4;
			this.chkFilters.TabStop = true;
			this.chkFilters.Text = "Show filters";
			this.chkFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkFilters.Visible = true;
			this.chkFilters.CheckStateChanged += new System.EventHandler(this.chkFilters_CheckStateChanged);
			// 
			// cmbManufacturer
			// 
			this.cmbManufacturer.AllowDrop = true;
			this.cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			this.cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbManufacturer.Location = new System.Drawing.Point(24, 80);
			this.cmbManufacturer.Name = "cmbManufacturer";
			this.cmbManufacturer.Size = new System.Drawing.Size(209, 26);
			this.cmbManufacturer.TabIndex = 2;
			this.cmbManufacturer.Text = "cmbManufacturer";
			// 
			// btnDelete
			// 
			this.btnDelete.AllowDrop = true;
			this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
			this.btnDelete.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.ForeColor = System.Drawing.Color.Empty;
			this.btnDelete.Location = new System.Drawing.Point(160, 528);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(169, 65);
			this.btnDelete.TabIndex = 3;
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
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(209, 17);
			this.Label6.TabIndex = 1;
			this.Label6.Text = "Manufacturer";
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
			this.lblTitle.Text = "Brand";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmDeleteBrand
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(514, 607);
			this.Controls.Add(this.frameFilters);
			this.Controls.Add(this.chkFilters);
			this.Controls.Add(this.cmbManufacturer);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmDeleteBrand.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDeleteBrand";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Brand";
			this.checkBoxHelper1.SetStyle(this.chkUseAllFilters, 0);
			this.commandButtonHelper1.SetStyle(this.cmdResetFilters, 0);
			this.commandButtonHelper1.SetStyle(this.btnDelete, 0);
			this.ToolTipMain.SetToolTip(this.cmbParent, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbAreaServed, "Manufacturer");
			this.ToolTipMain.SetToolTip(this.cmbManufacturer, "Manufacturer");
			this.Activated += new System.EventHandler(this.frmDeleteBrand_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
			this.frameFilters.ResumeLayout(false);
			this.pnlFilters.ResumeLayout(false);
			this.pnlResults.ResumeLayout(false);
			this.lstResults.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
		}
		#endregion
	}
}