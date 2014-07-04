using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2gsa
{
    public partial class Form1 : Form
    {
        public static string adminname = "Bos kullanici";
        public static string standname = "Bos stand";

        
        public Form1()
        {
            InitializeComponent();
            internetText.Text = "İnternet bağlantısı sağlandı.";
            internetText.ForeColor = Color.Green;
            timer1.Interval = 10 * 1000;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'esoguieeeDataSet3.katilimci' table. You can move, or remove it, as needed.
            try {
            this.katilimciTableAdapter.Fill(this.esoguieeeDataSet3.katilimci);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            adminNameLBL.Text = adminname;
            standnameLBL.Text = standname;
                }
            catch
            {
                MessageBox.Show("İnternet bağlantı hatası!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.CheckForInternetConnection()) { 
            try {
            this.katilimciTableAdapter.Fill(this.esoguieeeDataSet3.katilimci);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            button1.IsAccessible = false;
            SqlConnection connection = new SqlConnection("Server=YOURDBSERVER,1433;Database=esoguieee;User ID=YOURUSERID;Password=YOURPASSWORD;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
            connection.Open();
            string ekle = "INSERT INTO katilimci(adisoyadi, bolum, telefonno, eposta, uyemi, paraalindimi, adminname, stand, sira) VALUES('" +
            adiSoyadiTB.Text + "', '" + bolumCB.SelectedItem.ToString() + "', '" + telefonNoTB.Text + "', '" + epostaTB.Text + "', '" + null + "', '" + true
            + "','" + adminname + "', '" + standname + "', '"+ (esoguieeeDataSet3.katilimci.ToArray().Length + 1) +"' )";
            SqlCommand command = new SqlCommand(ekle, connection);
            command.ExecuteNonQuery();
            connection.Close();
            button1.IsAccessible = true;
            MessageBox.Show("Kayıt eklendi!");
            adiSoyadiTB.Clear();
            bolumCB.SelectedValue = null;
            telefonNoTB.Clear();
            epostaTB.Clear();
            this.katilimciTableAdapter.Fill(this.esoguieeeDataSet3.katilimci);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            }
            catch
            {
                button1.IsAccessible = true;
                MessageBox.Show("İnternet bağlantısı hatası, lütfen tekrar deneyiniz.");
                
            }
            }
            else
            {
                MessageBox.Show("Halen internet bağlantısına sahip değilsiniz, bağlantıyı sağlayıp tekrar deneyiniz.");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (login.CheckForInternetConnection()) { 
            try {
            this.katilimciTableAdapter.Fill(this.esoguieeeDataSet3.katilimci);
            MessageBox.Show("Kayıtlar yenilendi!");
            
                }
            catch
            {
                MessageBox.Show("Halen internet bağlantısına sahip değilsiniz, bağlantıyı sağlayıp tekrar deneyiniz.");
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login a = new login();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login.CheckForInternetConnection()) { 
            uyelist a = new uyelist();
            a.Show();
            }
            else
            {
                MessageBox.Show("Halen internet bağlantısına sahip değilsiniz, bağlantıyı sağlayıp tekrar deneyiniz.");
            }
        }

        private void bolumCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (login.CheckForInternetConnection())
            {
                internetText.Text = "İnternet bağlantısı sağlandı.";
                internetText.ForeColor = Color.Green;
            }
            else
            {
                internetText.Text = "İnternet bağlantısı sağlanamıyor!";
                internetText.ForeColor = Color.Red;
                MessageBox.Show("İnternet bağlantısı sağlanamıyor!");               
            }
            }

        private void form_closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Güle güle :)");
            System.Windows.Forms.Application.Exit();
        }

        

    }
}
