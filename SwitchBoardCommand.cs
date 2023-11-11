using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Events;

namespace ElectricalSwitch
{
    [Transaction(TransactionMode.Manual)]
    public class SwitchBoardCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
           // System.Windows.Forms.MessageBox.Show("hi");
            frmSwitchBoard objfrmSwitchBoard = new frmSwitchBoard();
            objfrmSwitchBoard.ShowDialog();
            return Result.Succeeded;



        }
    }
}
