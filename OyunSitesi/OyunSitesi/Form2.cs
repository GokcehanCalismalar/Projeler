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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled= false;
            txtSifre.PasswordChar = '*';
            txtSifre2.PasswordChar = '*';
            txtId.Text = "1";
            txtSifre.Text = "2";
            txtSifre2.Text = "2";
          
        }
        public static string ID;
        public static string Sifre;

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtId.Text!=null && txtSifre.Text == txtSifre2.Text)
            {
                MessageBox.Show("Kaydınız oluşmuştur");
                ID= txtId.Text;
                Sifre= txtSifre2.Text;
                Form1 frm1Don= new Form1();
                frm1Don.Show();
                this.Close();
            }
            else if (txtSifre.Text != txtSifre2.Text)
            {
                lblBilgi.Text = "Girmiş olduğunuz şifreler aynı değildir.";
            }
        }

        private void txtSifre2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtSifre2.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtSifre2.PasswordChar = '*';
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
