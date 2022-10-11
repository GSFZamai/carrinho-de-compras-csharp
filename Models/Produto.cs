using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras.Models
{
    public class Produto
    {
        public static int ItemCount { get; private set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double valor, int quantidade)
        {
            ItemCount++;
            Id = ItemCount;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public void EditaProduto()
        {
            Console.WriteLine("Informe novo nome para o produto ou deixe em branco para manter o mesmo.");
            string nome =  Console.ReadLine();

            if(!string.IsNullOrEmpty(nome))
            {
                Nome = nome;
            }

            Console.WriteLine("Informe o novo preço do produto ou deixe em branco para manter o mesmo.");
            string valor = Console.ReadLine();

            if (!string.IsNullOrEmpty(valor))
            {

                Valor = double.Parse(valor);
            }

            Console.WriteLine("Informe o novo preço do produto ou deixe em branco para manter o mesmo.");
            string quantidade = Console.ReadLine();

            if (!string.IsNullOrEmpty(quantidade))
            {
                Quantidade = int.Parse(quantidade);
            }
        }



        public override string ToString()
        {
            return $"{Id} - {Nome} - R$ {Valor:F2} - Em estoque: {Quantidade}";
        }

        public override bool Equals(object? obj)
        {
            Produto produto = (Produto)obj;

            return produto != null && produto.Nome.Trim().ToLower() == this.Nome.Trim().ToLower();
        }
    }
}
