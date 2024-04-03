using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmDeleteVehicle
		: System.Windows.Forms.Form
	{

		public frmDeleteVehicle()
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


		private void frmDeleteVehicle_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		private void btnDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			if (cmbModel.SelectedIndex != -1)
			{
				if (MessageBox.Show($"Are you sure you want to delete the vehicle model '{cmbModel.Text}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					if (AreThereVehiclesInStock(cmbModel.Text))
					{
						MessageBox.Show($"The selected model {cmbManufacturer.Text} has vehicles pending to sell!{Environment.NewLine}Remove or sell them to delete this model", "Error deleting vehicle model", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						modMain.ExecuteSQL($"Select * from Vehicle where Vehicle_Name = '{cmbModel.Text}'");
						modMain.rs["Available"] = false;
						modMain.rs["Quantity"] = 0;
						modMain.rs.Update();
						MessageBox.Show("Model deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadModels();
					}
				}
			}
			else if (lstResults.Items.Count > 0 && lstResults.FocusedItem != null)
			{ 
				if (MessageBox.Show($"Are you sure you want to delete the selected vehicle model '{lstResults.FocusedItem.Text}'?", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					if (AreThereVehiclesInStock(cmbModel.Text))
					{
						MessageBox.Show($"The selected model {lstResults.FocusedItem.Text} has vehicles pending to sell!{Environment.NewLine}Remove or sell them to delete this model", "Error deleting vehicle model", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						modMain.ExecuteSQL($"Select * from Vehicle where Vehicle_Name = '{lstResults.FocusedItem.Text}'");
						modMain.rs["Available"] = false;
						modMain.rs["Quantity"] = 0;
						modMain.rs.Update();
						MessageBox.Show("Model deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadBodyStyles();
						LoadClasses();
						LoadManufacturers();
						LoadYears();
						LoadTransmissions();
						LoadPrices();
						cmdResetFilters_Click(cmdResetFilters, new EventArgs());
					}
				}
			}
			else
			{
				MessageBox.Show("Select a vehicle model to delete it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public bool AreThereVehiclesInStock(string Model)
		{
			bool result = false;
			_ = 0;
			modMain.ExecuteSQL2($"Select * from Vehicle where Vehicle_Name = '{Model}'");
			while (!modMain.rs2.EOF)
			{
				int VehicleQuantity = Convert.ToInt32(modMain.rs2["Quantity"]);
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
				this.Height = 662;
				btnDelete.Top = 544;
				cmbModel.Enabled = false;
				cmbModel.SelectedIndex = -1;
			}
			else
			{
				frameFilters.Enabled = false;
				frameFilters.Visible = false;
				this.Height = 267;
				btnDelete.Top = 133;
				cmbModel.Enabled = true;
			}
		}

		private void chkUseAllFilters_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			LoadClasses();
			LoadTransmissions();
			LoadBodyStyles();
		}

		private void cmbBodyStyle_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadManufacturers();
				LoadClasses();
				LoadPrices();
				LoadTransmissions();
				LoadYears();
			}
			else
			{
				if (cmbManufacturer.Text == "")
				{
					string tempRefParam = cmbPrice.Text;
					LoadManufacturers(cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam, cmbYear.Text);
				}
				if (cmbClass.Text == "")
				{
					string tempRefParam2 = cmbPrice.Text;
					LoadClasses(cmbManufacturer.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam2, cmbYear.Text);
				}
				if (cmbPrice.Text == "")
				{
					LoadPrices(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text);
				}
				if (cmbTransmission.Text == "")
				{
					string tempRefParam3 = cmbPrice.Text;
					LoadTransmissions(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, ref tempRefParam3, cmbYear.Text);
				}
				if (cmbYear.Text == "")
				{
					string tempRefParam4 = cmbPrice.Text;
					LoadYears(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text, ref tempRefParam4);
				}
			}
			string tempRefParam5 = cmbPrice.Text;
			ShowResults(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam5, cmbYear.Text);
		}

		private void cmbClass_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadManufacturers();
				LoadBodyStyles();
				LoadPrices();
				LoadTransmissions();
				LoadYears();
			}
			else
			{
				if (cmbManufacturer.Text == "")
				{
					string tempRefParam = cmbPrice.Text;
					LoadManufacturers(cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam, cmbYear.Text);
				}
				if (cmbBodyStyle.Text == "")
				{
					string tempRefParam2 = cmbPrice.Text;
					LoadBodyStyles(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, ref tempRefParam2, cmbYear.Text);
				}
				if (cmbPrice.Text == "")
				{
					LoadPrices(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text);
				}
				if (cmbTransmission.Text == "")
				{
					string tempRefParam3 = cmbPrice.Text;
					LoadTransmissions(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, ref tempRefParam3, cmbYear.Text);
				}
				if (cmbYear.Text == "")
				{
					string tempRefParam4 = cmbPrice.Text;
					LoadYears(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text, ref tempRefParam4);
				}
			}
			string tempRefParam5 = cmbPrice.Text;
			ShowResults(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam5, cmbYear.Text);
		}

		private void cmbManufacturer_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadClasses();
				LoadBodyStyles();
				LoadPrices();
				LoadTransmissions();
				LoadYears();
			}
			else
			{
				if (cmbClass.Text == "")
				{
					string tempRefParam = cmbPrice.Text;
					LoadClasses(cmbManufacturer.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam, cmbYear.Text);
				}
				if (cmbBodyStyle.Text == "")
				{
					string tempRefParam2 = cmbPrice.Text;
					LoadBodyStyles(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, ref tempRefParam2, cmbYear.Text);
				}
				if (cmbPrice.Text == "")
				{
					LoadPrices(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text);
				}
				if (cmbTransmission.Text == "")
				{
					string tempRefParam3 = cmbPrice.Text;
					LoadTransmissions(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, ref tempRefParam3, cmbYear.Text);
				}
				if (cmbYear.Text == "")
				{
					string tempRefParam4 = cmbPrice.Text;
					LoadYears(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text, ref tempRefParam4);
				}
			}
			string tempRefParam5 = cmbPrice.Text;
			ShowResults(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam5, cmbYear.Text);
		}

		private void cmbPrice_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadClasses();
				LoadBodyStyles();
				LoadManufacturers();
				LoadTransmissions();
				LoadYears();
			}
			else
			{
				if (cmbClass.Text == "")
				{
					string tempRefParam = cmbPrice.Text;
					LoadClasses(cmbManufacturer.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam, cmbYear.Text);
				}
				if (cmbBodyStyle.Text == "")
				{
					string tempRefParam2 = cmbPrice.Text;
					LoadBodyStyles(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, ref tempRefParam2, cmbYear.Text);
				}
				if (cmbManufacturer.Text == "")
				{
					string tempRefParam3 = cmbPrice.Text;
					LoadManufacturers(cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam3, cmbYear.Text);
				}
				if (cmbTransmission.Text == "")
				{
					string tempRefParam4 = cmbPrice.Text;
					LoadTransmissions(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, ref tempRefParam4, cmbYear.Text);
				}
				if (cmbYear.Text == "")
				{
					string tempRefParam5 = cmbPrice.Text;
					LoadYears(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text, ref tempRefParam5);
				}
			}
			string tempRefParam6 = cmbPrice.Text;
			ShowResults(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam6, cmbYear.Text);
		}

		private void cmbTransmission_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadClasses();
				LoadBodyStyles();
				LoadManufacturers();
				LoadPrices();
				LoadYears();
			}
			else
			{
				if (cmbClass.Text == "")
				{
					string tempRefParam = cmbPrice.Text;
					LoadClasses(cmbManufacturer.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam, cmbYear.Text);
				}
				if (cmbBodyStyle.Text == "")
				{
					string tempRefParam2 = cmbPrice.Text;
					LoadBodyStyles(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, ref tempRefParam2, cmbYear.Text);
				}
				if (cmbManufacturer.Text == "")
				{
					string tempRefParam3 = cmbPrice.Text;
					LoadManufacturers(cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam3, cmbYear.Text);
				}
				if (cmbPrice.Text == "")
				{
					LoadPrices(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text);
				}
				if (cmbYear.Text == "")
				{
					string tempRefParam4 = cmbPrice.Text;
					LoadYears(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text, ref tempRefParam4);
				}
			}
			string tempRefParam5 = cmbPrice.Text;
			ShowResults(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam5, cmbYear.Text);
		}

		private void cmbYear_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (chkUseAllFilters.CheckState == CheckState.Unchecked)
			{
				LoadClasses();
				LoadBodyStyles();
				LoadManufacturers();
				LoadPrices();
				LoadTransmissions();
			}
			else
			{
				if (cmbClass.Text == "")
				{
					string tempRefParam = cmbPrice.Text;
					LoadClasses(cmbManufacturer.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam, cmbYear.Text);
				}
				if (cmbBodyStyle.Text == "")
				{
					string tempRefParam2 = cmbPrice.Text;
					LoadBodyStyles(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, ref tempRefParam2, cmbYear.Text);
				}
				if (cmbManufacturer.Text == "")
				{
					string tempRefParam3 = cmbPrice.Text;
					LoadManufacturers(cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam3, cmbYear.Text);
				}
				if (cmbPrice.Text == "")
				{
					LoadPrices(cmbManufacturer.Text, cmbClass.Text, cmbTransmission.Text, cmbBodyStyle.Text);
				}
				if (cmbTransmission.Text == "")
				{
					string tempRefParam4 = cmbPrice.Text;
					LoadTransmissions(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, ref tempRefParam4, cmbYear.Text);
				}
			}
			string tempRefParam5 = cmbPrice.Text;
			ShowResults(cmbManufacturer.Text, cmbClass.Text, cmbBodyStyle.Text, cmbTransmission.Text, ref tempRefParam5, cmbYear.Text);
		}

		private void cmdResetFilters_Click(Object eventSender, EventArgs eventArgs)
		{
			cmbManufacturer.SelectedIndex = -1;
			cmbClass.SelectedIndex = -1;
			cmbBodyStyle.SelectedIndex = -1;
			cmbTransmission.SelectedIndex = -1;
			cmbPrice.SelectedIndex = -1;
			cmbYear.SelectedIndex = -1;
			lstResults.Items.Clear();
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			LoadModels();
			LoadManufacturers();
			LoadClasses();
			LoadBodyStyles();
			LoadTransmissions();
			LoadPrices();
			LoadYears();
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
				MessageBox.Show("The current user does not have permission to delete vehicles", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnDelete.Enabled = false;
			}
		}

		public void LoadModels()
		{
			modMain.ExecuteSQL("Select * from Vehicle where Available = True Order By Vehicle_Name ASC");
			cmbModel.Clear();
			while (!modMain.rs.EOF)
			{
				cmbModel.AddItem(Convert.ToString(modMain.rs["Vehicle_Name"]));
				modMain.rs.MoveNext();
			}
		}

		public void LoadManufacturers(string class_Renamed, string bodyStyle, string Transmission, ref string Price, string pYear)
		{
			string query = "";
			_ = "";

			CreateQuery(ref query, "", class_Renamed, bodyStyle, Transmission, ref Price, pYear);

			modMain.ExecuteSQL(query);

			cmbManufacturer.Items.Clear();
			while (!modMain.rs.EOF)
			{
				string ManufacturerName = GetManufacturerName(Convert.ToInt32(modMain.rs["Manufacturer_ID"]));
				if (!CommonFunctions.ExistsInCombo(ManufacturerName, cmbManufacturer))
				{
					cmbManufacturer.AddItem(ManufacturerName);
				}
				modMain.rs.MoveNext();
			}
		}

		public void LoadManufacturers(string class_Renamed, string bodyStyle, string Transmission, ref string Price) => LoadManufacturers(class_Renamed, bodyStyle, Transmission, ref Price, "");


		public void LoadManufacturers(string class_Renamed, string bodyStyle, string Transmission)
		{
			string tempRefParam = "";
			LoadManufacturers(class_Renamed, bodyStyle, Transmission, ref tempRefParam, "");
		}

		public void LoadManufacturers(string class_Renamed, string bodyStyle)
		{
			string tempRefParam2 = "";
			LoadManufacturers(class_Renamed, bodyStyle, "", ref tempRefParam2, "");
		}

		public void LoadManufacturers(string class_Renamed)
		{
			string tempRefParam3 = "";
			LoadManufacturers(class_Renamed, "", "", ref tempRefParam3, "");
		}

		public void LoadManufacturers()
		{
			string tempRefParam4 = "";
			LoadManufacturers("", "", "", ref tempRefParam4, "");
		}

		public void LoadClasses(string manufacturer, string bodyStyle, string Transmission, ref string Price, string pYear)
		{
			string query = "";
			string ClassName = "";

			if (chkUseAllFilters.CheckState == CheckState.Checked)
			{
				CreateQuery(ref query, manufacturer, "", bodyStyle, Transmission, ref Price, pYear);

				modMain.ExecuteSQL(query);

				cmbClass.Clear();
				while (!modMain.rs.EOF)
				{
					ClassName = GetClassName(Convert.ToString(modMain.rs["Class_ID"]));
					if (!CommonFunctions.ExistsInCombo(ClassName, null, cmbClass))
					{
						cmbClass.AddItem(ClassName);
					}
					modMain.rs.MoveNext();
				}
			}
			else
			{
				modMain.ExecuteSQL("Select * from Class");
				cmbClass.Clear();
				while (!modMain.rs.EOF)
				{
					ClassName = Convert.ToString(modMain.rs["Class_Name"]);
					if (!CommonFunctions.ExistsInCombo(ClassName, null, cmbClass))
					{
						cmbClass.AddItem(ClassName);
					}
					modMain.rs.MoveNext();
				}
			}
		}

		public void LoadClasses(string manufacturer, string bodyStyle, string Transmission, ref string Price) => LoadClasses(manufacturer, bodyStyle, Transmission, ref Price, "");


		public void LoadClasses(string manufacturer, string bodyStyle, string Transmission)
		{
			string tempRefParam5 = "";
			LoadClasses(manufacturer, bodyStyle, Transmission, ref tempRefParam5, "");
		}

		public void LoadClasses(string manufacturer, string bodyStyle)
		{
			string tempRefParam6 = "";
			LoadClasses(manufacturer, bodyStyle, "", ref tempRefParam6, "");
		}

		public void LoadClasses(string manufacturer)
		{
			string tempRefParam7 = "";
			LoadClasses(manufacturer, "", "", ref tempRefParam7, "");
		}

		public void LoadClasses()
		{
			string tempRefParam8 = "";
			LoadClasses("", "", "", ref tempRefParam8, "");
		}


		public void LoadBodyStyles(string manufacturer, string class_Renamed, string Transmission, ref string Price, string pYear)
		{
			string query = "";
			string value = "";

			if (chkUseAllFilters.CheckState == CheckState.Checked)
			{
				CreateQuery(ref query, manufacturer, class_Renamed, "", Transmission, ref Price, pYear);

				modMain.ExecuteSQL(query);

				cmbBodyStyle.Clear();
				while (!modMain.rs.EOF)
				{
					value = Convert.ToString(modMain.rs["Body_Style"]);
					if (!CommonFunctions.ExistsInCombo(value, null, cmbBodyStyle))
					{
						cmbBodyStyle.AddItem(value);
					}
					modMain.rs.MoveNext();
				}
				//rs.Close
			}
			else
			{
				cmbBodyStyle.Clear();
				cmbBodyStyle.AddItem("Buggy");
				cmbBodyStyle.AddItem("Convertible");
				cmbBodyStyle.AddItem("Coupé");
				cmbBodyStyle.AddItem("Flower Car / Hearse");
				cmbBodyStyle.AddItem("Hatchback");
				cmbBodyStyle.AddItem("Limousine");
				cmbBodyStyle.AddItem("Microvan");
				cmbBodyStyle.AddItem("Minivan");
				cmbBodyStyle.AddItem("Panel van");
				cmbBodyStyle.AddItem("Panel truck");
				cmbBodyStyle.AddItem("Pickup truck");
				cmbBodyStyle.AddItem("Roadster");
				cmbBodyStyle.AddItem("Sedan");
				cmbBodyStyle.AddItem("Shooting -brake");
				cmbBodyStyle.AddItem("SUV");
				cmbBodyStyle.AddItem("Station wagon");
				cmbBodyStyle.AddItem("Targa Top");
				cmbBodyStyle.AddItem("Ute / Coupe utility");
			}
		}

		public void LoadBodyStyles(string manufacturer, string class_Renamed, string Transmission, ref string Price) => LoadBodyStyles(manufacturer, class_Renamed, Transmission, ref Price, "");


		public void LoadBodyStyles(string manufacturer, string class_Renamed, string Transmission)
		{
			string tempRefParam9 = "";
			LoadBodyStyles(manufacturer, class_Renamed, Transmission, ref tempRefParam9, "");
		}

		public void LoadBodyStyles(string manufacturer, string class_Renamed)
		{
			string tempRefParam10 = "";
			LoadBodyStyles(manufacturer, class_Renamed, "", ref tempRefParam10, "");
		}

		public void LoadBodyStyles(string manufacturer)
		{
			string tempRefParam11 = "";
			LoadBodyStyles(manufacturer, "", "", ref tempRefParam11, "");
		}

		public void LoadBodyStyles()
		{
			string tempRefParam12 = "";
			LoadBodyStyles("", "", "", ref tempRefParam12, "");
		}

		public void LoadTransmissions(string manufacturer, string class_Renamed, string bodyStyle, ref string Price, string pYear)
		{
			string query = "";
			string value = "";

			if (chkUseAllFilters.CheckState == CheckState.Checked)
			{

				CreateQuery(ref query, manufacturer, class_Renamed, bodyStyle, "", ref Price, pYear);

				modMain.ExecuteSQL(query);

				cmbTransmission.Clear();
				while (!modMain.rs.EOF)
				{
					value = Convert.ToString(modMain.rs["Transmission"]);
					if (!CommonFunctions.ExistsInCombo(value, null, cmbTransmission))
					{
						cmbTransmission.AddItem(value);
					}
					modMain.rs.MoveNext();
				}
			}
			else
			{
				cmbTransmission.Clear();
				cmbTransmission.AddItem("Automatic");
				cmbTransmission.AddItem("Manual");
			}
		}

		public void LoadTransmissions(string manufacturer, string class_Renamed, string bodyStyle, ref string Price) => LoadTransmissions(manufacturer, class_Renamed, bodyStyle, ref Price, "");


		public void LoadTransmissions(string manufacturer, string class_Renamed, string bodyStyle)
		{
			string tempRefParam13 = "";
			LoadTransmissions(manufacturer, class_Renamed, bodyStyle, ref tempRefParam13, "");
		}

		public void LoadTransmissions(string manufacturer, string class_Renamed)
		{
			string tempRefParam14 = "";
			LoadTransmissions(manufacturer, class_Renamed, "", ref tempRefParam14, "");
		}

		public void LoadTransmissions(string manufacturer)
		{
			string tempRefParam15 = "";
			LoadTransmissions(manufacturer, "", "", ref tempRefParam15, "");
		}

		public void LoadTransmissions()
		{
			string tempRefParam16 = "";
			LoadTransmissions("", "", "", ref tempRefParam16, "");
		}

		public void LoadPrices(string manufacturer = "", string class_Renamed = "", string Transmission = "", string bodyStyle = "", string pYear = "")
		{
			string query = "";
			string value = "";

			if (chkUseAllFilters.CheckState == CheckState.Checked)
			{

				string tempRefParam = "";
				CreateQuery(ref query, manufacturer, class_Renamed, bodyStyle, Transmission, ref tempRefParam, pYear);

				modMain.ExecuteSQL(query);

				cmbPrice.Clear();
				while (!modMain.rs.EOF)
				{
					value = Convert.ToString(modMain.rs["Price"]);
					if (!CommonFunctions.ExistsInCombo(value, null, cmbPrice))
					{
						cmbPrice.AddItem(value);
					}
					modMain.rs.MoveNext();
				}
			}
			else
			{
				cmbPrice.Clear();
				cmbPrice.AddItem("0 - 1000");
				cmbPrice.AddItem("1000 - 2000");
				cmbPrice.AddItem("2000 - 3000");
				cmbPrice.AddItem("3000 - 5000");
				cmbPrice.AddItem("5000 - 10000");
				cmbPrice.AddItem("10000 - 20000");
				cmbPrice.AddItem("20000 - 50000");
				cmbPrice.AddItem("50000+");
			}
		}

		public void LoadYears(string manufacturer, string class_Renamed, string Transmission, string bodyStyle, ref string Price)
		{
			string query = "", value = "";

			CreateQuery(ref query, manufacturer, class_Renamed, bodyStyle, Transmission, ref Price);
			query = $"{query} order by Produced asc";

			modMain.ExecuteSQL(query);

			cmbYear.Items.Clear();
			while (!modMain.rs.EOF)
			{
				value = Convert.ToString(modMain.rs["Produced"]);
				if (!CommonFunctions.ExistsInCombo(value, cmbYear))
				{
					cmbYear.AddItem(value);
				}
				modMain.rs.MoveNext();
			}

		}

		public void LoadYears(string manufacturer, string class_Renamed, string Transmission, string bodyStyle)
		{
			string tempRefParam17 = "";
			LoadYears(manufacturer, class_Renamed, Transmission, bodyStyle, ref tempRefParam17);
		}

		public void LoadYears(string manufacturer, string class_Renamed, string Transmission)
		{
			string tempRefParam18 = "";
			LoadYears(manufacturer, class_Renamed, Transmission, "", ref tempRefParam18);
		}

		public void LoadYears(string manufacturer, string class_Renamed)
		{
			string tempRefParam19 = "";
			LoadYears(manufacturer, class_Renamed, "", "", ref tempRefParam19);
		}

		public void LoadYears(string manufacturer)
		{
			string tempRefParam20 = "";
			LoadYears(manufacturer, "", "", "", ref tempRefParam20);
		}

		public void LoadYears()
		{
			string tempRefParam21 = "";
			LoadYears("", "", "", "", ref tempRefParam21);
		}

		public void ShowResults(string manufacturer, string class_Renamed, string bodyStyle, string pTransmission, ref string pPrice, string pYear)
		{
			ListViewItem li = null;
			string ManufacturerName = "", ClassName = "";
			string query = "";
			try
			{

				CreateQuery(ref query, manufacturer, class_Renamed, bodyStyle, pTransmission, ref pPrice, pYear);

				modMain.ExecuteSQL(query);
				lstResults.Items.Clear();
				while (!modMain.rs.EOF)
				{
					li = lstResults.Items.Add(Convert.ToString(modMain.rs["Vehicle_Name"]));
					ManufacturerName = GetManufacturerName(Convert.ToInt32(modMain.rs["Manufacturer_ID"]));
					ListViewHelper.GetListViewSubItem(li, 1).Text = ManufacturerName;
					ClassName = GetClassName(Convert.ToString(modMain.rs["Class_ID"]));
					ListViewHelper.GetListViewSubItem(li, 2).Text = ClassName;
					ListViewHelper.GetListViewSubItem(li, 3).Text = Convert.ToString(modMain.rs["Body_Style"]);
					ListViewHelper.GetListViewSubItem(li, 4).Text = Convert.ToString(modMain.rs["Transmission"]);
					ListViewHelper.GetListViewSubItem(li, 5).Text = Convert.ToString(modMain.rs["Price"]);
					ListViewHelper.GetListViewSubItem(li, 6).Text = Convert.ToString(modMain.rs["Produced"]);
					ListViewHelper.GetListViewSubItem(li, 7).Text = Convert.ToString(modMain.rs["Quantity"]);
					modMain.rs.MoveNext();
				}
			}
			catch
			{
				return;
			}
		}

		public void ShowResults(string manufacturer, string class_Renamed, string bodyStyle, string pTransmission, ref string pPrice) => ShowResults(manufacturer, class_Renamed, bodyStyle, pTransmission, ref pPrice, "");


		public void ShowResults(string manufacturer, string class_Renamed, string bodyStyle, string pTransmission)
		{
			string tempRefParam22 = "";
			ShowResults(manufacturer, class_Renamed, bodyStyle, pTransmission, ref tempRefParam22, "");
		}

		public void ShowResults(string manufacturer, string class_Renamed, string bodyStyle)
		{
			string tempRefParam23 = "";
			ShowResults(manufacturer, class_Renamed, bodyStyle, "", ref tempRefParam23, "");
		}

		public void ShowResults(string manufacturer, string class_Renamed)
		{
			string tempRefParam24 = "";
			ShowResults(manufacturer, class_Renamed, "", "", ref tempRefParam24, "");
		}

		public void ShowResults(string manufacturer)
		{
			string tempRefParam25 = "";
			ShowResults(manufacturer, "", "", "", ref tempRefParam25, "");
		}

		public void ShowResults()
		{
			string tempRefParam26 = "";
			ShowResults("", "", "", "", ref tempRefParam26, "");
		}

		public void CreateQuery(ref string queryOut, string manufacturer, string class_Renamed, string bodyStyle, string Transmission, ref string Price, string pYear)
		{
			queryOut = "Select * from Vehicle where Available = True";

			if (manufacturer != "")
			{
				queryOut = $"{queryOut} and Manufacturer_ID = {GetManufacturerID(manufacturer).ToString()}";
			}
			if (class_Renamed != "")
			{
				queryOut = $"{queryOut} and Class_ID = {GetClassID(class_Renamed).ToString()}";
			}
			if (bodyStyle != "")
			{
				queryOut = $"{queryOut} and Body_Style = '{bodyStyle}'";
			}
			if (Transmission != "")
			{
				queryOut = $"{queryOut} and Transmission = '{Transmission}'";
			}
			if (Price != "")
			{
				if (Price != "50000+")
				{
					GetPriceQuery(ref queryOut, ref Price, false);
				}
				else
				{
					GetPriceQuery(ref queryOut, ref Price, true);
				}
			}
			if (pYear != "")
			{
				queryOut = $"{queryOut} and Produced = {pYear}";
			}

		}

		public void CreateQuery(ref string queryOut, string manufacturer, string class_Renamed, string bodyStyle, string Transmission, ref string Price) => CreateQuery(ref queryOut, manufacturer, class_Renamed, bodyStyle, Transmission, ref Price, "");


		public void CreateQuery(ref string queryOut, string manufacturer, string class_Renamed, string bodyStyle, string Transmission)
		{
			string tempRefParam27 = "";
			CreateQuery(ref queryOut, manufacturer, class_Renamed, bodyStyle, Transmission, ref tempRefParam27, "");
		}

		public void CreateQuery(ref string queryOut, string manufacturer, string class_Renamed, string bodyStyle)
		{
			string tempRefParam28 = "";
			CreateQuery(ref queryOut, manufacturer, class_Renamed, bodyStyle, "", ref tempRefParam28, "");
		}

		public void CreateQuery(ref string queryOut, string manufacturer, string class_Renamed)
		{
			string tempRefParam29 = "";
			CreateQuery(ref queryOut, manufacturer, class_Renamed, "", "", ref tempRefParam29, "");
		}

		public void CreateQuery(ref string queryOut, string manufacturer)
		{
			string tempRefParam30 = "";
			CreateQuery(ref queryOut, manufacturer, "", "", "", ref tempRefParam30, "");
		}

		public void CreateQuery(ref string queryOut)
		{
			string tempRefParam31 = "";
			CreateQuery(ref queryOut, "", "", "", "", ref tempRefParam31, "");
		}

		public void GetPriceQuery(ref string queryOut, ref string Price, bool IsHighPrice)
		{
			Price = StringsHelper.Replace(Price, " ", "", 1, -1, CompareMethod.Binary);
			string[] Prices = Price.Split('-');
			if (chkUseAllFilters.CheckState == CheckState.Checked)
			{
				queryOut = $"{queryOut} and Price = {Double.Parse(Prices[0]).ToString()}";
			}
			else
			{
				if (!IsHighPrice)
				{
					queryOut = $"{queryOut} and Price >= {Double.Parse(Prices[0]).ToString()} and Price <= {Double.Parse(Prices[1]).ToString()}";
				}
				else
				{
					queryOut = $"{queryOut} and Price >= {Double.Parse(StringsHelper.Replace(Price, "+", "", 1, -1, CompareMethod.Binary)).ToString()}";
				}
			}
		}

		public int GetManufacturerID(string ManufacturerName)
		{
			modMain.ExecuteSQL2($"Select * from Brand where Brand_Name = '{ManufacturerName}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		public string GetManufacturerName(int ManufacturerID)
		{
			modMain.ExecuteSQL2($"Select * from Brand where ID = {ManufacturerID.ToString()}");
			return Convert.ToString(modMain.rs2["Brand_Name"]);
		}

		public int GetClassID(string ClassName)
		{
			modMain.ExecuteSQL2($"Select * from Class where Class_Name = '{ClassName}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		public string GetClassName(string ClassID)
		{
			modMain.ExecuteSQL2($"Select * from Class where ID = {ClassID}");
			return Convert.ToString(modMain.rs2["Class_Name"]);
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}