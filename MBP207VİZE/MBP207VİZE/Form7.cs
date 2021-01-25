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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            kAdiText.ReadOnly = true;
            sifreText.ReadOnly = true;
            epostaText.ReadOnly = true;
        }

        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");

        private void kadiLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            kadiLabel.BackColor = System.Drawing.Color.Transparent;
            sifreLabel.BackColor = System.Drawing.Color.Transparent;
            epostaLabel.BackColor = System.Drawing.Color.Transparent;
            hosgeldinizLbl.BackColor = System.Drawing.Color.Transparent;
            isimLbl1.BackColor = System.Drawing.Color.Transparent;
            yeniSiflbl1.BackColor = System.Drawing.Color.Transparent;
            yeniSifLbl2.BackColor = System.Drawing.Color.Transparent;
            yeniEpostaLbl.BackColor = System.Drawing.Color.Transparent;
            yeniEpostaLbl2.BackColor = System.Drawing.Color.Transparent;

            yeniSiflbl1.Visible = false;
            yeniSifLbl2.Visible = false;
            yeniSif.Visible = false;
            yeniSif2.Visible = false;
            onaylaBtn.Visible = false;
            yeniEposta.Visible = false;
            yeniEposta2.Visible = false;
            yeniEpostaLbl.Visible = false;
            yeniEpostaLbl2.Visible = false;
            onaylaBtn2.Visible = false;


            String cagiran = isimLbl1.Text;

            SqlCommand cagirici = new SqlCommand("SELECT * FROM kullanici WHERE kAdi='"  + cagiran + "'", baglanti);
            baglanti.Open();

            SqlDataReader okuyucu = cagirici.ExecuteReader();

            while(okuyucu.Read())
            {
                kAdiText.Text = (okuyucu["kAdi"].ToString());
                sifreText.Text = (okuyucu["sifre"].ToString());
                epostaText.Text = (okuyucu["eposta"].ToString());
            }
            okuyucu.Close();
            baglanti.Close();
            
            
        }

        private void sifreDegistirBtn_Click(object sender, EventArgs e)
        {
            yeniSiflbl1.Visible = true;
            yeniSifLbl2.Visible = true;
            yeniSif.Visible = true;
            yeniSif2.Visible = true;
            onaylaBtn.Visible = true;

           
        }

        private void epostaDegistir_Click(object sender, EventArgs e)
        {
            yeniEposta.Visible = true;
            yeniEposta2.Visible = true;
            yeniEpostaLbl.Visible = true;
            yeniEpostaLbl2.Visible = true;
            onaylaBtn2.Visible = true;
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            String yenisifre;
            String yenisifre2;
            String sifreCekme = kAdiText.Text;
            yenisifre = yeniSif.Text;
            yenisifre2 = yeniSif2.Text;

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM kullanici WHERE kAdi='" + sifreCekme + "'", baglanti);
            SqlDataReader sorgulama = sorgu.ExecuteReader();
            if (sorgulama.Read())
            {
                if (yenisifre == yenisifre2)
                {
                    sorgulama.Close();
                    SqlCommand sifreDegistir = new SqlCommand("UPDATE kullanici SET sifre='" + yenisifre + "' WHERE kAdi='" + sifreCekme + "'", baglanti);
                    sifreDegistir.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz yenilendi. Bundan sonra yeni şifrenizle giriş yapabilirsiniz.");
                    
                }
                else
                {
                    MessageBox.Show("İki şifreyle birbiriyle uyuşmamaktadır. Lütfen şifrelerinizi aynı giriniz.");
                }
            }
            baglanti.Close();
            
        }

        private void onaylaBtn2_Click(object sender, EventArgs e)
        {
            String yenieposta;
            String yenieposta2;
            String epostaCekme = kAdiText.Text;
            yenieposta = yeniEposta.Text;
            yenieposta2 = yeniEposta2.Text;

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM kullanici WHERE kAdi='" + epostaCekme + "'", baglanti);
            SqlDataReader sorgulama = sorgu.ExecuteReader();
            if(sorgulama.Read())
            {
                if(yenieposta == yenieposta2)
                {
                    sorgulama.Close();
                    SqlCommand epostaDegistir = new SqlCommand("UPDATE kullanici SET eposta='" + yenieposta + "' WHERE kAdi='" + epostaCekme + "'", baglanti);
                    epostaDegistir.ExecuteNonQuery();
                    MessageBox.Show("Eposta adresiniz değişmiştir.");
                }
                else
                {
                    MessageBox.Show("Girdiğiniz iki eposta birbiriyle uyuşmamaktadır. Lütfen doğru giriniz.");
                }
            }
            baglanti.Close();
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
