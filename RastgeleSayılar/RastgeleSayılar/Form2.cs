using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayılar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lblKullanıcıAdı.Text ="Nick : " +  Form1.Kullanıcı ;,
            lblSure.Visible = false;
            lblSureYazı.Visible = false;
        }
        Random rnd= new Random();

            int sure = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            tmrSure.Start();

        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text=sure.ToString();
        }
    }
}
