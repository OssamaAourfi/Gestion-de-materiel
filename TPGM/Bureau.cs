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
    public partial class Bureau : Form
    {
        public Bureau()
        {
            InitializeComponent();
        }
        public void Afficher()
        {
            Cnx.Connecter();
            Cnx.Afficher("select*from Bureau");
            dataGridView1.Rows.Clear();
            while (Cnx.dr.Read())
            {
                dataGridView1.Rows.Add(Cnx.dr[0], Cnx.dr[1]);
            }

            Cnx.dr.Close();


        }

        private void Bureau_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "NumB";
            dataGridView1.Columns[1].Name = "NomB";
           

        }

        private void BtnAfficher_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Cnx.dt;
            Afficher();

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Cnx.Connecter();
                Cnx.MiseAjour("insert into Bureau values(" + TxtNumB.Text + ",'" + TxtNomB.Text + "')");
                Afficher();

                MessageBox.Show("Bien Ajouter");
            }
            catch
            {
                MessageBox.Show("Non Ajouter");
            }
          


        }
        
    
        private void BtnSupprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous supprimer ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Cnx.Connecter();
                Cnx.cmd.CommandText = ("select count(NumB) from Personne where NumB=" +TxtNumB.Text + "");
                Int32 s = (Int32)Cnx.cmd.ExecuteScalar();
                if (s != 0)
                {
                    MessageBox.Show("Ce bureau  contient des personnes","suppresion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    Cnx.MiseAjour("delete from Bureau where NumB=" + TxtNumB.Text+"");
                    MessageBox.Show("Bien Suprimmer");
                    Afficher();
                }

            }

        }
               

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Cnx.Connecter();
                Cnx.MiseAjour("update Bureau set NomB='" + TxtNomB.Text + "' where NumB=" + TxtNumB.Text + "");
                MessageBox.Show("Bien Modifier");
                Afficher();

            }
            catch
            {
                MessageBox.Show("Non Modifier");

            }
        
        }
 //       public int count()
 //       {
           
 //           Cnx.Connecter();
 //           Cnx.Afficher("select count(NumB) from Bureau where NumB='" + TxtNumB.Text + "'");
          
 //           int b =(int)Cnx.cmd.ExecuteScalar();
        
 //return b;
 //           Cnx.Deconnecter();
           
        //}
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
           
                Cnx.Connecter();
                Cnx.Afficher("select*from Bureau where NumB=" + TxtNumB.Text + "");
                Cnx.dr.Read();
                TxtNumB.Text = Cnx.dr["NumB"].ToString();
                TxtNomB.Text = Cnx.dr["NomB"].ToString();
                Cnx.dr.Close();
            
            

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

    }
}
