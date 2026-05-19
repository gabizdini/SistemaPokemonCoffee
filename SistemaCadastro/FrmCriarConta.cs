using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmCriarConta : Form
    {
        public FrmCriarConta()
        {
            InitializeComponent();
        }
        void limpaCampos()
        {
            txtUserCriar.Clear();
            txtSenhaCriar.Clear();
            txtEmailCriar.Clear();
            txtUserCriar.Focus();
        }
        private void BtnCriarConta_Click(object sender, EventArgs e)
        {
            // Recuperar informações inseridas pelo usuário
            {
                ConectaBanco con = new ConectaBanco();
                Usuario novoUsuario = new Usuario();
                novoUsuario.nome = txtUserCriar.Text;
                novoUsuario.senha = txtSenhaCriar.Text;
                novoUsuario.email = txtEmailCriar.Text;
                bool retorno = con.insereUsuario(novoUsuario);

                if (!retorno)
                    MessageBox.Show(con.mensagem);

                else{
                    MessageBox.Show("Usuario criado com sucesso");
                    FrmLogin formConta = new FrmLogin();
                    this.Hide();
                    formConta.ShowDialog();
                    this.Close();
                    limpaCampos();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogin formConta = new FrmLogin();
            this.Hide();
            formConta.ShowDialog();
            this.Close();
        }
        private void FrmCriarConta_Load(object sender, EventArgs e)
        {

        }
        private bool InsereNovoUsuario(Usuario novoUsuario)
        {
            
            try
            {
                ConectaBanco conexaoBanco = new ConectaBanco();
                return conexaoBanco.insereUsuario(novoUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário no banco de dados: " + ex.Message);
                return false;
            }
        }
    }
}

