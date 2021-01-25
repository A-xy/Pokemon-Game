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

namespace MBP207VİZE
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string onayKodu = "";
        Random rand = new Random();
        string harfler = "ABCDEFGHIJKLMNOPRSTUVYZWX123456789";


        SmtpClient smtp = new SmtpClient();
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");


        private void Form5_Load(object sender, EventArgs e)
        {
            resLbl1.BackColor = System.Drawing.Color.Transparent;
            resLbl2.BackColor = System.Drawing.Color.Transparent;
            resLbl3.BackColor = System.Drawing.Color.Transparent;

            resLbl3.Visible = false;
            gelenKod.Visible = false;
            dogrulaBtn.Visible = false;

            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("canberk-pokemon@outlook.com", "C4nb0b4b0l1!?");
        }

        private void resBtn_Click(object sender, EventArgs e)
        {
            if (resKAdi.Text == "" || resEposta.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve Eposta alanları boş bırakılamaz.");
            }
            else
            {


                string kadi;
                string eposta;
                //Değişkenler
                kadi = resKAdi.Text;
                eposta = resEposta.Text;

                //Veritabanı başlıyor
                baglanti.Open();
                SqlCommand pwloseSorgu = new SqlCommand("SELECT * FROM kullanici WHERE kAdi='" + kadi + "' OR eposta='" + eposta + "'", baglanti);
                SqlDataReader pwloseKontrol = pwloseSorgu.ExecuteReader();
                if (pwloseKontrol.Read())
                {
                    for (int i = 0; i < 6; i++)
                    {
                        onayKodu += harfler[rand.Next(harfler.Length)];

                    }
                    //Mesaj Yollama Kısımları Onay İçin
                    MailMessage mesaj = new MailMessage();
                    mesaj.From = new MailAddress("canberk-pokemon@outlook.com", "CANBO POKEMON");
                    mesaj.To.Add("" + eposta + "");
                    mesaj.Subject = "Şifre Yenilemek İçin Onay Kodu - CANBO POKEMON";
                    mesaj.Body = "Şifre yenilemek için onay kodunuz: " + onayKodu;

                    try
                    {
                        smtp.Send(mesaj);
                        MessageBox.Show("Onay kodunuz gönderildi. Lütfen epostanızı kontrol ediniz.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mail gönderilirken bir hatayla karşılaşıldı: " + ex.Message);
                    }
                    gelenKod.Visible = true;
                    dogrulaBtn.Visible = true;
                    resLbl3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya epostanız yanlış. Lütfen ikisini de doğru giriniz.");
                }
                baglanti.Close();
            }
        }

        private void dogrulaBtn_Click(object sender, EventArgs e)
        {
            string onayKodu1;

            onayKodu1 = gelenKod.Text;

            if (onayKodu1 == onayKodu)
            {
                MessageBox.Show("Onay kodunuz doğru. Şifrenizi yenileyebilirsiniz.");
                Form6 form6 = new Form6();
                form6.otoText.Text = resEposta.Text;
                form6.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış onay kodu girdiniz. Yenisini isteyiniz ya da doğrusunu giriniz.");
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

