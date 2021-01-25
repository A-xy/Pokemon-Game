using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBP207VİZE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            hosgeldinizLbl.BackColor = System.Drawing.Color.Transparent;
            isimLbl.BackColor = System.Drawing.Color.Transparent;
        }

        private void profilGuncelle_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.isimLbl1.Text = isimLbl.Text;
            form7.Show();
            this.Hide();
        }

        private void pokemonEkleBtn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.isimLbl.Text = isimLbl.Text;
            form8.Show();
            this.Hide();
        }

        private void pokeDuzenle_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.isimLbl.Text = isimLbl.Text;
            form9.Show();
            this.Hide();
        }

        private void pokeGucDznBtn_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.isimLbl2.Text = isimLbl.Text;
            form10.Show();
            this.Hide();

        }

        private void hosgeldinizLbl_Click(object sender, EventArgs e)
        {

        }

        private void isimLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
