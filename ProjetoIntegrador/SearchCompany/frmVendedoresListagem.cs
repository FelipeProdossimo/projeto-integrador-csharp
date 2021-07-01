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
    public partial class frmVendedoresListagem : Form
    {
        public frmVendedoresListagem()
        {
            InitializeComponent();
        }

        private void btnNovoVendedor_Click(object sender, EventArgs e)
        {
            
                // ABRIR FORMULÁRIO
                frmVendedores formulario = new frmVendedores();
                formulario.ShowDialog();
        }

        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                string nomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_vendedores WHERE nome LIKE '%{nomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridVendedores.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, " erro na conexão");
            }
        }


        private void Pesquisar(string nome)
        {
            string sqlBuscar = "";
            sqlBuscar = $"SELECT * FROM tb_vendedores";

            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto;";

            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridVendedores.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, " erro na conexão");
            }
        }
    }
}
