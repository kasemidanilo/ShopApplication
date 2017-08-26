using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class Menaxheri : Form
    {


        string menaxheri;
        int idMenaxheri;

        public Menaxheri(string menaxheri, int idMenaxheri)
        {
            this.menaxheri = menaxheri;
            this.idMenaxheri = idMenaxheri;
            InitializeComponent();
        }

        private void fleteHyrjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FleteHyrjecs cs = new FleteHyrjecs(menaxheri, idMenaxheri);
            cs.Show();
        }

        private void shtoNjesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();

        }
    }
}
