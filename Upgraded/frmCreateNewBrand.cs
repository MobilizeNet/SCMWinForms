using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal partial class frmCreateNewBrand
		: System.Windows.Forms.Form
	{

		public frmCreateNewBrand()
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


		private void frmCreateNewBrand_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		public string PreviousName = "";
		bool AlreadyMarked = false;

		private void btnCreate_Click(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				modMain.ExecuteSQL($"Select * from Brand where Brand_Name = '{txtName.Text}'");
				if (IsInformationValid())
				{
					if (btnCreate.Text == "&Create")
					{
						if (!modMain.rs.EOF)
						{
							MessageBox.Show("Brand already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						modMain.rs.AddNew();

						MessageBox.Show("New brand added successfully!", "Information", MessageBoxButtons.OK);
					}
					else if (btnCreate.Text == "&Update")
					{ 
						if (BrandExists(txtName.Text))
						{
							return;
						}
						if (cmbParent.Text == txtName.Text)
						{
							MessageBox.Show("Parent Company can't be the same company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}

						MessageBox.Show("Brand updated successfully!", "Information", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Fill all the required spaces in the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CheckEmptyText();
					AlreadyMarked = true;
					return;
				}

				modMain.rs["Brand_Name"] = txtName.Text;
				modMain.rs["Owner"] = txtOwner.Text;
				modMain.rs["Headquarter"] = txtHeadquarters.Text;
				modMain.rs["Area_Served"] = txtAreaServed.Text;
				modMain.rs["Website"] = txtWebsite.Text;
				modMain.rs["Founded"] = ReflectionHelper.GetPrimitiveValue<System.DateTime>(dtFounded.GetValue());
				if (cmbParent.SelectedIndex != -1)
				{
					modMain.rs["Parent_Company"] = GetManufacturerID();
				}
				modMain.rs["Number_Employees"] = StringsHelper.Replace(txtNumberEmployees.Text, ",", "", 1, -1, CompareMethod.Binary);
				modMain.rs["Available"] = true;
				modMain.rs.Update();

				AlreadyMarked = false;
				CommonFunctions.RemoveMark(this);
				ClearForm();
				LoadParents();
			}
			catch
			{
				MessageBox.Show("There was an error during the operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		public bool BrandExists(string BrandName)
		{
			bool result = false;
			modMain.ExecuteSQL2($"Select * from Brand where Brand_Name = '{BrandName}'");
			if (BrandName == PreviousName)
			{
				result = false;
			}
			else if (BrandName != PreviousName && !modMain.rs2.EOF)
			{ 
				MessageBox.Show("Brand already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				result = true;
			}
			return result;
		}

		public void CheckEmptyText()
		{
			CommonFunctions.AddRequiredMark(lblName, Color.Red, txtName);
			CommonFunctions.AddRequiredMark(lblOwner, Color.Red, txtOwner);
			CommonFunctions.AddRequiredMark(lblHeadquarter, Color.Red, txtHeadquarters);
			CommonFunctions.AddRequiredMark(lblAreaServed, Color.Red, txtAreaServed);
			CommonFunctions.AddRequiredMark(lblWebsite, Color.Red, txtWebsite);
			CommonFunctions.AddRequiredMark(lblNumberEmployees, Color.Red, txtNumberEmployees);
		}

		public int GetManufacturerID()
		{
			modMain.ExecuteSQL2($"Select * from Brand where Brand_Name = '{cmbParent.Text}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		public bool IsInformationValid()
		{
			return txtName.Text != "" && txtOwner.Text != "" && txtHeadquarters.Text != "" && txtAreaServed.Text != "" && txtWebsite.Text != "" && txtNumberEmployees.Text != "";
		}

		private void btnReset_Click(Object eventSender, EventArgs eventArgs)
		{
			ClearForm();
		}

		public void ClearForm()
		{
			CommonFunctions.RemoveMark(this);
			AlreadyMarked = false;
			txtName.Text = "";
			txtOwner.Text = "";
			txtHeadquarters.Text = "";
			txtAreaServed.Text = "";
			txtWebsite.Text = "";
			dtFounded.SetValue(DateTime.Today);
			cmbParent.SelectedIndex = -1;
			txtNumberEmployees.Text = "";
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
		private void Form_Load()
		{
			dtFounded.SetValue(DateTime.Today);
			LoadParents();
			VerifyCurrentRole();
		}

		public void VerifyCurrentRole()
		{
			if (frmMain.DefInstance.CurrentUserRoleID == 1)
			{
				MessageBox.Show("The current user does not have permission to add or modify brands information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCreate.Enabled = false;
			}
		}

		public void LoadParents()
		{
			modMain.ExecuteSQL("Select * from Brand order by Brand_Name asc");
			cmbParent.Clear();
			while (!modMain.rs.EOF)
			{
				cmbParent.AddItem(Convert.ToString(modMain.rs["Brand_Name"]));
				modMain.rs.MoveNext();
			}
		}

		private void txtNumberEmployees_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtNumberEmployees.Text != "")
			{
				txtNumberEmployees.Text = StringsHelper.Format(txtNumberEmployees.Text, "");
			}
		}

		private void txtNumberEmployees_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (!Information.IsNumeric(Strings.Chr(KeyAscii).ToString()) && KeyAscii != 8)
				{
					KeyAscii = 0;
					MessageBox.Show("Enter only numeric characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		public void txtNumberEmployees_Leave(Object eventSender, EventArgs eventArgs)
		{
			txtNumberEmployees.Text = StringsHelper.Format(txtNumberEmployees.Text, "###,###");
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}