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
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            Hide();
            PersonalInformation informationForm = new PersonalInformation();
            informationForm.Show();
        }
    }
}