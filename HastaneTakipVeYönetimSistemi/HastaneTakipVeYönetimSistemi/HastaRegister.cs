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
    public partial class HastaRegister : MaterialSkin.Controls.MaterialForm
    {
        public HastaRegister()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void HastaRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email, sifre;
            String Ad, Soyad;
            String DogumTarihi, Cinsiyet;
            String Telefon, Adres;
            email = txtemail.Text;
            sifre = txtpassword.Text;
            Ad = txtad.Text;
            Soyad = txtsoyad.Text;
            DogumTarihi = txtbirth.Text;
            Cinsiyet = txtcinsiyet.Text;
            Telefon = txttel.Text;
            Adres = txtadres.Text;

            try
            {
                // Veritabanına kayıt ekleme sorgusu
                string query = "INSERT INTO Hastalar (Ad, Soyad, DogumTarihi, Telefon, Adres, email, sifre) VALUES (@Ad, @Soyad, @DogumTarihi, @Telefon, @Adres, @Email, @Sifre)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ad", Ad);
                cmd.Parameters.AddWithValue("@Soyad", Soyad);
                cmd.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                cmd.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                cmd.Parameters.AddWithValue("@Telefon", Telefon);
                cmd.Parameters.AddWithValue("@Adres", Adres);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Kayıt eklendikten sonra istediğiniz işlemi yapabilirsiniz, örneğin başka bir sayfaya yönlendirme
                    HastaLogin hastaLogin = new HastaLogin();
                    hastaLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
