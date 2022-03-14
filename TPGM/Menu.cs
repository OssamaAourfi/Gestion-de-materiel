using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        //Bureau bureauq = null;
        //Personne personneq = null;
        //Materiels materielsq = null;
        private void bureauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    if(bureauq == null)
            //    {
            //        bureauq = new Bureau();
            //        bureauq.Show();

            //    }
            Bureau B = new Bureau();
            B.Show();
            B.MdiParent = this;
        }

        private void personneToolStripMenuItem_Click(object sender, EventArgs e)

        //if(personneq==null)
        //{
        //    personneq = new Personne();
        //    personneq.Show();
        //}
        {
            Personne P = new Personne();
            P.Show();
            P.MdiParent = this;

        }

        private void materielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(materielsq==null)
            //{
            //    materielsq = new Materiels();
            //    materielsq.Show();
            //}
           
            Materiels M = new Materiels();
            M.Show();
            M.MdiParent = this;
        }
    }
}

