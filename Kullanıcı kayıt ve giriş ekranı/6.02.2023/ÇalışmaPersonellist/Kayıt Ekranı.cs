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
    public partial class Kayıt_Ekranı : Form
    {
        public Kayıt_Ekranı()
        {
            InitializeComponent();
        }
        public string KullanıcıID;
        public string KullanıcıSifre;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSifreKayıt1.Text==txtSifreKayit2.Text)
            {
                MessageBox.Show("Kayıt işlemi başarılıdır.");
                KullanıcıID = txtMailKayıt.Text;
                KullanıcıSifre= txtSifreKayıt1.Text;
            }
            else if (txtSifreKayıt1.Text != txtSifreKayit2.Text ) 
            {
                MessageBox.Show("Girmiş olduğunuz sifreler birbiriyle uyuşmamaktadır.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
