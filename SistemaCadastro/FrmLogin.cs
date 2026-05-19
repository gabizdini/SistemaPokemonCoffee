using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConectaBanco conecta = new ConectaBanco();
            if(conecta.verifica(txtUserLogin.Text, txtSenhaLogin.Text)== true)
            {
                Sistema formSistema = new Sistema();
                this.Hide();
                formSistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreta.   " + conecta.mensagem);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
            {
            FrmCriarConta formConta = new FrmCriarConta();
            this.Hide();
            formConta.ShowDialog();
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
