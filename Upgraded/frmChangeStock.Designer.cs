
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeStock));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.frameStock = new System.Windows.Forms.Panel();
			this.chkOutOfStock = new System.Windows.Forms.CheckBox();
			this.cmdAccept = new System.Windows.Forms.Button();
			this.txtNewStock = new System.Windows.Forms.TextBox();
			this.txtCurrentStock = new System.Windows.Forms.TextBox();
			this.lblNewStock = new System.Windows.Forms.Label();
			this.lblCurrent = new System.Windows.Forms.Label();
			this.frameStock.SuspendLayout();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
			// 
			// frameStock
			// 
			this.frameStock.AllowDrop = true;
			this.frameStock.BackColor = System.Drawing.SystemColors.Control;
			this.frameStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.frameStock.Controls.Add(this.chkOutOfStock);
			this.frameStock.Controls.Add(this.cmdAccept);
			this.frameStock.Controls.Add(this.txtNewStock);
			this.frameStock.Controls.Add(this.txtCurrentStock);
			this.frameStock.Controls.Add(this.lblNewStock);
			this.frameStock.Controls.Add(this.lblCurrent);
			this.frameStock.Enabled = true;
			this.frameStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.frameStock.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frameStock.Location = new System.Drawing.Point(0, 0);
			this.frameStock.Name = "frameStock";
			this.frameStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frameStock.Size = new System.Drawing.Size(305, 193);
			this.frameStock.TabIndex = 0;
			this.frameStock.Text = "Frame1";
			this.frameStock.Visible = true;
			// 
			// chkOutOfStock
			// 
			this.chkOutOfStock.AllowDrop = true;
			this.chkOutOfStock.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkOutOfStock.BackColor = System.Drawing.SystemColors.Control;
			this.chkOutOfStock.CausesValidation = true;
			this.chkOutOfStock.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkOutOfStock.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkOutOfStock.Enabled = true;
			this.chkOutOfStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkOutOfStock.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkOutOfStock.Location = new System.Drawing.Point(24, 96);
			this.chkOutOfStock.Name = "chkOutOfStock";
			this.chkOutOfStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkOutOfStock.Size = new System.Drawing.Size(169, 33);
			this.chkOutOfStock.TabIndex = 6;
			this.chkOutOfStock.TabStop = true;
			this.chkOutOfStock.Text = "Out of Stock?";
			this.chkOutOfStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkOutOfStock.Visible = true;
			this.chkOutOfStock.CheckStateChanged += new System.EventHandler(this.chkOutOfStock_CheckStateChanged);
			// 
			// cmdAccept
			// 
			this.cmdAccept.AllowDrop = true;
			this.cmdAccept.BackColor = System.Drawing.SystemColors.Control;
			this.cmdAccept.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdAccept.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAccept.Location = new System.Drawing.Point(64, 136);
			this.cmdAccept.Name = "cmdAccept";
			this.cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdAccept.Size = new System.Drawing.Size(169, 41);
			this.cmdAccept.TabIndex = 5;
			this.cmdAccept.Text = "Change &Stock";
			this.cmdAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdAccept.UseVisualStyleBackColor = false;
			this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
			// 
			// txtNewStock
			// 
			this.txtNewStock.AcceptsReturn = true;
			this.txtNewStock.AllowDrop = true;
			this.txtNewStock.BackColor = System.Drawing.SystemColors.Window;
			this.txtNewStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtNewStock.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNewStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtNewStock.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNewStock.Location = new System.Drawing.Point(176, 56);
			this.txtNewStock.MaxLength = 0;
			this.txtNewStock.Name = "txtNewStock";
			this.txtNewStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNewStock.Size = new System.Drawing.Size(113, 33);
			this.txtNewStock.TabIndex = 4;
			this.txtNewStock.Enter += new System.EventHandler(this.txtNewStock_Enter);
			this.txtNewStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewStock_KeyPress);
			this.txtNewStock.Leave += new System.EventHandler(this.txtNewStock_Leave);
			// 
			// txtCurrentStock
			// 
			this.txtCurrentStock.AcceptsReturn = true;
			this.txtCurrentStock.AllowDrop = true;
			this.txtCurrentStock.BackColor = System.Drawing.SystemColors.Window;
			this.txtCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCurrentStock.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCurrentStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCurrentStock.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCurrentStock.Location = new System.Drawing.Point(176, 8);
			this.txtCurrentStock.MaxLength = 0;
			this.txtCurrentStock.Name = "txtCurrentStock";
			this.txtCurrentStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCurrentStock.Size = new System.Drawing.Size(113, 33);
			this.txtCurrentStock.TabIndex = 2;
			this.txtCurrentStock.Leave += new System.EventHandler(this.txtCurrentStock_Leave);
			// 
			// lblNewStock
			// 
			this.lblNewStock.AllowDrop = true;
			this.lblNewStock.BackColor = System.Drawing.SystemColors.Control;
			this.lblNewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblNewStock.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblNewStock.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNewStock.Location = new System.Drawing.Point(24, 64);
			this.lblNewStock.MinimumSize = new System.Drawing.Size(153, 25);
			this.lblNewStock.Name = "lblNewStock";
			this.lblNewStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNewStock.Size = new System.Drawing.Size(153, 25);
			this.lblNewStock.TabIndex = 3;
			this.lblNewStock.Text = "New Stock:";
			// 
			// lblCurrent
			// 
			this.lblCurrent.AllowDrop = true;
			this.lblCurrent.BackColor = System.Drawing.SystemColors.Control;
			this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCurrent.Font = new System.Drawing.Font("Consolas", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCurrent.Location = new System.Drawing.Point(24, 16);
			this.lblCurrent.MinimumSize = new System.Drawing.Size(145, 25);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCurrent.Size = new System.Drawing.Size(145, 25);
			this.lblCurrent.TabIndex = 1;
			this.lblCurrent.Text = "Current Stock:";
			// 
			// frmChangeStock
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(308, 194);
			this.Controls.Add(this.frameStock);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmChangeStock.Icon");
			this.Location = new System.Drawing.Point(3, 26);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangeStock";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Change Stock";
			this.commandButtonHelper1.SetStyle(this.cmdAccept, 0);
			this.Activated += new System.EventHandler(this.frmChangeStock_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.frameStock.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents) => InitializeHelp();

		#endregion
	}
}