using System;
using System.Windows.Forms;

namespace StarCarsManagement
{
	internal partial class frmMain
		: System.Windows.Forms.Form
	{

		public frmMain()
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


		private void frmMain_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		public int CurrentUserRoleID = 0;

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis/warnings#id-2080
		private void Form_Load()
		{
			frmLogin f = frmLogin.CreateInstance();
			f.ShowDialog(this);
			if (lblUser.Text == "")
			{
				if (!f.LoginSucceeded)
				{
					this.Close();
				}
			}
		}

		public void menuCreateReceipts_Click(Object eventSender, EventArgs eventArgs)
		{
			frmCreateNewReceipt f = frmCreateNewReceipt.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuAbout_Click(Object eventSender, EventArgs eventArgs)
		{
			frmAbout f = frmAbout.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuChangeUser_Click(Object eventSender, EventArgs eventArgs) => Form_Load();


		public void mnuCreateBrand_Click(Object eventSender, EventArgs eventArgs)
		{
			frmCreateNewBrand f = frmCreateNewBrand.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuCreateStaff_Click(Object eventSender, EventArgs eventArgs)
		{
			frmCreateNewStaff f = frmCreateNewStaff.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuCreateVehicle_Click(Object eventSender, EventArgs eventArgs)
		{
			frmCreateNewVehicle f = frmCreateNewVehicle.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuDeleteBrand_Click(Object eventSender, EventArgs eventArgs)
		{
			frmDeleteBrand f = frmDeleteBrand.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuDeleteStaff_Click(Object eventSender, EventArgs eventArgs)
		{
			frmDeleteStaff f = frmDeleteStaff.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuDeleteVehicle_Click(Object eventSender, EventArgs eventArgs)
		{
			frmDeleteVehicle f = frmDeleteVehicle.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuDetailedInformation_Click(Object eventSender, EventArgs eventArgs)
		{
			frmDetailedInformation f = frmDetailedInformation.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuExit_Click(Object eventSender, EventArgs eventArgs) => this.Close();


		public void mnuShowBrands_Click(Object eventSender, EventArgs eventArgs)
		{
			frmViewBrands f = frmViewBrands.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuShowReceipts_Click(Object eventSender, EventArgs eventArgs)
		{
			frmViewReceipts f = frmViewReceipts.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuShowStaff_Click(Object eventSender, EventArgs eventArgs)
		{
			frmViewStaff f = frmViewStaff.CreateInstance();
			f.ShowDialog(this);
		}

		public void mnuShowVehicles_Click(Object eventSender, EventArgs eventArgs)
		{
			frmViewVehicles f = frmViewVehicles.CreateInstance();
			f.ShowDialog(this);
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}