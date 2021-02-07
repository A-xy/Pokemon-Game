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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");

        private void Form8_Load(object sender, EventArgs e)
        {
            //Şuan listeliyor
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT pokemonAdi FROM pokemonBilgi", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]).ToString();
            }
            baglanti.Close();
           
            isimLbl.BackColor = System.Drawing.Color.Transparent;
            lblHg.BackColor = System.Drawing.Color.Transparent;
            mevcutLbl.BackColor = System.Drawing.Color.Transparent;
            

            
        }

        private void gonderBtn_Click(object sender, EventArgs e)
        {
            String pokemonAdi;
            pokemonAdi = pokeAdiTxt.Text;
            baglanti.Open();
            SqlCommand pokeAdiKontrol = new SqlCommand("SELECT * FROM pokemonBilgi WHERE pokemonAdi='" + pokemonAdi + "'", baglanti);
            SqlDataReader sorgulama = pokeAdiKontrol.ExecuteReader();
            if (sorgulama.Read())
            {
                MessageBox.Show("Bu adda bir pokemon bulunmaktadır, aynı pokemon eklenemez.");
            }
            else
            {
                using (SqlCommand pokeEkle = baglanti.CreateCommand())
                {
                    sorgulama.Close();
                    pokeEkle.CommandText = "insert pokeBilgi (pokemonAdi,pokemonTur,pokemonCan,pokemonGuc,pokemonAciklama,pokemonAdi) values (@p1,@p2,@p3,@p4,@p5);";
                    pokeEkle.CommandText = "insert pokeYetenek (pokemonAdi) values (@p1);";
                    pokeEkle.Parameters.Add(new SqlParameter("@p1", pokeAdiTxt.Text));
                    pokeEkle.Parameters.Add(new SqlParameter("@p2", pokeTurTxt.Text));
                    pokeEkle.Parameters.Add(new SqlParameter("@p3", pokeCanTxt.Text));
                    pokeEkle.Parameters.Add(new SqlParameter("@p4", pokeGucuTxt.Text));
                    pokeEkle.Parameters.Add(new SqlParameter("@p5", pokeAciklamaTxt.Text));
                   

                    

                    pokeEkle.ExecuteNonQuery();
                    MessageBox.Show("Pokemon sistemimize eklenmiştir.");
                    pokeAdiTxt.Clear();
                    pokeTurTxt.Clear();
                    pokeCanTxt.Clear();
                    pokeGucuTxt.Clear();
                    pokeAciklamaTxt.Clear();
                    comboBox1.Items.Add(pokemonAdi).ToString();
                    
                    
                }
                
            }
            baglanti.Close();
            
        }

        private void pokeCanTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pokeAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.isimLbl.Text = isimLbl.Text;
            form4.Show();
            this.Hide();
        }
    }
}
