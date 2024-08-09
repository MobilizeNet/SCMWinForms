
namespace StarCarsManagement
{
	partial class frmViewVehicles
	{

		#region "Upgrade Support "
		private static frmViewVehicles m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmViewVehicles DefInstance
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
		public static frmViewVehicles CreateInstance()
		{
			frmViewVehicles theInstance = new frmViewVehicles();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 30);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "gridResults", "btnShowHiddenElements", "btnExit", "btnChangeStock", "btnEdit", "btnDelete", "lblTitle", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public UpgradeHelpers.DataGridViewFlex gridResults;
		public System.Windows.Forms.Button btnShowHiddenElements;
		public System.Windows.Forms.Button btnExit;
		public System.Windows.Forms.Button btnChangeStock;
		public System.Windows.Forms.Button btnEdit;
		public System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.Label lblTitle;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewVehicles));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.gridResults = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.btnShowHiddenElements = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnChangeStock = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.gridResults).BeginInit();
			// 
			// gridResults
			// 
			this.gridResults.AllowBigSelection = false;
			this.gridResults.AllowDrop = true;
			this.gridResults.AllowUserToAddRows = false;
			this.gridResults.AllowUserToDeleteRows = false;
			this.gridResults.AllowUserToResizeColumns = false;
			this.gridResults.AllowUserToResizeColumns = this.gridResults.ColumnHeadersVisible;
			this.gridResults.AllowUserToResizeRows = false;
			this.gridResults.AllowUserToResizeRows = false;
			this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridResults.ColumnsCount = 2;
			this.gridResults.FixedColumns = 0;
			this.gridResults.FixedRows = 0;
			this.gridResults.Font = new System.Drawing.Font("Consolas", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.gridResults.Location = new System.Drawing.Point(16, 64);
			this.gridResults.Name = "gridResults";
			this.gridResults.ReadOnly = true;
			this.gridResults.RowsCount = 2;
			this.gridResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridResults.ShowCellToolTips = false;
			this.gridResults.Size = new System.Drawing.Size(1305, 361);
			this.gridResults.StandardTab = true;
			this.gridResults.TabIndex = 1;
			this.gridResults.Click += new System.EventHandler(this.gridResults_Click);
			this.gridResults.DoubleClick += new System.EventHandler(this.gridResults_DoubleClick);
			this.gridResults.SelectionChanged += new System.EventHandler(this.gridResults_SelectionChanged);
			// 
			// btnShowHiddenElements
			// 
			this.btnShowHiddenElements.AllowDrop = true;
			this.btnShowHiddenElements.BackColor = System.Drawing.SystemColors.Control;
			this.btnShowHiddenElements.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnShowHiddenElements.ForeColor = System.Drawing.Color.Empty;
			this.btnShowHiddenElements.Location = new System.Drawing.Point(168, 440);
			this.btnShowHiddenElements.Name = "btnShowHiddenElements";
			this.btnShowHiddenElements.Size = new System.Drawing.Size(129, 65);
			this.btnShowHiddenElements.TabIndex = 6;
			this.btnShowHiddenElements.Text = "&Show Deleted";
			this.btnShowHiddenElements.Click += new System.EventHandler(this.btnShowHiddenElements_Click);
			// 
			// btnExit
			// 
			this.btnExit.AllowDrop = true;
			this.btnExit.BackColor = System.Drawing.SystemColors.Control;
			this.btnExit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnExit.ForeColor = System.Drawing.Color.Empty;
			this.btnExit.Location = new System.Drawing.Point(984, 440);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(169, 65);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnChangeStock
			// 
			this.btnChangeStock.AllowDrop = true;
			this.btnChangeStock.BackColor = System.Drawing.SystemColors.Control;
			this.btnChangeStock.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnChangeStock.ForeColor = System.Drawing.Color.Empty;
			this.btnChangeStock.Location = new System.Drawing.Point(776, 440);
			this.btnChangeStock.Name = "btnChangeStock";
			this.btnChangeStock.Size = new System.Drawing.Size(169, 65);
			this.btnChangeStock.TabIndex = 4;
			this.btnChangeStock.Text = "Change &Stock";
			this.btnChangeStock.Click += new System.EventHandler(this.btnChangeStock_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.AllowDrop = true;
			this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnEdit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnEdit.ForeColor = System.Drawing.Color.Empty;
			this.btnEdit.Location = new System.Drawing.Point(344, 440);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(169, 65);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "&Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AllowDrop = true;
			this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
			this.btnDelete.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.ForeColor = System.Drawing.Color.Empty;
			this.btnDelete.Location = new System.Drawing.Point(560, 440);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(169, 65);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AllowDrop = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitle.Location = new System.Drawing.Point(16, 0);
			this.lblTitle.MinimumSize = new System.Drawing.Size(1321, 49);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTitle.Size = new System.Drawing.Size(1321, 49);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Vehicle";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmViewVehicles
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1357, 520);
			this.Controls.Add(this.gridResults);
			this.Controls.Add(this.btnShowHiddenElements);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnChangeStock);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmViewVehicles.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmViewVehicles";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Vehicle Models Details";
			this.commandButtonHelper1.SetStyle(this.btnShowHiddenElements, 0);
			this.commandButtonHelper1.SetStyle(this.btnExit, 0);
			this.commandButtonHelper1.SetStyle(this.btnChangeStock, 0);
			this.commandButtonHelper1.SetStyle(this.btnEdit, 0);
			this.commandButtonHelper1.SetStyle(this.btnDelete, 0);
			this.Activated += new System.EventHandler(this.frmViewVehicles_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.gridResults).EndInit();
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}