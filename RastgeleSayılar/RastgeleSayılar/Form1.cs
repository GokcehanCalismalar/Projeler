using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastgeleSayılar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Kullanıcı;
        private void btn1_Click(object sender, EventArgs e)
        {
            Kullanıcı=txtKullanıcıAdı.Text;
            Form2 frm2= new Form2();

            frm2.Show();

            Hide();
        }
    }
}
