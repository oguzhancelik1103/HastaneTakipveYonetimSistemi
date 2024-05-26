using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneTakipVeYönetimSistemi
{
    public partial class HastaLogin : MaterialSkin.Controls.MaterialForm
    {
        public HastaLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void HastaLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaRegister hastaRegister = new HastaRegister();
            hastaRegister.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email, sifre;
            email = txtemail.Text;
            sifre = txtpassword.Text;

            try
            {
                String query = "SELECT * FROM Hastalar WHERE email = '"+txtemail.Text+"' AND sifre = '"+txtpassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email = txtemail.Text;
                    sifre = txtpassword.Text;

                    HastaBilgiler hastabilgiler = new HastaBilgiler();
                    hastabilgiler.hastaemail = txtemail.Text;
                    hastabilgiler.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Clear();
                    txtpassword.Clear();

                    txtemail.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally 
            { 
                
            }
        }
    }
}
