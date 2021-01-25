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

namespace MBP207VİZE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            girisLB.BackColor = System.Drawing.Color.Transparent;
            sifreLB.BackColor = System.Drawing.Color.Transparent;
        }

        private void girisLB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void girisyapBtn_Click(object sender, EventArgs e)
        {
            if (girisTB.Text == "" || sifreTB.Text == "")
            {
                MessageBox.Show("Giriş yaparken iki alandan birisi boş bırakılamaz.");
            }
            else
            {
                //Giriş için bağlantı açıldı
                baglanti.Open();
                string kullaniciadi;
                string sifre;
                //Değişkenleri alıyoruz
                kullaniciadi = girisTB.Text;
                sifre = sifreTB.Text;
                //Sorgulatıyoruz
                SqlCommand girisSorgu = new SqlCommand("SELECT * FROM kullanici WHERE kAdi='" + kullaniciadi + "' AND sifre='" + sifre + "'", baglanti);
                SqlDataReader girisKontrol = girisSorgu.ExecuteReader();
                if (girisKontrol.Read())
                {
                    MessageBox.Show("Hoşgeldiniz " + kullaniciadi + ", Anasayfaya yönlendiriliyorsunuz.");
                    Form3 form3 = new Form3();
                    form3.slmLbl.Text = girisTB.Text;
                    form3.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış. Giriş bilgilerinizi hatırlamıyorsanız Şifremi Unuttum butonuna tıklayabilirsiniz.");
                }
                baglanti.Close();
            }
        }

        private void sifreUnuttumBtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void girisTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
