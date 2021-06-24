using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchCompany
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesListagem formulario = new frmClientesListagem();
            formulario.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente formulario = new frmCliente();
            formulario.ShowDialog();
        }
    }
}
