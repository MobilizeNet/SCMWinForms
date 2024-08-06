
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailedInformation));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			cmdExit = new System.Windows.Forms.Button();
			cmdSoldByModel = new System.Windows.Forms.Button();
			cmdSoldByManufacturer = new System.Windows.Forms.Button();
			cmdCompaniesByCountry = new System.Windows.Forms.Button();
			cmdSoldBySeller = new System.Windows.Forms.Button();
			Picture1 = new System.Windows.Forms.PictureBox();
			lstResults = new System.Windows.Forms.ListView();
			lblTitle = new System.Windows.Forms.Label();
			Picture1.SuspendLayout();
			SuspendLayout();
			listViewHelper1 = new UpgradeHelpers.Gui.Controls.ListViewHelper(components);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).BeginInit();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// cmdExit
			// 
			cmdExit.AllowDrop = true;
			cmdExit.BackColor = System.Drawing.SystemColors.Control;
			cmdExit.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdExit.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdExit.Location = new System.Drawing.Point(848, 424);
			cmdExit.Name = "cmdExit";
			cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdExit.Size = new System.Drawing.Size(169, 65);
			cmdExit.TabIndex = 6;
			cmdExit.Text = "Exit";
			cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdExit.UseVisualStyleBackColor = false;
			cmdExit.Click += new System.EventHandler(cmdExit_Click);
			// 
			// cmdSoldByModel
			// 
			cmdSoldByModel.AllowDrop = true;
			cmdSoldByModel.BackColor = System.Drawing.SystemColors.Control;
			cmdSoldByModel.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSoldByModel.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSoldByModel.Location = new System.Drawing.Point(848, 152);
			cmdSoldByModel.Name = "cmdSoldByModel";
			cmdSoldByModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSoldByModel.Size = new System.Drawing.Size(169, 65);
			cmdSoldByModel.TabIndex = 5;
			cmdSoldByModel.Text = "Most Sold by &Model";
			cmdSoldByModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSoldByModel.UseVisualStyleBackColor = false;
			cmdSoldByModel.Click += new System.EventHandler(cmdSoldByModel_Click);
			// 
			// cmdSoldByManufacturer
			// 
			cmdSoldByManufacturer.AllowDrop = true;
			cmdSoldByManufacturer.BackColor = System.Drawing.SystemColors.Control;
			cmdSoldByManufacturer.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSoldByManufacturer.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSoldByManufacturer.Location = new System.Drawing.Point(848, 248);
			cmdSoldByManufacturer.Name = "cmdSoldByManufacturer";
			cmdSoldByManufacturer.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSoldByManufacturer.Size = new System.Drawing.Size(169, 65);
			cmdSoldByManufacturer.TabIndex = 4;
			cmdSoldByManufacturer.Text = "Most Sold by M&anufacturer";
			cmdSoldByManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSoldByManufacturer.UseVisualStyleBackColor = false;
			cmdSoldByManufacturer.Click += new System.EventHandler(cmdSoldByManufacturer_Click);
			// 
			// cmdCompaniesByCountry
			// 
			cmdCompaniesByCountry.AllowDrop = true;
			cmdCompaniesByCountry.BackColor = System.Drawing.SystemColors.Control;
			cmdCompaniesByCountry.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdCompaniesByCountry.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdCompaniesByCountry.Location = new System.Drawing.Point(848, 336);
			cmdCompaniesByCountry.Name = "cmdCompaniesByCountry";
			cmdCompaniesByCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdCompaniesByCountry.Size = new System.Drawing.Size(169, 65);
			cmdCompaniesByCountry.TabIndex = 3;
			cmdCompaniesByCountry.Text = "Most &Companies by Country";
			cmdCompaniesByCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdCompaniesByCountry.UseVisualStyleBackColor = false;
			cmdCompaniesByCountry.Click += new System.EventHandler(cmdCompaniesByCountry_Click);
			// 
			// cmdSoldBySeller
			// 
			cmdSoldBySeller.AllowDrop = true;
			cmdSoldBySeller.BackColor = System.Drawing.SystemColors.Control;
			cmdSoldBySeller.Font = new System.Drawing.Font("Consolas", 14.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdSoldBySeller.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdSoldBySeller.Location = new System.Drawing.Point(848, 64);
			cmdSoldBySeller.Name = "cmdSoldBySeller";
			cmdSoldBySeller.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdSoldBySeller.Size = new System.Drawing.Size(169, 65);
			cmdSoldBySeller.TabIndex = 2;
			cmdSoldBySeller.Text = "Sold by &Seller";
			cmdSoldBySeller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdSoldBySeller.UseVisualStyleBackColor = false;
			cmdSoldBySeller.Click += new System.EventHandler(cmdSoldBySeller_Click);
			// 
			// Picture1
			// 
			Picture1.AllowDrop = true;
			Picture1.BackColor = System.Drawing.SystemColors.Control;
			Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			Picture1.CausesValidation = true;
			Picture1.Controls.Add(lstResults);
			Picture1.Dock = System.Windows.Forms.DockStyle.None;
			Picture1.Enabled = true;
			Picture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			Picture1.Location = new System.Drawing.Point(24, 64);
			Picture1.Name = "Picture1";
			Picture1.Size = new System.Drawing.Size(801, 425);
			Picture1.TabIndex = 0;
			Picture1.TabStop = true;
			Picture1.Visible = true;
			// 
			// lstResults
			// 
			lstResults.AllowDrop = true;
			lstResults.BackColor = System.Drawing.SystemColors.Window;
			lstResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			lstResults.Font = new System.Drawing.Font("Consolas", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lstResults.ForeColor = System.Drawing.SystemColors.WindowText;
			lstResults.HideSelection = true;
			lstResults.LabelEdit = true;
			lstResults.Location = new System.Drawing.Point(160, 8);
			lstResults.MultiSelect = false;
			lstResults.Name = "lstResults";
			lstResults.Size = new System.Drawing.Size(489, 401);
			lstResults.TabIndex = 7;
			lstResults.View = System.Windows.Forms.View.Details;
			// 
			// lblTitle
			// 
			lblTitle.AllowDrop = true;
			lblTitle.BackColor = System.Drawing.SystemColors.Control;
			lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblTitle.Font = new System.Drawing.Font("Javanese Text", 24f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
			lblTitle.Location = new System.Drawing.Point(16, 0);
			lblTitle.MinimumSize = new System.Drawing.Size(1009, 49);
			lblTitle.Name = "lblTitle";
			lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblTitle.Size = new System.Drawing.Size(1009, 49);
			lblTitle.TabIndex = 1;
			lblTitle.Text = "Detailed Queries";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmDetailedInformation
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(1043, 497);
			Controls.Add(cmdExit);
			Controls.Add(cmdSoldByModel);
			Controls.Add(cmdSoldByManufacturer);
			Controls.Add(cmdCompaniesByCountry);
			Controls.Add(cmdSoldBySeller);
			Controls.Add(Picture1);
			Controls.Add(lblTitle);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmDetailedInformation.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmDetailedInformation";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			Text = "Detailed Information";
			commandButtonHelper1.SetStyle(cmdExit, 0);
			commandButtonHelper1.SetStyle(cmdSoldByModel, 0);
			commandButtonHelper1.SetStyle(cmdSoldByManufacturer, 0);
			commandButtonHelper1.SetStyle(cmdCompaniesByCountry, 0);
			commandButtonHelper1.SetStyle(cmdSoldBySeller, 0);
			Activated += new System.EventHandler(frmDetailedInformation_Activated);
			Closed += new System.EventHandler(Form_Closed);
			((System.ComponentModel.ISupportInitialize) listViewHelper1).EndInit();
			Picture1.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}