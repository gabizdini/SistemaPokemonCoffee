using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;
        public Sistema()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }


        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }







        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBCategorias();
            lista_gridProdutos();
        }

        void lista_gridProdutos()
        {
            ConectaBanco con = new ConectaBanco();
            dgProdutos.DataSource = con.listaProdutos();
            dgProdutos.Columns["id_produto"].Visible = false;
        }
        public void listaCBCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cbcategoria.DataSource = tabelaDados;
            cbcategoria.DisplayMember = "categoria";
            cbcategoria.ValueMember = "id_categoria";

            cbAlteraCategoria.DataSource = tabelaDados;
            cbAlteraCategoria.DisplayMember = "categoria";
            cbAlteraCategoria.ValueMember = "id_categoria";

            //cbDelCategoria.DataSource = tabelaDados;
            //cbDelCategoria.DisplayMember = "categoria";
            //cbDelCategoria.ValueMember = "id_categoria"; NÃO ESTAMOS SABENDO FAZER ESSA PARTE
        }


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgProdutos.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("Nome like '%{0}%'", txtBusca.Text);
        }

        private void btnRemoveProduto_Click(object sender, EventArgs e)
        {
            int linha = dgProdutos.CurrentRow.Index;
            int id = Convert.ToInt32(
                dgProdutos.Rows[linha].Cells["id_produto"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja remover este produto?",
                "Remove Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaProduto(id);
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluído com sucesso!");
                    lista_gridProdutos();
                }
                else
                    MessageBox.Show(con.mensagem);
            }
            else
                MessageBox.Show("Exclusão cancelada.");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgProdutos.CurrentRow.Index;// pega linha selecionada
            idAlterar = Convert.ToInt32(
                dgProdutos.Rows[linha].Cells["id_produto"].Value.ToString());
            txtAlteraNome.Text =
                dgProdutos.Rows[linha].Cells["nome"].Value.ToString();
            txtAlteraPreco.Text =
                dgProdutos.Rows[linha].Cells["preco"].Value.ToString();
            txtAlteraDescricao.Text =
                dgProdutos.Rows[linha].Cells["descricao"].Value.ToString();
            cbAlteraCategoria.Text =
                dgProdutos.Rows[linha].Cells["categoria"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar; // muda aba
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {

            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.nome = txtAlteraNome.Text;
            novoProduto.preco = Convert.ToDouble(txtAlteraPreco.Text);
            novoProduto.descricao = txtAlteraDescricao.Text;
            novoProduto.categoria = Convert.ToInt32(cbAlteraCategoria.SelectedValue.ToString());
            bool retorno = con.alteraProduto(novoProduto, idAlterar);
            if (!retorno)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Alteração realizada com sucesso!");
            lista_gridProdutos();
            limpaCampos();

        }

        private void bntAddCategoria_Click(object sender, EventArgs e)
        {
            FrmAddCategoria formCategoria = new FrmAddCategoria();
            this.Hide();
            formCategoria.ShowDialog();
            this.Close();
        }

        void limpaCampos()
        {
            txtnome.Clear();
            txtpreco.Clear();
            txtdescricao.Clear();
            cbcategoria.Text = "";
            txtnome.Focus();
        }
        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.nome = txtnome.Text;
            novoProduto.preco = Convert.ToDouble(txtpreco.Text);
            novoProduto.descricao = txtdescricao.Text;
            novoProduto.categoria = Convert.ToInt32(cbcategoria.SelectedValue.ToString());
            bool retorno = con.insereProduto(novoProduto);
            if (!retorno)
                MessageBox.Show(con.mensagem);

            else
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            limpaCampos();
            lista_gridProdutos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            marcador.Height = btnAltera.Height;
            marcador.Top = btnAltera.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void btnAddCategoria1_Click(object sender, EventArgs e)
        {
            FrmAddCategoria formCategoria = new FrmAddCategoria();
            this.Hide();
            formCategoria.ShowDialog();
            this.Close();
        }

        private void btnDelCategoria_Click(object sender, EventArgs e)
        {
            FrmDelCategoria formCategoria = new FrmDelCategoria();
            this.Hide();
            formCategoria.ShowDialog();
            this.Close();
        }
    }
}
