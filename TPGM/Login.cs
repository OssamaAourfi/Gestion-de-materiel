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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cnx.Connecter();

        }

        private void BtnSeConnecter_Click(object sender, EventArgs e)
        {
            bool tr = false;
            Cnx.Connecter();
            Cnx.cmd.CommandText = "select NumP,NumB from Personne";
            Cnx.cmd.Connection = Cnx.cnx;
            Cnx.dr = Cnx.cmd.ExecuteReader();
            while(Cnx.dr.Read())
            {
                if(TxtNumB.Text.Equals(Cnx.dr[0].ToString()) && TxtNumP.Text.Equals(Cnx.dr[1].ToString()))
                { 
                    tr = true;
                    break;

                }
            }
            if(tr==true)
            {
                this.Hide();
                Menu M = new Menu();
                M.Show();
            }
            else
            {
                MessageBox.Show("Le num de bureau ou de personne est incorrecte");
            }
            Cnx.dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==false)
            {
                TxtNumP.UseSystemPasswordChar = true;
            }
            else
                TxtNumP.UseSystemPasswordChar = false;
        }
    }
}
