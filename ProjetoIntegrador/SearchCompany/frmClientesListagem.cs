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
    public partial class frmClientesListagem : Form
    {
        public frmClientesListagem()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmCliente formulario = new frmCliente();
            formulario.ShowDialog();
        }
    }
}
