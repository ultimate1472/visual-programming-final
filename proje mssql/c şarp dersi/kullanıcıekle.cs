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
    public partial class kullanıcıekle : Form
    {
        public kullanıcıekle()
        {
            InitializeComponent();
        }

        private void kullanıcıekle_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        kılas.kullanici k=new kılas.kullanici();
        private void btnekle_Click(object sender, EventArgs e)
        {
            k.Yenikullanicii(txtisimsoyisim.Text, txttelno.Text, txtadres.Text, txtemail.Text, txtkullaniciadi.Text, txtsifre.Text, txtsifretekrar.Text, txtgörevi.Text, pictureBoxresim.ImageLocation);
        }

        private void btnresimsec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            if (file.ShowDialog()==DialogResult.OK)
            {
                pictureBoxresim.ImageLocation=file.FileName;
            }
        }
    }
}
