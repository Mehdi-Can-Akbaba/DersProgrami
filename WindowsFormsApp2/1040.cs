using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class _1040 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=dersprogrami;Uid=root;Pwd=123456");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        void ogretmen()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT \r\n    CONCAT(ogretmen_unvan, ' ', ogretmen_ad, ' ', ogretmen_soyad) AS ogretmen, \r\n    dersler.ders_ad,\r\n    gunler.gun_ad AS gun,\r\n    saat.saat\r\nFROM \r\n    derslikler\r\nJOIN \r\n    dersderslik ON derslikler.derslik_id = dersderslik.derslik_id\r\nJOIN \r\n    dersogretmen ON dersderslik.ders_id = dersogretmen.ders_id\r\nJOIN \r\n    ogretmen ON dersogretmen.ogretmen_id = ogretmen.ogretmen_id\r\nJOIN\r\n    dersler ON dersogretmen.ders_id = dersler.ders_id\r\nJOIN\r\n    gunler ON dersler.gun_ad = gunler.gun_ad\r\nJOIN\r\n    saat ON dersler.saat_id = saat.saat_id\r\nWHERE \r\n    derslikler.derslik_id = 2\r\nORDER BY \r\n    gunler.gun_id;\r\n", conn);
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            conn.Close();

        }

        /* void gunler()
         {
             dt = new DataTable();
             conn.Open();
             adapter = new MySqlDataAdapter("SELECT*FROM gunler", conn);
             dataGridView1.DataSource = dt;
             adapter.Fill(dt);
             conn.Close();

         }*/

        public _1040()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        

        private void _1036_Load(object sender, EventArgs e)
        {
            ogretmen();
            //  gunler();
        }
    }
}
