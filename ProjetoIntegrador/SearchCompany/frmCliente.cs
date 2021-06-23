using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SearchCompany
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 
            CadastrarCliente(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text);
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
        }

        private void CadastrarCliente(string nome, string email, string telefone, string senha)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\clientes.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine(nome + " | " + email + " | " + telefone + " | " + senha);
            arquivo.Close();

            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
    ;       MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "insert into tb_clientes(nome, email, telefone, senha) values ('' , '', '', '')";
                cmd.ExecuteNonQuery();
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possivel conectar com o banco de dados: " + erro.Message);
            }
        }
    }
}
