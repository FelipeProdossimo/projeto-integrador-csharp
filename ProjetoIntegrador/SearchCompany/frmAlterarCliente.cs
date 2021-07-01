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
    public partial class frmAlterarCliente : Form
    {
        public frmAlterarCliente()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string idCliente = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto;";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlBuscar = $" SELECT * FROM tb_clientes WHERE id={idCliente}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                txtNome.Text = dt.Rows[0]["nome"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtTelefone.Text = dt.Rows[0]["telefone"].ToString();
                txtSenha.Text = dt.Rows[0]["senha"].ToString();
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a conexão. Erro: " +
                   erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto;";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlAlterar = $"UPDATE tb_clientes set nome='{txtNome.Text}' , email='{txtEmail.Text}' , " +
                    $"telefone='{txtTelefone.Text}' , senha='{txtSenha.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com sucesso");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algum erro ocorreu. Erro: " + erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            string idCliente = txtID.Text;
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_clientes WHERE id={idCliente}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cliente exluído com sucesso!");
                txtID.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtSenha.Clear();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algum erro ocorreu. Erro: " + erro.Message);
            }
        }
    }
}

