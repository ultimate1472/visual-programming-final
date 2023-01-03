using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace c_şarp_dersi.kılas
{
    internal class veritabanı
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=ödev;Uid=root;Pwd='';");
       public static  string strbaglantı = "Data Source=DESKTOP-O6LTO41;Initial Catalog=ödev;Integrated Security=True;Pooling=False";
    }
}
