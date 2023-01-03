using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_şarp_dersi
{
    public partial class ürünekle : Form
    {
        public ürünekle()
        {
            InitializeComponent();
        }
        kılas.ürün ürün= new kılas.ürün();
        private void buttonekle_Click(object sender, EventArgs e)
        {
            string sorgu2="insert into ürünler values('"+combocesit.Text+ "','" + combotür.Text + "','" + textfiyat.Text + "','" + int.Parse(textvergi.Text) + "'" +
                "" +
                "" +
                ")";
            SqlCommand komut2 = new SqlCommand();
            ürün.ESG(komut2,sorgu2);// combocesit, combotür, textfiyat, textvergi

        }

        private void ürünekle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ödevDataSet.cesit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cesitTableAdapter.Fill(this.ödevDataSet.cesit);
            // TODO: Bu kod satırı 'ödevDataSet.cesitid' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cesitidTableAdapter.Fill(this.ödevDataSet.cesitid);

        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
