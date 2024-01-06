using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=dersprogrami;Uid=root;Pwd=123456");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
       
        

        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM derslikler", conn);
           // MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT ogretmen_unvan, ogretmen_ad, ogretmen_soyad FROM ogretmen", conn);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * from gunler", conn);
            MySqlDataAdapter adapter3 = new MySqlDataAdapter("SELECT * from saat", conn);
            MySqlDataAdapter adapter4 = new MySqlDataAdapter("SELECT * from dersler", conn);

            conn.Open();
            adapter.Fill(dt);
          //  adapter1.Fill(dt);
            adapter2.Fill(dt);
            adapter3.Fill(dt);
            adapter4.Fill(dt);
            conn.Close();


           

            foreach (DataRow row in dt.Rows)
            {
                string derslik_no = row["derslik_no"].ToString();
                if (!string.IsNullOrEmpty(derslik_no))
                {
                    comboBox1.Items.Add(derslik_no);
                }
            }

          /*  foreach (DataRow row in dt.Rows)
            {
                string ogretmen_unvan = row["ogretmen_unvan"].ToString();
                string ogretmen_ad = row["ogretmen_ad"].ToString();
                string ogretmen_soyad = row["ogretmen_soyad"].ToString();
                if (!string.IsNullOrEmpty(ogretmen_unvan) && !string.IsNullOrEmpty(ogretmen_ad) && !string.IsNullOrEmpty(ogretmen_soyad))
                {
                    comboBox2.Items.Add(ogretmen_unvan + " " + ogretmen_ad + " " + ogretmen_soyad);
                }
            }*/

            foreach (DataRow row in dt.Rows)
            {
                string gun_ad = row["gun_ad"].ToString();
                if (!string.IsNullOrEmpty(gun_ad))
                {
                    comboBox3.Items.Add(gun_ad);
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                string saat= row["saat"].ToString();
                if (!string.IsNullOrEmpty(saat))
                {
                    comboBox4.Items.Add(saat);
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                string ders_ad = row["ders_ad"].ToString();
                if (!string.IsNullOrEmpty(ders_ad))
                {
                    comboBox2.Items.Add(ders_ad);
                }
            }


        }
    }
}
