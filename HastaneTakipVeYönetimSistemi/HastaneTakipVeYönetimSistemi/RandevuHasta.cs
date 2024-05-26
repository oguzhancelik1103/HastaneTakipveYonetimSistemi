using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneTakipVeYönetimSistemi
{
    public partial class RandevuHasta : MaterialSkin.Controls.MaterialForm
    {
        public string hastaemail;
        private HastaBilgiler hastabilgiler;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public RandevuHasta(string email)
        {
            InitializeComponent();
            FillDoctorComboBox();
            hastabilgiler = new HastaBilgiler();
            hastaemail = email;
        }

        private void RandevuHasta_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = "SELECT * FROM Randevular";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void FillDoctorComboBox()
        {
            try
            {
                conn.Open();
                string query = "SELECT Ad, Soyad, Uzmanlik FROM Doktorlar";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string doktorAdi = reader["Ad"].ToString();
                    string doktorSoyadi = reader["Soyad"].ToString();
                    string uzmanlikAlani = reader["Uzmanlik"].ToString();
                    string doktorBilgisi = doktorAdi + " " + doktorSoyadi + " - " + uzmanlikAlani;
                    comboBoxDoktorlar.Items.Add(doktorBilgisi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor bilgileri getirme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaBilgiler hasta = new HastaBilgiler();
            hasta.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int GetHastaID(string hastaEmail)
        {
            int hastaID = -1;

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "SELECT HastaID FROM Hastalar WHERE email = @HastaEmail";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@HastaEmail", hastaEmail);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    hastaID = Convert.ToInt32(result);
                }
            }

            return hastaID;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();

                string selectedDoktor = comboBoxDoktorlar.SelectedItem.ToString();
                string[] doktorBilgisi = selectedDoktor.Split('-');
                string[] adSoyad = doktorBilgisi[0].Trim().Split(' ');
                string doktorAdi = adSoyad[0].Trim();
                string doktorSoyadi = adSoyad[1].Trim();

                SqlCommand doktorCommand = new SqlCommand("SELECT DoktorID FROM Doktorlar WHERE Ad = '"+doktorAdi+ "'", conn);
                int doktorID = (int)doktorCommand.ExecuteScalar();

                int hastaID = GetHastaID(hastaemail);

                string randevuTarih = dateTimeRandevu.Text;
                string randevuSaat = comboBoxSaat.Text;
                string aciklama = txtsikayet.Text;

                string insertQuery = "INSERT INTO Randevular (DoktorID, HastaID, Tarih, Saat, Aciklama) VALUES (@DoktorID, @HastaID, @RandevuTarihi, @RandevuSaati, @Aciklama)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                insertCommand.Parameters.AddWithValue("@DoktorID", doktorID);
                insertCommand.Parameters.AddWithValue("@HastaID", hastaID);
                insertCommand.Parameters.AddWithValue("@RandevuTarihi", randevuTarih);
                insertCommand.Parameters.AddWithValue("@RandevuSaati", randevuSaat);
                insertCommand.Parameters.AddWithValue("@Aciklama", aciklama);

                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Randevu başarıyla oluşturuldu!");
                }
                else
                {
                    MessageBox.Show("Randevu oluşturulurken bir hata oluştu.");
                }
            }
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row != null)
                {
                    int randevutarih = Convert.ToInt32(row.Cells["Tarih"].Value);

                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Randevular WHERE Tarih = @tarih";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@tarih", randevutarih);

                        command.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Randevu başarıyla silindi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu silinirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
