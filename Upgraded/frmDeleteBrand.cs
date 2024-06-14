using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmDeleteBrand
		: System.Windows.Forms.Form
	{

		public frmDeleteBrand()
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


		private void frmDeleteBrand_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		private void btnDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			if (cmbManufacturer.SelectedIndex != -1)
			{
				if (MessageBox.Show($"Are you sure you want to delete the brand '{cmbManufacturer.Text}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					if (DoesBrandHasChildren(cmbManufacturer.Text))
					{
						MessageBox.Show($"The selected brand has other brands associated, it can't be deleted!{Environment.NewLine}Remove the associated brands to remove this one", "Error deleting brand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						if (AreThereVehiclesInStock(cmbManufacturer.Text))
						{
							MessageBox.Show($"The brand {cmbManufacturer.Text} has vehicles pending to sell!{Environment.NewLine}Remove or sell them to remove this brand", "Error deleting brand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else
						{
							modMain.ExecuteSQL($"Select * from Brand where Brand_Name = '{cmbManufacturer.Text}'");
							modMain.rs["Available"] = false;
							modMain.rs.Update();
							MessageBox.Show("Brand deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadManufacturers();
						}
					}
				}
			}
			else if (lstResults.Items.Count > 0 && lstResults.FocusedItem != null)
			{ 
				if (MessageBox.Show($"Are you sure you want to delete the brand '{lstResults.FocusedItem.Text}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					if (DoesBrandHasChildren(lstResults.FocusedItem.Text))
					{
						MessageBox.Show($"The selected brand has other brands associated, it can't be deleted!{Environment.NewLine}Remove the associated brands to remove this one", "Error deleting brand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						if (AreThereVehiclesInStock(lstResults.FocusedItem.Text))
						{
							MessageBox.Show($"The brand {lstResults.FocusedItem.Text} has vehicles pending to sell!{Environment.NewLine}Remove or sell them to remove this brand", "Error deleting brand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else
						{
							modMain.ExecuteSQL($"Select * from Brand where Brand_Name = '{lstResults.FocusedItem.Text}'");
							modMain.rs["Available"] = false;
							modMain.rs.Update();
							MessageBox.Show("Brand deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadManufacturers();
							LoadHeadquarters();
							LoadParents();
							LoadAreasServed();
							cmdResetFilters_Click(cmdResetFilters, new EventArgs());
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Select a brand to delete it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public bool DoesBrandHasChildren(string value)
		{
			bool result = false;
			int ParentID = GetManufacturerID(value);
			modMain.ExecuteSQL2($"Select * from Brand where Parent_Company = {ParentID.ToString()}");
			result = !modMain.rs2.EOF;
			return result;
		}

		public bool AreThereVehiclesInStock(string value)
		{
			int VehicleQuantity = 0;
			bool result = false;
			int BrandID = GetManufacturerID(value);
			modMain.ExecuteSQL2($"Select * from Vehicle where Manufacturer_ID = {BrandID.ToString()}");
			while (!modMain.rs2.EOF)
			{
				VehicleQuantity = Convert.ToInt32(modMain.rs2["Quantity"]);
				if (VehicleQuantity > 0)
				{
					result = true;
				}
				modMain.rs2.MoveNext();
			}
			return result;
		}

		private void chkFilters_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkFilters.CheckState != CheckState.Unchecked)
			{
				frameFilters.Enabled = true;
				frameFilters.Visible = true;
				this.Height = 646;
				btnDelete.Top = 528;
				cmbManufacturer.Enabled = false;
				cmbManufacturer.SelectedIndex = -1;
			}
			else
			{
				frameFilters.Enabled = false;
				frameFilters.Visible = false;
				this.Height = 267;
				btnDelete.Top = 133;
				cmbManufacturer.Enabled = true;
			}
		}

		private void cmbAreaServed_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (cmbAreaServed.Text != "")
			{
				if (chkUseAllFilters.CheckState == CheckState.Unchecked)
				{
					LoadParents();
					LoadHeadquarters();
				}
				else
				{
					if (cmbParent.Text == "")
					{
						LoadParents(cmbHeadquarter.Text, cmbAreaServed.Text);
					}
					if (cmbHeadquarter.Text == "")
					{
						LoadHeadquarters(cmbParent.Text, cmbAreaServed.Text);
					}
				}
				ShowResults(cmbHeadquarter.Text, cmbParent.Text, cmbAreaServed.Text);
			}
		}

		private void cmbHeadquarter_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (cmbHeadquarter.Text == "")
			{
				return;
			}
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadParents();
				LoadAreasServed();
			}
			else
			{
				if (cmbParent.Text == "")
				{
					LoadParents(cmbHeadquarter.Text, cmbAreaServed.Text);
				}
				if (cmbAreaServed.Text == "")
				{
					LoadAreasServed(cmbHeadquarter.Text, cmbParent.Text);
				}
			}
			ShowResults(cmbHeadquarter.Text, cmbParent.Text, cmbAreaServed.Text);
		}

		private void cmbParent_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (cmbParent.Text != "")
			{
				if (chkUseAllFilters.CheckState == CheckState.Unchecked)
				{
					LoadAreasServed();
					LoadHeadquarters();
				}
				else
				{
					if (cmbHeadquarter.Text == "")
					{
						LoadHeadquarters(cmbParent.Text, cmbAreaServed.Text);
					}
					if (cmbAreaServed.Text == "")
					{
						LoadAreasServed(cmbHeadquarter.Text, cmbParent.Text);
					}
				}
				ShowResults(cmbHeadquarter.Text, cmbParent.Text, cmbAreaServed.Text);
			}
		}

		public int GetManufacturerID(string ManufacturerName)
		{
			modMain.ExecuteSQL3($"Select * from Brand where Brand_Name = '{ManufacturerName}'");
			return Convert.ToInt32(modMain.rs3["ID"]);
		}

		public void ShowResults(string HQValue = "", string Parent_Renamed = "", string Area = "")
		{
			ListViewItem li = null;
			string ParentName = "";
			string query = "";
			try
			{

				CreateQuery(ref query, HQValue, Parent_Renamed, Area);

				modMain.ExecuteSQL(query);
				lstResults.Items.Clear();
				while (!modMain.rs.EOF)
				{
					li = lstResults.Items.Add(Convert.ToString(modMain.rs["Brand_Name"]));
					ListViewHelper.GetListViewSubItem(li, 1).Text = Convert.ToString(modMain.rs["Headquarter"]);
					//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1049
					if (!Convert.IsDBNull(modMain.rs["Parent_Company"]) && Convert.ToDouble(modMain.rs["Parent_Company"]) != 0)
					{
						ParentName = GetParentName(Convert.ToInt32(modMain.rs["Parent_Company"]));
						ListViewHelper.GetListViewSubItem(li, 2).Text = ParentName;
					}
					ListViewHelper.GetListViewSubItem(li, 3).Text = Convert.ToString(modMain.rs["Area_Served"]);
					modMain.rs.MoveNext();
				}
			}
			catch
			{
				return;
			}
		}

		private void cmdResetFilters_Click(Object eventSender, EventArgs eventArgs)
		{
			cmbAreaServed.SelectedIndex = -1;
			cmbHeadquarter.SelectedIndex = -1;
			cmbParent.SelectedIndex = -1;
			lstResults.Items.Clear();
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			LoadManufacturers();
			LoadHeadquarters();
			LoadParents();
			LoadAreasServed();
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
				MessageBox.Show("The current user does not have permission to delete brands", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnDelete.Enabled = false;
			}
		}

		public void LoadManufacturers()
		{
			modMain.ExecuteSQL2("Select * from Brand where Available = True order by Brand_Name asc ");
			cmbManufacturer.Clear();
			while (!modMain.rs2.EOF)
			{
				cmbManufacturer.AddItem(Convert.ToString(modMain.rs2["Brand_Name"]));
				modMain.rs2.MoveNext();
			}
		}

		public string GetParentName(int ParentID)
		{
			modMain.ExecuteSQL3($"Select * from Brand where ID = {ParentID.ToString()}");
			return Convert.ToString(modMain.rs3["Brand_Name"]);
		}

		public void LoadParents(string HeadquarterLocation = "", string AreaServed = "")
		{
			string ParentName = "";
			string query = "";
			CreateQuery(ref query, HeadquarterLocation, "", AreaServed);

			modMain.ExecuteSQL2(query);

			cmbParent.Clear();
			while (!modMain.rs2.EOF)
			{
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1049
				if (!Convert.IsDBNull(modMain.rs2["Parent_Company"]) && Convert.ToDouble(modMain.rs2["Parent_Company"]) != 0)
				{
					ParentName = GetParentName(Convert.ToInt32(modMain.rs2["Parent_Company"]));
					if (!CommonFunctions.ExistsInCombo(ParentName, null, cmbParent))
					{
						cmbParent.AddItem(ParentName);
					}
				}
				modMain.rs2.MoveNext();
			}
		}

		public void LoadHeadquarters(string ParentCompany = "", string AreaServed = "")
		{
			string query = "";
			string value = "";
			CreateQuery(ref query, "", ParentCompany, AreaServed);

			modMain.ExecuteSQL(query);

			cmbHeadquarter.Items.Clear();
			while (!modMain.rs.EOF)
			{
				value = Convert.ToString(modMain.rs["Headquarter"]);
				if (!CommonFunctions.ExistsInCombo(value, cmbHeadquarter))
				{
					cmbHeadquarter.AddItem(value);
				}
				modMain.rs.MoveNext();
			}
		}

		public void LoadAreasServed(string HeadquarterLocation = "", string ParentCompany = "")
		{
			string value = "";
			string query = "";
			CreateQuery(ref query, HeadquarterLocation, ParentCompany);

			modMain.ExecuteSQL(query);

			cmbAreaServed.Clear();
			while (!modMain.rs.EOF)
			{
				value = Convert.ToString(modMain.rs["Area_Served"]);
				if (!CommonFunctions.ExistsInCombo(value, null, cmbAreaServed))
				{
					cmbAreaServed.AddItem(value);
				}
				modMain.rs.MoveNext();
			}
		}

		public void CreateQuery(ref string queryOut, string HQValue = "", string Parent_Renamed = "", string Area = "")
		{
			queryOut = "Select * from Brand where Available = True";

			if (HQValue != "")
			{
				queryOut = $"{queryOut} and Headquarter = '{HQValue}'";
			}
			if (Parent_Renamed != "")
			{
				queryOut = $"{queryOut} and Parent_Company = {GetManufacturerID(Parent_Renamed).ToString()}";
			}
			if (Area != "")
			{
				queryOut = $"{queryOut} and Area_Served = '{Area}'";
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}