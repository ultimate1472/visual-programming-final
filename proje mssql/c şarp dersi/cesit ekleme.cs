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
    public partial class cesit_ekleme : Form
    {
        public cesit_ekleme()
        {
            InitializeComponent();
        }
        kılas.ürün ürün = new kılas.ürün();
        private void btnekle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into cesitid values('" + textekle.Text + "')";
            SqlCommand komut2 = new SqlCommand();
            ürün.ESG(komut2, sorgu2);
        }
    }
}
