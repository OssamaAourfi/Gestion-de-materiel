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
    public partial class  Personne : Form
    {
        public Personne()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous Supprimer ce personne", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            { 

                Cnx.Connecter();
                Cnx.MiseAjour("delete  from Personne where NumP=" + txtNumP.Text + "");
                MessageBox.Show("Bien Supprimer");
                Afficher();
            }
            else
            {
                MessageBox.Show("Non Supprimer");
            }
        }

        private void Personne_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "NumP";
            dataGridView1.Columns[1].Name = "NumB";
            dataGridView1.Columns[2].Name = "NomP";
            dataGridView1.Columns[3].Name = "PrenomP";
            dataGridView1.Columns[4].Name = "Adresse";
            dataGridView1.Columns[5].Name = "Tele";
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
        public void Afficher()
        {
 Cnx.Connecter();
            dataGridView1.Rows.Clear();
            Cnx.Afficher("select*from Personne");
            while(Cnx.dr.Read())
            {
                dataGridView1.Rows.Add(Cnx.dr[0], Cnx.dr[1], Cnx.dr[2], Cnx.dr[3], Cnx.dr[4], Cnx.dr[5]);
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
                Cnx.MiseAjour("insert into Personne values(" + txtNumP.Text + "," + TxtNumB.Text + ",'" + TxtNomP.Text + "','" + TxtPersonne.Text + "','" + TxtAdresse.Text + "','" + TxtTele.Text + "')");
                MessageBox.Show("Bien Ajouter");
                Afficher();
            }
            catch
            {
                MessageBox.Show("Non Ajouter");
            }
           
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            Cnx.Connecter();
            Cnx.Afficher("select*from Personne where NumP=" + txtNumP.Text + "");
            Cnx.dr.Read();

            txtNumP.Text = Cnx.dr["NumP"].ToString();
            TxtNumB.Text = Cnx.dr["NumB"].ToString();
            TxtNomP.Text = Cnx.dr["NomP"].ToString();
            TxtPersonne.Text = Cnx.dr["PrenomP"].ToString();
            TxtAdresse.Text = Cnx.dr["Adresse"].ToString();
            TxtTele.Text = Cnx.dr["Tele"].ToString();
            Cnx.dr.Close();
            Afficher();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {Cnx.Connecter();
            Cnx.MiseAjour("update Personne set NumB="+TxtNumB.Text+", Nomp='"+TxtNomP.Text+"',Prenomp='"+TxtPersonne.Text+"',Adresse='"+TxtAdresse.Text+"',Tele='"+TxtTele.Text+"' where Nump = "+txtNumP.Text+" ");
                MessageBox.Show("Bien Modifier");
                Afficher();
            }
            catch
            {
                MessageBox.Show("Non Mofiier");
            }
            
        }
    }
}
