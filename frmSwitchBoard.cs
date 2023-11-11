using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Creation;

namespace ElectricalSwitch
{
    public partial class frmSwitchBoard : Form
    {
        private UIApplication uiapp;
        private UIDocument uidoc;
        private Autodesk.Revit.ApplicationServices.Application app;
        private Document doc;
        public frmSwitchBoard()
        {
            InitializeComponent();
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string[] itemArray = new string[]
        //        {"Switch Board Back Box-1M",
        //        "Switch Board Back Box-2M",
        //        "Switch Board Back Box-3M",
        //        "Switch Board Back Box-4M",
        //        "Switch Board Back Box-6M",
        //        "Switch Board Back Box-8M",
        //        "Switch Board Back Box-12M",
        //        "Switch Board Back Box -16M",
        //        "Switch Board Back Box -18M"
        //        };

        //    foreach (string item in itemArray)
        //    {
        //        comboBox1.Items.Add(item);
        //    }
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSwitchBoard_Load(object sender, EventArgs e)
        {
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            label1.Text = "You selected: " + selectedOption;
        }
    }
}
