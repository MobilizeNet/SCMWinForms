using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmViewStaff
		: System.Windows.Forms.Form
	{

		public frmViewStaff()
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


		private void frmViewStaff_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		int SelectedRow = 0;
		string query = "";

		private void btnExit_Click(Object eventSender, EventArgs eventArgs) => this.Close();


		private void btnShowHiddenElements_Click(Object eventSender, EventArgs eventArgs)
		{
			if (btnShowHiddenElements.Text == "&Show Deleted")
			{
				query = "Select * from Staff where Available = False Order By Staff_LastName Asc";
				FillGrid();
				btnShowHiddenElements.Text = "Show &Both";
			}
			else if (btnShowHiddenElements.Text == "Show &Both")
			{ 
				query = "Select * from Staff order by Staff_LastName asc";
				FillGrid();
				btnShowHiddenElements.Text = "&Hide Deleted";
			}
			else if (btnShowHiddenElements.Text == "&Hide Deleted")
			{ 
				query = "Select * from Staff where Available = True Order By Staff_LastName Asc";
				FillGrid();
				btnShowHiddenElements.Text = "&Show Deleted";
			}
			gridResults_SelectionChanged(gridResults, new EventArgs());
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			query = "Select * from Staff where Available = True Order By Staff_LastName Asc";
			FillGrid();
			gridResults_SelectionChanged(gridResults, new EventArgs());
		}

		public void FillGrid()
		{
			string RoleName = "";
			string value = "";
			gridResults.Clear();
			modMain.ExecuteSQL(query);
			int i = 0, k = 0;
			gridResults.ColumnsCount = 7;
			gridResults.FixedColumns = 0;
			gridResults.RowsCount = 0;
			gridResults.AddItem($"Name{"\t"}Last Name{"\t"}Identification Number{"\t"}Phone Number{"\t"}Date of Birth{"\t"}Role{"\t"}Username");
			AutoFitRows();
			i = 1;
			k = 0;
			if (modMain.rs.RecordCount == 0)
			{
				gridResults.RowsCount = 2;
				gridResults.FixedRows = 1;
				gridResults.CurrentRowIndex = 0;
				return;
			}
			while (!modMain.rs.EOF)
			{
				gridResults.RowsCount++;
				for (int j = 1; j <= 7; j++)
				{
					value = Convert.ToString(modMain.rs[j]);
					if (j == 1 || j == 2)
					{
						gridResults.SetColumnWidth(j - 1, 100);
					}
					else if (j == 3)
					{ 
						value = StringsHelper.Format(value, "#-####-####");
						gridResults.SetColumnWidth(j - 1, 107);
					}
					else if (j == 4)
					{ 
						value = StringsHelper.Format(value, "####-####");
						gridResults.SetColumnWidth(j - 1, 93);
					}
					else if (j == 5)
					{ 
						System.DateTime TempDate = DateTime.FromOADate(0);
						value = (DateTime.TryParse(value, out TempDate)) ? TempDate.ToString("MM/dd/yyyy") : value;
						gridResults.SetColumnWidth(j - 1, 100);
					}
					else if (j == 6)
					{ 
						RoleName = GetRoleName(Convert.ToInt32(modMain.rs[j]));
						value = RoleName;
						gridResults.SetColumnWidth(j - 1, 100);
					}
					gridResults[i, k].Value = value;
					k++;
				}
				modMain.rs.MoveNext();
				i++;
				k = 0;
			}
			gridResults.FixedRows = 1;
			gridResults.AllowUserToResizeColumns = gridResults.ColumnHeadersVisible;
			gridResults.AllowUserToResizeRows = false;
			//.Row = 0
		}

		public void AutoFitRows()
		{
			_ = 0;

			int tempForEndVar = gridResults.ColumnsCount - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				int Twips = Convert.ToInt32(ControlHelper.TextWidth(this, Convert.ToString(gridResults[0, i].Value)));
				gridResults.SetColumnWidth(i, (((double) (Twips * this.gridResults.Font.SizeInPoints)) / ((double) this.Font.SizeInPoints) + 530) / 15); //* Screen.TwipsPerPixelX
			}
		}

		public string GetRoleName(int RoleID)
		{
			modMain.ExecuteSQL3($"Select * from Role where ID = {RoleID.ToString()}");
			return Convert.ToString(modMain.rs3["Role"]);
		}

		public int GetRoleIndex(string RoleName, frmCreateNewStaff CreateUserForm)
		{
			int value = 0;
			int tempForEndVar = CreateUserForm.cmbRole.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateUserForm.cmbRole.GetListItem(i) == RoleName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		public int GetUserIndex(string UserName, frmDeleteStaff DeleteUserForm)
		{
			int value = 0;
			int tempForEndVar = DeleteUserForm.cmbFullName.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (DeleteUserForm.cmbFullName.GetListItem(i) == UserName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		private void gridResults_DoubleClick(Object eventSender, EventArgs eventArgs)
		{
			string SelectedUser = StringsHelper.Replace(Convert.ToString(gridResults[gridResults.CurrentRowIndex, 2].Value), "-", "", 1, -1, CompareMethod.Binary);
			modMain.ExecuteSQL2($"Select * from Staff where DNI = '{SelectedUser}'");
			if (modMain.rs2.EOF || modMain.rs2.RecordCount == 0)
			{
				MessageBox.Show("Please select a valid item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_ = "";
			_ = 0;
			frmCreateNewStaff f = null;
			if (btnEdit.Text == "&Edit")
			{
				f = frmCreateNewStaff.CreateInstance();
				f.txtName.Text = Convert.ToString(modMain.rs2["Staff_Name"]);
				f.txtLastName.Text = Convert.ToString(modMain.rs2["Staff_LastName"]);
				f.txtDNI.Text = Convert.ToString(modMain.rs2["DNI"]);
				f.txtPhoneNumber.Text = Convert.ToString(modMain.rs2["Phone_Number"]);
				f.dtDateBirth.SetValue(modMain.rs2["DateBirth"]);
				string RoleName = GetRoleName(Convert.ToInt32(modMain.rs2["Role_ID"]));
				int RoleIndex = GetRoleIndex(RoleName, f);
				f.cmbRole.Text = f.cmbRole.GetListItem(RoleIndex);
				f.txtUsername.Text = Convert.ToString(modMain.rs2["UserName"]);
				f.PreviousDNI = Convert.ToString(modMain.rs2["DNI"]);
				f.PreviousUsername = Convert.ToString(modMain.rs2["UserName"]);
				f.btnCreate.Text = "&Update";
				f.btnReset.Enabled = false;
				f.txtDNI_Leave(null, new EventArgs());
				f.txtPhoneNumber_Leave(null, new EventArgs());
				f.ShowDialog(this);
			}
			else if (btnEdit.Text == "&Restore user")
			{ 
				modMain.rs2["Available"] = true;
				modMain.rs2["Role_ID"] = modMain.rs2["PreviousRole_ID"];
				modMain.rs2.Update();

				MessageBox.Show("User restored successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//btnEdit.Caption = "&Edit"
				//btnDelete.Enabled = True
			}
			SelectedRow = gridResults.CurrentRowIndex;
			FillGrid();
			SelectLastRow();
		}

		private void gridResults_Click(Object eventSender, EventArgs eventArgs) => gridResults_SelectionChanged(gridResults, new EventArgs());


		public void SelectLastRow()
		{
			if (gridResults.RowsCount > SelectedRow)
			{
				gridResults.CurrentRowIndex = SelectedRow;
			}
			else
			{
				gridResults.CurrentRowIndex = gridResults.RowsCount - 1;
			}
		}

		private void btnDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			string SelectedUser = $"{Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value)} {Convert.ToString(gridResults[gridResults.CurrentRowIndex, 1].Value)}";
			frmDeleteStaff f = frmDeleteStaff.CreateInstance();
			int UserIndex = GetUserIndex(SelectedUser, f);
			f.cmbFullName.Text = f.cmbFullName.GetListItem(UserIndex);
			SelectedRow = gridResults.CurrentRowIndex;
			f.ShowDialog(this);
			FillGrid();
			SelectLastRow();
		}

		private void btnEdit_Click(Object eventSender, EventArgs eventArgs) => gridResults_DoubleClick(gridResults, new EventArgs());


		private void gridResults_SelectionChanged(Object eventSender, EventArgs eventArgs)
		{
			string CurrentEmployee = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 2].Value);
			_ = "";
			if (gridResults.CurrentRowIndex > 0 && CurrentEmployee != "" && CurrentEmployee != "Identification Number")
			{
				_ = false;
				string SelectedUser = StringsHelper.Replace(CurrentEmployee, "-", "", 1, -1, CompareMethod.Binary);
				if (SelectedUser == "")
				{
					return;
				}
				modMain.ExecuteSQL3($"Select * from Staff where DNI = '{SelectedUser}'");
				bool currentBool = Convert.ToBoolean(modMain.rs3["Available"]);
				if (!currentBool)
				{
					btnEdit.Text = "&Restore user";
					btnDelete.Enabled = false;
					btnEdit.Enabled = true;
				}
				else if (currentBool)
				{ 
					btnEdit.Text = "&Edit";
					btnEdit.Enabled = true;
					btnDelete.Enabled = true;
				}
			}
			else
			{
				btnDelete.Enabled = false;
				btnEdit.Enabled = false;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}