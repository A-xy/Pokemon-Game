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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");

        private void Form10_Load(object sender, EventArgs e)
        {
            hosgeldinizLbl2.BackColor = System.Drawing.Color.Transparent;
            isimLbl2.BackColor = System.Drawing.Color.Transparent;
            pokeAdiLbl.BackColor = System.Drawing.Color.Transparent;
            birinciYetLbl.BackColor = System.Drawing.Color.Transparent;
            ikinciYetLbl.BackColor = System.Drawing.Color.Transparent;
            birinciYetMinLbl.BackColor = System.Drawing.Color.Transparent;
            birinciYetMaxLbl.BackColor = System.Drawing.Color.Transparent;
            ikinciYetMinLbl.BackColor = System.Drawing.Color.Transparent;
            ikinciYetMaxLbl.BackColor = System.Drawing.Color.Transparent;
            mevcutPokeLbl.BackColor = System.Drawing.Color.Transparent;
            gucDuzenleLbl.BackColor = System.Drawing.Color.Transparent;

            pokeAdiTxt.ReadOnly = true;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT pokemonAdi FROM pokeYetenek", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]).ToString();
            }
            baglanti.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pokeAdiTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM pokeYetenek WHERE pokemonAdi='" + comboBox1.Text + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string pokemonAdi = dr["pokemonAdi"].ToString();
                pokeAdiTxt.Text = pokemonAdi;

                string yetenekAdi = dr["yetenekAdi1"].ToString();
                yetenekAdi1Txt.Text = yetenekAdi;

                string yetenekAdi2 = dr["yetenekAdi2"].ToString();
                yetenekAdi2Txt.Text = yetenekAdi2;

                string yetenekGucu1Min = dr["yetenekGucu1Min"].ToString();
                yetenekGucu1MinTxt.Text = yetenekGucu1Min;

                string yetenekGucu1Max = dr["yetenekGucu1Max"].ToString();
                yetenekGucu1MaxTxt.Text = yetenekGucu1Max;

                string yetenekGucu2Min = dr["yetenekGucu2Min"].ToString();
                yetenekGucu2TxtMin.Text = yetenekGucu2Min;

                string yetenekGucu2Max = dr["yetenekGucu2Max"].ToString();
                yetenekGucu2MaxTxt.Text = yetenekGucu2Max;
            }
            baglanti.Close();
        }

        private void pokeKaydetBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            using (SqlCommand pokeGuncelle = baglanti.CreateCommand())
            {
                string pokemonAdi = pokeAdiTxt.Text;
                pokeGuncelle.CommandText = ("UPDATE pokeYetenek SET yetenekAdi1 = @p1, yetenekAdi2 = @p2, yetenekGucu1Min = @p3, yetenekGucu1Max = @p4, yetenekGucu2Min = @p5, yetenekGucu2Max = @p6 WHERE pokemonAdi = '" + pokemonAdi + "'");
                pokeGuncelle.Parameters.AddWithValue("@p1", yetenekAdi1Txt.Text);
                pokeGuncelle.Parameters.AddWithValue("@p2", yetenekAdi2Txt.Text);
                pokeGuncelle.Parameters.AddWithValue("@p3", yetenekGucu1MinTxt.Text);
                pokeGuncelle.Parameters.AddWithValue("@p4", yetenekGucu1MaxTxt.Text);
                pokeGuncelle.Parameters.AddWithValue("@p5", yetenekGucu2TxtMin.Text);
                pokeGuncelle.Parameters.AddWithValue("@p6", yetenekGucu2MaxTxt.Text);
                pokeGuncelle.ExecuteNonQuery();
                MessageBox.Show("Pokemon bilgileri eklendi / Güncellendi.");
            }
            baglanti.Close();
        }

        private void geriDonBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.isimLbl.Text = isimLbl2.Text;
            form4.Show();
            this.Hide();
        }
    }
}
