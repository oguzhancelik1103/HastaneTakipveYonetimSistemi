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
    public partial class YoneticiLogin : MaterialSkin.Controls.MaterialForm
    {
        public YoneticiLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void YoneticiLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email, sifre;
            email = txtemail.Text;
            sifre = txtpassword.Text;

            try
            {
                String query = "SELECT * FROM Yoneticiler WHERE email = '" + txtemail.Text + "' AND sifre = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email = txtemail.Text;
                    sifre = txtpassword.Text;

                    Yonetici yonetici = new Yonetici();
                    yonetici.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
