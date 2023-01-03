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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ürünekle ürünekle=new ürünekle();
            FormGetir(ürünekle);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("siparişiniz yola çıkmıştır");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanıcıekle kullanıcıekle= new kullanıcıekle();
            FormGetir(kullanıcıekle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
         ürünlistele ürünlistele= new ürünlistele();
            FormGetir(ürünlistele);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanıcı_listele listele=new kullanıcı_listele();
            FormGetir(listele);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        public void FormGetir(Form frm)
        {
            panelsayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            panelsayfalar.Controls.Add(frm);
            frm.Show();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
