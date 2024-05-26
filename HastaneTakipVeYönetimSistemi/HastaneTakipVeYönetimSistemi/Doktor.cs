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

namespace HastaneTakipVeYönetimSistemi
{
    public partial class Doktor : MaterialSkin.Controls.MaterialForm
    {
        public string doktoremail { get; set; }

        public Doktor()
        {
            InitializeComponent();
        }

        private void Doktor_Load(object sender, EventArgs e)
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
                    string query = "SELECT * FROM Doktorlar WHERE email = '" + doktoremail + "'";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtad.Text = reader["Ad"].ToString();
                        txtsoyad.Text = reader["Soyad"].ToString();
                        txtalan.Text = reader["Uzmanlik"].ToString();
                        txthastane.Text = reader["DoktorHastane"].ToString();
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
                    string query = "UPDATE Doktorlar SET Ad = @Ad, Soyad = @Soyad, Uzmanlik = @Uzmanlik, DoktorHastane = @Hastane WHERE email = '" + doktoremail + "'";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Ad", txtad.Text);
                    command.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                    command.Parameters.AddWithValue("@Uzmanlik", txtalan.Text);
                    command.Parameters.AddWithValue("@Hastane", txthastane.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Show();
            this.Hide();
        }
    }
}
