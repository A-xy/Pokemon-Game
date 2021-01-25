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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True; MultipleActiveResultSets=True;");
        SqlConnection baglanti2 = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True; MultipleActiveResultSets=True;");
        SqlConnection baglanti3 = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True; MultipleActiveResultSets=True;");

        private void Form14_Load(object sender, EventArgs e)
        {
            baglanti3.Open();
            SqlCommand komut3 = new SqlCommand("SELECT birinciOyuncuCan AS can1, ikinciOyuncuCan AS can2 FROM oyuncuCani", baglanti3);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                can1Lbl.Text = dr3["can1"].ToString();
                can2Lbl.Text = dr3["can2"].ToString();
            }
            baglanti3.Close();

            yetenek1Btn.Enabled = false;
            yetenek2Btn.Enabled = false;
            yetenek3Btn.Enabled = false;
            yetenek4Btn.Enabled = false;
            baglanti.Open();
            baglanti2.Open();
            SqlCommand komut = new SqlCommand("SELECT yetenekAdi1, yetenekAdi2  FROM pokeYetenek WHERE pokemonAdi = '" + poke1Lbl.Text + "'", baglanti);
            SqlCommand komut2 = new SqlCommand("SELECT yetenekAdi1, yetenekAdi2 FROM pokeYetenek WHERE pokemonAdi = '" + poke2Lbl.Text + "'", baglanti2);
            SqlDataReader dr = komut.ExecuteReader();
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr.Read())
            {
                yetenek1Btn.Text = dr["yetenekAdi1"].ToString();
                yetenek2Btn.Text = dr["yetenekAdi2"].ToString();
            }
            while (dr2.Read())
            {
                yetenek3Btn.Text = dr2["yetenekAdi1"].ToString();
                yetenek4Btn.Text = dr2["yetenekAdi2"].ToString();
            }
            baglanti.Close();
            baglanti2.Close();

            Random baslangicOyuncusu = new Random();
            int baslayan = baslangicOyuncusu.Next(2);
            if (baslayan == 0)
            {
                baslayanLbl.Text = ("Birinci Oyuncu Oyuna Başlıyor!");
                yetenek1Btn.Enabled = true;
                yetenek2Btn.Enabled = true;
            }
            else
            {
                baslayanLbl.Text = ("İkinci Oyuncu Oyuna Başlıyor!");
                yetenek3Btn.Enabled = true;
                yetenek4Btn.Enabled = true;
            }
        }

        private void yetenek1Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT yetenekGucu1Min, yetenekGucu1Max FROM pokeYetenek WHERE pokemonAdi = '" + poke1Lbl.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int minHasar = Convert.ToInt32(dr["yetenekGucu1Min"]);
            int maxHasar = Convert.ToInt32(dr["yetenekGucu1Max"]);
            int canBir = Convert.ToInt32(can1Lbl.Text);
            int canIki = Convert.ToInt32(can2Lbl.Text);
            dr.Close();
            baglanti.Close();
            Random cHasar = new Random();
            int critikHasar = cHasar.Next(2);
            while (canIki >= 0 && canBir >= 0)
            {
                if (critikHasar == 0)
                {
                    Random critic = new Random();
                    int vurulanCritic = critic.Next(minHasar, maxHasar);
                    int vurulanCriticSonuc = vurulanCritic + 20;
                    canIki -= vurulanCriticSonuc;
                    hasarLbl.Text = "Kritik Hasar: " + vurulanCriticSonuc;
                    can2Lbl.Text = canIki.ToString();
                    yetenek1Btn.Enabled = false;
                    yetenek2Btn.Enabled = false;
                    yetenek3Btn.Enabled = true;
                    yetenek4Btn.Enabled = true;
                    dr.Close();
                    break;
                    
                }
                else
                {
                    Random normal = new Random();
                    int normalHasar = normal.Next(minHasar, maxHasar);
                    canIki = canIki - normalHasar;
                    hasarLbl.Text = "Vurulan Hasar: " + normalHasar;
                    can2Lbl.Text = canIki.ToString();
                    yetenek1Btn.Enabled = false;
                    yetenek2Btn.Enabled = false;
                    yetenek3Btn.Enabled = true;
                    yetenek4Btn.Enabled = true;
                    dr.Close();
                    break;
                    
                }
                
                
            }
            if (canIki <= 0)
            {
                MessageBox.Show("BİRİNCİ OYUNCU BU TURNUVAYI KAZANIYOR!");
            }





        }

        private void yetenek2Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT yetenekGucu2Min, yetenekGucu2Max FROM pokeYetenek WHERE pokemonAdi = '" + poke1Lbl.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int minHasar = Convert.ToInt32(dr["yetenekGucu2Min"]);
            int maxHasar = Convert.ToInt32(dr["yetenekGucu2Max"]);
            int canBir = Convert.ToInt32(can1Lbl.Text);
            int canIki = Convert.ToInt32(can2Lbl.Text);
            dr.Close();
            baglanti.Close();
            Random cHasar = new Random();
            int critikHasar = cHasar.Next(2);
            while (canIki >= 0 && canBir >= 0)
            {
                if (critikHasar == 0)
                {
                    Random critic = new Random();
                    int vurulanCritic = critic.Next(minHasar, maxHasar);
                    int vurulanCriticSonuc = vurulanCritic + 20;
                    canIki -= vurulanCriticSonuc;
                    hasarLbl.Text = "Kritik Hasar: " + vurulanCriticSonuc;
                    can2Lbl.Text = canIki.ToString();
                    yetenek1Btn.Enabled = false;
                    yetenek2Btn.Enabled = false;
                    yetenek3Btn.Enabled = true;
                    yetenek4Btn.Enabled = true;
                    
                    break;
                    
                }
                else
                {
                    Random normal = new Random();
                    int normalHasar = normal.Next(minHasar, maxHasar);
                    canIki = canIki - normalHasar;
                    hasarLbl.Text = "Vurulan Hasar: " + normalHasar;
                    can2Lbl.Text = canIki.ToString();
                    yetenek1Btn.Enabled = false;
                    yetenek2Btn.Enabled = false;
                    yetenek3Btn.Enabled = true;
                    yetenek4Btn.Enabled = true;
                    
                    break;
                    
                }
               
            }
            if (canIki <= 0)
            {
                MessageBox.Show("BİRİNCİ OYUNCU BU TURNUVAYI KAZANIYOR!");
            }


        }

        private void yetenek3Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT yetenekGucu1Min, yetenekGucu1Max FROM pokeYetenek WHERE pokemonAdi = '" + poke2Lbl.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int minHasar = Convert.ToInt32(dr["yetenekGucu1Min"]);
            int maxHasar = Convert.ToInt32(dr["yetenekGucu1Max"]);
            int canBir = Convert.ToInt32(can1Lbl.Text);
            int canIki = Convert.ToInt32(can2Lbl.Text);
            dr.Close();
            baglanti.Close();
            Random cHasar = new Random();
            int critikHasar = cHasar.Next(2);
            while (canIki >= 0 && canBir >= 0)
            {
                if (critikHasar == 0)
                {
                    Random critic = new Random();
                    int vurulanCritic = critic.Next(minHasar, maxHasar);
                    int vurulanCriticSonuc = vurulanCritic + 20;
                    canBir -= vurulanCriticSonuc;
                    hasarLbl.Text = "Kritik Hasar: " + vurulanCriticSonuc;
                    can1Lbl.Text = canBir.ToString();
                    yetenek1Btn.Enabled = true;
                    yetenek2Btn.Enabled = true;
                    yetenek3Btn.Enabled = false;
                    yetenek4Btn.Enabled = false;
                    break;
                    

                }
                else
                {
                    Random normal = new Random();
                    int normalHasar = normal.Next(minHasar, maxHasar);
                    canBir = canBir - normalHasar;
                    hasarLbl.Text = "Vurulan Hasar: " + normalHasar;
                    can1Lbl.Text = canBir.ToString();
                    yetenek1Btn.Enabled = true;
                    yetenek2Btn.Enabled = true;
                    yetenek3Btn.Enabled = false;
                    yetenek4Btn.Enabled = false;
                    break;
                    
                }
            }
            if (canBir <= 0)
            {
                MessageBox.Show("İKİNCİ OYUNCU BU TURNUVAYI KAZANIYOR!");
            }

        }

        private void yetenek4Btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT yetenekGucu2Min, yetenekGucu2Max FROM pokeYetenek WHERE pokemonAdi = '" + poke2Lbl.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            int minHasar = Convert.ToInt32(dr["yetenekGucu2Min"]);
            int maxHasar = Convert.ToInt32(dr["yetenekGucu2Max"]);
            int canBir = Convert.ToInt32(can1Lbl.Text);
            int canIki = Convert.ToInt32(can2Lbl.Text);
            dr.Close();
            baglanti.Close();
            Random cHasar = new Random();
            int critikHasar = cHasar.Next(2);
            while (canIki >= 0 && canBir >= 0)
            {
                if (critikHasar == 0)
                {
                    Random critic = new Random();
                    int vurulanCritic = critic.Next(minHasar, maxHasar);
                    int vurulanCriticSonuc = vurulanCritic + 20;
                    canBir -= vurulanCriticSonuc;
                    hasarLbl.Text = "Kritik Hasar: " + vurulanCriticSonuc;
                    can1Lbl.Text = canBir.ToString();
                    yetenek1Btn.Enabled = true;
                    yetenek2Btn.Enabled = true;
                    yetenek3Btn.Enabled = false;
                    yetenek4Btn.Enabled = false;
                    
                    break;
                    
                }
                else
                {
                    Random normal = new Random();
                    int normalHasar = normal.Next(minHasar, maxHasar);
                    canBir = canBir - normalHasar;
                    hasarLbl.Text = "Vurulan Hasar: " + normalHasar;
                    can1Lbl.Text = canBir.ToString();
                    yetenek1Btn.Enabled = true;
                    yetenek2Btn.Enabled = true;
                    yetenek3Btn.Enabled = false;
                    yetenek4Btn.Enabled = false;
                    
                    break;
                    
                }
            }
            if (canBir <= 0)
            {
                MessageBox.Show("İKİNCİ OYUNCU BU TURNUVAYI KAZANIYOR!");
            }



        }
    }
}



