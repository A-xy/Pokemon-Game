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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            slmLbl.BackColor = System.Drawing.Color.Transparent;
            hosgeldinizLbl.BackColor = System.Drawing.Color.Transparent;
        }

        private void yoneticipanelBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.isimLbl.Text = slmLbl.Text;
            form4.Show();
            this.Hide();
        }

        private void oyuncularBtn_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.isimLbl.Text = slmLbl.Text;
            form11.Show();
            this.Hide();
        }

        private void karsilasmaListBtn_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.isimLbl.Text = slmLbl.Text;
            form12.Show();
            this.Hide();
        }
    }
}
