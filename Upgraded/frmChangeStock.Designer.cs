
namespace StarCarsManagement
{
	partial class frmChangeStock
	{

		#region "Upgrade Support "
		private static frmChangeStock m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmChangeStock DefInstance
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
		public static frmChangeStock CreateInstance()
		{
			frmChangeStock theInstance = new frmChangeStock();
			return theInstance;
		}
		protected void InitializeHelp()
		{
			UpgradeSupport.helpSupport.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "chkOutOfStock", "cmdAccept", "txtNewStock", "txtCurrentStock", "lblNewStock", "lblCurrent", "frameStock", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.CheckBox chkOutOfStock;
		public System.Windows.Forms.Button cmdAccept;
		public System.Windows.Forms.TextBox txtNewStock;
		public System.Windows.Forms.TextBox txtCurrentStock;
		public System.Windows.Forms.Label lblNewStock;
		public System.Windows.Forms.Label lblCurrent;
		public System.Windows.Forms.Panel frameStock;
		public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeStock));
			ToolTipMain = new System.Windows.Forms.ToolTip(components);
			frameStock = new System.Windows.Forms.Panel();
			chkOutOfStock = new System.Windows.Forms.CheckBox();
			cmdAccept = new System.Windows.Forms.Button();
			txtNewStock = new System.Windows.Forms.TextBox();
			txtCurrentStock = new System.Windows.Forms.TextBox();
			lblNewStock = new System.Windows.Forms.Label();
			lblCurrent = new System.Windows.Forms.Label();
			frameStock.SuspendLayout();
			SuspendLayout();
			commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
			// 
			// frameStock
			// 
			frameStock.AllowDrop = true;
			frameStock.BackColor = System.Drawing.SystemColors.Control;
			frameStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			frameStock.Controls.Add(chkOutOfStock);
			frameStock.Controls.Add(cmdAccept);
			frameStock.Controls.Add(txtNewStock);
			frameStock.Controls.Add(txtCurrentStock);
			frameStock.Controls.Add(lblNewStock);
			frameStock.Controls.Add(lblCurrent);
			frameStock.Enabled = true;
			frameStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			frameStock.ForeColor = System.Drawing.SystemColors.ControlText;
			frameStock.Location = new System.Drawing.Point(0, 0);
			frameStock.Name = "frameStock";
			frameStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			frameStock.Size = new System.Drawing.Size(305, 193);
			frameStock.TabIndex = 0;
			frameStock.Text = "Frame1";
			frameStock.Visible = true;
			// 
			// chkOutOfStock
			// 
			chkOutOfStock.AllowDrop = true;
			chkOutOfStock.Appearance = System.Windows.Forms.Appearance.Normal;
			chkOutOfStock.BackColor = System.Drawing.SystemColors.Control;
			chkOutOfStock.CausesValidation = true;
			chkOutOfStock.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkOutOfStock.CheckState = System.Windows.Forms.CheckState.Unchecked;
			chkOutOfStock.Enabled = true;
			chkOutOfStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			chkOutOfStock.ForeColor = System.Drawing.SystemColors.ControlText;
			chkOutOfStock.Location = new System.Drawing.Point(24, 96);
			chkOutOfStock.Name = "chkOutOfStock";
			chkOutOfStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			chkOutOfStock.Size = new System.Drawing.Size(169, 33);
			chkOutOfStock.TabIndex = 6;
			chkOutOfStock.TabStop = true;
			chkOutOfStock.Text = "Out of Stock?";
			chkOutOfStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			chkOutOfStock.Visible = true;
			chkOutOfStock.CheckStateChanged += new System.EventHandler(chkOutOfStock_CheckStateChanged);
			// 
			// cmdAccept
			// 
			cmdAccept.AllowDrop = true;
			cmdAccept.BackColor = System.Drawing.SystemColors.Control;
			cmdAccept.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cmdAccept.ForeColor = System.Drawing.SystemColors.ControlText;
			cmdAccept.Location = new System.Drawing.Point(64, 136);
			cmdAccept.Name = "cmdAccept";
			cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No;
			cmdAccept.Size = new System.Drawing.Size(169, 41);
			cmdAccept.TabIndex = 5;
			cmdAccept.Text = "Change &Stock";
			cmdAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			cmdAccept.UseVisualStyleBackColor = false;
			cmdAccept.Click += new System.EventHandler(cmdAccept_Click);
			// 
			// txtNewStock
			// 
			txtNewStock.AcceptsReturn = true;
			txtNewStock.AllowDrop = true;
			txtNewStock.BackColor = System.Drawing.SystemColors.Window;
			txtNewStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtNewStock.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtNewStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtNewStock.ForeColor = System.Drawing.SystemColors.WindowText;
			txtNewStock.Location = new System.Drawing.Point(176, 56);
			txtNewStock.MaxLength = 0;
			txtNewStock.Name = "txtNewStock";
			txtNewStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtNewStock.Size = new System.Drawing.Size(113, 33);
			txtNewStock.TabIndex = 4;
			txtNewStock.Enter += new System.EventHandler(txtNewStock_Enter);
			txtNewStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtNewStock_KeyPress);
			txtNewStock.Leave += new System.EventHandler(txtNewStock_Leave);
			// 
			// txtCurrentStock
			// 
			txtCurrentStock.AcceptsReturn = true;
			txtCurrentStock.AllowDrop = true;
			txtCurrentStock.BackColor = System.Drawing.SystemColors.Window;
			txtCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			txtCurrentStock.Cursor = System.Windows.Forms.Cursors.IBeam;
			txtCurrentStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCurrentStock.ForeColor = System.Drawing.SystemColors.WindowText;
			txtCurrentStock.Location = new System.Drawing.Point(176, 8);
			txtCurrentStock.MaxLength = 0;
			txtCurrentStock.Name = "txtCurrentStock";
			txtCurrentStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			txtCurrentStock.Size = new System.Drawing.Size(113, 33);
			txtCurrentStock.TabIndex = 2;
			txtCurrentStock.Leave += new System.EventHandler(txtCurrentStock_Leave);
			// 
			// lblNewStock
			// 
			lblNewStock.AllowDrop = true;
			lblNewStock.BackColor = System.Drawing.SystemColors.Control;
			lblNewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblNewStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblNewStock.ForeColor = System.Drawing.SystemColors.ControlText;
			lblNewStock.Location = new System.Drawing.Point(24, 64);
			lblNewStock.MinimumSize = new System.Drawing.Size(153, 25);
			lblNewStock.Name = "lblNewStock";
			lblNewStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblNewStock.Size = new System.Drawing.Size(153, 25);
			lblNewStock.TabIndex = 3;
			lblNewStock.Text = "New Stock:";
			// 
			// lblCurrent
			// 
			lblCurrent.AllowDrop = true;
			lblCurrent.BackColor = System.Drawing.SystemColors.Control;
			lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			lblCurrent.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
			lblCurrent.Location = new System.Drawing.Point(24, 16);
			lblCurrent.MinimumSize = new System.Drawing.Size(145, 25);
			lblCurrent.Name = "lblCurrent";
			lblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No;
			lblCurrent.Size = new System.Drawing.Size(145, 25);
			lblCurrent.TabIndex = 1;
			lblCurrent.Text = "Current Stock:";
			// 
			// frmChangeStock
			// 
			AllowDrop = true;
			AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.Control;
			ClientSize = new System.Drawing.Size(308, 194);
			Controls.Add(frameStock);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			Icon = (System.Drawing.Icon) resources.GetObject("frmChangeStock.Icon");
			Location = new System.Drawing.Point(3, 26);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmChangeStock";
			RightToLeft = System.Windows.Forms.RightToLeft.No;
			Text = "Change Stock";
			commandButtonHelper1.SetStyle(cmdAccept, 0);
			Activated += new System.EventHandler(frmChangeStock_Activated);
			Closed += new System.EventHandler(Form_Closed);
			frameStock.ResumeLayout(false);
			ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}