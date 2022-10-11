using CarrinhoDeCompras.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras.Models
{
    public class Produtos
    {
        private List<Produto> _listaDeProdutos { get; set; }
        public IReadOnlyList<Produto> ListaDeProdutos => _listaDeProdutos;

        public Produtos()
        {
            _listaDeProdutos = new List<Produto>();
        }

        public void AdicionaProduto(Produto produto)
        {
            _listaDeProdutos.Add(produto);
        }

        public IReadOnlyList<Produto> ListarProdutos()
        {
            Console.ReadLine();

            if(ListaDeProdutos.Count <= 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                Console.WriteLine("Pressione qualquer recla para retornar ao menu principal.");
                Console.ReadLine();
            }

            return ListaDeProdutos;
        }
    }
}
