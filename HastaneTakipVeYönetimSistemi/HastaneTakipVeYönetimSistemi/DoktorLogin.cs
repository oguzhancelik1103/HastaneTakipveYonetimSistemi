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
    public partial class DoktorLogin : MaterialSkin.Controls.MaterialForm
    {
        public DoktorLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BEA7CFV\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void DoktorLogin_Load(object sender, EventArgs e)
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
                String query = "SELECT * FROM Doktorlar WHERE email = '" + txtemail.Text + "' AND sifre = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    email = txtemail.Text;
                    sifre = txtpassword.Text;

                    Doktor doktor = new Doktor();
                    doktor.doktoremail = txtemail.Text;
                    doktor.Show();
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
