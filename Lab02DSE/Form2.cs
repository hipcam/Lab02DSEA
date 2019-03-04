using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02DSE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        Desconectado d = new Desconectado();
        private void Form2_Load(object sender, EventArgs e)
        {
            d.ListaCategorias(cboCategoria);
        }

        private void cboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DGCategorias.DataSource = d.ListaProductosxCategoria(Convert.ToInt32(cboCategoria.SelectedValue));
        }
    }
}
