using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmChangeStock
		: System.Windows.Forms.Form
	{

		public frmChangeStock()
			: base()
		{
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			ReLoadForm(false);
		}


		private void frmChangeStock_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		private void chkOutOfStock_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkOutOfStock.CheckState != CheckState.Unchecked)
			{
				txtNewStock.Enabled = false;
			}
		}

		private void cmdAccept_Click(Object eventSender, EventArgs eventArgs)
		{
			if (txtNewStock.Text == "" && chkOutOfStock.CheckState == CheckState.Unchecked)
			{
				MessageBox.Show("Enter a valid amount", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (MessageBox.Show("Do you really want to change the Stock of this model?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				if (chkOutOfStock.CheckState != CheckState.Unchecked)
				{
					modMain.rs3["Quantity"] = 0;
				}
				else
				{
					modMain.rs3["Quantity"] = Double.Parse(txtNewStock.Text, NumberStyles.Any).ToString("N0");
				}
				modMain.rs3.Update();
				MessageBox.Show("Stock changed successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}

		public void LoadQuery(string query)
		{
			modMain.ExecuteSQL3(query);
			txtCurrentStock.Text = Convert.ToString(modMain.rs3["Quantity"]);
			txtCurrentStock.Enabled = false;
		}

		private void txtCurrentStock_Leave(Object eventSender, EventArgs eventArgs) => txtCurrentStock.Text = StringsHelper.Format(txtCurrentStock.Text, "#,###");


		private void txtNewStock_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtNewStock.Text != "")
			{
				txtNewStock.Text = Double.Parse(txtNewStock.Text, NumberStyles.Any).ToString("N0");
			}
		}

		private void txtNewStock_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				VerifyChar(ref KeyAscii);
			}
			finally
			{
				if (KeyAscii == 0)
				{
					eventArgs.Handled = true;
				}
				eventArgs.KeyChar = Convert.ToChar(KeyAscii);
			}
		}

		private void txtNewStock_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (Strings.Len(txtNewStock.Text) % 3 == 0)
			{
				txtNewStock.MaxLength = 7;
			}
			txtNewStock.Text = StringsHelper.Format(txtNewStock.Text, "#,###");
		}

		public void VerifyChar(ref int KeyAscii)
		{
			if (!Information.IsNumeric(Strings.Chr(KeyAscii).ToString()) && KeyAscii != 8)
			{
				KeyAscii = 0;
				MessageBox.Show("Enter only numeric characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}