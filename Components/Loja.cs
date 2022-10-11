using CarrinhoDeCompras.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoDeCompras.Components
{
    public class Loja
    {
        public  List<Produto> listaProdutos { get; set; }
        public List<Carrinho> carrinhos { get; set; }

        public Loja()
        {
            listaProdutos = new List<Produto>();
            carrinhos = new List<Carrinho>();
        }

        public void ExibeMenu(int opcao = -1)
        {
            int selectedOption = opcao;
            Console.Clear();
            if(selectedOption == -1)
            {
                Console.WriteLine("Selecione uma opção.");
                Console.WriteLine("1 - Exibir a lista de produtos.");
                Console.WriteLine("2 - Editar um produto existente.");
                Console.WriteLine("3 - Adicionar um novo produto.");
                Console.WriteLine("4 - Criar um novo pedido.");
                Console.WriteLine("5 - Listar pedidos.");
                Console.WriteLine("6 - Visualizar pedido.");
                Console.WriteLine("0 - Encerrar sistema.");
                int novaSelecao = int.Parse(Console.ReadLine());
                selectedOption = novaSelecao;
            }

            switch (selectedOption)
            {
                case 1:
                    ExibeProdutos();
                    break;
                case 2:
                    EditaProduto();
                    break;
                case 3:
                    AdicionaProduto();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opção inválida. Clique novamente para selecionar outra opção");
                    Console.ReadLine();
                    ExibeMenu();
                    break;
            };
            
        }

        public void ExibeProdutos()
        {
            Console.Clear();
            if (listaProdutos == null || listaProdutos.Count <= 0)
            {
                Console.WriteLine("Nenhum item na lista. Deseja incluir?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int resposta = int.Parse(Console.ReadLine());

                if(resposta == 1)
                {
                    ExibeMenu(3);
                    return;
                }

                ExibeMenu();
                return;
            }

            Console.WriteLine("Lista de produtos:");
            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine(produto.ToString());
            }
            Console.WriteLine("Clique qualquer tecla para voltar");
            Console.ReadLine();
            ExibeMenu();
        }

        public void AdicionaProduto()
        {
            Console.Clear();
            Console.WriteLine("Qual o nome do produto");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Quantos produtos deseja inserir no estoque?");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do produto?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto novoProduto = new Produto(nomeProduto,valor, quantidade);

            if(listaProdutos.Contains(novoProduto))
            {
                Console.WriteLine("Produto já existe, as informações foram atualizadas");
                Produto produto = listaProdutos.Find(produto => produto.Nome.Trim().ToLower() == novoProduto.Nome.Trim().ToLower());
                produto.Quantidade += novoProduto.Quantidade;
                produto.Valor = novoProduto.Valor;
                Console.WriteLine("Clique qualquer tecla para continuar");
                Console.ReadLine();
                ExibeMenu();
                return;
            }

            listaProdutos.Add(novoProduto);
            Console.WriteLine($"Produto inserido com sucesso");
            Console.WriteLine(novoProduto.ToString());
            Console.WriteLine("Clique qualquer tecla para continuar");
            Console.ReadLine();
            ExibeMenu();
            return;
        }

        public void EditaProduto()
        {
            if (listaProdutos == null || listaProdutos.Count <= 0)
            {
                Console.WriteLine("Nenhum item na lista. Deseja incluir?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    ExibeMenu(3);
                    return;
                }

                ExibeMenu();
                return;
            }

            Console.WriteLine("Lista de produtos:");
            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine(produto.ToString());
            }
            Console.WriteLine("Digite o Id do produto que deseja editar");
            Console.ReadLine();
            ExibeMenu();
        }
    }
}
