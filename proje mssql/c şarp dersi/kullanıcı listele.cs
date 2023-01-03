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
    public partial class kullanıcı_listele : Form
    {
        public kullanıcı_listele()
        {
            InitializeComponent();
        }

        private void kullanıcı_listele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tümtablolardataset.kullanıcı' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcıTableAdapter.Fill(this.tümtablolardataset.kullanıcı);

        }
    }
}
