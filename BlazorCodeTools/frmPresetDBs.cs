using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BlazorCodeTools
{
    public partial class frmPresetDBs : Form
    {

        public bool frmOK = false;
        public string selectedDB = "";


        public frmPresetDBs()
        {
            InitializeComponent();

            lbPresets.Items.Clear();

            if (File.Exists(Path.Combine(Application.StartupPath,"BlazorCodeTools.ini")))
            {
                string[] arr = File.ReadAllLines(Path.Combine(Application.StartupPath, "BlazorCodeTools.ini"));

                foreach(string s in arr)
                {
                    if (s.ToUpper().StartsWith("DBASE="))
                    {
                        lbPresets.Items.Add(s.Substring(6));
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmOK = false;
            selectedDB = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedDB!="")
            {
                frmOK = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select from one of the Preset Database Connection Strings");
            }
        }

        private void HandleADatabaseSelection(object sender, EventArgs e)
        {
            if (lbPresets.SelectedItem != null)
                selectedDB = lbPresets.SelectedItem.ToString();
        }

        private void HandleDoubleclick(object sender, MouseEventArgs e)
        {
            if (lbPresets.SelectedItem != null)
                btnOK_Click(sender, new EventArgs());
        }
    }
}
