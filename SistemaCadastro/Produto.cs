using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public string descricao;
        public int categoria;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Categoria { get => categoria; set => categoria = value; }
    }
}

class Program
{

}
