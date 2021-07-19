using System;
using System.Collections.Generic;

namespace ControleEstoque
{
    public class Shopping
    {
        List<Produto> produtos = new List<Produto>();
        public void Iniciar()
        {
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 - Cadastrar produto.");
            Console.WriteLine("2 - Listar produto.");
            Console.WriteLine("0 - Sair da aplicação.");
            string opcao = Console.ReadLine();
            switch (opcao)
            { 
                case "1":
                    CadastroDeProdutos();
                    break;
                case "2":
                    ListarProdutos();         
                    break;
                case "0":
                    return;                    
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.WriteLine("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Iniciar(); //chama a funcao novamente para fazer o loop

        }

        void CadastroDeProdutos()
        {
            Produto prod = new Produto();
            Console.WriteLine("Informe um nome para o produto: ");
            prod.Nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto: ");
            prod.Preco = Convert.ToDouble(Console.ReadLine());
            produtos.Add(prod);
            Console.WriteLine($"Produto {prod.Nome} adicionado com sucesso.");            
        }

        void ListarProdutos()
        {
            foreach (Produto p in produtos)
            {
                Console.WriteLine(p.Descricao);
            }
        }
    }
}
