using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;
using UpgradeHelpers.Gui;
using UpgradeHelpers.Gui.Controls;
using UpgradeHelpers.Helpers;

namespace StarCarsManagement
{
	internal static class CommonFunctions
	{


		internal static bool ExistsInCombo(string v, ComboBox combo = null, ComboBox WLcombo = null)
		{
			string element = "";
			bool result = false;
			if (combo != null)
			{
				int tempForEndVar = combo.Items.Count;
				for (int i = 0; i <= tempForEndVar; i++)
				{
					element = combo.GetListItem(i);
					if (v == element)
					{
						result = true;
						break;
					}
				}
			}
			else if (WLcombo != null)
			{ 
				int tempForEndVar2 = WLcombo.Items.Count;
				for (int i = 0; i <= tempForEndVar2; i++)
				{
					element = WLcombo.GetListItem(i);
					if (v == element)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		internal static void AddRequiredMark(Label label, Color colorToUse, Control textbox = null, ComboBox combo = null, System.Windows.Forms.RadioButton[] optionArray = null)
		{
			//UPGRADE_WARNING: (2065) Boolean method Information.IsMissing has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2065
			if (!(textbox is null))
			{
				if (Convert.ToString(textbox.Text) == "")
				{
					label.Text = $"{label.Text} *";
					label.ForeColor = colorToUse;
				}
			}
			else if (!(optionArray is null))
			{ 
				if (!optionArray[0].Checked && !optionArray[1].Checked)
				{
					label.Text = $"{label.Text} *";
					label.ForeColor = colorToUse;
				}
			}
			else if (!(combo is null))
			{ 
				if (combo.SelectedIndex == -1)
				{
					label.Text = $"{label.Text} *";
					label.ForeColor = colorToUse;
				}
			}
		}

		internal static void RemoveMark(Form frm)
		{
			Control ctrl = null;
			Label ctrlTyped = null;
			//UPGRADE_WARNING: (2065) Form property frm.Controls has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2065
			foreach (Control ctrlIterator in ContainerHelper.Controls(frm))
			{
				ctrl = ctrlIterator;
				if (ctrl is Label)
				{
					ctrlTyped = (Label) ctrl;
					ctrlTyped.ForeColor = Color.Black;
					ctrlTyped.Text = StringsHelper.Replace(ctrlTyped.Text, " *", "", 1, -1, CompareMethod.Binary);
				}
				ctrl = default(Control);
			}
		}

		internal static string ReadFile(string strFilename)
		{
			_ = "";
			string TextLine = "";
			int FileHandle = 1;
			FileSystem.FileOpen(FileHandle, strFilename, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);


			while(!FileSystem.EOF(FileHandle))
			{ // Loop until end of file
				TextLine = FileSystem.LineInput(FileHandle); // Read line into variable
			};
			string result = TextLine;
			FileSystem.FileClose(FileHandle);
			return result;
		}
	}
}