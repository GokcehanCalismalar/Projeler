using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaşKağıtMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPCPuan.Text ="0";
            lblKullanıcıPuan.Text = "0";
        }
        Random random= new Random();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            label2.Text = txtIsım.Text;
        }
        private void EkrandaGöster()
        {
            lblPcEkran.Text = random.Next(1, 4).ToString();
            
            if ((Convert.ToInt32(lblPcEkran.Tag)) == 1)
            {
                lblPcEkran.Text = "Taş";

            }
            else if ((Convert.ToInt32(lblPcEkran.Tag)) == 2)
            {
                lblPcEkran.Text = "Kağıt";

            }
            else if ((Convert.ToInt32(lblPcEkran.Tag)) == 3)
            {
                lblPcEkran.Text = "Makas";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTas_Click(object sender, EventArgs e)
        {
            EkrandaGöster();
            lblKullanıcıEkran.Text = "Makas";
            if (lblPcEkran.Text == "makas")
            {
                lblPcEkran.BackColor = Color.Blue;
                lblKullanıcıEkran.BackColor = Color.Blue;

            }
            else if (lblPcEkran.Text == "Kağıt")
            {
                lblPcEkran.BackColor = Color.Red;
                lblKullanıcıEkran.BackColor = Color.Green;
                lblKullanıcıEkran.Text = ((Convert.ToInt32(lblPCPuan.Text)) + 1).ToString();
            }
            else if (lblPcEkran.Text == "Taş")
            {
                lblPcEkran.BackColor = Color.Green;
                lblKullanıcıEkran.BackColor = Color.Red;
                lblPCPuan.Text = ((Convert.ToInt32(lblPCPuan.Text)) + 1).ToString();
            }
        }

        private void btnKagıt_Click(object sender, EventArgs e)
        {
            EkrandaGöster();
            lblKullanıcıEkran.Text = "Kağıt";
            if (lblPcEkran.Text == "Kağıt")
            {
                lblPcEkran.BackColor = Color.Blue;
                lblKullanıcıEkran.BackColor = Color.Blue;

            }
            else if (lblPcEkran.Text == "Makas")
            {
                lblPcEkran.BackColor = Color.Green;
                lblKullanıcıEkran.BackColor = Color.Red;
                lblPCPuan.Text = ((Convert.ToInt32(lblPCPuan.Text)) + 1).ToString();
            }
            else if (lblPcEkran.Text == "Taş")
            {
                lblPcEkran.BackColor = Color.Green;
                lblKullanıcıEkran.BackColor = Color.Red;
                lblPCPuan.Text = ((Convert.ToInt32(lblPCPuan.Text)) + 1).ToString();
            }
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {

        }
    }
}
