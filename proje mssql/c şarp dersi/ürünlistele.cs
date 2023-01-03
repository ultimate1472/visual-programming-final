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
    public partial class ürünlistele : Form
    {
        public ürünlistele()
        {
            InitializeComponent();
        }
        ödevDataSetTableAdapters.ürünlerTableAdapter ds=new ödevDataSetTableAdapters.ürünlerTableAdapter();         
        private void ürünlistele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ödevDataSet.cesitid' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cesitidTableAdapter.Fill(this.ödevDataSet.cesitid);
            // TODO: Bu kod satırı 'ödevDataSet.cesit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cesitTableAdapter.Fill(this.ödevDataSet.cesit);
            dataGridView1.DataSource = ds.listele2();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblcesit.Text =dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lbltur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           textfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textvergi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void butunmrkgüncel_Click(object sender, EventArgs e)
        {
            lblcesit.Text=combocesit.Text;
            lbltur.Text = combotür.Text;
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        kılas.ürün ürn = new kılas.ürün();
        private void butonguncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update ürünler set çeşit='" + lblcesit.Text + "',marka='" + lbltur.Text + "',fiyat='" + double.Parse(textfiyat.Text) + "',VERGİ='" + double.Parse(textvergi.Text) + "'where Id='" + txtid.Text + "'";
            SqlCommand komut2=new SqlCommand();
            ürn.ESG(komut2, sorgu2);
            dataGridView1.DataSource = ds.listele2();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from ürünler where Id='" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            SqlCommand komut2 = new SqlCommand();
            ürn.ESG(komut2, sorgu2);
            dataGridView1.DataSource = ds.listele2();
        }
    }
}
