using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmCreateNewStaff
		: System.Windows.Forms.Form
	{

		public frmCreateNewStaff()
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


		private void frmCreateNewStaff_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		public string PreviousDNI = "", PreviousUsername = "";
		bool AlreadyMarked = false;

		private void btnCreate_Click(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				if (IsInformationValid())
				{
					if (btnCreate.Text == "&Create")
					{
						modMain.ExecuteSQL($"Select * from Staff where DNI = '{StringsHelper.Replace(txtDNI.Text, "-", "", 1, -1, CompareMethod.Binary)}'");
						modMain.ExecuteSQL2($"Select * from Staff where Username = '{txtUsername.Text}'");
						if (!modMain.rs.EOF)
						{
							MessageBox.Show("DNI already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						else if (!modMain.rs2.EOF)
						{ 
							MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}

						modMain.rs.AddNew();

						MessageBox.Show("New user added successfully!", "Information", MessageBoxButtons.OK);
					}
					else if (btnCreate.Text == "&Update")
					{ 
						modMain.ExecuteSQL($"Select * from Staff where DNI = '{PreviousDNI}'");
						if (UserExists(StringsHelper.Replace(txtDNI.Text, "-", "", 1, -1, CompareMethod.Binary), txtUsername.Text))
						{
							return;
						}

						MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Fill all the required spaces in the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CheckEmptyText();
					AlreadyMarked = true;
					return;
				}

				modMain.rs["Staff_Name"] = txtName.Text;
				modMain.rs["Staff_LastName"] = txtLastName.Text;
				modMain.rs["DNI"] = StringsHelper.Replace(txtDNI.Text, "-", "", 1, -1, CompareMethod.Binary);
				modMain.rs["Phone_Number"] = StringsHelper.Replace(txtPhoneNumber.Text, "-", "", 1, -1, CompareMethod.Binary);
				modMain.rs["DateBirth"] = dtDateBirth.GetValue();
				modMain.rs["Role_ID"] = GetRoleID();
				modMain.rs["UserName"] = txtUsername.Text;
				modMain.rs["Password"] = txtPassword.Text;
				modMain.rs["Available"] = true;
				modMain.rs["PreviousRole_ID"] = GetRoleID();
				modMain.rs.Update();

				AlreadyMarked = false;
				CommonFunctions.RemoveMark(this);
				ClearForm();
			}
			catch
			{
				MessageBox.Show("There was an error during the operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		public bool UserExists(string UserDNI, string UserName)
		{
			bool result = false;
			modMain.ExecuteSQL2($"Select * from Staff where DNI = '{UserDNI}'");
			modMain.ExecuteSQL3($"Select * from Staff where Username = '{UserName}'");
			if (UserDNI == PreviousDNI && UserName == PreviousUsername)
			{
				result = false;
			}
			else if (!modMain.rs2.EOF && UserDNI != PreviousDNI)
			{ 
				MessageBox.Show("DNI already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				result = true;
			}
			else if (!modMain.rs3.EOF && UserName != PreviousUsername)
			{ 
				MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				result = true;
			}
			return result;
		}

		public void CheckEmptyText()
		{
			CommonFunctions.AddRequiredMark(lblName, Color.Red, txtName);
			CommonFunctions.AddRequiredMark(lblLastName, Color.Red, txtLastName);
			CommonFunctions.AddRequiredMark(lblDNI, Color.Red, txtDNI);
			CommonFunctions.AddRequiredMark(lblPhoneNumber, Color.Red, txtPhoneNumber);
			CommonFunctions.AddRequiredMark(lblRole, Color.Red, cmbRole);
			CommonFunctions.AddRequiredMark(lblUsername, Color.Red, txtUsername);
			CommonFunctions.AddRequiredMark(lblPassword, Color.Red, txtPassword);
		}

		public int GetRoleID()
		{
			modMain.ExecuteSQL2($"Select * from Role where Role = '{cmbRole.Text}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		private void btnReset_Click(Object eventSender, EventArgs eventArgs) => ClearForm();


		public void ClearForm()
		{
			CommonFunctions.RemoveMark(this);
			AlreadyMarked = false;
			txtName.Text = "";
			txtLastName.Text = "";
			txtDNI.Text = "";
			txtPhoneNumber.Text = "";
			dtDateBirth.SetValue(DateTime.Today);
			cmbRole.SelectedIndex = -1;
			txtUsername.Text = "";
			txtPassword.Text = "";
		}

		public bool IsInformationValid() => txtName.Text != "" && txtLastName.Text != "" && txtDNI.Text != "" && txtPhoneNumber.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && cmbRole.SelectedIndex != -1;


		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			dtDateBirth.SetValue(DateTime.Today);
			LoadRoles();
			VerifyCurrentRole();
		}

		public void VerifyCurrentRole()
		{
			if (frmMain.DefInstance.CurrentUserRoleID == 1)
			{
				MessageBox.Show("The current user does not have permission to add or modify employees information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCreate.Enabled = false;
			}
		}

		public void LoadRoles()
		{
			modMain.ExecuteSQL("Select * from Role Where ID <> 4");
			cmbRole.Clear();
			while (!modMain.rs.EOF)
			{
				cmbRole.AddItem(Convert.ToString(modMain.rs["Role"]));
				modMain.rs.MoveNext();
			}
		}

		private void txtDNI_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtDNI.Text != "")
			{
				txtDNI.Text = StringsHelper.Replace(txtDNI.Text, "-", "", 1, -1, CompareMethod.Binary);
			}
		}

		private void txtDNI_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				VerifyChar(ref KeyAscii);
				if (Strings.Len(txtDNI.Text) == 9 && KeyAscii != 8)
				{
					KeyAscii = 0;
				}
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

		public void VerifyChar(ref int KeyAscii)
		{
			if (!Information.IsNumeric(Strings.Chr(KeyAscii).ToString()) && KeyAscii != 8)
			{
				KeyAscii = 0;
				MessageBox.Show("Enter only numeric characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public void txtDNI_Leave(Object eventSender, EventArgs eventArgs) => txtDNI.Text = StringsHelper.Format(txtDNI.Text, "#-####-####");


		private void txtPhoneNumber_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtPhoneNumber.Text != "")
			{
				txtPhoneNumber.Text = StringsHelper.Replace(txtPhoneNumber.Text, "-", "", 1, -1, CompareMethod.Binary);
			}
		}

		private void txtPhoneNumber_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (Strings.Len(txtPhoneNumber.Text) == 8 && KeyAscii != 8)
				{
					KeyAscii = 0;
				}
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

		public void txtPhoneNumber_Leave(Object eventSender, EventArgs eventArgs) => txtPhoneNumber.Text = StringsHelper.Format(txtPhoneNumber.Text, "####-####");

		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}