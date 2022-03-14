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
    public partial class Materiels : Form
    {
        public Materiels()
        {
            InitializeComponent();
        }

        private void Materiels_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "NumM";
            dataGridView1.Columns[1].Name = "TypeM";
            dataGridView1.Columns[2].Name = "NomM";
            dataGridView1.Columns[3].Name = "MarqueM";
            dataGridView1.Columns[4].Name = "StockM";
        }
        public void Afficher()
        {
            Cnx.Connecter();
            Cnx.Afficher("select*from Materiels");
            dataGridView1.Rows.Clear();
            while (Cnx.dr.Read())
            {
                dataGridView1.Rows.Add(Cnx.dr[0], Cnx.dr[1], Cnx.dr[2], Cnx.dr[3], Cnx.dr[4]);
            }
            Cnx.dr.Close();
        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            Afficher();

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
             Cnx.Connecter();
            Cnx.MiseAjour("insert into Materiels values(" + TxtNumM.Text + ",'" + TxtTypeM.Text + "','" + txtNomM.Text + "','" + TxtMarqueM.Text + "'," + txtStockM.Text + ")");
                MessageBox.Show("Bien Ajouter");
                Afficher();
            }
            catch
            {
                MessageBox.Show("Non Ajouter");
            }
            }
            

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
             Cnx.Connecter();
            Cnx.MiseAjour("update Materiels set TypeM='"+TxtTypeM.Text+"',NomM='"+txtNomM.Text+"', MarqueM='"+TxtMarqueM.Text+"',StockM="+txtStockM.Text+" where NumM="+TxtNumM.Text+"");
                MessageBox.Show("Bien Modifier");
                Afficher();
            }
            catch
            {
                MessageBox.Show("Non Modifier");
            }
            
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
            Cnx.Connecter();
           Cnx.MiseAjour("delete from Materiels where NumM=" + TxtNumM.Text + "");
                MessageBox.Show("Bien Supprimer");
                Afficher();
            }
            catch
            {
                MessageBox.Show("Non Supprimer");
            }
             
           
            

           
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous Quitter ?", "Femer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Non Merci...");
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            Cnx.Connecter();
            Cnx.Afficher("select*from Materiels where NumM=" + TxtNumM.Text + "");
            Cnx.dr.Read();
            TxtNumM.Text = Cnx.dr["NumM"].ToString();
            TxtTypeM.Text = Cnx.dr["TypeM"].ToString();
            txtNomM.Text = Cnx.dr["NomM"].ToString();
            TxtMarqueM.Text = Cnx.dr["MarqueM"].ToString();
            txtStockM.Text = Cnx.dr["StockM"].ToString();
            Cnx.dr.Close();
        }
    }
}
