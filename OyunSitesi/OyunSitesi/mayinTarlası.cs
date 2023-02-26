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
    public partial class MayinTarlası : Form
    {
        public MayinTarlası()
        {
            InitializeComponent();
            lbCan.Text = "3";
            lbPuan.Text = "0";
            
        }
        Random rnd= new Random();
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(txtAdet.Text); i++)
            {
                int sayi=rnd.Next(1,6);
                Button btn = new Button();
                btn.Height = 40;
                btn.Width = 40;
                btn.Tag = sayi;
                btn.Click += Btn_Click;

                flpTarla.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn=sender as Button;
            if (Convert.ToInt32(btn.Tag)==1)
            {
                btn.BackColor= Color.Red;
                lbCan.Text = ((Convert.ToInt32(lbCan.Text)) - 1).ToString();
                if (lbCan.Text == "0")
                {
                    MessageBox.Show("Buraya Kadar");
                    lbScor.Items.Add(Form2.ID + " " + lbPuan.Text.ToString()); 
                    lbCan.Text = "3";
                    lbPuan.Text = "0";
                    flpTarla.Controls.Clear();
                    
                }
              
            }
            else
            {
                btn.BackColor= Color.Green;
                lbPuan.Text = ((Convert.ToInt32(lbPuan.Text)) + 1).ToString();
                
            }
        }

        private void MayinTarlası_Load(object sender, EventArgs e)
        {

        }
    }
}
