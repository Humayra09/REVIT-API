using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;
using System.Reflection;

namespace ElectricalSwitch
{
    public class SwitchBoard : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                //System.Diagnostics.Debugger.Launch();
                bool isRibbonTabExist = false;
                Autodesk.Windows.RibbonControl r = Autodesk.Windows.ComponentManager.Ribbon;
                foreach (Autodesk.Windows.RibbonTab tab in r.Tabs)
                {
                    if (!string.IsNullOrEmpty(tab.Name) && tab.Name.ToUpper() == "ENG VB")
                    {
                        isRibbonTabExist = true;
                        break;
                    }
                }
                if (isRibbonTabExist == false)
                {
                    application.CreateRibbonTab("ENG VB");
                }


                RibbonPanel ribbonPanel = application.CreateRibbonPanel("ENG VB", "Electrical");

                // Create the first button
                PushButtonData pushButtonData1 = new PushButtonData("SwitchBoard", "SwitchBoard", Assembly.GetExecutingAssembly().Location, "ElectricalSwitch.SwitchBoardCommand");
                Stream stream1 = Assembly.GetExecutingAssembly().GetManifestResourceStream("ElectricalSwitch.Resources.click.png");
                pushButtonData1.LargeImage = BitmapFrame.Create(stream1);
                PushButton pushButton1 = ribbonPanel.AddItem(pushButtonData1) as PushButton;
                pushButton1.Enabled = true;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message+Environment.NewLine+ex.StackTrace);
            }
           


            return Result.Succeeded;
        }
    }
}
