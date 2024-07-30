
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteBrand));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			frameFilters = new System.Windows.Forms.Panel();
			pnlFilters = new System.Windows.Forms.GroupBox();
			cmdResetFilters = new System.Windows.Forms.Button();
			cmbHeadquarter = new System.Windows.Forms.ComboBox();
			chkUseAllFilters = new System.Windows.Forms.CheckBox();
			cmbParent = new System.Windows.Forms.ComboBox();
			cmbAreaServed = new System.Windows.Forms.ComboBox();
			Label2 = new System.Windows.Forms.Label();
			Label1 = new System.Windows.Forms.Label();
			Label3 = new System.Windows.Forms.Label();
			pnlResults = new System.Windows.Forms.GroupBox();
			lstResults = new System.Windows.Forms.ListView();
			lstResults_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			lstResults_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			chkFilters = new System.Windows.Forms.CheckBox();
			cmbManufacturer = new System.Windows.Forms.ComboBox();
			btnDelete = new System.Windows.Forms.Button();
			Label6 = new System.Windows.Forms.Label();
			lblTitle = new System.Windows.Forms.Label();
			frameFilters.SuspendLayout();
			pnlFilters.SuspendLayout();
			pnlResults.SuspendLayout();
			lstResults.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			checkBoxHelper1 = new UpgradeHelpers.Gui.Controls.CheckBoxHelper(components);
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// frameFilters
			// 
			frameFilters.AllowDrop = true;
			frameFilters.BackColor = System.Drawing.SystemColors.Control;
			frameFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			frameFilters.Controls.Add(pnlFilters);
			frameFilters.Controls.Add(pnlResults);
			frameFilters.Enabled = true;
			frameFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			frameFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			frameFilters.Location = new System.Drawing.Point(24, 120);
			frameFilters.Name = "frameFilters";
			frameFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			frameFilters.Size = new System.Drawing.Size(465, 393);
			frameFilters.TabIndex = 5;
			frameFilters.Visible = true;
			// 
			// pnlFilters
			// 
			pnlFilters.AllowDrop = true;
			pnlFilters.BackColor = System.Drawing.SystemColors.Control;
			pnlFilters.Controls.Add(cmdResetFilters);
			pnlFilters.Controls.Add(cmbHeadquarter);
			pnlFilters.Controls.Add(chkUseAllFilters);
			pnlFilters.Controls.Add(cmbParent);
			pnlFilters.Controls.Add(cmbAreaServed);
			pnlFilters.Controls.Add(Label2);
			pnlFilters.Controls.Add(Label1);
			pnlFilters.Controls.Add(Label3);
			pnlFilters.Cursor = UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
			pnlFilters.Enabled = true;
			pnlFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			pnlFilters.ForeColor = System.Drawing.SystemColors.ControlText;
			pnlFilters.Location = new System.Drawing.Point(8, 0);
			pnlFilters.Name = "pnlFilters";
			pnlFilters.RightToLeft = System.Windows.Forms.RightToLeft.No;
			pnlFilters.Size = new System.Drawing.Size(449, 169);
			pnlFilters.TabIndex = 8;
			pnlFilters.Text = "Filters";
			pnlFilters.Visible = true;
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
			cmdResetFilters.TabIndex = 15;
			cmdResetFilters.Text = "Reset Filters";
			cmdResetFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdResetFilters.UseVisualStyleBackColor = false;
			cmdResetFilters.Click += new System.EventHandler(cmdResetFilters_Click);
			// 
			// cmbHeadquarter
			// 
			cmbHeadquarter.AllowDrop = true;
			cmbHeadquarter.BackColor = System.Drawing.SystemColors.Window;
			cmbHeadquarter.CausesValidation = true;
			cmbHeadquarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbHeadquarter.Enabled = true;
			cmbHeadquarter.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbHeadquarter.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbHeadquarter.IntegralHeight = true;
			cmbHeadquarter.Location = new System.Drawing.Point(16, 64);
			cmbHeadquarter.Name = "cmbHeadquarter";
			cmbHeadquarter.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmbHeadquarter.Size = new System.Drawing.Size(177, 26);
			cmbHeadquarter.Sorted = false;
			cmbHeadquarter.TabIndex = 9;
			cmbHeadquarter.TabStop = true;
			cmbHeadquarter.Visible = true;
			cmbHeadquarter.SelectedIndexChanged += new System.EventHandler(cmbHeadquarter_SelectedIndexChanged);
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
			chkUseAllFilters.TabIndex = 16;
			chkUseAllFilters.Text = "Use all filters?";
			chkUseAllFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbParent
			// 
			cmbParent.AllowDrop = true;
			cmbParent.BackColor = System.Drawing.SystemColors.Window;
			cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbParent.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbParent.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbParent.Location = new System.Drawing.Point(264, 64);
			cmbParent.Name = "cmbParent";
			cmbParent.Size = new System.Drawing.Size(169, 26);
			cmbParent.TabIndex = 10;
			cmbParent.Text = "cmbParent";
			cmbParent.SelectedIndexChanged += new System.EventHandler(cmbParent_SelectedIndexChanged);
			// 
			// cmbAreaServed
			// 
			cmbAreaServed.AllowDrop = true;
			cmbAreaServed.BackColor = System.Drawing.SystemColors.Window;
			cmbAreaServed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbAreaServed.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbAreaServed.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbAreaServed.Location = new System.Drawing.Point(16, 120);
			cmbAreaServed.Name = "cmbAreaServed";
			cmbAreaServed.Size = new System.Drawing.Size(177, 26);
			cmbAreaServed.TabIndex = 11;
			cmbAreaServed.Text = "cmbAreaServed";
			cmbAreaServed.SelectedIndexChanged += new System.EventHandler(cmbAreaServed_SelectedIndexChanged);
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
			Label2.TabIndex = 14;
			Label2.Text = "Parent Company";
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
			Label1.TabIndex = 13;
			Label1.Text = "Headquarter";
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
			Label3.Text = "Area Served";
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
			pnlResults.Location = new System.Drawing.Point(8, 184);
			pnlResults.Name = "pnlResults";
			pnlResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
			pnlResults.Size = new System.Drawing.Size(449, 201);
			pnlResults.TabIndex = 6;
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
			lstResults.Size = new System.Drawing.Size(417, 177);
			lstResults.TabIndex = 7;
			lstResults.View = System.Windows.Forms.View.Details;
			lstResults.Columns.Add(lstResults_ColumnHeader_1_);
			lstResults.Columns.Add(lstResults_ColumnHeader_2_);
			lstResults.Columns.Add(lstResults_ColumnHeader_3_);
			lstResults.Columns.Add(lstResults_ColumnHeader_4_);
			// 
			// lstResults_ColumnHeader_1_
			// 
			lstResults_ColumnHeader_1_.Text = "Name";
			lstResults_ColumnHeader_1_.Width = 101;
			// 
			// lstResults_ColumnHeader_2_
			// 
			lstResults_ColumnHeader_2_.Text = "Headquarter";
			lstResults_ColumnHeader_2_.Width = 101;
			// 
			// lstResults_ColumnHeader_3_
			// 
			lstResults_ColumnHeader_3_.Text = "Parent Company";
			lstResults_ColumnHeader_3_.Width = 114;
			// 
			// lstResults_ColumnHeader_4_
			// 
			lstResults_ColumnHeader_4_.Text = "Area Served";
			lstResults_ColumnHeader_4_.Width = 101;
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
			chkFilters.TabIndex = 4;
			chkFilters.TabStop = true;
			chkFilters.Text = "Show filters";
			chkFilters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkFilters.Visible = true;
			chkFilters.CheckStateChanged += new System.EventHandler(chkFilters_CheckStateChanged);
			// 
			// cmbManufacturer
			// 
			cmbManufacturer.AllowDrop = true;
			cmbManufacturer.BackColor = System.Drawing.SystemColors.Window;
			cmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			cmbManufacturer.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmbManufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
			cmbManufacturer.Location = new System.Drawing.Point(24, 80);
			cmbManufacturer.Name = "cmbManufacturer";
			cmbManufacturer.Size = new System.Drawing.Size(209, 26);
			cmbManufacturer.TabIndex = 2;
			cmbManufacturer.Text = "cmbManufacturer";
			// 
			// btnDelete
			// 
			btnDelete.AllowDrop = true;
			btnDelete.BackColor = System.Drawing.SystemColors.Control;
			btnDelete.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnDelete.ForeColor = System.Drawing.Color.Empty;
			btnDelete.Location = new System.Drawing.Point(160, 528);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new System.Drawing.Size(169, 65);
			btnDelete.TabIndex = 3;
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
			Label6.TabIndex = 1;
			Label6.Text = "Manufacturer";
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
			lblTitle.Text = "Brand";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmDeleteBrand
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(514, 607);
			Controls.Add(frameFilters);
			Controls.Add(chkFilters);
			Controls.Add(cmbManufacturer);
			Controls.Add(btnDelete);
			Controls.Add(Label6);
			Controls.Add(lblTitle);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmDeleteBrand.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmDeleteBrand";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Delete Brand";
			checkBoxHelper1.SetStyle(chkUseAllFilters, 0);
			commandButtonHelper1.SetStyle(cmdResetFilters, 0);
			commandButtonHelper1.SetStyle(btnDelete, 0);
			ToolTipMain.SetToolTip(cmbParent, "Manufacturer");
			ToolTipMain.SetToolTip(cmbAreaServed, "Manufacturer");
			ToolTipMain.SetToolTip(cmbManufacturer, "Manufacturer");
			Activated += new System.EventHandler(frmDeleteBrand_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			frameFilters.ResumeLayout(false);
			pnlFilters.ResumeLayout(false);
			pnlResults.ResumeLayout(false);
			lstResults.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}