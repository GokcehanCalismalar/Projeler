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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string,string> ıdVeSifre = new Dictionary<string,string>();
        public string  kullanıcı;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text= "Hoşgeldin.\n Çeşitli oyunlar ile zamanın akıp gitmesini istiyorsanız doğru adrestesiniz.\n Başlamak için neyi bekliyorsun. \n hadi hadi hadi... Giriş yap ve Eğlen.";
            txtSifre.PasswordChar = '*';
            label5.Text = "";
            txtId.Text= "1";
            txtSifre.Text = "2";
            ıdVeSifre.Add("gokcehan", "123");
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2Kayıt= new Form2();

            frm2Kayıt.Show();
            Hide();
        


        }


        private void button1_Click(object sender, EventArgs e)
        {
            ıdVeSifre.Add(Form2.ID, Form2.Sifre);
            if (txtId.Text == "" || txtSifre.Text == "")
            {
                label5.Text = "Lütfen Bilgileriniz Giriniz";
            }
            else
            {
                foreach (var item in ıdVeSifre)
                {
                    if (item.Key == txtId.Text && item.Value == txtSifre.Text)
                    {
                        Form3OyunEkranı oyunEkranı = new Form3OyunEkranı();
                        oyunEkranı.Show();
                        kullanıcı = item.Key;

                        Close();
                    }
                    else if (item.Key == txtId.Text)
                    {
                        label5.Text = "Hatalı şifre";
                    }
                    else
                    {
                        label5.Text = "Kayıtlı kullanıcı bulunamadı";
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
