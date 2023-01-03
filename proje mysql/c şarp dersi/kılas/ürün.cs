using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace c_şarp_dersi.kılas
{
    internal class ürün
                    {
                        MySqlConnection baglantı = new MySqlConnection(veritabanı.strbaglantı);
        public int ESG(MySqlCommand komut, string sorgu)//, ComboBox marka, ComboBox çesit,TextBox fiyat,TextBox VERGİ 
        {
            int sonuc = 0;

            komut.CommandText = sorgu;
            komut.Connection = baglantı;

            

            if (baglantı.State==System.Data.ConnectionState.Closed)
                baglantı.Open();

            try
            {
              sonuc=  komut.ExecuteNonQuery();
                MessageBox.Show("işlem başarılı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string hata=ex.Message;
               
            }
            finally
            {
                baglantı.Close();
            }
            return sonuc;
        }

        internal void ESG()
        {
       
        }
    }
}
