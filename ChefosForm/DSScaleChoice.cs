using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Read
{
    public partial class DSScaleChoice : Form
    {
        private string supplier;
        private long choiceTime;
        private long nextTime;
        private long dsChoiceTime;
        private int dsChoice;
        private Stopwatch dsStopWatch = new Stopwatch();
        private Stopwatch nextWatch = new Stopwatch();
        FormReadExperiment mainForm;
        private bool allowClose;
        private string outputFileName;

        public DSScaleChoice(string supplier, string offered,
                             string received, string total,
                             long choiceTime, long nextTime,
                             string outputFileName,
                             FormReadExperiment mainForm)
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
            this.outputFileName = outputFileName;

            dsStopWatch.start();
        }

        private void RadioMinus4_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();

            radioGroupDSScale.Enabled = false;
            dsChoice = -4;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioMinus3_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = -3;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioMinus2_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = -2;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioMinus1_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = -1;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioZero_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 0;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioPlus1_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 1;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioPlus2_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 2;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioPlus3_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 3;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void RadioPlus4_CheckedChanged(object sender, EventArgs e)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = 4;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FileUtil.WriteToFile(supplier,choiceTime.ToString(),nextTime.ToString(),dsChoiceTime.ToString(),dsChoice.ToString(),nextWatch.stop().ToString(),  outputFileName);
            mainForm.NextIteration();
            allowClose = true;
            Close();
        }

        private void FormDSScaleChice_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !allowClose;
        }

    }
}