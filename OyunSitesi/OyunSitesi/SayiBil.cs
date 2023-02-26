using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyunSitesi
{
    public partial class SayiBil : Form
    {
        private int sure = 20;
        private int rastgele;
        public SayiBil()
        {
            InitializeComponent();
            btnTahmin.Enabled = false;
            txtTahmin.Enabled=false;
            lbSkor.Text = "";
            lblSure.Visible = false;
            label2.Visible= false;
        }
        Random rnd = new Random();
        private void Sure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            lblSure.ForeColor= Color.Green;
            if (sure==0)
            {
                Sure.Stop();
                lblBilgiEkranı.Text = "Oyun Bitti";
                btnTahmin.Enabled = false;
                btnBasla.Enabled = true;
                txtTahmin.Enabled = false;
             
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            sure = 20;
            btnBasla.Enabled = false;
            btnTahmin.Enabled = true;
            txtTahmin.Enabled = true;
            lblSure.Visible = true;
            label2.Visible = true;
            rastgele =rnd.Next(1,2);
            Sure.Start();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int fark = rastgele - Convert.ToInt32(txtTahmin.Text);
            if (fark>0)
            {
                lblBilgiEkranı.Text = $"{txtTahmin.Text}'den daha büyük ";
            }
            else if(fark<0)
            {
                lblBilgiEkranı.Text = $"{txtTahmin.Text}'den daha küçük ";
            }
            else
            {
                Sure.Stop();
                lblBilgiEkranı.Text = "Tebrikler";
                lbSkor.Items.Add ($"{fark} saniyede bildin");
                btnBasla.Enabled = true;
            }
        }

        private void lblSure_Click(object sender, EventArgs e)
        {

        }
    }
}
