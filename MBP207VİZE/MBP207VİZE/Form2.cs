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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");

        private void kAdiTxtB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kAdiTxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kAdiKayit.BackColor = System.Drawing.Color.Transparent;
            sifreKayit.BackColor = System.Drawing.Color.Transparent;
            epostaKayit.BackColor = System.Drawing.Color.Transparent;
        }

        private void kayitOlBtn_Click(object sender, EventArgs e)
        {
            if (kAdiTxtB.Text == "" || sifreKayitTxt.Text == "" || epostaKytTxt.Text == "")
            {
                MessageBox.Show("Kayıt olurken boş alan bırakmamalısınız.");
            }
            else
            {
                String kullaniciAdi;
                string sifre;
                string eposta;

                //Değişkenleri alma
                kullaniciAdi = kAdiTxtB.Text;
                sifre = sifreKayitTxt.Text;
                eposta = epostaKytTxt.Text;


                //Veritabanının başladığı yer.
                baglanti.Open();
                SqlCommand kadiSorgu = new SqlCommand("SELECT * FROM kullanici WHERE kAdi='" + kullaniciAdi + "'", baglanti);
                SqlDataReader kontrol = kadiSorgu.ExecuteReader();
                if (kontrol.Read())
                {
                    MessageBox.Show("Almak istediğiniz kullanıcı adı alınmış. Lütfen başka bir kullanıcı adı giriniz.");
                }
                else
                {
                    //Kayıdın yapıldığı veritabanı
                    kontrol.Close();
                    SqlCommand kayitAlma = new SqlCommand("INSERT INTO kullanici(kAdi, sifre, eposta) VALUES('" + kullaniciAdi + "', '" + sifre + "', '" + eposta + "')", baglanti);
                    kayitAlma.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı! Pokemon anasayfasına yönlendiriliyorsunuz.");
                    Form3 form3 = new Form3();
                    form3.slmLbl.Text = kAdiTxtB.Text;
                    form3.Show();
                    this.Hide();
                }
                baglanti.Close();
            }
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
