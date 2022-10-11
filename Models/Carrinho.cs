using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras.Models
{
    public class Carrinho
    {
        public Guid Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public string DocumentoCliente { get; set; }
    }
}
