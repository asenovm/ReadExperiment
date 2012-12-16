using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChefosForm
{
    public partial class DSScaleChoice : Form
    {
        private string supplier;
        private int choiceTime;
        private int nextTime;
        private int dsChoiceTime;
        private int dsChoice;
        private Stopwatch dsStopWatch = new Stopwatch();
        private Stopwatch nextWatch = new Stopwatch();
        formReadExperiment mainForm;
        private bool allowClose;

        public DSScaleChoice(string supplier, string offered, 
                             string received, string total,
                             int choiceTime, int nextTime,
                             formReadExperiment mainForm)
        {
            InitializeComponent();

            offerLabel.Text = offered;
            this.supplier = supplierLabel.Text = supplier;
            realLabel.Text = received;
            omniumQuontityLabel.Text = total;
            this.choiceTime = choiceTime;
            this.nextTime = nextTime;
            this.mainForm = mainForm;
            this.allowClose = false;

            dsStopWatch.start();
        }

        private void print(int nextIterationTime)
        {
            System.IO.StreamWriter SW;
            SW = System.IO.File.AppendText("result.txt");
            SW.WriteLine(supplier + " " + choiceTime.ToString() + " "  + nextTime.ToString() + " " + 
                         dsChoiceTime.ToString() + " " + dsChoice + " " + nextIterationTime);
            SW.Close(); 
        }

        private void radioMinus4_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();

            radioGroupDSScale.Enabled = false;
            dsChoice =  -4;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioMinus3_CheckedChanged(object sender, EventArgs e)
        {
            int dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = -3;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioMinus2_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = -2;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioMinus1_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = -1;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioZero_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 0;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioPlus1_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 1;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioPlus2_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 2;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioPlus3_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 3;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void radioPlus4_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoiceTime = 4;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print(nextWatch.stop());
            mainForm.nextIteration();
            allowClose = true;
            Close();
        }

        private void formDSScaleChice_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true;
            }
        }


    }
}