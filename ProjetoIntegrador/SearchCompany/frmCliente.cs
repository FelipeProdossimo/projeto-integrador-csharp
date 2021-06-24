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
            /* Para gravar os dados em arquivo.txt
            
            StreamWriter arquivo;
            string caminho = "C:\\sistema1\\clientes.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine(nome + " | " + email + " | " + telefone + " | " + senha);
            arquivo.Close();
            */

            /*
             Conexão com o banco de dados.
             */
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_projeto";
    ;       MySqlConnection conexao = new MySqlConnection(bancoDeDados);


            /*
             Abrir conexão com banco de dados.
             +
             Tratamento de exceção, procurar depois!
             */

            //if (ValidateChildren(Valida))

                try
                {
                /*    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        MessageBox.Show(txt)
                       
                    }*/
                /* Abertura de conexão */
                conexao.Open();

                //  Objeto que vai armazenar um comando SQL e vai executar
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao; // Informa o objeto de conexão para o CMD 

                // Informar o SQL que será executado
                cmd.CommandText = "insert into tb_clientes(nome, email, telefone, senha) values " +
                    "('" + txtNome.Text + "', '" + txtEmail.Text + "', '" + txtTelefone.Text + "', '" + txtSenha.Text + "')";

                /*
                 Outras formas de insert SQL no C# 

                --- O primeiro feito (CRUD em C# com parâmetros) ---

                 cmd.CommandText = "insert into tb_clientes(nome, email, telefone, senha) values " +
                    "('" + nome + "', '" + email + "', '" + telefone + "', '" + senha + "')";

                $ = é para ele entender que todos campos que tiver {CHAVES} é uma variavel

                cmd.CommandText = $"insert into tb_clientes(nome, email, telefone, senha) values " +
                    "('{nome}', '{email}', '{telefone}' , '{senha}')";
                 */

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

        private void txtNome_Validar(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                e.Cancel = true;
                txtNome.Focus();

                errorProvider1.SetError(txtNome, "O Nome está em branco!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNome, "");
            }
        }
    }
}
