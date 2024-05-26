using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HastaneTakipVeYönetimSistemi
{
    public partial class HastaBilgiler : MaterialSkin.Controls.MaterialForm
    {
        public string hastaemail { get; set; }

        public HastaBilgiler()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void HastaBilgiler_Load(object sender, EventArgs e)
        {
            FillUserData();
        }

        private void FillUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "SELECT * FROM Hastalar WHERE email = '"+hastaemail+"'";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtad.Text = reader["Ad"].ToString();
                        txtsoyad.Text = reader["Soyad"].ToString();
                        txtcinsiyet.Text = reader["Cinsiyet"].ToString();
                        txttel.Text = reader["Telefon"].ToString();
                        txtbirth.Text = reader["DogumTarihi"].ToString();
                        txtadres.Text = reader["Adres"].ToString();
                        // Şifreyi burada göstermemek daha güvenli olabilir
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgileri getirirken bir hata oluştu: " + ex.Message);
            }
        }

        private void UpdateUserData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "UPDATE Hastalar SET Ad = @Ad, Soyad = @Soyad, Cinsiyet = @Cinsiyet, " +
                                   "Telefon = @Telefon, DogumTarihi = @DogumTarihi, Adres = @Adres WHERE email = '"+hastaemail+"'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Ad", txtad.Text);
                    command.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                    command.Parameters.AddWithValue("@Cinsiyet", txtcinsiyet.Text);
                    command.Parameters.AddWithValue("@Telefon", txttel.Text);
                    command.Parameters.AddWithValue("@DogumTarihi", txtbirth.Text);
                    command.Parameters.AddWithValue("@Adres", txtadres.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Bilgileriniz başarıyla güncellendi!");
                    }
                    else
                    {
                        MessageBox.Show("Bilgileri güncelleme işlemi başarısız!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgileri güncellerken bir hata oluştu: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateUserData();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedHastaEmail = hastaemail;
            RandevuHasta randevu = new RandevuHasta(selectedHastaEmail);
            randevu.Show();
            this.Hide();
        }
    }
}