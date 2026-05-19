using MySql.Data.MySqlClient;
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

    public partial class FrmDelCategoria : Form
    {


        public FrmDelCategoria()
        {
            InitializeComponent();
        }

        private void BtnDelCategoria_Click(object sender, EventArgs e)
        {
            if (cbDelCategoria.SelectedIndex != -1) // Verifica se algo está selecionado na ComboBox
            {
                int id = Convert.ToInt32(cbDelCategoria.SelectedValue);

                string categoriaSelecionada = cbDelCategoria.Text;

                DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                    "Remove Categoria", MessageBoxButtons.OKCancel);
                if (resp == DialogResult.OK)
                {
                    ConectaBanco con = new ConectaBanco();
                    bool retorno = con.deletaCategoria(id);

                    if (retorno == true)
                    {
                        MessageBox.Show("Categoria excluída com sucesso!");
                        listaCBCategoriasDel();
                    }
                    else
                        MessageBox.Show(con.mensagem);
                }
                else
                    MessageBox.Show("Exclusão cancelada");
            }
            else
            {
                MessageBox.Show("Nenhuma categoria selecionada");
            }
        }

        private void cbDelCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void listaCBCategoriasDel()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();

            cbDelCategoria.DataSource = tabelaDados;
            cbDelCategoria.DisplayMember = "categoria";
            cbDelCategoria.ValueMember = "id_categoria";

            cbDelCategoria.SelectedIndex = -1;
        }

        private void FrmDelCategoria_Load(object sender, EventArgs e)
        {
            listaCBCategoriasDel();
        }

        private void btnFecharDelCategoria_Click(object sender, EventArgs e)
        {
            Sistema formSistema = new Sistema();
            this.Hide();
            formSistema.ShowDialog();
            this.Close();
        }
    }
}