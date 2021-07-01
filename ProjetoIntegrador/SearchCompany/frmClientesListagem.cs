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

        private void frmClientesListagem_Load(object sender, EventArgs e)
        {
            //conexão com banco
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                //iniciando conexão
                conexao.Open();
                //Comando SQL para mostrar o banco de dados - referente a tb_clientes.

                //MySqlCommand cmd = new MySqlCommand();
                //cmd.Connection = conexao;
                //cmd.CommandText = "SELECT * FROM tb_clientes";
                //cmd.ExecuteNonQuery();
                string sqlSelecionar = "SELECT * FROM tb_clientes";

                // Adaptador de dados p/ pegar informações do banco
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar , conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, " erro na conexão");
            }
        }

        /*
         
            PARA CASO DE USO DO BUTTON
            
         private void btnBuscar_Click(object sender, EventArgs e)
        {
            //conexão com banco
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                //Colocando o campo nome para pesquisar, transformando em variavel p/ usar no comando SQL depois.
                string nomeBuscar = txtNomeBuscar.Text;
                //iniciando conexão
                conexao.Open();
                //Comando SQL para mostrar o banco de dados - referente a tb_clientes.

                //MySqlCommand cmd = new MySqlCommand();
                //cmd.Connection = conexao;
                //cmd.CommandText = "SELECT nome FROM tb_clientes";
                //cmd.ExecuteNonQuery();

                
                string sqlSelecionar = $"SELECT * FROM tb_clientes WHERE nome like '%{nomeBuscar}%'";

                // Adaptador de dados p/ pegar informações do banco
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, " erro na conexão");
            }
        }
        */
        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root; password=;database=bd_projeto";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                string nomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_clientes WHERE nome LIKE '%{nomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, " erro na conexão");
            }         
        }
        //private = classe privada (não pode ser acessada de outro local)
        //void = não precisa de retorno nenhum. (string nome) = espera receber um tipo string.
        private void Pesquisar(string nome)
        {
            string sqlBuscar = "";
            sqlBuscar = $"SELECT * FROM tb_clientes";

            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto;";

            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridClientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("A conexão falhou. Erro: " + erro.Message, " erro na conexão");
            }
        }
    }
}