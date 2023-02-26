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
    public partial class Form3OyunEkranı : Form
    {
        
        public Form3OyunEkranı()
        {
            InitializeComponent();
            kullanıcıToolStripMenuItem1.Text = "Oyuncu" + Form2.ID;
           
        }
        
        private void Form3OyunEkranı_Load(object sender, EventArgs e)
        {
            
            SayiBil sayiBil= new SayiBil();
            sayiBil.MdiParent= this;
            sayiBil.Show();
            Width = sayiBil.Width ;
            Height = sayiBil.Height ;

        }

        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.ToArray().OfType<MayinTarlası>().Count() <= 0)
            {
                MayinTarlası mayinTarlası = new MayinTarlası();
                mayinTarlası.MdiParent = this;
                mayinTarlası.Show();
                Width = mayinTarlası.Width +50;
                Height = mayinTarlası.Height +50;

            }


        }

        private void sayıyıBilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.ToArray().OfType<SayiBil>().Count() <= 0)
            {
                SayiBil sayiBil = new SayiBil();
                sayiBil.MdiParent = this;
                sayiBil.Show();
                Width = sayiBil.Width + 50;
                Height = sayiBil.Height + 50;
            }
          
        }
    }
}
