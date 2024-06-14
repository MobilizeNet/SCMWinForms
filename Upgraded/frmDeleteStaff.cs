using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmDeleteStaff
		: System.Windows.Forms.Form
	{

		public frmDeleteStaff()
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


		private void frmDeleteStaff_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		private void btnDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			string UserDNI = "";
			bool IsFullNameDuplicated = false;
			if (cmbFullName.SelectedIndex != -1)
			{
				if (MessageBox.Show($"Are you sure you want to delete the user '{cmbFullName.Text}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					UserDNI = GetUserDNI(ref IsFullNameDuplicated);
					if (IsFullNameDuplicated)
					{
						MessageBox.Show($"There are more than 1 user with this name.{Environment.NewLine}" +
						                $"Please use the filters to select the right user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					else
					{
						if (IsUserLastAdministrator())
						{
							MessageBox.Show("User can't be deleted because there are no more Administrators", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							modMain.ExecuteSQL($"Select * from Staff where DNI = '{UserDNI}'");
							modMain.rs["Available"] = false;
							modMain.rs["Role_ID"] = 4;
							modMain.rs.Update();
							MessageBox.Show("User deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadFullNames();
						}
					}
				}
			}
			else if (lstResults.Items.Count > 0 && lstResults.FocusedItem != null)
			{ 
				if (MessageBox.Show($"Are you sure you want to delete the user '{GetUserFullName(lstResults.FocusedItem.Text)}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					if (IsUserLastAdministrator())
					{
						MessageBox.Show("User can't be deleted because there are no more Administrators", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						modMain.ExecuteSQL($"Select * from Staff where DNI = '{lstResults.FocusedItem.Text}'");
						modMain.rs["Available"] = false;
						modMain.rs["Role_ID"] = 4;
						modMain.rs.Update();
						MessageBox.Show("User deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadLastNames();
						LoadRoles();
						cmdResetFilters_Click(cmdResetFilters, new EventArgs());
					}
				}
			}
			else
			{
				MessageBox.Show("Select an user to delete it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public bool IsUserLastAdministrator()
		{
			bool result = false;
			modMain.ExecuteSQL2("Select * from Staff where Role_ID = 3");
			if (modMain.rs2.RecordCount == 1)
			{
				result = true;
			}
			return result;
		}

		public string GetUserDNI(ref bool IsFullNameDuplicated)
		{
			string[] dividedName = cmbFullName.Text.Split(' ');
			modMain.ExecuteSQL2($"Select * from Staff where Staff_Name = '{dividedName[0]}' and Staff_LastName = '{dividedName[1]}'");
			if (modMain.rs2.RecordCount > 1)
			{
				IsFullNameDuplicated = true;
				return "";
			}
			return Convert.ToString(modMain.rs2["DNI"]);
		}

		public string GetUserFullName(string UserDNI)
		{
			modMain.ExecuteSQL2($"Select * from Staff where DNI = '{UserDNI}'");
			string FullName = $"{Convert.ToString(modMain.rs2["Staff_Name"])} {Convert.ToString(modMain.rs2["Staff_LastName"])}";
			return FullName;
		}

		private void chkFilters_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkFilters.CheckState != CheckState.Unchecked)
			{
				frameFilters.Enabled = true;
				frameFilters.Visible = true;
				this.Height = 581;
				btnDelete.Top = 464;
				cmbFullName.Enabled = false;
				cmbFullName.SelectedIndex = -1;
			}
			else
			{
				frameFilters.Enabled = false;
				frameFilters.Visible = false;
				this.Height = 267;
				btnDelete.Top = 133;
				cmbFullName.Enabled = true;
			}
		}

		private void chkUseAllFilters_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			LoadLastNames();
			LoadRoles();
		}

		private void cmbLastName_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadRoles();
			}
			else
			{
				if (cmbRole.Text == "")
				{
					LoadRoles(cmbLastName.Text);
				}
			}
			ShowResults(cmbLastName.Text, cmbRole.Text);
		}

		private void cmbRole_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadLastNames();
			}
			else
			{
				if (cmbLastName.Text == "")
				{
					LoadLastNames(cmbRole.Text);
				}
			}
			ShowResults(cmbLastName.Text, cmbRole.Text);
		}

		private void cmdResetFilters_Click(Object eventSender, EventArgs eventArgs)
		{
			LoadLastNames();
			LoadRoles();
			lstResults.Items.Clear();
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			LoadFullNames();
			LoadLastNames();
			LoadRoles();
			frameFilters.Enabled = false;
			frameFilters.Visible = false;
			this.Height = 267;
			btnDelete.Top = 133;
			VerifyCurrentRole();
		}

		public void VerifyCurrentRole()
		{
			if (frmMain.DefInstance.CurrentUserRoleID == 1)
			{
				MessageBox.Show("The current user does not have permission to delete employees", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnDelete.Enabled = false;
			}
		}

		public void LoadFullNames()
		{
			string FullName = "";
			modMain.ExecuteSQL("Select * from Staff where Available = True order by Staff_LastName asc");
			cmbFullName.Clear();
			while (!modMain.rs.EOF)
			{
				FullName = $"{Convert.ToString(modMain.rs["Staff_Name"])} {Convert.ToString(modMain.rs["Staff_LastName"])}";
				cmbFullName.AddItem(FullName);
				modMain.rs.MoveNext();
			}
		}

		public void LoadLastNames(string Role = "")
		{
			string query = "";
			string value = "";

			if (chkUseAllFilters.CheckState != CheckState.Unchecked)
			{
				CreateQuery(ref query, "", Role);

				modMain.ExecuteSQL(query);

				cmbLastName.Items.Clear();
				while (!modMain.rs.EOF)
				{
					value = Convert.ToString(modMain.rs["Staff_LastName"]);
					if (!CommonFunctions.ExistsInCombo(value, cmbLastName))
					{
						cmbLastName.AddItem(value);
					}
					modMain.rs.MoveNext();
				}
			}
			else
			{
				cmbLastName.Items.Clear();
				cmbLastName.AddItem("A-E");
				cmbLastName.AddItem("F-J");
				cmbLastName.AddItem("K-O");
				cmbLastName.AddItem("P-T");
				cmbLastName.AddItem("U-Z");
			}
		}

		public void LoadRoles(string lastName = "")
		{
			string query = "";
			string value = "";

			if (chkUseAllFilters.CheckState != CheckState.Unchecked)
			{
				CreateQuery(ref query, lastName);

				modMain.ExecuteSQL(query);

				cmbRole.Clear();
				while (!modMain.rs.EOF)
				{
					value = GetRoleName(Convert.ToInt32(modMain.rs["Role_ID"]));
					if (!CommonFunctions.ExistsInCombo(value, null, cmbRole))
					{
						cmbRole.AddItem(value);
					}
					modMain.rs.MoveNext();
				}
			}
			else
			{
				cmbRole.Clear();
				cmbRole.AddItem("Seller");
				cmbRole.AddItem("Manager");
				cmbRole.AddItem("Administrator");
			}
		}

		public string GetRoleName(int RoleID)
		{
			modMain.ExecuteSQL2($"Select * from Role where ID = {RoleID.ToString()}");
			return Convert.ToString(modMain.rs2["Role"]);
		}

		public int GetRoleID(string RoleName)
		{
			modMain.ExecuteSQL2($"Select * from Role where Role = '{RoleName}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		public void CreateQuery(ref string queryOut, string lastName = "", string Role = "")
		{
			queryOut = "Select * from Staff where Available = True";

			if (lastName != "")
			{
				GetLastNameQuery(ref queryOut, lastName);
			}
			if (Role != "")
			{
				queryOut = $"{queryOut} and Role_ID = {GetRoleID(Role).ToString()}";
			}
		}

		public void ShowResults(string lastName = "", string Role = "")
		{
			ListViewItem li = null;
			string RoleName = "";
			string query = "";
			try
			{

				CreateQuery(ref query, lastName, Role);

				modMain.ExecuteSQL(query);
				lstResults.Items.Clear();
				while (!modMain.rs.EOF)
				{
					li = lstResults.Items.Add(Convert.ToString(modMain.rs["DNI"]));
					ListViewHelper.GetListViewSubItem(li, 1).Text = Convert.ToString(modMain.rs["Staff_Name"]);
					ListViewHelper.GetListViewSubItem(li, 2).Text = Convert.ToString(modMain.rs["Staff_LastName"]);
					RoleName = GetRoleName(Convert.ToInt32(modMain.rs["Role_ID"]));
					ListViewHelper.GetListViewSubItem(li, 3).Text = RoleName;
					modMain.rs.MoveNext();
				}
			}
			catch
			{
				return;
			}
		}

		public void GetLastNameQuery(ref string queryOut, string lastName)
		{
			string[] Initials = null;
			if (Strings.Len(lastName) == 3 && (lastName.IndexOf('-') + 1) == 2)
			{
				Initials = lastName.Split('-');
				queryOut = $"{queryOut} and Staff_LastName >= '{Initials[0]}' and Staff_LastName <= '{Initials[1]}'";
			}
			else
			{
				queryOut = $"{queryOut} and Staff_LastName = '{lastName}'";
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}