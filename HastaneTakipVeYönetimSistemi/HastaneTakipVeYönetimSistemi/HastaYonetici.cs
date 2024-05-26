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
    public partial class HastaYonetici : MaterialSkin.Controls.MaterialForm
    {
        public HastaYonetici()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void HastaYonetici_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HastaEkle();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                string query = "SELECT * FROM Hastalar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void HastaEkle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "INSERT INTO Hastalar(Ad,Soyad,DogumTarihi,Cinsiyet,Telefon,Adres,email,sifre) VALUES(@ad,@soyad,@dogumtarihi,@cinsiyet,@telefon,@adres,@email,@sifre)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@ad", txtad.Text);
                    command.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                    command.Parameters.AddWithValue("@cinsiyet", txtcinsiyet.Text);
                    command.Parameters.AddWithValue("@telefon", txttel.Text);
                    command.Parameters.AddWithValue("@DogumTarihi", txtbirth.Text);
                    command.Parameters.AddWithValue("@Adres", txtadres.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@sifre", txtsifre.Text); 
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
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();  
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HastaYonetici hastaYonetici = new HastaYonetici();
            hastaYonetici.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string query = "UPDATE Hastalar SET Ad = @ad, Soyad = @soyad, DogumTarihi = @dogumtarihi, Cinsiyet = @cinsiyet, Telefon = @telefon, Adres = @adres, sifre = @sifre WHERE email = @email";
                SqlCommand command = new SqlCommand(query, conn);

                //command.Parameters.AddWithValue("@hastaid", HastaID);
                command.Parameters.AddWithValue("@ad", txtad.Text);
                command.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                command.Parameters.AddWithValue("@dogumtarihi", txtbirth.Text);
                command.Parameters.AddWithValue("@cinsiyet", txtcinsiyet.Text);
                command.Parameters.AddWithValue("@telefon", txttel.Text);
                command.Parameters.AddWithValue("@adres", txtadres.Text);
                command.Parameters.AddWithValue("@email", txtemail.Text);
                command.Parameters.AddWithValue("@sifre", txtsifre.Text);

                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                if (row != null)
                {
                    int hastaid = Convert.ToInt32(row.Cells["HastaID"].Value);

                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                    {
                        conn.Open();
                        string query = "DELETE FROM Hastalar WHERE HastaID = @hastaid";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@hastaid", hastaid);

                        command.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("Hasta başarıyla silindi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta silinirken bir hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtad.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
                txtsoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
                txtbirth.Text = dataGridView1.CurrentRow.Cells["DogumTarihi"].Value.ToString();
                txtcinsiyet.Text = dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
                txttel.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
                txtadres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
                txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                txtsifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorYonetici doktorYonetici = new DoktorYonetici();
            doktorYonetici.Show();
            this.Hide();
        }
    }
}
