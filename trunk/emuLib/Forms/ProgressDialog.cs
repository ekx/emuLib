using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace emuLib.Forms
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog(int max)
        {
            InitializeComponent();

            progressBar.Minimum = 1;
            progressBar.Maximum = max;
            progressBar.Value = 1;
        }

        public void setStep(int step)
        {
            progressBar.Value = step;
            progressBar.Refresh();

            progressLabel.Text = step + " of " + progressBar.Maximum + " Games processed";
            progressLabel.Refresh();
        }
    }
}
