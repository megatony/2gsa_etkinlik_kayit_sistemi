using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2gsa
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        public static bool CheckForInternetConnection()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (CheckForInternetConnection())
            {
                if (adminAdiSoyadiTB.Text == "")
                {
                    MessageBox.Show("Lütfen isim bilginizi boş bırakmayınız.");
                }
                else if (adminStandTB.Text == "")
                {
                    MessageBox.Show("Lütfen stand bilgisini boş bırakmayınız.");
                }
                else {
                    Form1.adminname = adminAdiSoyadiTB.Text;
                    Form1.standname = adminStandTB.Text;
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
                }
            }
            else
            {
                MessageBox.Show("İnternet bağlantısı hatası, lütfen tekrar deneyiniz.");
            }

            
        }

       

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }
}

