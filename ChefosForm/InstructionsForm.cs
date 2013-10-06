using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Read
{
    public partial class InstructionsForm : Form
    {

        public InstructionsForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormReadExperiment experimentForm = new FormReadExperiment();
            experimentForm.Show();
        }

        private void OnCloseRequired(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}