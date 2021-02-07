using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBP207VİZE
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT oyuncuAdi FROM oyuncu", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                mevcutCombo.Items.Add(dr[0].ToString());
                guncelleCombo.Items.Add(dr[0].ToString());

            }
            dr.Close();
            
            baglanti2.Open();
            SqlCommand komut2 = new SqlCommand("SELECT pokemonAdi FROM pokemonBilgi", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                birGuncelleCombo.Items.Add(dr2[0].ToString());
                ikiGuncelleCombo.Items.Add(dr2[0].ToString());
                ucGuncelleCombo.Items.Add(dr2[0].ToString());
                birinciComboC.Items.Add(dr2[0].ToString());
                ikinciComboC.Items.Add(dr2[0].ToString());
                ucuncuComboC.Items.Add(dr2[0].ToString());
            }
            baglanti2.Close();
            baglanti.Close();
        }

        private void hosgeldinizLbl_Click(object sender, EventArgs e)
        {

        }

        private void mevcutCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM oyuncu WHERE oyuncuAdi='" + mevcutCombo.Text + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string oyuncuAdi = dr["oyuncuAdi"].ToString();
                mevOyuncuTxt.Text = oyuncuAdi;

                string poke1 = dr["poke1"].ToString();
                mevBirTxt.Text = poke1;

                string poke2 = dr["poke2"].ToString();
                mevİkiTxt.Text = poke2;

                string poke3 = dr["poke3"].ToString();
                mevUcTxt.Text = poke3;
            }
            baglanti.Close();
        }

        private void birGuncelleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            String oyuncuAdi;
            oyuncuAdi = createTxt.Text;
            baglanti.Open();
            SqlCommand oyuncuAdiKontrol = new SqlCommand("SELECT * FROM oyuncu WHERE oyuncuAdi='" + oyuncuAdi + "'", baglanti);
            SqlDataReader sorgu = oyuncuAdiKontrol.ExecuteReader();
            if (sorgu.Read())
            {
                MessageBox.Show("Bu adda bir oyuncu bulunmaktadır, adınızı düzeltin.");
            }
            else
            {
                sorgu.Close();
                using (SqlCommand oyuncuEkle = baglanti.CreateCommand())
                {

                    oyuncuEkle.CommandText = "insert oyuncu(oyuncuAdi, poke1, poke2, poke3) values (@p1,@p2,@p3,@p4);";
                    oyuncuEkle.Parameters.Add(new SqlParameter("@p1", createTxt.Text));
                    oyuncuEkle.Parameters.Add(new SqlParameter("@p2", birinciComboC.Text));
                    oyuncuEkle.Parameters.Add(new SqlParameter("@p3", ikinciComboC.Text));
                    oyuncuEkle.Parameters.Add(new SqlParameter("@p4", ucuncuComboC.Text));
                    oyuncuEkle.ExecuteNonQuery();
                    MessageBox.Show("Oyuncu sistemimize eklenmiştir.");
                    createTxt.Clear();
                    mevcutCombo.Items.Add(oyuncuAdi).ToString();
                    guncelleCombo.Items.Add(oyuncuAdi).ToString();
                    baglanti.Close();
                }
                
            }
            
        }
        

        private void guncelleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM oyuncu WHERE oyuncuAdi='" + guncelleCombo.Text + "'", baglanti2);
            baglanti2.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string poke1 = dr["poke1"].ToString();
                birGuncelleCombo.Text = poke1;

                string poke2 = dr["poke2"].ToString();
                ikiGuncelleCombo.Text = poke2;

                string poke3 = dr["poke3"].ToString();
                ucGuncelleCombo.Text = poke3;
            }
            baglanti2.Close();

            
            
        }

        private void birGuncelleCombo_Load(object sender, EventArgs e)
        {
            
        }

        private void birGuncelleCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            using (SqlCommand oyuncuGuncelle = baglanti.CreateCommand())
            {
                String oyuncuAdi = guncelleCombo.Text;
                oyuncuGuncelle.CommandText = "UPDATE oyuncu SET poke1 = @p1, poke2 = @p2, poke3 = @p3 WHERE oyuncuAdi = '" + oyuncuAdi + "';";
                oyuncuGuncelle.Parameters.AddWithValue("@p1", birGuncelleCombo.Text);
                oyuncuGuncelle.Parameters.AddWithValue("@p2", ikiGuncelleCombo.Text);
                oyuncuGuncelle.Parameters.AddWithValue("@p3", ucGuncelleCombo.Text);
                oyuncuGuncelle.ExecuteNonQuery();
                MessageBox.Show("Pokemonlar Güncellendi.");

            }
            baglanti.Close();
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.slmLbl.Text = isimLbl.Text;
            form3.Show();
            this.Hide();
        }
    }
}
