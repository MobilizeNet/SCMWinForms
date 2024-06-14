using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmCreateNewReceipt
		: System.Windows.Forms.Form
	{

		public frmCreateNewReceipt()
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


		private void frmCreateNewReceipt_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		bool AlreadyMarked = false;
		public double SubTotalValue = 0;
		public double TotalValue = 0;
		public string PreviousStatus = "";
		const int VehicleInsuranceValue = 4000;
		const int ThirdPersonInsuranceValue = 7500;

		private void btnCreate_Click(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				int Subtotal = 0;
				int Total = 0;
				if (IsInformationValid() && IsQuantityAvailable())
				{
					if (btnCreate.Text == "&Create")
					{
						modMain.ExecuteSQL("Select * from Receipt");
						modMain.rs.AddNew();
						modMain.rs["Receipt_ID"] = txtID.Text;
						PreviousStatus = "Approved";
						MessageBox.Show("New receipt created successfully!", "Information", MessageBoxButtons.OK);
					}
					else if (btnCreate.Text == "&Update")
					{ 
						modMain.ExecuteSQL($"Select * from Receipt where Receipt_ID = '{txtID.Text}'");
						MessageBox.Show("Receipt updated successfully!", "Information", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Fill all the required spaces in the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CheckEmptyText();
					AlreadyMarked = true;
					return;
				}
				modMain.rs["Client_Name"] = txtName.Text;
				modMain.rs["Client_LastName"] = txtLastName.Text;
				modMain.rs["Manufacturer_ID"] = GetManufacturerID();
				modMain.rs["Model_ID"] = GetModelID();
				modMain.rs["Quantity"] = Double.Parse(txtQuantity.Text, NumberStyles.Any).ToString("N0");
				modMain.rs["Seller_ID"] = GetSellerID();
				modMain.rs["Vehicle_Insurance"] = chkVehicleInsurance.CheckState;
				modMain.rs["Third_Person_Insurance"] = chk3PersonInsurance.CheckState;
				Subtotal = Convert.ToInt32(Double.Parse(Double.Parse(StringsHelper.Replace(txtSubTotal.Text, "$", "", 1, -1, CompareMethod.Binary), NumberStyles.Any).ToString("N0")));
				modMain.rs["Subtotal"] = Subtotal;
				Total = Convert.ToInt32(Double.Parse(Double.Parse(StringsHelper.Replace(txtTotal.Text, "$", "", 1, -1, CompareMethod.Binary), NumberStyles.Any).ToString("N0")));
				modMain.rs["Total"] = Total;
				modMain.rs["Status"] = PreviousStatus;

				modMain.rs.Update();

				UpdateVehicleQuantity();

				AlreadyMarked = false;
				CommonFunctions.RemoveMark(this);
				ClearForm();
				if (btnCreate.Text == "&Update")
				{
					this.Close();
				}
			}
			catch
			{
				MessageBox.Show("There was an error during the operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		public bool IsQuantityAvailable()
		{
			bool value = true;
			modMain.ExecuteSQL($"Select * from Vehicle where ID = {GetModelID().ToString()}");
			object NextAvailable = Convert.ToDouble(modMain.rs["Quantity"]) - Double.Parse(txtQuantity.Text);
			if (ReflectionHelper.GetPrimitiveValue<double>(NextAvailable) < 0)
			{
				MessageBox.Show("Quantity is not available or vehicle is currently Out of Stock", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
				value = false;
			}
			return value;
		}

		public void UpdateVehicleQuantity()
		{
			modMain.ExecuteSQL($"Select * from Vehicle where ID = {GetModelID().ToString()}");
			modMain.rs["Quantity"] = Convert.ToDouble(modMain.rs["Quantity"]) - Double.Parse(txtQuantity.Text);
			modMain.rs.Update();
		}

		public void CheckEmptyText()
		{
			if (!AlreadyMarked)
			{
				CommonFunctions.AddRequiredMark(lblName, Color.Red, txtName);
				CommonFunctions.AddRequiredMark(lblLastName, Color.Red, txtLastName);
				CommonFunctions.AddRequiredMark(lblManufacturer, Color.Red, null, cmbManufacturer);
				CommonFunctions.AddRequiredMark(lblModel, Color.Red, null, cmbModel);
				CommonFunctions.AddRequiredMark(lblQuantity, Color.Red, txtQuantity);
				CommonFunctions.AddRequiredMark(lblSeller, Color.Red, null, cmbSeller);
			}
		}

		private void chk3PersonInsurance_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				if (chk3PersonInsurance.CheckState == CheckState.Checked)
				{
					SubTotalValue = Double.Parse(StringsHelper.Replace(txtSubTotal.Text, "$", "", 1, -1, CompareMethod.Binary));
					SubTotalValue += ThirdPersonInsuranceValue;
					txtSubTotal.Text = "";
					FormatSubTotalValue();
				}
				else
				{
					SubTotalValue = Double.Parse(StringsHelper.Replace(txtSubTotal.Text, "$", "", 1, -1, CompareMethod.Binary));
					SubTotalValue -= ThirdPersonInsuranceValue;
					txtSubTotal.Text = "";
					FormatSubTotalValue();
				}
			}
			catch
			{
				return;
			}
		}

		private void txtQuantity_Leave(Object eventSender, EventArgs eventArgs)
		{
			object currentQuantity = null;
			if (cmbManufacturer.SelectedIndex == -1 || cmbModel.SelectedIndex == -1 || txtQuantity.Text == "")
			{
				return;
			}
			if (IsQuantityValid(ref currentQuantity))
			{
				txtQuantity.Text = StringsHelper.Format(txtQuantity.Text, "###,#");
				SetSubTotal();
			}
			else
			{
				MessageBox.Show($"There are not enough vehicles, maximum available is {ReflectionHelper.GetPrimitiveValue<string>(currentQuantity)}", "Information", MessageBoxButtons.OK);
				txtQuantity.Text = "0";
				txtQuantity.Focus();
			}
		}

		public bool IsQuantityValid(ref object currentQuantity)
		{
			modMain.ExecuteSQL2($"Select * from Vehicle where Vehicle_Name = '{cmbModel.Text}'");
			currentQuantity = modMain.rs2["Quantity"];
			return ReflectionHelper.GetPrimitiveValue<double>(currentQuantity) >= Double.Parse(txtQuantity.Text);
		}

		public int GetManufacturerID()
		{
			modMain.ExecuteSQL3($"Select * from Brand where Brand_Name = '{cmbManufacturer.Text}'");
			return Convert.ToInt32(modMain.rs3["ID"]);
		}

		public int GetModelID()
		{
			modMain.ExecuteSQL3($"Select * from Vehicle where Vehicle_Name = '{cmbModel.Text}'");
			return Convert.ToInt32(modMain.rs3["ID"]);
		}

		public int GetSellerID()
		{
			string SellerDNI = cmbSeller.Text.Substring(Math.Max(cmbSeller.Text.Length - 9, 0));
			modMain.ExecuteSQL3($"Select * from Staff where DNI = '{SellerDNI}'");
			return Convert.ToInt32(modMain.rs3["ID"]);
		}

		private void btnReset_Click(Object eventSender, EventArgs eventArgs) => ClearForm();


		public void ClearForm()
		{
			CommonFunctions.RemoveMark(this);
			AlreadyMarked = false;
			txtID.Text = "";
			txtName.Text = "";
			txtLastName.Text = "";
			txtQuantity.Text = "";
			cmbManufacturer.SelectedIndex = -1;
			cmbModel.SelectedIndex = -1;
			cmbSeller.SelectedIndex = -1;
			txtSubTotal.Text = "";
			txtTotal.Text = "";
			chkVehicleInsurance.CheckState = CheckState.Unchecked;
			chk3PersonInsurance.CheckState = CheckState.Unchecked;
			LoadReceiptID();
		}

		public bool IsInformationValid() => txtName.Text != "" && txtLastName.Text != "" && cmbManufacturer.SelectedIndex != -1 && cmbModel.SelectedIndex != -1 && txtQuantity.Text != "" && cmbSeller.SelectedIndex != -1;


		private void chkVehicleInsurance_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				if (chkVehicleInsurance.CheckState == CheckState.Checked)
				{
					SubTotalValue = Double.Parse(StringsHelper.Replace(txtSubTotal.Text, "$", "", 1, -1, CompareMethod.Binary));
					SubTotalValue += VehicleInsuranceValue;
					txtSubTotal.Text = "";
					FormatSubTotalValue();
				}
				else
				{
					SubTotalValue = Double.Parse(StringsHelper.Replace(txtSubTotal.Text, "$", "", 1, -1, CompareMethod.Binary));
					SubTotalValue -= VehicleInsuranceValue;
					txtSubTotal.Text = "";
					FormatSubTotalValue();
				}
			}
			catch
			{
				return;
			}
		}

		private void cmbManufacturer_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (cmbManufacturer.Text != "")
			{
				LoadModels();
				txtQuantity.Text = "";
				txtSubTotal.Text = "";
				txtTotal.Text = "";
				chk3PersonInsurance.CheckState = CheckState.Unchecked;
				chkVehicleInsurance.CheckState = CheckState.Unchecked;
			}
		}

		private void cmbModel_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			if (cmbModel.Text == "")
			{
				return;
			}
			txtQuantity.Text = "";
			txtSubTotal.Text = "";
			txtTotal.Text = "";
			chk3PersonInsurance.CheckState = CheckState.Unchecked;
			chkVehicleInsurance.CheckState = CheckState.Unchecked;
		}

		public void SetSubTotal()
		{
			object vehiclePrice = null;
			if (txtQuantity.Text != "")
			{
				modMain.ExecuteSQL2($"Select * from Vehicle where Vehicle_Name = '{cmbModel.Text}'");
				vehiclePrice = modMain.rs2["Price"];
				SubTotalValue = ReflectionHelper.GetPrimitiveValue<double>(vehiclePrice) * Double.Parse(txtQuantity.Text);
				if (chkVehicleInsurance.CheckState == CheckState.Checked)
				{
					SubTotalValue += VehicleInsuranceValue;
				}
				if (chk3PersonInsurance.CheckState == CheckState.Checked)
				{
					SubTotalValue += ThirdPersonInsuranceValue;
				}
				FormatSubTotalValue();
			}
			else
			{
				SubTotalValue = 0;
				TotalValue = 0;
				FormatSubTotalValue();
			}
		}

		public void FormatSubTotalValue()
		{
			txtSubTotal.Text = StringsHelper.Format(SubTotalValue, "$#,###");
			TotalValue = SubTotalValue + SubTotalValue * 0.13d;
			txtTotal.Text = StringsHelper.Format(TotalValue, "$#,###");
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			LoadReceiptID();
			LoadManufacturers();
			LoadSellers();
			cmbModel.SelectedIndex = 0;
			VerifyCurrentRole();
		}

		public void VerifyCurrentRole()
		{
			if (frmMain.DefInstance.CurrentUserRoleID == 2)
			{
				MessageBox.Show("The current user does not have permission to sell cars", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCreate.Enabled = false;
			}
		}

		public void LoadReceiptID()
		{
			modMain.ExecuteSQL("Select * from Receipt");
			txtID.Text = $"V3UC44P{(Double.Parse(modMain.rs.RecordCount.ToString()) + 1).ToString()}";
			if (Strings.Len(modMain.rs.RecordCount.ToString()) == 2)
			{
				txtID.Text = $"V3UC44{(Double.Parse(modMain.rs.RecordCount.ToString()) + 1).ToString()}";
			}
			else if (Strings.Len(modMain.rs.RecordCount.ToString()) == 3)
			{ 
				txtID.Text = $"V3UC4{(Double.Parse(modMain.rs.RecordCount.ToString()) + 1).ToString()}";
			}
			else if (Strings.Len(modMain.rs.RecordCount.ToString()) == 4)
			{ 
				txtID.Text = $"V3UC{(Double.Parse(modMain.rs.RecordCount.ToString()) + 1).ToString()}";
			}
		}

		public void LoadManufacturers()
		{
			modMain.ExecuteSQL("Select * from Brand");
			cmbManufacturer.Clear();
			while (!modMain.rs.EOF)
			{
				cmbManufacturer.AddItem(Convert.ToString(modMain.rs["Brand_Name"]));
				modMain.rs.MoveNext();
			}
		}

		public void LoadModels()
		{
			modMain.ExecuteSQL($"Select * from Vehicle where Manufacturer_ID = {GetManufacturerID().ToString()}");
			cmbModel.Clear();
			while (!modMain.rs.EOF)
			{
				cmbModel.AddItem(Convert.ToString(modMain.rs["Vehicle_Name"]));
				modMain.rs.MoveNext();
			}
		}

		public void LoadSellers()
		{
			string FullName = "";
			modMain.ExecuteSQL("Select * from Staff where Role_ID = 1 or Role_ID = 3");
			cmbSeller.Clear();
			while (!modMain.rs.EOF)
			{
				FullName = $"{Convert.ToString(modMain.rs["Staff_Name"])} {Convert.ToString(modMain.rs["Staff_LastName"])} - {Convert.ToString(modMain.rs["DNI"])}";
				cmbSeller.AddItem(FullName);
				modMain.rs.MoveNext();
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}