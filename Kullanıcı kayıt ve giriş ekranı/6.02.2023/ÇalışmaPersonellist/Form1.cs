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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.PasswordChar = '*';
        }
        private Dictionary<string, string> OgrenciKullanıcıIdSifre=new Dictionary<string,string> ();   
         

        private void kayıtOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kayıt_Ekranı kayıt=new Kayıt_Ekranı();
           


            
            kayıt.ShowDialog();

            OgrenciKullanıcıIdSifre.Add(kayıt.KullanıcıID, kayıt.KullanıcıSifre);
            foreach (var item in OgrenciKullanıcıIdSifre)
            {
                MessageBox.Show(item.Key + item.Value);
            }

        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            foreach (var item in OgrenciKullanıcıIdSifre)
            {
                
                if (item.Key==txtMail.Text && item.Value==txtSifre.Text)
                {
                    MessageBox.Show("Giris Başarılı");
                    Form2 kullanıcıEkranı=new Form2();
                    kullanıcıEkranı.Show();

                    Hide();

                }
                else if (item.Key == txtMail.Text && item.Value !=txtSifre.Text)
                {
                    MessageBox.Show("Hatalı Şifre");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Kaydı Bulunamadı");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar= '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
