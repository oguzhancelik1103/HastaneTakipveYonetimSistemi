using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneTakipVeYönetimSistemi
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaLogin hastaLogin = new HastaLogin();
            hastaLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorLogin doktorLogin = new DoktorLogin();
            doktorLogin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YoneticiLogin yoneticiLogin = new YoneticiLogin();
            yoneticiLogin.Show();
            this.Hide();
        }
    }
}
