using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblKazan.Text = "0";
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                case Keys.Up:
                    YukarıCik();
                    break;
                case Keys.Down:
                    Assagıİn();
                    break;
                case Keys.Right:
                    SagaGit();
                    break;
                case Keys.Left:
                    SolaGit();

                    break;
            }
            OyunBittiMi();
        }
        int kazanSayac ;
        int kaybetSayac ;

        private void OyunBittiMi()
        {
            bool kazandıMi = pnlKutu.Bounds.IntersectsWith(lblBitis.Bounds);
            bool kaybettiMi = pnlKutu.Bounds.IntersectsWith(lbl1D.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl2D.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl3D.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl4D.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl5D.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl6D.Bounds)
                || pnlKutu.Bounds.IntersectsWith(lbl7D.Bounds);
            if (kazandıMi)
            {
                kazanSayac++;
                //lblKazan.Text=kazanSayac.ToString();
                lblKazan.Text=(Convert.ToInt32(lblKazan.Text)+1).ToString();
                DialogResult result= MessageBox.Show("Tekrar Deneyiniz", "Kazandınız",MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    // Application.Restart();
                     pnlKutu.Location = new Point(113, 116);
                }
                else
                {
                     //  Close();
                     Application.Exit();
                }
                
            }
            if (kaybettiMi)
            {
                kaybetSayac++;
                lblKaybet.Text = kaybetSayac.ToString();
                DialogResult result = MessageBox.Show("Tekrar Deneyiniz", "Kaybettiniz !", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Application.Restart();
                    pnlKutu.Location = new Point(113, 116);
                }
                else
                {
                    //  Close();
                    Application.Exit();
                }
               
            }

        }

        private void SolaGit()
        {
            pnlKutu.Left -= 10;
        }

        private void SagaGit()
        {
            pnlKutu.Left += 10;
        }

        private void Assagıİn()
        {
            pnlKutu.Top += 10;
        }

        private void YukarıCik()
        {
            pnlKutu.Top-=10;
        }

    }
}
