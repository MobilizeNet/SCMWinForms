
namespace StarCarsManagement
{
	partial class frmDetailedInformation
	{

		#region "Upgrade Support "
		private static frmDetailedInformation m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmDetailedInformation DefInstance
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
		public static frmDetailedInformation CreateInstance()
		{
			frmDetailedInformation theInstance = new frmDetailedInformation();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpContextId(this, 30);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdExit", "cmdSoldByModel", "cmdSoldByManufacturer", "cmdCompaniesByCountry", "cmdSoldBySeller", "lstResults", "Picture1", "lblTitle", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdExit;
		public System.Windows.Forms.Button cmdSoldByModel;
		public System.Windows.Forms.Button cmdSoldByManufacturer;
		public System.Windows.Forms.Button cmdCompaniesByCountry;
		public System.Windows.Forms.Button cmdSoldBySeller;
		public System.Windows.Forms.ListView lstResults;
		public System.Windows.Forms.PictureBox Picture1;
		public System.Windows.Forms.Label lblTitle;
		public UpgradeHelpers.Gui.Controls.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailedInformation));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cmdExit = new System.Windows.Forms.Button();
			this.cmdSoldByModel = new System.Windows.Forms.Button();
			this.cmdSoldByManufacturer = new System.Windows.Forms.Button();
			this.cmdCompaniesByCountry = new System.Windows.Forms.Button();
			this.cmdSoldBySeller = new System.Windows.Forms.Button();
			this.Picture1 = new System.Windows.Forms.PictureBox();
			this.lstResults = new System.Windows.Forms.ListView();
			this.lblTitle = new System.Windows.Forms.Label();
			this.Picture1.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// cmdExit
			// 
			this.cmdExit.AllowDrop = true;
			this.cmdExit.BackColor = System.Drawing.SystemColors.Control;
			this.cmdExit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdExit.Location = new System.Drawing.Point(848, 424);
			this.cmdExit.Name = "cmdExit";
			this.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdExit.Size = new System.Drawing.Size(169, 65);
			this.cmdExit.TabIndex = 6;
			this.cmdExit.Text = "Exit";
			this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdExit.UseVisualStyleBackColor = false;
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// cmdSoldByModel
			// 
			this.cmdSoldByModel.AllowDrop = true;
			this.cmdSoldByModel.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSoldByModel.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSoldByModel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSoldByModel.Location = new System.Drawing.Point(848, 152);
			this.cmdSoldByModel.Name = "cmdSoldByModel";
			this.cmdSoldByModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSoldByModel.Size = new System.Drawing.Size(169, 65);
			this.cmdSoldByModel.TabIndex = 5;
			this.cmdSoldByModel.Text = "Most Sold by &Model";
			this.cmdSoldByModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSoldByModel.UseVisualStyleBackColor = false;
			this.cmdSoldByModel.Click += new System.EventHandler(this.cmdSoldByModel_Click);
			// 
			// cmdSoldByManufacturer
			// 
			this.cmdSoldByManufacturer.AllowDrop = true;
			this.cmdSoldByManufacturer.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSoldByManufacturer.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSoldByManufacturer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSoldByManufacturer.Location = new System.Drawing.Point(848, 248);
			this.cmdSoldByManufacturer.Name = "cmdSoldByManufacturer";
			this.cmdSoldByManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSoldByManufacturer.Size = new System.Drawing.Size(169, 65);
			this.cmdSoldByManufacturer.TabIndex = 4;
			this.cmdSoldByManufacturer.Text = "Most Sold by M&anufacturer";
			this.cmdSoldByManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSoldByManufacturer.UseVisualStyleBackColor = false;
			this.cmdSoldByManufacturer.Click += new System.EventHandler(this.cmdSoldByManufacturer_Click);
			// 
			// cmdCompaniesByCountry
			// 
			this.cmdCompaniesByCountry.AllowDrop = true;
			this.cmdCompaniesByCountry.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCompaniesByCountry.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCompaniesByCountry.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCompaniesByCountry.Location = new System.Drawing.Point(848, 336);
			this.cmdCompaniesByCountry.Name = "cmdCompaniesByCountry";
			this.cmdCompaniesByCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCompaniesByCountry.Size = new System.Drawing.Size(169, 65);
			this.cmdCompaniesByCountry.TabIndex = 3;
			this.cmdCompaniesByCountry.Text = "Most &Companies by Country";
			this.cmdCompaniesByCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCompaniesByCountry.UseVisualStyleBackColor = false;
			this.cmdCompaniesByCountry.Click += new System.EventHandler(this.cmdCompaniesByCountry_Click);
			// 
			// cmdSoldBySeller
			// 
			this.cmdSoldBySeller.AllowDrop = true;
			this.cmdSoldBySeller.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSoldBySeller.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSoldBySeller.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSoldBySeller.Location = new System.Drawing.Point(848, 64);
			this.cmdSoldBySeller.Name = "cmdSoldBySeller";
			this.cmdSoldBySeller.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSoldBySeller.Size = new System.Drawing.Size(169, 65);
			this.cmdSoldBySeller.TabIndex = 2;
			this.cmdSoldBySeller.Text = "Sold by &Seller";
			this.cmdSoldBySeller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSoldBySeller.UseVisualStyleBackColor = false;
			this.cmdSoldBySeller.Click += new System.EventHandler(this.cmdSoldBySeller_Click);
			// 
			// Picture1
			// 
			this.Picture1.AllowDrop = true;
			this.Picture1.BackColor = System.Drawing.SystemColors.Control;
			this.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Picture1.CausesValidation = true;
			this.Picture1.Controls.Add(this.lstResults);
			this.Picture1.Dock = System.Windows.Forms.DockStyle.None;
			this.Picture1.Enabled = true;
			this.Picture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Picture1.Location = new System.Drawing.Point(24, 64);
			this.Picture1.Name = "Picture1";
			this.Picture1.Size = new System.Drawing.Size(801, 425);
			this.Picture1.TabIndex = 0;
			this.Picture1.TabStop = true;
			this.Picture1.Visible = true;
			// 
			// lstResults
			// 
			this.lstResults.AllowDrop = true;
			this.lstResults.BackColor = System.Drawing.SystemColors.Window;
			this.lstResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstResults.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstResults.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstResults.HideSelection = true;
			this.lstResults.LabelEdit = true;
			this.lstResults.Location = new System.Drawing.Point(160, 8);
			this.lstResults.MultiSelect = false;
			this.lstResults.Name = "lstResults";
			this.lstResults.Size = new System.Drawing.Size(489, 401);
			this.lstResults.TabIndex = 7;
			this.lstResults.View = System.Windows.Forms.View.Details;
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
			this.lblTitle.Size = new System.Drawing.Size(1009, 49);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Detailed Queries";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmDetailedInformation
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1043, 497);
			this.Controls.Add(this.cmdExit);
			this.Controls.Add(this.cmdSoldByModel);
			this.Controls.Add(this.cmdSoldByManufacturer);
			this.Controls.Add(this.cmdCompaniesByCountry);
			this.Controls.Add(this.cmdSoldBySeller);
			this.Controls.Add(this.Picture1);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmDetailedInformation.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDetailedInformation";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Detailed Information";
			this.commandButtonHelper1.SetStyle(this.cmdExit, 0);
			this.commandButtonHelper1.SetStyle(this.cmdSoldByModel, 0);
			this.commandButtonHelper1.SetStyle(this.cmdSoldByManufacturer, 0);
			this.commandButtonHelper1.SetStyle(this.cmdCompaniesByCountry, 0);
			this.commandButtonHelper1.SetStyle(this.cmdSoldBySeller, 0);
			this.Activated += new System.EventHandler(this.frmDetailedInformation_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
			this.Picture1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeHelp();
		}
		#endregion
	}
}