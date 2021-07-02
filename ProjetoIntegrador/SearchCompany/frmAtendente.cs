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
    public partial class frmAtendente : Form
    {
        public frmAtendente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarAtendente(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
        }
        private void CadastrarAtendente(string nome, string email, string telefone, string senha)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
            ; MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                /* Abertura de conexão */
                conexao.Open();

                //  Objeto que vai armazenar um comando SQL e vai executar
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao; // Informa o objeto de conexão para o CMD 

                // Informar o SQL que será executado
                cmd.CommandText = "insert into tb_atendentes(nome, email, telefone, senha) values " +
                    "('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "', '" + txtSenha.Text + "')";
            
            // Executar o SQL
                cmd.ExecuteNonQuery();

            // Verificar se foi feito o cadastro

            MessageBox.Show("Cadastro realizado com sucesso!");
            // Fechar conexão
            conexao.Close();
        }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possivel conectar com o banco de dados: " + erro.Message);
            }
        }
    }      
}

