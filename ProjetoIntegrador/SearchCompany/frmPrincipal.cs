using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algum erro ocorreu no link. Erro: " + erro.Message);
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarCliente formulario = new frmAlterarCliente();
            formulario.ShowDialog();
        }

        private void novoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmVendedores formulario = new frmVendedores();
            formulario.ShowDialog();
        }

        private void listarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmVendedoresListagem formulario = new frmVendedoresListagem();
            formulario.ShowDialog();
        }

        private void alterarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmAlterarVendedor formulario = new frmAlterarVendedor();
            formulario.ShowDialog();
        }

        private void novoAtendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmAtendente formulario = new frmAtendente();
            formulario.ShowDialog();
        }

        private void alterarAtendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmAlterarAtendente formulario = new frmAlterarAtendente();
            formulario.ShowDialog();
        }

        private void listarTodosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // ABRIR FORMULÁRIO
            frmAtendenteListagem formulario = new frmAtendenteListagem();
            formulario.ShowDialog();
        }
    }
}
