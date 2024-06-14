using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmViewVehicles
		: System.Windows.Forms.Form
	{

		public frmViewVehicles()
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


		private void frmViewVehicles_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		int SelectedRow = 0;
		string query = "";

		private void btnChangeStock_Click(Object eventSender, EventArgs eventArgs)
		{
			string SelectedModel = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			SelectedRow = gridResults.CurrentRowIndex;
			frmChangeStock f = frmChangeStock.CreateInstance();
			f.LoadQuery($"Select * from Vehicle where Vehicle_Name = '{SelectedModel}'");
			f.ShowDialog(this);
			FillGrid();
			gridResults.CurrentRowIndex = SelectedRow;
		}

		private void btnShowHiddenElements_Click(Object eventSender, EventArgs eventArgs)
		{
			if (btnShowHiddenElements.Text == "&Show Deleted")
			{
				query = "Select * from Vehicle where Available = False Order By Vehicle_Name Asc";
				FillGrid();
				btnShowHiddenElements.Text = "Show &Both";
			}
			else if (btnShowHiddenElements.Text == "Show &Both")
			{ 
				query = "Select * from Vehicle order by Vehicle_Name asc";
				FillGrid();
				btnShowHiddenElements.Text = "&Hide Deleted";
			}
			else if (btnShowHiddenElements.Text == "&Hide Deleted")
			{ 
				query = "Select * from Vehicle where Available = True Order By Vehicle_Name Asc";
				FillGrid();
				btnShowHiddenElements.Text = "&Show Deleted";
			}
			gridResults_SelectionChanged(gridResults, new EventArgs());
		}

		private void btnExit_Click(Object eventSender, EventArgs eventArgs) => this.Close();


		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			query = "Select * from Vehicle where Available = True Order By Vehicle_Name Asc";
			FillGrid();
			gridResults_SelectionChanged(gridResults, new EventArgs());
		}

		public void FillGrid()
		{
			string ClassName = "", ManufacturerName = "", value = "";
			gridResults.Clear();
			modMain.ExecuteSQL(query);
			int i = 0, k = 0;
			gridResults.ColumnsCount = 12;
			gridResults.FixedColumns = 0;
			gridResults.RowsCount = 0;
			gridResults.AddItem($"Model Name{"\t"}Manufacturer{"\t"}Production Started{"\t"}Production Ended{"\t"}Year of Production{"\t"}Quantity Available{"\t"}Price per Unit{"\t"}Transmission{"\t"}Class{"\t"}Body Style{"\t"}Length{"\t"}Width");
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
				for (int j = 1; j <= 12; j++)
				{
					value = Convert.ToString(modMain.rs[j]);
					if (j == 2)
					{
						ManufacturerName = GetManufacturerName(Convert.ToInt32(modMain.rs[j]));
						value = ManufacturerName;
						gridResults.SetColumnWidth(j - 1, 100);
					}
					else if (j == 3 || j == 4)
					{ 
						System.DateTime TempDate = DateTime.FromOADate(0);
						value = (DateTime.TryParse(value, out TempDate)) ? TempDate.ToString("MM/yyyy") : value;
						if (j == 3)
						{
							gridResults.SetColumnWidth(j - 1, 133);
						}
						if (j == 4)
						{
							gridResults.SetColumnWidth(j - 1, 120);
						}
					}
					else if (j == 5)
					{ 
						gridResults.SetColumnWidth(j - 1, 133);
					}
					else if (j == 6)
					{ 
						if (StringsHelper.ToDoubleSafe(value) == 0)
						{
							value = "Out of Stock";
						}
						value = StringsHelper.Format(value, "#,###");
						gridResults.SetColumnWidth(j - 1, 133);
					}
					else if (j == 7)
					{ 
						value = StringsHelper.Format(value, "$#,###");
						gridResults.SetColumnWidth(j - 1, 107);
					}
					else if (j == 8)
					{ 
						gridResults.SetColumnWidth(j - 1, 93);
					}
					else if (j == 9)
					{ 
						ClassName = GetClassName(Convert.ToInt32(modMain.rs[j]));
						value = ClassName;
						gridResults.SetColumnWidth(j - 1, 120);
					}
					else if (j == 11 || j == 12)
					{ 
						value = StringsHelper.Format(value, "#,### mm");
					}
					gridResults[i, k].Value = value;
					if (k >= 2 && k <= 6 || k == 10 || k == 11)
					{
						gridResults.ColAlignment[k] = DataGridViewContentAlignment.MiddleRight;
					}
					else
					{
						gridResults.ColAlignment[k] = DataGridViewContentAlignment.MiddleLeft;
					}
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
			int Twips = 0;

			int tempForEndVar = gridResults.ColumnsCount - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				Twips = Convert.ToInt32(ControlHelper.TextWidth(this, Convert.ToString(gridResults[0, i].Value)));
				gridResults.SetColumnWidth(i, (((double) (Twips * this.gridResults.Font.SizeInPoints)) / ((double) this.Font.SizeInPoints) + 530) / 15); //* Screen.TwipsPerPixelX
			}
		}

		private void btnEdit_Click(Object eventSender, EventArgs eventArgs) => gridResults_DoubleClick(gridResults, new EventArgs());


		public string GetManufacturerName(int ManufacturerID)
		{
			modMain.ExecuteSQL3($"Select * from Brand where ID = {ManufacturerID.ToString()}");
			return Convert.ToString(modMain.rs3["Brand_Name"]);
		}

		public int GetManufacturerID(int ManufacturerName)
		{
			modMain.ExecuteSQL3($"Select * from Brand where Brand_Name = {ManufacturerName.ToString()}");
			return Convert.ToInt32(modMain.rs3["ID"]);
		}

		public string GetClassName(int ClassID)
		{
			modMain.ExecuteSQL3($"Select * from Class where ID = {ClassID.ToString()}");
			return Convert.ToString(modMain.rs3["Class_Name"]);
		}

		public string GetClassID(int ClassName)
		{
			modMain.ExecuteSQL3($"Select * from Class where Class_Name = {ClassName.ToString()}");
			return Convert.ToString(modMain.rs3["ID"]);
		}

		public int GetManufacturerIndex(string ManufacturerName, frmCreateNewVehicle CreateVehicleForm)
		{
			int value = 0;
			int tempForEndVar = CreateVehicleForm.cmbManufacturer.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateVehicleForm.cmbManufacturer.GetListItem(i) == ManufacturerName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		public int GetClassIndex(string ClassName, frmCreateNewVehicle CreateVehicleForm)
		{
			int value = 0;
			int tempForEndVar = CreateVehicleForm.cmbClass.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateVehicleForm.cmbClass.GetListItem(i) == ClassName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		public int GetBodyStyleIndex(string BodyStyleName, frmCreateNewVehicle CreateVehicleForm)
		{
			int value = 0;
			int tempForEndVar = CreateVehicleForm.cmbBodyStyle.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (CreateVehicleForm.cmbBodyStyle.GetListItem(i) == BodyStyleName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		public int GetModelIndex(string ModelName, frmDeleteVehicle DeleteVehicleForm)
		{
			int value = 0;
			int tempForEndVar = DeleteVehicleForm.cmbModel.Items.Count - 1;
			for (int i = 0; i <= tempForEndVar; i++)
			{
				if (DeleteVehicleForm.cmbModel.GetListItem(i) == ModelName)
				{
					value = i;
					break;
				}
			}
			return value;
		}

		private void btnDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			string SelectedModel = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			frmDeleteVehicle f = frmDeleteVehicle.CreateInstance();
			int ModelIndex = GetModelIndex(SelectedModel, f);
			f.cmbModel.Text = f.cmbModel.GetListItem(ModelIndex);
			SelectedRow = gridResults.CurrentRowIndex;
			f.ShowDialog(this);
			FillGrid();
			SelectLastRow();
		}

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

		private void gridResults_DoubleClick(Object eventSender, EventArgs eventArgs)
		{
			string SelectedModel = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			modMain.ExecuteSQL2($"Select * from Vehicle where Vehicle_Name = '{SelectedModel}'");
			if (modMain.rs2.EOF || modMain.rs2.RecordCount == 0)
			{
				MessageBox.Show("Please select a valid item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string ManufacturerName = "", ClassName = "";
			int ClassIndex = 0, ManufacturerIndex = 0, BodyStyleIndex = 0;
			string Transmission = "";
			frmCreateNewVehicle f = null;
			if (btnEdit.Text == "&Edit")
			{
				f = frmCreateNewVehicle.CreateInstance();
				f.txtName.Text = Convert.ToString(modMain.rs2["Vehicle_Name"]);
				ManufacturerName = GetManufacturerName(Convert.ToInt32(modMain.rs2["Manufacturer_ID"]));
				ManufacturerIndex = GetManufacturerIndex(ManufacturerName, f);
				f.cmbManufacturer.Text = f.cmbManufacturer.GetListItem(ManufacturerIndex);
				f.dtProductionStarted.SetValue(modMain.rs2["Production_Started"]);
				f.dtProductionEnded.SetValue(modMain.rs2["Production_Ended"]);
				f.txtYear.Text = Convert.ToString(modMain.rs2["Produced"]);
				f.txtQuantity.Text = Convert.ToString(modMain.rs2["Quantity"]);
				f.txtQuantity.Enabled = false;
				f.txtPrice.Text = Convert.ToString(modMain.rs2["Price"]);
				Transmission = Convert.ToString(modMain.rs2["Transmission"]);
				if (Transmission == "Manual")
				{
					f.optTransmission[1].Checked = true;
				}
				else
				{
					f.optTransmission[0].Checked = true;
				}
				ClassName = GetClassName(Convert.ToInt32(modMain.rs2["Class_ID"]));
				ClassIndex = GetClassIndex(ClassName, f);
				f.cmbClass.Text = f.cmbClass.GetListItem(ClassIndex);
				BodyStyleIndex = GetBodyStyleIndex(Convert.ToString(modMain.rs2["Body_Style"]), f);
				f.cmbBodyStyle.Text = f.cmbBodyStyle.GetListItem(BodyStyleIndex);
				f.txtLength.Text = Convert.ToString(modMain.rs2["Length"]);
				f.txtWidth.Text = Convert.ToString(modMain.rs2["Width"]);
				f.txtLength_Leave(null, new EventArgs());
				f.txtPrice_Leave(null, new EventArgs());
				f.txtQuantity_Leave(null, new EventArgs());
				f.txtWidth_Leave(null, new EventArgs());
				f.PreviousName = Convert.ToString(modMain.rs2["Vehicle_Name"]);
				f.btnCreate.Text = "&Update";
				f.btnReset.Enabled = false;
				f.ShowDialog(this);
			}
			else if (btnEdit.Text == "&Restore model")
			{ 
				modMain.rs2["Available"] = true;
				modMain.rs2.Update();

				MessageBox.Show("Model restored successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//btnEdit.Caption = "&Edit"
				//btnDelete.Enabled = True
			}
			SelectedRow = gridResults.CurrentRowIndex;
			FillGrid();
			SelectLastRow();
		}

		private void gridResults_Click(Object eventSender, EventArgs eventArgs) => gridResults_SelectionChanged(gridResults, new EventArgs());


		private void gridResults_SelectionChanged(Object eventSender, EventArgs eventArgs)
		{
			string CurrentVehicle = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			string SelectedModel = "";
			if (gridResults.CurrentRowIndex > 0 && CurrentVehicle != "" && CurrentVehicle != "Model Name")
			{
				bool currentBool = false;
				SelectedModel = CurrentVehicle;
				modMain.ExecuteSQL3($"Select * from Vehicle where Vehicle_Name = '{SelectedModel}'");
				currentBool = Convert.ToBoolean(modMain.rs3["Available"]);
				if (!currentBool)
				{
					btnEdit.Text = "&Restore model";
					btnDelete.Enabled = false;
					btnChangeStock.Enabled = false;
					btnEdit.Enabled = true;
				}
				else if (currentBool)
				{ 
					btnEdit.Text = "&Edit";
					btnDelete.Enabled = true;
					btnChangeStock.Enabled = true;
					btnEdit.Enabled = true;
				}
			}
			else
			{
				btnDelete.Enabled = false;
				btnEdit.Enabled = false;
				btnChangeStock.Enabled = false;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}