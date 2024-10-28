using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___Controls__Events__and_Properties
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = true;
            lblStatus.Text = "Status: Clicked";
            btnQuit.Enabled = true;
            btnSubmit.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgCharacter_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = false;
        }
    }
}
