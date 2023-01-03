using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_şarp_dersi.kılas
{
    internal class kullanici
    {  SqlConnection baglantı=new SqlConnection(veritabanı.strbaglantı);
        private string isimsoyisim;
        private string telefon;
        string adres;
        string email;
        string kullaiciadi;
       string sifre;
        string görevi;
       string resim;
       

        public string Isimsoyisim { get => isimsoyisim; 
            set => isimsoyisim = value; }
        public string telno { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Email { get => email; set => email = value; }
        public string kullanıcıadi { get => kullaiciadi; set => kullaiciadi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string görev { get => görevi; set => görevi = value; }
        public string Resim { get => resim; set => resim = value; }
        public void kullanicigiris(TextBox txtsifre,TextBox txtkullaniciadi)
        {
            if(txtkullaniciadi.Text == "" || txtsifre.Text=="")
            {
                MessageBox.Show("kullanici adı yada şifre boş geçilemez", "boş geçmeyin",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglantı.Open();
                SqlCommand komut=new SqlCommand("select *from kullanıcı where kullanıcıadi='"+txtkullaniciadi.Text+"'and sifre='"+txtsifre.Text+"'",baglantı);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Anasayfa anasayfa = new Anasayfa();
                    kullanicigirisi.ActiveForm.Visible = false;
                    anasayfa.Show();
                  

                }
                    
                 
                else
                {
                    MessageBox.Show("kullanıcı adı yada sifre hatalı", "hatalı sifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }baglantı.Close();
            }
        }public void Yenikullanicii(string _AdiSoyadi, string _TelNo, string _adres, string _email, string _kullaniciadi, string _sifre, string _sifretekrar, string _görevi, string _resim)
        {
            isimsoyisim = _AdiSoyadi;
            telefon = _TelNo;
            adres = _adres;
            kullanıcıadi = _kullaniciadi;
            email = _email;
            sifre = _sifre;
            görevi = _görevi;
            resim = _resim;
            if (Sifre==_sifretekrar)
              {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into kullanıcı values('" + isimsoyisim + "','" + telno + "','" + adres + "','" + email + "','" + kullanıcıadi + "','" + sifre + "','" + görev + "','" + resim + "')", baglantı);
                _ = komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("yeni kullanıcı eklendi", "kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("sifreler uyuşmuyor", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
