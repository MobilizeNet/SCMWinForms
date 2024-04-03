using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmDetailedInformation
		: System.Windows.Forms.Form
	{

		public frmDetailedInformation()
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


		private void frmDetailedInformation_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		string query = "", SellerName = "";
		ListViewItem li = null;

		private void cmdCompaniesByCountry_Click(Object eventSender, EventArgs eventArgs)
		{
			ClearListView();
			query = $"SELECT Count(Brand.Brand_Name) AS CountOfBrand_Name, Brand.Headquarter " +
			        $"From Brand " +
			        $"GROUP BY Brand.Headquarter " +
			        $"ORDER BY Count(Brand.Brand_Name) DESC";

			modMain.ExecuteSQL(query);

			lstResults.Columns.Add("Country", 300);
			lstResults.Columns.Add("Quantity", 100);

			while (!modMain.rs.EOF)
			{
				li = lstResults.Items.Add(Convert.ToString(modMain.rs["Headquarter"]));
				ListViewHelper.GetListViewSubItem(li, 1).Text = Convert.ToString(modMain.rs["CountOfBrand_Name"]);
				modMain.rs.MoveNext();
			}
		}

		private void cmdExit_Click(Object eventSender, EventArgs eventArgs) => this.Close();


		private void cmdSoldByManufacturer_Click(Object eventSender, EventArgs eventArgs)
		{
			ClearListView();
			query = $"SELECT DISTINCTROW Brand.Brand_Name, Sum(Receipt.Quantity) AS TotalSold " +
			        $"FROM Brand INNER JOIN Receipt ON Brand.[ID] = Receipt.[Manufacturer_ID] " +
			        $"WHERE Receipt.Status = 'Approved' " +
			        $"GROUP BY Brand.Brand_Name " +
			        $"ORDER BY Sum(Receipt.Quantity) DESC";

			modMain.ExecuteSQL(query);

			lstResults.Columns.Add("Manufacturer", 300);
			lstResults.Columns.Add("Quantity", 100);

			while (!modMain.rs.EOF)
			{
				li = lstResults.Items.Add(Convert.ToString(modMain.rs["Brand_Name"]));
				ListViewHelper.GetListViewSubItem(li, 1).Text = StringsHelper.Format(modMain.rs["TotalSold"], "#,###");
				modMain.rs.MoveNext();
			}
		}

		private void cmdSoldByModel_Click(Object eventSender, EventArgs eventArgs)
		{
			ClearListView();
			query = $"SELECT DISTINCTROW Vehicle.Vehicle_Name, Sum(Receipt.Quantity) AS TotalSold " +
			        $"FROM Vehicle INNER JOIN Receipt ON Vehicle.[ID] = Receipt.[Model_ID] " +
			        $"WHERE (((Receipt.Status)='Approved')) " +
			        $"GROUP BY Receipt.Model_ID, Vehicle.ID, Vehicle.Vehicle_Name " +
			        $"ORDER BY Sum(Receipt.Quantity) DESC ";

			modMain.ExecuteSQL(query);

			lstResults.Columns.Add("Model", 300);
			lstResults.Columns.Add("Quantity", 100);

			while (!modMain.rs.EOF)
			{
				li = lstResults.Items.Add(Convert.ToString(modMain.rs["Vehicle_Name"]));
				ListViewHelper.GetListViewSubItem(li, 1).Text = StringsHelper.Format(modMain.rs["TotalSold"], "#,###");
				modMain.rs.MoveNext();
			}

		}

		public void ClearListView()
		{
			lstResults.Items.Clear();
			lstResults.Columns.Clear();
		}

		private void cmdSoldBySeller_Click(Object eventSender, EventArgs eventArgs)
		{
			ClearListView();
			query = $"SELECT DISTINCTROW Staff.DNI, Sum(Receipt.Quantity) AS TotalSold " +
			        $"FROM Staff INNER JOIN Receipt ON Staff.[ID] = Receipt.[Seller_ID] " +
			        $"WHERE Receipt.Status = 'Approved' " +
			        $"GROUP BY Staff.DNI, Receipt.Seller_ID, Staff.ID " +
			        $"ORDER BY Sum(Receipt.Quantity) DESC ";

			modMain.ExecuteSQL(query);

			lstResults.Columns.Add("Seller DNI", 133);
			lstResults.Columns.Add("Seller Full Name", 233);
			lstResults.Columns.Add("Quantity", 100);

			while (!modMain.rs.EOF)
			{
				li = lstResults.Items.Add(StringsHelper.Format(modMain.rs["DNI"], "#-####-####"));
				SellerName = GetSellerName(Convert.ToString(modMain.rs["DNI"]));
				ListViewHelper.GetListViewSubItem(li, 1).Text = SellerName;
				ListViewHelper.GetListViewSubItem(li, 2).Text = StringsHelper.Format(modMain.rs["TotalSold"], "#,###");
				modMain.rs.MoveNext();
			}
		}

		public string GetSellerName(string SellerDNI)
		{
			modMain.ExecuteSQL3($"Select * from Staff where DNI = '{SellerDNI}'");
			return $"{Convert.ToString(modMain.rs3["Staff_Name"])} {Convert.ToString(modMain.rs3["Staff_LastName"])}";
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}