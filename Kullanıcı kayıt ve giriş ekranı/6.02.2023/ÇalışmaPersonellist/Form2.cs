using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÇalışmaPersonellist
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pb1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pProgramlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb1.Visible=false;
        }

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb1.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
