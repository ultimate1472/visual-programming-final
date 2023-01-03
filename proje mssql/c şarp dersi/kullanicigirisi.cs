using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_şarp_dersi
{
    public partial class kullanicigirisi : Form
    {
        public kullanicigirisi()
        {
            InitializeComponent();
        }

        private void kullanicigirisi_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            kullanicigirisi kullanıcı= new kullanicigirisi();
            kullanıcı.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Unchecked)
            {
                txtsifre.UseSystemPasswordChar = true;
                checkBox1.Text = "gizle";
            }

            else if (checkBox1.CheckState == CheckState.Checked)
                    {
                txtsifre.UseSystemPasswordChar = false;
                checkBox1.Text = "göster";

            }
        }
        kılas.kullanici k=new kılas.kullanici();
        private void butongiris_Click(object sender, EventArgs e)
        {
            k.kullanicigiris(txtsifre,txtkullaniciadi);
        }

        private void butoncıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonkayit_Click(object sender, EventArgs e)
        {
            kullanıcıekle kullanıcıekle=new kullanıcıekle();
            kullanıcıekle.Show();

        }
    }
}
