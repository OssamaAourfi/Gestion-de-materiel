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
    public partial class Apartenir : Form
    {
        public Apartenir()
        {
            InitializeComponent();
        }

        private void Apartenir_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "NumPersonne";
            dataGridView1.Columns[1].Name = "NumMateriels"; 
            dataGridView1.Columns[2].Name = "Date";

        }
    }
}
