using CarrinhoDeCompras.Components;
using CarrinhoDeCompras.Models;

namespace CarrinhoDeCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Loja novaLoja = new Loja();
            novaLoja.ExibeMenu();
            Console.ReadLine();
        }
    }
}