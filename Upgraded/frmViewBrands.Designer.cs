
namespace StarCarsManagement
{
	partial class frmViewBrands
	{

		#region "Upgrade Support "
		private static frmViewBrands m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmViewBrands DefInstance
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
		public static frmViewBrands CreateInstance()
		{
			frmViewBrands theInstance = new frmViewBrands();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 30);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "gridResults", "btnShowHiddenElements", "btnExit", "btnDelete", "btnEdit", "lblTitle", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public UpgradeHelpers.DataGridViewFlex gridResults;
		public System.Windows.Forms.Button btnShowHiddenElements;
		public System.Windows.Forms.Button btnExit;
		public System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.Button btnEdit;
		public System.Windows.Forms.Label lblTitle;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBrands));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			gridResults = new UpgradeHelpers.DataGridViewFlex(components);
			btnShowHiddenElements = new System.Windows.Forms.Button();
			btnExit = new System.Windows.Forms.Button();
			btnDelete = new System.Windows.Forms.Button();
			btnEdit = new System.Windows.Forms.Button();
			lblTitle = new System.Windows.Forms.Label();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			((System.ComponentModel.ISupportInitialize) gridResults).BeginInit();
			// 
			// gridResults
			// 
			gridResults.AllowBigSelection = false;
			gridResults.AllowDrop = true;
			gridResults.AllowUserToAddRows = false;
			gridResults.AllowUserToDeleteRows = false;
			gridResults.AllowUserToResizeColumns = false;
			gridResults.AllowUserToResizeColumns = gridResults.ColumnHeadersVisible;
			gridResults.AllowUserToResizeRows = false;
			gridResults.AllowUserToResizeRows = false;
			gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			gridResults.ColumnsCount = 2;
			gridResults.FixedColumns = 0;
			gridResults.FixedRows = 0;
			gridResults.Font = new System.Drawing.Font("Consolas", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			gridResults.Location = new System.Drawing.Point(16, 64);
			gridResults.Name = "gridResults";
			gridResults.ReadOnly = true;
			gridResults.RowsCount = 2;
			gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			gridResults.ShowCellToolTips = false;
			gridResults.Size = new System.Drawing.Size(977, 361);
			gridResults.StandardTab = true;
			gridResults.TabIndex = 1;
			gridResults.Click += new System.EventHandler(gridResults_Click);
			gridResults.DoubleClick += new System.EventHandler(gridResults_DoubleClick);
			gridResults.SelectionChanged += new System.EventHandler(gridResults_SelectionChanged);
			// 
			// btnShowHiddenElements
			// 
			btnShowHiddenElements.AllowDrop = true;
			btnShowHiddenElements.BackColor = System.Drawing.SystemColors.Control;
			btnShowHiddenElements.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnShowHiddenElements.ForeColor = System.Drawing.Color.Empty;
			btnShowHiddenElements.Location = new System.Drawing.Point(88, 440);
			btnShowHiddenElements.Name = "btnShowHiddenElements";
			btnShowHiddenElements.Size = new System.Drawing.Size(169, 65);
			btnShowHiddenElements.TabIndex = 5;
			btnShowHiddenElements.Text = "&Show Deleted";
			btnShowHiddenElements.Click += new System.EventHandler(btnShowHiddenElements_Click);
			// 
			// btnExit
			// 
			btnExit.AllowDrop = true;
			btnExit.BackColor = System.Drawing.SystemColors.Control;
			btnExit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnExit.ForeColor = System.Drawing.Color.Empty;
			btnExit.Location = new System.Drawing.Point(736, 440);
			btnExit.Name = "btnExit";
			btnExit.Size = new System.Drawing.Size(169, 65);
			btnExit.TabIndex = 4;
			btnExit.Text = "E&xit";
			btnExit.Click += new System.EventHandler(btnExit_Click);
			// 
			// btnDelete
			// 
			btnDelete.AllowDrop = true;
			btnDelete.BackColor = System.Drawing.SystemColors.Control;
			btnDelete.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnDelete.ForeColor = System.Drawing.Color.Empty;
			btnDelete.Location = new System.Drawing.Point(520, 440);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new System.Drawing.Size(169, 65);
			btnDelete.TabIndex = 3;
			btnDelete.Text = "&Delete";
			btnDelete.Click += new System.EventHandler(btnDelete_Click);
			// 
			// btnEdit
			// 
			btnEdit.AllowDrop = true;
			btnEdit.BackColor = System.Drawing.SystemColors.Control;
			btnEdit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnEdit.ForeColor = System.Drawing.Color.Empty;
			btnEdit.Location = new System.Drawing.Point(304, 440);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new System.Drawing.Size(169, 65);
			btnEdit.TabIndex = 2;
			btnEdit.Text = "&Edit";
			btnEdit.Click += new System.EventHandler(btnEdit_Click);
			// 
			// lblTitle
			// 
			lblTitle.AllowDrop = true;
			lblTitle.BackColor = System.Drawing.SystemColors.Control;
			lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			lblTitle.Location = new System.Drawing.Point(16, 0);
			lblTitle.MinimumSize = new System.Drawing.Size(985, 49);
			lblTitle.Name = "lblTitle";
			lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTitle.Size = new System.Drawing.Size(985, 49);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Brand";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmViewBrands
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(1019, 518);
			Controls.Add(gridResults);
			Controls.Add(btnShowHiddenElements);
			Controls.Add(btnExit);
			Controls.Add(btnDelete);
			Controls.Add(btnEdit);
			Controls.Add(lblTitle);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmViewBrands.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmViewBrands";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "View Brands Details";
			commandButtonHelper1.SetStyle(btnShowHiddenElements, 0);
			commandButtonHelper1.SetStyle(btnExit, 0);
			commandButtonHelper1.SetStyle(btnDelete, 0);
			commandButtonHelper1.SetStyle(btnEdit, 0);
			Activated += new System.EventHandler(frmViewBrands_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) gridResults).EndInit();
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}