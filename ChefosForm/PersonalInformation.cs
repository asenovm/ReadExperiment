using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Read
{
    public partial class PersonalInformation : Form
    {

        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (!CanOpenExperiment())
            {
                return;
            }

            string resultsFile = "results" + Guid.NewGuid() + ".txt";
            FileUtil.WriteToFile(ageBox.Text, maleRadio.Checked ? "0" : "1", majorDropDown.SelectedText, resultsFile);

            FormReadExperiment frm =
                new FormReadExperiment(resultsFile);
            this.Hide();
            frm.Show();
        }

        private bool CanOpenExperiment()
        {
            return ageBox.Text.Length > 0 && majorDropDown.SelectedItem != null && (maleRadio.Checked || femaleRadio.Checked);
        }
    }
}
