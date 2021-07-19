using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeladBasico
{
    public class SistemaPrincipal
    {
        List<Produto> produtos = new List<Produto>();
        public void Menu()
        {
            Console.WriteLine("Menu de opções:");
            Console.WriteLine("1- Cadastrar produto");
            Console.WriteLine("2- Listar produtos");
            Console.WriteLine("3- Valor total de estoque");
            Console.WriteLine("0- Sair");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break;
                case "2":
                    ListarProdutos();
                    break;
                case "3":
                    SomaValorEstoque();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        void CadastrarProduto()
        {
            Produto prod = new Produto();
            Console.WriteLine("Nome do produto: ");
            prod.Nome = Console.ReadLine();
            Console.WriteLine("Preço do produto: ");
            prod.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            prod.Quantidade = Convert.ToInt32(Console.ReadLine());
            produtos.Add(prod);
            Console.WriteLine($"Produto {prod.Nome} adicionado com sucesso.");
        }

        void ListarProdutos()
        {
            foreach (Produto prod in produtos)
            {
                Console.WriteLine(prod.Descricao);
            }
        }

        void SomaValorEstoque()
        {
            Produto prod = new Produto();
            double total = prod.Preco.Sum(x => Convert.ToInt32(x.Preco));
        }

    }
}
