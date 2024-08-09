
namespace StarCarsManagement
{
	partial class frmViewReceipts
	{

		#region "Upgrade Support "
		private static frmViewReceipts m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmViewReceipts DefInstance
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
		public static frmViewReceipts CreateInstance()
		{
			frmViewReceipts theInstance = new frmViewReceipts();
			theInstance.Form_Load();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 30);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "gridResults", "btnShowAll", "btnExit", "btnEdit", "btnChangeStatus", "lblTitle", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public UpgradeHelpers.DataGridViewFlex gridResults;
		public System.Windows.Forms.Button btnShowAll;
		public System.Windows.Forms.Button btnExit;
		public System.Windows.Forms.Button btnEdit;
		public System.Windows.Forms.Button btnChangeStatus;
		public System.Windows.Forms.Label lblTitle;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewReceipts));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.gridResults = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnChangeStatus = new System.Windows.Forms.Button();
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
			this.gridResults.Size = new System.Drawing.Size(1121, 361);
			this.gridResults.StandardTab = true;
			this.gridResults.TabIndex = 1;
			this.gridResults.DoubleClick += new System.EventHandler(this.gridResults_DoubleClick);
			// 
			// btnShowAll
			// 
			this.btnShowAll.AllowDrop = true;
			this.btnShowAll.BackColor = System.Drawing.SystemColors.Control;
			this.btnShowAll.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnShowAll.ForeColor = System.Drawing.Color.Empty;
			this.btnShowAll.Location = new System.Drawing.Point(184, 440);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(169, 65);
			this.btnShowAll.TabIndex = 5;
			this.btnShowAll.Text = "&Show Approved";
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// btnExit
			// 
			this.btnExit.AllowDrop = true;
			this.btnExit.BackColor = System.Drawing.SystemColors.Control;
			this.btnExit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnExit.ForeColor = System.Drawing.Color.Empty;
			this.btnExit.Location = new System.Drawing.Point(832, 440);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(169, 65);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.AllowDrop = true;
			this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnEdit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnEdit.ForeColor = System.Drawing.Color.Empty;
			this.btnEdit.Location = new System.Drawing.Point(400, 440);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(169, 65);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "&Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnChangeStatus
			// 
			this.btnChangeStatus.AllowDrop = true;
			this.btnChangeStatus.BackColor = System.Drawing.SystemColors.Control;
			this.btnChangeStatus.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnChangeStatus.ForeColor = System.Drawing.Color.Empty;
			this.btnChangeStatus.Location = new System.Drawing.Point(616, 440);
			this.btnChangeStatus.Name = "btnChangeStatus";
			this.btnChangeStatus.Size = new System.Drawing.Size(169, 65);
			this.btnChangeStatus.TabIndex = 2;
			this.btnChangeStatus.Text = "&Change Status";
			this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AllowDrop = true;
			this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTitle.Location = new System.Drawing.Point(16, 0);
			this.lblTitle.MinimumSize = new System.Drawing.Size(1129, 49);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTitle.Size = new System.Drawing.Size(1129, 49);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Receipt";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmViewReceipts
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1162, 519);
			this.Controls.Add(this.gridResults);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnChangeStatus);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmViewReceipts.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmViewReceipts";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Receipts Details";
			this.commandButtonHelper1.SetStyle(this.btnShowAll, 0);
			this.commandButtonHelper1.SetStyle(this.btnExit, 0);
			this.commandButtonHelper1.SetStyle(this.btnEdit, 0);
			this.commandButtonHelper1.SetStyle(this.btnChangeStatus, 0);
			this.Activated += new System.EventHandler(this.frmViewReceipts_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.gridResults).EndInit();
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}