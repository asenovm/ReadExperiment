using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Read
{
    public partial class ExprimentEndDialog : Form
    {

        private Timer timer;

        private const int DELAY_QUESTIONNAIRE = 10000;

        private bool allowClose;

        public ExprimentEndDialog()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = DELAY_QUESTIONNAIRE;
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs args)
        {
            timer.Stop();
            allowClose = true;
        }

        private void OnOKButtonClicked(object sender, EventArgs e)
        {
            if (allowClose)
            {
                Close();
            }
        }

        private void OnFormCloseRequired(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !allowClose;
        }
    }
}
