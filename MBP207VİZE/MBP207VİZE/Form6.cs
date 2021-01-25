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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");
        private void sifYenileBtn_Click(object sender, EventArgs e)
        {
            string yenisifre1;
            string yenisifre2;
            string eposta;


            yenisifre1 = yeniSif1.Text;
            yenisifre2 = yeniSif2.Text;
            eposta = otoText.Text;

            //Veritabanı
            baglanti.Open();
            SqlCommand epostaSorgu = new SqlCommand("SELECT * FROM kullanici WHERE eposta='" + eposta + "'", baglanti);
            SqlDataReader epostaSorguKontrol = epostaSorgu.ExecuteReader();
            if (epostaSorguKontrol.Read())
            {
                if (yenisifre1 == yenisifre2)
                {
                    epostaSorguKontrol.Close();
                    SqlCommand sifreDegistir = new SqlCommand("UPDATE kullanici SET sifre='" + yenisifre1 + "' WHERE eposta='" + eposta + "'", baglanti);
                    sifreDegistir.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz yenilendi. Giriş yapmak için anasayfaya yönlendiriliyorsunuz.");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("İki şifre birbiriyle uyuşmamaktadır. Lütfen tekrar giriniz.");

                }
            }
            baglanti.Close();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            epostaLBL.BackColor = System.Drawing.Color.Transparent;
            yeniSifLBL.BackColor = System.Drawing.Color.Transparent;
            yeniSif2LBL.BackColor = System.Drawing.Color.Transparent;
        }
    }
    }

