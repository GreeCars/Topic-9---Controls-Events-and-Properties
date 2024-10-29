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
        Random generator = new Random();

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

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void lblInstruction_MouseEnter(object sender, EventArgs e)
        {
            lblInstruction.ForeColor = Color.Red;
        }

        private void lblInstruction_MouseLeave(object sender, EventArgs e)
        {
            lblInstruction.ForeColor= Color.Black;
        }

        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            int max = 256; // 255 is the maximum value an RGB value can be
            int r = generator.Next(max);
            int g = generator.Next(max);
            int b = generator.Next(max);
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
