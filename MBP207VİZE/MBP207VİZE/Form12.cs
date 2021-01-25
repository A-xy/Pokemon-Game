using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBP207VİZE
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-7RV6RIR\SQLEXPRESS; Initial Catalog=POKEMON;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT oyuncuAdi FROM oyuncu", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                birinciOyuncuCm.Items.Add(dr[0]).ToString();
                ikinciOyuncuCm.Items.Add(dr[0].ToString());
            }
            baglanti.Close();

           
        }

        private void birinciOyuncuCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT poke1, poke2, poke3 FROM oyuncu WHERE oyuncuAdi = '"+birinciOyuncuCm.Text+"'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                pokeSec1Cm.Items.Add(dr["poke1"].ToString());
                pokeSec1Cm.Items.Add(dr["poke2"].ToString());
                pokeSec1Cm.Items.Add(dr["poke3"].ToString());
            }
            baglanti.Close();
        }

        private void ikinciOyuncuCm_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT poke1, poke2, poke3 FROM oyuncu WHERE oyuncuAdi = '" + ikinciOyuncuCm.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                pokeSec2Cm.Items.Add(dr["poke1"].ToString());
                pokeSec2Cm.Items.Add(dr["poke2"].ToString());
                pokeSec2Cm.Items.Add(dr["poke3"].ToString());
            }
            baglanti.Close();
        }

        public void baslatBtn_Click(object sender, EventArgs e)
        {
            string oyuncu1 = pokeSec1Cm.Text;
            string oyuncu2 = pokeSec2Cm.Text;

            Form14 form14 = new Form14();
            form14.poke1Lbl.Text = oyuncu1;
            form14.poke2Lbl.Text = oyuncu2;
            form14.Show();
            this.Hide();
        }
    }
}
