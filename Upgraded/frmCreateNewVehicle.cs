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
	internal partial class frmCreateNewVehicle
		: System.Windows.Forms.Form
	{

		public frmCreateNewVehicle()
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


		private void frmCreateNewVehicle_Activated(System.Object eventSender, System.EventArgs eventArgs)
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
				modMain.ExecuteSQL($"Select * from Vehicle where Vehicle_Name = '{txtName.Text}'");
				if (IsInformationValid())
				{
					if (btnCreate.Text == "&Create")
					{
						if (!modMain.rs.EOF)
						{
							MessageBox.Show("Vehicle model already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						modMain.rs.AddNew();

						MessageBox.Show("New vehicle model added successfully!", "Information", MessageBoxButtons.OK);
					}
					else if (btnCreate.Text == "&Update")
					{ 
						if (ModelExists(txtName.Text))
						{
							return;
						}

						MessageBox.Show("Vehicle model updated successfully!", "Information", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Fill all the required spaces in the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CheckEmptyText();
					AlreadyMarked = true;
					return;
				}

				modMain.rs["Vehicle_Name"] = txtName.Text;
				modMain.rs["Manufacturer_ID"] = GetManufacturerID();
				modMain.rs["Production_Started"] = ReflectionHelper.GetPrimitiveValue<System.DateTime>(dtProductionStarted.GetValue()).ToString("MM/dd/yyyy");
				modMain.rs["Production_Ended"] = ReflectionHelper.GetPrimitiveValue<System.DateTime>(dtProductionEnded.GetValue()).ToString("MM/dd/yyyy");
				modMain.rs["Produced"] = txtYear.Text;
				modMain.rs["Quantity"] = txtQuantity.Text;
				modMain.rs["Price"] = Double.Parse(StringsHelper.Replace(txtPrice.Text, "$", "", 1, -1, CompareMethod.Binary));
				if (optTransmission[0].Checked)
				{
					modMain.rs["Transmission"] = "Automatic";
				}
				else
				{
					modMain.rs["Transmission"] = "Manual";
				}
				modMain.rs["Class_ID"] = GetClassID();
				modMain.rs["Body_Style"] = cmbBodyStyle.Text;
				modMain.rs["Length"] = Double.Parse(StringsHelper.Replace(txtLength.Text, " mm", "", 1, -1, CompareMethod.Binary));
				modMain.rs["Width"] = Double.Parse(StringsHelper.Replace(txtWidth.Text, " mm", "", 1, -1, CompareMethod.Binary));
				modMain.rs["Available"] = true;
				modMain.rs.Update();

				AlreadyMarked = false;
				CommonFunctions.RemoveMark(this);
				ClearForm();
			}
			catch
			{
				MessageBox.Show("There was an error during the operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		public bool ModelExists(string ModelName)
		{
			bool result = false;
			modMain.ExecuteSQL2($"Select * from Vehicle where Vehicle_Name = '{ModelName}'");
			if (ModelName == PreviousName)
			{
				result = false;
			}
			else if (!modMain.rs2.EOF && ModelName != PreviousName)
			{ 
				MessageBox.Show("Vehicle model already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				result = true;
			}
			return result;
		}

		public void CheckEmptyText()
		{
			if (!AlreadyMarked)
			{
				CommonFunctions.AddRequiredMark(lblName, Color.Red, txtName);
				CommonFunctions.AddRequiredMark(lblManufacturer, Color.Red, null, cmbManufacturer);
				CommonFunctions.AddRequiredMark(lblYearProduction, Color.Red, txtYear);
				CommonFunctions.AddRequiredMark(lblQuantity, Color.Red, txtQuantity);
				CommonFunctions.AddRequiredMark(lblPrice, Color.Red, txtPrice);
				CommonFunctions.AddRequiredMark(lblTransmission, Color.Red, null, null, optTransmission);
				CommonFunctions.AddRequiredMark(lblClass, Color.Red, null, cmbClass);
				CommonFunctions.AddRequiredMark(lblBodyStyle, Color.Red, null, cmbBodyStyle);
				CommonFunctions.AddRequiredMark(lblLength, Color.Red, txtLength);
				CommonFunctions.AddRequiredMark(lblWidth, Color.Red, txtWidth);
			}
		}

		public int GetManufacturerID()
		{
			modMain.ExecuteSQL2($"Select * from Brand where Brand_Name = '{cmbManufacturer.Text}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		public int GetClassID()
		{
			modMain.ExecuteSQL2($"Select * from Class where Class_Name = '{cmbClass.Text}'");
			return Convert.ToInt32(modMain.rs2["ID"]);
		}

		public bool IsInformationValid()
		{
			return txtName.Text != "" && cmbManufacturer.SelectedIndex != -1 && txtQuantity.Text != "" && txtPrice.Text != "" && txtYear.Text != "" && (optTransmission[0].Checked || optTransmission[1].Checked) && cmbClass.SelectedIndex != -1 && cmbBodyStyle.SelectedIndex != -1 && txtLength.Text != "" && txtWidth.Text != "";
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
			cmbManufacturer.SelectedIndex = -1;
			optTransmission[0].Checked = false;
			optTransmission[1].Checked = false;
			cmbClass.SelectedIndex = -1;
			cmbBodyStyle.SelectedIndex = -1;
			dtProductionEnded.SetValue(DateTime.Today);
			dtProductionStarted.SetValue(DateTime.Today);
			txtYear.Text = "";
			txtQuantity.Text = "";
			txtPrice.Text = "";
			txtLength.Text = "";
			txtWidth.Text = "";
		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
		private void Form_Load()
		{
			LoadManufacturers();
			LoadClasses();
			VerifyCurrentRole();
		}

		public void VerifyCurrentRole()
		{
			if (frmMain.DefInstance.CurrentUserRoleID == 1)
			{
				MessageBox.Show("The current user does not have permission to add or modify vehicles information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnCreate.Enabled = false;
			}
		}

		public void LoadManufacturers()
		{
			modMain.ExecuteSQL("Select * from Brand order by Brand_Name asc");
			cmbManufacturer.Clear();
			while (!modMain.rs.EOF)
			{
				cmbManufacturer.AddItem(Convert.ToString(modMain.rs["Brand_Name"]));
				modMain.rs.MoveNext();
			}
		}

		public void LoadClasses()
		{
			modMain.ExecuteSQL("Select * from Class");
			cmbClass.Clear();
			while (!modMain.rs.EOF)
			{
				cmbClass.AddItem(Convert.ToString(modMain.rs["Class_Name"]));
				modMain.rs.MoveNext();
			}
		}

		private void txtLength_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtLength.Text != "")
			{
				txtLength.Text = StringsHelper.Replace(txtLength.Text, " mm", "", 1, -1, CompareMethod.Binary);
				txtLength.Text = Strings.FormatNumber(txtLength.Text, 0, TriState.False, TriState.False, TriState.False);
				txtLength.MaxLength = 6;
			}
		}

		private void txtLength_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				VerifyChar(ref KeyAscii);
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

		public void txtLength_Leave(Object eventSender, EventArgs eventArgs)
		{
			txtLength.MaxLength = 10;
			txtLength.Text = StringsHelper.Format(txtLength.Text, "##,### mm");
		}

		private void txtPrice_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtPrice.Text != "")
			{
				txtPrice.Text = StringsHelper.Replace(Double.Parse(txtPrice.Text, NumberStyles.Any).ToString("N0"), ",", "", 1, -1, CompareMethod.Binary);
			}
		}

		private void txtPrice_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				VerifyChar(ref KeyAscii);
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

		public void txtPrice_Leave(Object eventSender, EventArgs eventArgs)
		{
			txtPrice.Text = StringsHelper.Format(txtPrice.Text, "$#,###");
		}

		private void txtQuantity_Click(Object eventSender, EventArgs eventArgs)
		{
			txtQuantity.MaxLength = 6;
		}

		private void txtQuantity_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtQuantity.Text != "")
			{
				txtQuantity.Text = StringsHelper.Replace(Double.Parse(txtQuantity.Text, NumberStyles.Any).ToString("N0"), ",", "", 1, -1, CompareMethod.Binary);
			}
		}

		private void txtQuantity_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				VerifyChar(ref KeyAscii);
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

		public void txtQuantity_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (Strings.Len(txtQuantity.Text) % 3 == 0)
			{
				txtQuantity.MaxLength = 7;
			}
			txtQuantity.Text = StringsHelper.Format(txtQuantity.Text, "#,##0");
		}

		private void txtWidth_Enter(Object eventSender, EventArgs eventArgs)
		{
			if (txtWidth.Text != "")
			{
				txtWidth.Text = StringsHelper.Replace(txtWidth.Text, " mm", "", 1, -1, CompareMethod.Binary);
				txtWidth.Text = StringsHelper.Format(txtWidth.Text, "");
				txtWidth.MaxLength = 6;
			}
		}

		private void txtWidth_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				VerifyChar(ref KeyAscii);
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

		public void VerifyChar(ref int KeyAscii)
		{
			if (!Information.IsNumeric(Strings.Chr(KeyAscii).ToString()) && KeyAscii != 8)
			{
				KeyAscii = 0;
				MessageBox.Show("Enter only numeric characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public void txtWidth_Leave(Object eventSender, EventArgs eventArgs)
		{
			txtWidth.MaxLength = 10;
			txtWidth.Text = StringsHelper.Format(txtWidth.Text, "##,### mm");
		}

		private void txtYear_KeyPress(Object eventSender, KeyPressEventArgs eventArgs)
		{
			int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
			try
			{
				if (!Information.IsNumeric(Strings.Chr(KeyAscii).ToString()) && KeyAscii != 8)
				{
					KeyAscii = 0;
					MessageBox.Show("Enter only numeric characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				if (Strings.Len(txtYear.Text) == 4 && KeyAscii != 8)
				{
					KeyAscii = 0;
					MessageBox.Show("Enter a valid year of 4 characters", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
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
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}