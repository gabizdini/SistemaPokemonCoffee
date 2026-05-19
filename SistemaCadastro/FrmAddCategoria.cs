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
    public partial class FrmAddCategoria : Form
    {
        public FrmAddCategoria()
        {
            InitializeComponent();
        }

        private void BtnInsereCategoria_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereCategoria(txtInsereCategoria.Text);
            if (!retorno)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Categoria adicionada com sucesso!");
            txtInsereCategoria.Clear();
            txtInsereCategoria.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharAddCategoria_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            this.Hide();
            formSistema.ShowDialog();
            this.Close();
        }
    }
}
