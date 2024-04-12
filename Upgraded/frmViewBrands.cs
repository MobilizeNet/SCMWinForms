using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmViewBrands
		: System.Windows.Forms.Form
	{

		public frmViewBrands()
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


		private void frmViewBrands_Activated(System.Object eventSender, System.EventArgs eventArgs)
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
				query = "Select * from Brand where Available = False Order By Brand_Name Asc";
				FillGrid();
				btnShowHiddenElements.Text = "Show &Both";
				//btnDelete.Enabled = False
			}
			else if (btnShowHiddenElements.Text == "Show &Both")
			{ 
				query = "Select * from Brand order by Brand_Name asc";
				FillGrid();
				btnShowHiddenElements.Text = "&Hide Deleted";
				//btnDelete.Enabled = True
			}
			else if (btnShowHiddenElements.Text == "&Hide Deleted")
			{ 
				query = "Select * from Brand where Available = True Order By Brand_Name Asc";
				FillGrid();
				btnShowHiddenElements.Text = "&Show Deleted";
				//btnDelete.Enabled = True
			}
			gridResults_SelectionChanged(gridResults, new EventArgs());
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			query = "Select * from Brand where Available = True Order By Brand_Name Asc";
			FillGrid();
			gridResults_SelectionChanged(gridResults, new EventArgs());
		}

		public string GetParentName(int ParentID)
		{
			modMain.ExecuteSQL3($"Select * from Brand where ID = {ParentID.ToString()}");
			return Convert.ToString(modMain.rs3["Brand_Name"]);
		}

		public void FillGrid()
		{
			string value = "";
			gridResults.Clear();
			modMain.ExecuteSQL(query);
			int i = 0, k = 0;
			gridResults.ColumnsCount = 8;
			gridResults.FixedColumns = 0;
			gridResults.RowsCount = 0;
			gridResults.AddItem($"Brand Name{"\t"}Owner{"\t"}Headquarter Location{"\t"}Area Served{"\t"}Website{"\t"}Year of Foundation{"\t"}Parent Company{"\t"}Number of Employees");
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
				for (int j = 1; j <= 8; j++)
				{
					if (j == 2)
					{
						value = Convert.ToString(modMain.rs[j]);
						gridResults.SetColumnWidth(j - 1, 107);
					}
					else if (j == 3)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						gridResults.SetColumnWidth(j - 1, 147);
					}
					else if (j == 4)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						gridResults.SetColumnWidth(j - 1, 87);
					}
					else if (j == 5)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						value = value.Substring(Math.Min(4, value.Length));
						gridResults.SetColumnWidth(j - 1, 120);
					}
					else if (j == 6)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						System.DateTime TempDate = DateTime.FromOADate(0);
						value = (DateTime.TryParse(value, out TempDate)) ? TempDate.ToString("MM/dd/yyyy") : value;
						gridResults.SetColumnWidth(j - 1, 133);
					}
					else if (j == 7 && !Convert.IsDBNull(modMain.rs[j]))
					{ 
						if (Convert.ToDouble(modMain.rs[j]) == 0)
						{
							value = "";
						}
						else
						{
							value = GetParentName(Convert.ToInt32(modMain.rs[j]));
						}
						gridResults.SetColumnWidth(j - 1, 107);
					}
					else if (j == 7 && Convert.IsDBNull(modMain.rs[j]))
					{ 
						value = "";
					}
					else if (j == 8)
					{ 
						value = Convert.ToString(modMain.rs[j]);
						value = StringsHelper.Format(value, "#,###");
						gridResults.SetColumnWidth(j - 1, 140);
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

		private void gridResults_Click(Object eventSender, EventArgs eventArgs) => gridResults_SelectionChanged(gridResults, new EventArgs());


		private void gridResults_DoubleClick(Object eventSender, EventArgs eventArgs)
		{
			string SelectedBrand = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			modMain.ExecuteSQL2($"Select * from Brand where Brand_Name = '{SelectedBrand}'");
			if (modMain.rs2.EOF || modMain.rs2.RecordCount == 0)
			{
				MessageBox.Show("Please select a valid item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string ParentName = "";
			frmCreateNewBrand f = null;
			if (btnEdit.Text == "&Edit")
			{
				_ = 0;
				f = frmCreateNewBrand.CreateInstance();
				f.txtName.Text = Convert.ToString(modMain.rs2["Brand_Name"]);
				f.txtOwner.Text = Convert.ToString(modMain.rs2["Owner"]);
				f.txtHeadquarters.Text = Convert.ToString(modMain.rs2["Headquarter"]);
				f.txtAreaServed.Text = Convert.ToString(modMain.rs2["Area_Served"]);
				f.txtWebsite.Text = Convert.ToString(modMain.rs2["Website"]);
				f.dtFounded.SetValue(modMain.rs2["Founded"]);
				//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-1049
				if (!Convert.IsDBNull(modMain.rs2["Parent_Company"]) && Convert.ToDouble(modMain.rs2["Parent_Company"]) != 0)
				{
					ParentName = GetParentName(Convert.ToInt32(modMain.rs2["Parent_Company"]));
					int ParentIndex = GetBrandIndex(ParentName, f);
					f.cmbParent.Text = f.cmbParent.GetListItem(ParentIndex);
				}
				else
				{
					f.cmbParent.SelectedIndex = -1;
				}
				f.txtNumberEmployees.Text = Convert.ToString(modMain.rs2["Number_Employees"]);
				f.btnCreate.Text = "&Update";
				f.btnReset.Enabled = false;
				f.txtNumberEmployees_Leave(null, new EventArgs());
				f.PreviousName = Convert.ToString(modMain.rs2["Brand_Name"]);
				f.ShowDialog(this);
			}
			else if (btnEdit.Text == "&Restore brand")
			{ 
				modMain.rs2["Available"] = true;
				modMain.rs2.Update();

				MessageBox.Show("Brand restored successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				//btnEdit.Caption = "&Edit"
				//btnDelete.Enabled = False
			}
			SelectedRow = gridResults.CurrentRowIndex;
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

		private void btnDelete_Click(Object eventSender, EventArgs eventArgs)
		{
			string SelectedBrand = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			frmDeleteBrand f = frmDeleteBrand.CreateInstance();
			int ParentIndex = GetBrandIndex(SelectedBrand, null, f);
			f.cmbManufacturer.Text = f.cmbManufacturer.GetListItem(ParentIndex);
			f.ShowDialog(this);
			SelectedRow = gridResults.CurrentRowIndex;
			FillGrid();
			SelectLastRow();
		}

		private void btnEdit_Click(Object eventSender, EventArgs eventArgs) => gridResults_DoubleClick(gridResults, new EventArgs());


		public int GetBrandIndex(string BrandName, frmCreateNewBrand CreateBrandForm = null, frmDeleteBrand DeleteBrandForm = null)
		{
			int value = 0;
			if (CreateBrandForm != null)
			{
				int tempForEndVar = CreateBrandForm.cmbParent.Items.Count - 1;
				for (int i = 0; i <= tempForEndVar; i++)
				{
					if (CreateBrandForm.cmbParent.GetListItem(i) == BrandName)
					{
						value = i;
						break;
					}
				}
			}
			else if (DeleteBrandForm != null)
			{ 
				int tempForEndVar2 = DeleteBrandForm.cmbManufacturer.Items.Count - 1;
				for (int i = 0; i <= tempForEndVar2; i++)
				{
					if (DeleteBrandForm.cmbManufacturer.GetListItem(i) == BrandName)
					{
						value = i;
						break;
					}
				}
			}
			return value;
		}

		private void gridResults_SelectionChanged(Object eventSender, EventArgs eventArgs)
		{
			string CurrentBrand = Convert.ToString(gridResults[gridResults.CurrentRowIndex, 0].Value);
			_ = "";
			if (gridResults.CurrentRowIndex > 0 && CurrentBrand != "" && CurrentBrand != "Brand Name")
			{
				_ = false;
				string SelectedBrand = CurrentBrand;
				if (SelectedBrand == "")
				{
					return;
				}
				modMain.ExecuteSQL3($"Select * from Brand where Brand_Name = '{SelectedBrand}'");
				bool currentBool = Convert.ToBoolean(modMain.rs3["Available"]);
				if (!currentBool)
				{
					btnEdit.Text = "&Restore brand";
					btnDelete.Enabled = false;
					btnEdit.Enabled = true;
				}
				else if (currentBool)
				{ 
					btnEdit.Text = "&Edit";
					btnDelete.Enabled = true;
					btnEdit.Enabled = true;
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