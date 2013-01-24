using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChefosForm
{
    public partial class InstructionsForm : Form
    {

        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int fileSuffix = random.Next(10000);
            string outputFileName = "result" + fileSuffix + ".txt";
            System.IO.FileInfo fi1 = new System.IO.FileInfo(outputFileName);
            while (fi1.Exists)
            {
                outputFileName = "resul" + fileSuffix + ".txt";
                fi1 = new System.IO.FileInfo(outputFileName);
            }

            ServerConnection connection = new ServerConnection(new ClientConfiguration("client.dat"));
            connection.Register();

            FormReadExperiment frm =
                new FormReadExperiment("SuppliersOffers.txt", outputFileName);
            this.Hide();
            frm.Show();
        }
    }
}