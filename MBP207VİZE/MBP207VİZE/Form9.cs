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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM pokemonBilgi WHERE pokemonAdi='" + comboBox1.Text + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                string pokemonAdi = dr["pokemonAdi"].ToString();
                pokeAdiTxt.Text = pokemonAdi;

                string pokemonTuru = dr["pokemonTur"].ToString();
                pokeTurTxt.Text = pokemonTuru;

                string pokemonCan = dr["pokemonCan"].ToString();
                pokeCanDgs.Text = pokemonCan;

                string pokemonGuc = dr["pokemonGuc"].ToString();
                pokeGucDgs.Text = pokemonGuc;

                string pokemonAcik = dr["pokemonAciklama"].ToString();
                pokeAcikDgs.Text = pokemonAcik;
            }
            baglanti.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT pokemonAdi FROM pokemonBilgi", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]).ToString();
            }
            baglanti.Close();

            hosgeldinizLbl.BackColor = System.Drawing.Color.Transparent;
            isimLbl.BackColor = System.Drawing.Color.Transparent;
            mevcutPoke.BackColor = System.Drawing.Color.Transparent;
            degisLbl.BackColor = System.Drawing.Color.Transparent;
            pokeAdiLbl.BackColor = System.Drawing.Color.Transparent;
            pokeTurDgsLbl.BackColor = System.Drawing.Color.Transparent;
            pokeCanDgsLbl.BackColor = System.Drawing.Color.Transparent;
            pokeGucDgsLbl.BackColor = System.Drawing.Color.Transparent;
            pokemonAcikDgsLbl.BackColor = System.Drawing.Color.Transparent;

            pokeAdiTxt.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            using (SqlCommand pokeGuncelle = baglanti.CreateCommand())
            {
                String pokeAdi = pokeAdiTxt.Text;
                pokeGuncelle.CommandText = ("UPDATE pokemonBilgi SET pokemonTur = @pTur, pokemonCan = @pCan, pokemonGuc = @pGuc, pokemonAciklama = @pAcik WHERE pokemonAdi='"+pokeAdi+"'");
                pokeGuncelle.Parameters.AddWithValue("@pTur", pokeTurTxt.Text);
                pokeGuncelle.Parameters.AddWithValue("@pCan", pokeCanDgs.Text);
                pokeGuncelle.Parameters.AddWithValue("@pGuc", pokeGucDgs.Text);
                pokeGuncelle.Parameters.AddWithValue("@pAcik", pokeAcikDgs.Text);
                pokeGuncelle.ExecuteNonQuery();
                MessageBox.Show("Pokemon bilgileri güncellendi.");
                
               
            }
            baglanti.Close();
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.isimLbl.Text = isimLbl.Text;
            form4.Show();
            this.Hide();
        }

        private void hosgeldinizLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
