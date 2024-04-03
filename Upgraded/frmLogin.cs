using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;

namespace StarCarsManagement
{
	internal partial class frmLogin
		: System.Windows.Forms.Form
	{

		public frmLogin()
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


		private void frmLogin_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		public bool LoginSucceeded = false;

		private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
		{
			LoginSucceeded = false;
			this.Close();
		}

		private void cmdOK_Click(Object eventSender, EventArgs eventArgs)
		{
			if (VerifyUser())
			{
				LoginSucceeded = true;
				SetMessage();
				this.Hide();
				frmMain.DefInstance.Show();
			}
			else
			{
				MessageBox.Show("Invalid Username or Password, try again!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPassword.Focus();
			}
		}

		public void SetMessage()
		{
			modMain.ExecuteSQL($"Select * from Staff where Username = '{txtUsername.Text}'");

			string FullName = $"{Convert.ToString(modMain.rs["Staff_Name"])} {Convert.ToString(modMain.rs["Staff_LastName"])}";
			string Role = GetRoleName(Convert.ToInt32(modMain.rs["Role_ID"]));

			frmMain.DefInstance.lblUser.Text = $"Welcome {FullName}!";
			frmMain.DefInstance.lblRole.Text = $"Role: {Role}";

			frmMain.DefInstance.CurrentUserRoleID = Convert.ToInt32(modMain.rs["Role_ID"]);
		}

		public string GetRoleName(int RoleID)
		{
			modMain.ExecuteSQL2($"Select * from Role where ID = {RoleID.ToString()}");
			return Convert.ToString(modMain.rs2["Role"]);
		}

		public bool VerifyUser()
		{
			bool result = false;
			modMain.ExecuteSQL($"Select * from Staff where Username = '{txtUsername.Text}' and Password = '{txtPassword.Text}'");

			if (modMain.rs.EOF)
			{
				return false;
			}
			else
			{
				if (Convert.ToDouble(modMain.rs["Role_ID"]) == 4)
				{
					result = false;
					//UPGRADE_WARNING: (6021) Casting 'VBA.VbVarType' to Enum may cause different behaviour. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-6021
					//UPGRADE_ISSUE: (1046) MsgBox Parameter 'context' is not supported, and was removed. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-1046
					//UPGRADE_ISSUE: (1046) MsgBox Parameter 'helpfile' is not supported, and was removed. More Information: https://docs.mobilize.net/vbuc/ewis/issues#id-1046
					Interaction.MsgBox("The user can not access the application anymore.", (MsgBoxStyle) VariantType.Error, "Error");
					return result;
				}
				return true;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}