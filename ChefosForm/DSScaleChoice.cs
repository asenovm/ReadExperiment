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

        private ServerConnection serverConnection;

        private AnswerRecorder experimentRecorder;

        public DSScaleChoice(string supplier, string offered,
                             string received, string total,
                             long choiceTime, long nextTime,
                             FormReadExperiment mainForm,
                             ServerConnection serverConnection)
        {
            InitializeComponent();

            experimentRecorder = new AnswerRecorder(FileName.RESULTS_EXPERIMENT, " ");

            offerLabel.Text = offered;
            this.supplier = supplierLabel.Text = supplier;
            realLabel.Text = received;
            omniumQuontityLabel.Text = total;
            this.choiceTime = choiceTime;
            this.nextTime = nextTime;
            this.mainForm = mainForm;
            this.allowClose = false;
            this.serverConnection = serverConnection;

            dsStopWatch.start();
        }

        private void RadioMinus4_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(-4);
        }

        private void RadioMinus3_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(-3);
        }

        private void RadioMinus2_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(-2);
        }

        private void RadioMinus1_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(-1);
        }

        private void RadioZero_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(0);
        }

        private void RadioPlus1_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(1);
        }

        private void RadioPlus2_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(2);
        }

        private void RadioPlus3_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(3);
        }

        private void RadioPlus4_CheckedChanged(object sender, EventArgs e)
        {
            onSatisfactionPicked(4);
        }

        private void onSatisfactionPicked(int satisfaction)
        {
            dsChoiceTime = dsStopWatch.stop();
            radioGroupDSScale.Enabled = false;
            dsChoice = satisfaction;
            nextBtn.Enabled = true;
            nextWatch.start();
        }

        private void FormDSScaleChice_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !allowClose;
        }

        private void onNextButtonClicked(object sender, EventArgs e)
        {
            experimentRecorder.WriteAnswer(supplier, true);
            experimentRecorder.WriteAnswer(choiceTime.ToString(), true);
            experimentRecorder.WriteAnswer(nextTime.ToString(), true);
            experimentRecorder.WriteAnswer(dsChoiceTime.ToString(), true);
            experimentRecorder.WriteAnswer(dsChoice.ToString(), true);
            experimentRecorder.WriteAnswer(nextWatch.stop().ToString(), false);
            experimentRecorder.WriteAnswer(Environment.NewLine, false);

            serverConnection.SendAnswer(new Answer(supplier, dsChoice));

            mainForm.NextIteration();

            allowClose = true;
            Close();
        }

    }
}