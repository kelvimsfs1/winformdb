using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'univilleDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.univilleDataSet.clientes);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Update(this.univilleDataSet.clientes);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.univilleDataSet.clientes);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.univilleDataSet.clientes);
        }
    }
}

