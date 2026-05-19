using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; user id=root; password=; database=projeto_cafeteria");
        public string mensagem;

        public bool insereProduto(Produto novoProduto)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereProduto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", novoProduto.nome);
                cmd.Parameters.AddWithValue("preco", novoProduto.preco);
                cmd.Parameters.AddWithValue("descricao", novoProduto.descricao);
                cmd.Parameters.AddWithValue("fk_categoria", novoProduto.categoria);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch(MySqlException erro) 
            { 
                mensagem = erro.Message; 
                return false;
            }
        }// fim do insereProduto
        public bool insereUsuario(Usuario novoUsuario)
        {
            try
            {
                conexao.Open();

                string senhaHash = Biblioteca.makeHash(novoUsuario.senha);

                MySqlCommand cmd = new MySqlCommand("sp_insereUsuario", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nome", novoUsuario.nome);
                cmd.Parameters.AddWithValue("email", novoUsuario.email);
                cmd.Parameters.AddWithValue("senha", senhaHash);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }
        public DataTable listaCategorias()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaCategorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try 
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }// fim listaCategorias
        public DataTable listaProdutos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaProdutos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try 
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }// fim listaProdutos

        public bool deletaProduto(int idRemoveProduto)
        {
            MySqlCommand cmd =
            new MySqlCommand("sp_removeProduto", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_produtos", idRemoveProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }
        

        public bool alteraProduto(Produto p, int id_produtos)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("sp_alteraProduto", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id_produtos", id_produtos);
                cmd.Parameters.AddWithValue("nome", p.nome);
                cmd.Parameters.AddWithValue("preco", p.preco);
                cmd.Parameters.AddWithValue("descricao", p.descricao);
                cmd.Parameters.AddWithValue("categoria", p.categoria);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }// fim do alteraProduto

        public bool insereCategoria(string novaCategoria)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("categoria", novaCategoria);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }// fim do insereCategoria

        public bool deletaCategoria(int id_categoria)
        {
            // Verificar se há produtos associados a essa categoria
            MySqlCommand verificaProdutosCmd = new MySqlCommand("SELECT COUNT(*) FROM produtos WHERE fk_categoria = @id_categoria", conexao);
            verificaProdutosCmd.Parameters.AddWithValue("id_categoria", id_categoria);

            try
            {
                conexao.Open();
                int numProdutos = Convert.ToInt32(verificaProdutosCmd.ExecuteScalar());

                if (numProdutos > 0)
                {
                    // Se houver produtos associados, não permitir a exclusão da categoria
                    mensagem = "Não é possível excluir a categoria, pois há produtos associados a ela.";
                    return false;
                }

                // Se não houver produtos associados, continuar com a exclusão da categoria
                MySqlCommand cmd = new MySqlCommand("sp_removeCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idcategoria", id_categoria);

                cmd.ExecuteNonQuery(); // Executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }// fim classe
}
