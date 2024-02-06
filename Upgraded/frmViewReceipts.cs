using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmViewReceipts
		: System.Windows.Forms.Form
	{

		public frmViewReceipts()
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


		private void frmViewReceipts_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		int SelectedRow = 0;
		string query = "";

		private void btnChangeStatus_Click(Object eventSender, EventArgs eventArgs)
		{
			string SelectedReceipt = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			modMain.ExecuteSQL2($"Select * from Receipt where Receipt_ID = '{SelectedReceipt}'");
			string currentStatus = Convert.ToString(modMain.rs2["Status"]);
			if (currentStatus == "Approved")
			{
				modMain.rs2["Status"] = "Rejected";
				UpdateQuantity(Convert.ToInt32(modMain.rs2["Model_ID"]), false, Convert.ToInt32(modMain.rs2["Quantity"]));
			}
			else
			{
				modMain.rs2["Status"] = "Approved";
				UpdateQuantity(Convert.ToInt32(modMain.rs2["Model_ID"]), true, Convert.ToInt32(modMain.rs2["Quantity"]));
			}
			modMain.rs2.Update();
			MessageBox.Show("Status changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			FillGrid();
		}

		public void UpdateQuantity(int ModelID, bool IsRemovingVehicles, int CarsSold)
		{
			modMain.ExecuteSQL($"Select * from Vehicle where ID = {ModelID.ToString()}");
			double currentQuantity = Convert.ToDouble(modMain.rs["Quantity"]);
			if (IsRemovingVehicles)
			{
				currentQuantity -= CarsSold;
			}
			else
			{
				currentQuantity += CarsSold;
			}
			modMain.rs["Quantity"] = currentQuantity;
			modMain.rs.Update();
		}

		private void btnExit_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
		}

		private void btnShowAll_Click(Object eventSender, EventArgs eventArgs)
		{
			if (btnShowAll.Text == "&Show Approved")
			{
				query = "Select * from Receipt where Status = 'Approved' Order by Receipt_ID Asc";
				FillGrid();
				btnShowAll.Text = "&Show Rejected";
			}
			else if (btnShowAll.Text == "&Show Rejected")
			{ 
				query = "Select * from Receipt where Status = 'Rejected' Order by Receipt_ID Asc";
				FillGrid();
				btnShowAll.Text = "&Show All";
			}
			else if (btnShowAll.Text == "&Show All")
			{ 
				query = "Select * from Receipt Order by Receipt_ID Asc";
				FillGrid();
				btnShowAll.Text = "&Show Approved";
			}
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
		private void Form_Load()
		{
			query = "Select * from Receipt Order by Receipt_ID Asc";
			FillGrid();
		}

		public void FillGrid()
		{
			string ModelName = "", ManufacturerName = "", SellerName = "";
			string value = "";
			object BooleanValue = null;
			gridResults.Clear();
			modMain.ExecuteSQL(query);
			int i = 0, k = 0;
			gridResults.ColumnsCount = 12;
			gridResults.FixedColumns = 0;
			gridResults.RowsCount = 0;
			gridResults.AddItem($"Receipt ID{"\t"}Name{"\t"}Last Name{"\t"}Manufacturer{"\t"}Model{"\t"}Quantity{"\t"}Seller{"\t"}Vehicle Insurance{"\t"}Third Person Insurance{"\t"}SubTotal{"\t"}Total{"\t"}Status");
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
				int tempForEndVar = gridResults.ColumnsCount;
				for (int j = 1; j <= tempForEndVar; j++)
				{
					if (j == 4)
					{
						ManufacturerName = GetManufacturerName(Convert.ToInt32(modMain.rs[j]));
						value = ManufacturerName;
					}
					else if (j == 5)
					{ 
						ModelName = GetModelName(Convert.ToInt32(modMain.rs[j]));
						value = ModelName;
						gridResults.ColAlignment[k] = DataGridViewContentAlignment.MiddleLeft;
					}
					else if (j == 6)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						value = StringsHelper.Format(value, "#,###");
					}
					else if (j == 7)
					{ 
						SellerName = GetSellerName(Convert.ToInt32(modMain.rs[j]));
						value = SellerName;
					}
					else if (j == 8 || j == 9)
					{ 
						BooleanValue = modMain.rs[j];
						if (ReflectionHelper.GetPrimitiveValue<bool>(BooleanValue))
						{
							value = "Yes";
						}
						else
						{
							value = "No";
						}
					}
					else if (j == 10 || j == 11)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						value = StringsHelper.Format(value, "$#,###");
					}
					else
					{
						value = Convert.ToString(modMain.rs[j]);
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
		}

		public void AutoFitRows()
		{
			int Twips = 0;

			int tempForEndVar = gridResults.ColumnsCount - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				Twips = Convert.ToInt32(ControlHelper.TextWidth(this, Convert.ToString(gridResults[0, i].Value)));
				gridResults.SetColumnWidth(i, (((double) (Twips * this.gridResults.Font.SizeInPoints)) / ((double) this.Font.SizeInPoints) + 530) / 15); //* Screen.TwipsPerPixelX
			}
		}

		public string GetSellerName(int SellerID)
		{
			modMain.ExecuteSQL3($"Select * from Staff where ID = {SellerID.ToString()}");
			return $"{Convert.ToString(modMain.rs3["Staff_Name"])} {Convert.ToString(modMain.rs3["Staff_LastName"])}";
		}

		public string GetModelName(int ModelID)
		{
			modMain.ExecuteSQL3($"Select * from Vehicle where ID = {ModelID.ToString()}");
			return Convert.ToString(modMain.rs3["Vehicle_Name"]);
		}

		public string GetManufacturerName(int ManufacturerID)
		{
			modMain.ExecuteSQL3($"Select * from Brand where ID = {ManufacturerID.ToString()}");
			return Convert.ToString(modMain.rs3["Brand_Name"]);
		}

		private void gridResults_DoubleClick(Object eventSender, EventArgs eventArgs)
		{
			string SelectedReceipt = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			modMain.ExecuteSQL2($"Select * from Receipt where Receipt_ID = '{SelectedReceipt}'");
			if (modMain.rs2.EOF || modMain.rs2.RecordCount == 0)
			{
				MessageBox.Show("Please select a valid item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_ = "";
			frmCreateNewReceipt f = frmCreateNewReceipt.CreateInstance();
			f.txtID.Text = Convert.ToString(modMain.rs2["Receipt_ID"]);
			f.txtName.Text = Convert.ToString(modMain.rs2["Client_Name"]);
			f.txtLastName.Text = Convert.ToString(modMain.rs2["Client_LastName"]);
			string ManufacturerName = GetManufacturerName(Convert.ToInt32(modMain.rs2["Manufacturer_ID"]));
			int ManufacturerIndex = GetManufacturerIndex(ManufacturerName, f);
			f.cmbManufacturer.Text = f.cmbManufacturer.GetListItem(ManufacturerIndex);
			string ModelName = GetModelName(Convert.ToInt32(modMain.rs2["Model_ID"]));
			int ModelIndex = GetModelIndex(ModelName, f);
			f.cmbModel.Text = f.cmbModel.GetListItem(ModelIndex);
			f.txtQuantity.Text = Convert.ToString(modMain.rs2["Quantity"]);
			string SellerDNI = GetSellerDNI(Convert.ToInt32(modMain.rs2["Seller_ID"]));
			int SellerIndex = GetSellerIndex(SellerDNI, f);
			f.cmbSeller.Text = f.cmbSeller.GetListItem(SellerIndex);
			//UPGRADE_WARNING: (6021) Casting 'Variant' to Enum may cause different behaviour. More Information: https://docs.mobilize.net/vbuc/ewis#6021
			f.chk3PersonInsurance.CheckState = (CheckState) Convert.ToInt32(modMain.rs2["Third_Person_Insurance"]);
			//UPGRADE_WARNING: (6021) Casting 'Variant' to Enum may cause different behaviour. More Information: https://docs.mobilize.net/vbuc/ewis#6021
			f.chkVehicleInsurance.CheckState = (CheckState) Convert.ToInt32(modMain.rs2["Vehicle_Insurance"]);
			f.txtSubTotal.Text = Convert.ToString(modMain.rs2["Subtotal"]);
			f.txtTotal.Text = Convert.ToString(modMain.rs2["Total"]);
			f.btnCreate.Text = "&Update";
			f.btnReset.Enabled = false;
			f.PreviousStatus = Convert.ToString(modMain.rs2["Status"]);
			f.SubTotalValue = Double.Parse(f.txtSubTotal.Text);
			f.TotalValue = Double.Parse(f.txtTotal.Text);
			f.FormatSubTotalValue();
			f.ShowDialog(this);
			SelectedRow = gridResults.CurrentRowIndex;
			FillGrid();
			gridResults.CurrentRowIndex = SelectedRow;
		}

		public string GetSellerDNI(int SellerID)
		{
			modMain.ExecuteSQL3($"Select * from Staff where ID = {SellerID.ToString()}");
			return Convert.ToString(modMain.rs3["DNI"]);
		}

		public int GetSellerIndex(string SellerDNI, frmCreateNewReceipt CreateReceiptForm)
		{
			int value = 0;
			int tempForEndVar = CreateReceiptForm.cmbSeller.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateReceiptForm.cmbModel.GetListItem(i).IndexOf(SellerDNI, StringComparison.CurrentCultureIgnoreCase) >= 0)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		public int GetModelIndex(string ModelName, frmCreateNewReceipt CreateReceiptForm)
		{
			int value = 0;
			int tempForEndVar = CreateReceiptForm.cmbModel.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateReceiptForm.cmbModel.GetListItem(i) == ModelName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		public int GetManufacturerIndex(string ManufacturerName, frmCreateNewReceipt CreateReceiptForm)
		{
			int value = 0;
			int tempForEndVar = CreateReceiptForm.cmbManufacturer.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateReceiptForm.cmbManufacturer.GetListItem(i) == ManufacturerName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		private void btnEdit_Click(Object eventSender, EventArgs eventArgs)
		{
			gridResults_DoubleClick(gridResults, new EventArgs());
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}