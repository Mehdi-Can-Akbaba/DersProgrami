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
        DataTable dt2;

        void dersler()
        {
            dt2 = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT ders_id, ders_ad, ders_sinif, ders_derslik, gun_ad\r\nFROM dersler;", conn);
            dataGridView1.DataSource = dt2;
            adapter.Fill(dt2);
            conn.Close();
        }

        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {



            dersler();




            comboBox5.Items.Add(1);
            comboBox5.Items.Add(2);
            comboBox5.Items.Add(3);
            comboBox5.Items.Add(4);

            comboBox4.Items.Add(1);
            comboBox4.Items.Add(2);
            comboBox4.Items.Add(3);
            comboBox4.Items.Add(4);
            comboBox4.Items.Add(5);
            comboBox4.Items.Add(6);
            comboBox4.Items.Add(7);


            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM derslikler", conn);
            // MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT ogretmen_unvan, ogretmen_ad, ogretmen_soyad FROM ogretmen", conn);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * from gunler", conn);
            MySqlDataAdapter adapter3 = new MySqlDataAdapter("SELECT * from saat", conn);
            MySqlDataAdapter adapter4 = new MySqlDataAdapter("SELECT * from dersler", conn);

            conn.Open();
            adapter.Fill(dt);
            //  adapter1.Fill(dt);
            adapter2.Fill(dt1);
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

            foreach (DataRow row in dt1.Rows)
            {
                string gun_ad = row["gun_ad"].ToString();
                if (!string.IsNullOrEmpty(gun_ad))
                {
                    comboBox3.Items.Add(gun_ad);
                }
            }
            /* foreach (DataRow row in dt.Rows)
             {
                 string saat= row["saat"].ToString();
                 if (!string.IsNullOrEmpty(saat))
                 {
                     comboBox4.Items.Add(saat);
                 }
             }*/
            foreach (DataRow row in dt.Rows)
            {
                string ders_ad = row["ders_ad"].ToString();
                if (!string.IsNullOrEmpty(ders_ad))
                {
                    comboBox2.Items.Add(ders_ad);
                }
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO dersler (ders_ad , ders_derslik , gun_ad, ders_sinif,saat_id ) " + "VALUES (@ders , @derslik , @gun , @sinif , @saat)";
            cmd = new MySqlCommand(sql, conn);
            string selectedDers = comboBox2.SelectedItem?.ToString();
            string selectedDerslik = comboBox1.SelectedItem?.ToString();
            string selectedGun = comboBox3.SelectedItem?.ToString();
            string selectedSinif = comboBox5.SelectedItem?.ToString();
            string selectedSaat = comboBox4.SelectedItem?.ToString();
            cmd.Parameters.AddWithValue("ders", selectedDers);
            cmd.Parameters.AddWithValue("derslik", selectedDerslik);
            cmd.Parameters.AddWithValue("gun", selectedGun);
            cmd.Parameters.AddWithValue("sinif", selectedSinif);
            cmd.Parameters.AddWithValue("saat", selectedSaat);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            dersler();
        }

        /*  private void button2_Click(object sender, EventArgs e)
          {
               string sql = ("DELETE FROM dersler WHERE ders_id = @ders_id");
              cmd = new MySqlCommand(sql, conn);
              cmd.Parameters.AddWithValue("ders_id", textBox1.Text);
              conn.Open();
              cmd.Connection = conn;
              cmd.CommandText = "DELETE FROM dersler WHERE ders_id = @ders_id";
              cmd.Parameters.AddWithValue("@ders_id", comboBox2.SelectedItem);
              cmd.ExecuteNonQuery();
              conn.Close();

          }*/

        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
             {
                 conn.Open();
                 cmd = new MySqlCommand("DELETE FROM dersler WHERE ders_id=@ders_id", conn);
                 cmd.Parameters.AddWithValue("@ders_id", dataGridView1.Rows[e.RowIndex].Cells["ders_id"].Value);
                 cmd.ExecuteNonQuery();
                 conn.Close();
                 dersler(); // Verileri yeniden yüklemek için dersler() fonksiyonunu çağırırız
             }
         }
        */

        

        private void button2_Click_1(object sender, EventArgs e)
        {

            // Seçili satırın ders_id'sini al
            string ders_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            // Veritabanı bağlantısını aç
            conn.Open();

            // Silme sorgusunu oluştur
            string query = "DELETE FROM dersler WHERE ders_id = @id";

            // Komutu oluştur
            MySqlCommand cmd = new MySqlCommand(query, conn);

            // Parametreleri ayarla
            cmd.Parameters.AddWithValue("@id", ders_id);

            // Sorguyu çalıştır
            cmd.ExecuteNonQuery();

            // Veritabanı bağlantısını kapat
            conn.Close();

            // DataGridView'i güncelle
            dersler();

        }

        private void button3_Click(object sender, EventArgs e)
        /*{

            string ders_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = ("UPDATE dersler SET ders_ad=@ders_ad, ders_sinif=@ders_sinif, ders_derslik=@ders_derslik, gun_ad=@gun_ad " + "WHERE ders_id= @ders_id");
            // Komutu oluştur
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            

            string selectedDers = comboBox2.SelectedItem?.ToString();
            string selectedDerslik = comboBox1.SelectedItem?.ToString();
            string selectedGun = comboBox3.SelectedItem?.ToString();
            string selectedSinif = comboBox5.SelectedItem?.ToString();
           
            cmd.Parameters.AddWithValue("ders_ad", selectedDers);
            cmd.Parameters.AddWithValue("ders_derslik", selectedDerslik);
            cmd.Parameters.AddWithValue("gun_ad" , selectedGun);
            cmd.Parameters.AddWithValue("ders_sinif", selectedSinif);
            cmd.Parameters.AddWithValue("ders_id", ders_id);


            conn.Open();

            // Sorguyu çalıştır
            cmd.ExecuteNonQuery();

            // Veritabanı bağlantısını kapat
            conn.Close();

            // DataGridView'i güncelle
            dersler();


        }*/
        {
            // Seçili satırın ders_id'sini al
            string ders_id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            // Güncelleme sorgusunu oluştur
            string sql = "UPDATE dersler SET ders_ad = @ders_ad, ders_sinif = @ders_sinif, ders_derslik = @ders_derslik, gun_ad = @gun_ad WHERE ders_id = @ders_id";

            // Komutu oluştur
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // comboBox2'den seçili değeri al
            string selectedDers = comboBox2.SelectedItem?.ToString();

            // comboBox1'den seçili değeri al
            string selectedDerslik = comboBox1.SelectedItem?.ToString();

            // comboBox3'den seçili değeri al
            string selectedGun = comboBox3.SelectedItem?.ToString();

            // comboBox5'den seçili değeri al
            string selectedSinif = comboBox5.SelectedItem?.ToString();

            // Eğer comboBox2'den seçili bir değer varsa parametreye ekle
            if (!string.IsNullOrEmpty(selectedDers))
            {
                cmd.Parameters.AddWithValue("@ders_ad", selectedDers);
            }
            else
            {
                // Kullanıcı bir değer seçmemişse, uygun bir değer verilebilir veya hata mesajı gösterilebilir.
                cmd.Parameters.AddWithValue("@ders_ad", DBNull.Value);
            }

            // Eğer comboBox1'den seçili bir değer varsa parametreye ekle
            if (!string.IsNullOrEmpty(selectedDerslik))
            {
                cmd.Parameters.AddWithValue("@ders_derslik", selectedDerslik);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ders_derslik", DBNull.Value);
            }

            // Eğer comboBox3'den seçili bir değer varsa parametreye ekle
            if (!string.IsNullOrEmpty(selectedGun))
            {
                cmd.Parameters.AddWithValue("@gun_ad", selectedGun);
            }
            else
            {
                cmd.Parameters.AddWithValue("@gun_ad", DBNull.Value);
            }

            // Eğer comboBox5'den seçili bir değer varsa parametreye ekle
            if (!string.IsNullOrEmpty(selectedSinif))
            {
                cmd.Parameters.AddWithValue("@ders_sinif", selectedSinif);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ders_sinif", DBNull.Value);
            }

            // ders_id parametresini ekle
            cmd.Parameters.AddWithValue("@ders_id", ders_id);

            try
            {
                // Veritabanı bağlantısını aç
                conn.Open();

                // Sorguyu çalıştır
                cmd.ExecuteNonQuery();

                // DataGridView'i güncelle
                dersler();
            }
            catch (Exception ex)
            {
                // Hata yönetimi burada yapılabilir
                Console.WriteLine("Hata Mesajı: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını kapat
                conn.Close();
                dersler();
            }
        }

    }
}
