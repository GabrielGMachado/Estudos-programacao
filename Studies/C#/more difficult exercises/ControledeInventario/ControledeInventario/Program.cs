using ControledeInventario;

namespace ControleDeInventario {
    public class Program {
        static List<Produtos> produtos = new List<Produtos>();

        static void Main(string[] args) {

            Console.WriteLine("Bem vindo ao Sistema de controle de inventário");

            while (true) {
                MostrarMenu();

                int escolha;
                while (!int.TryParse(Console.ReadLine(), out escolha) || escolha > 5 || escolha < 1) {
                    Console.WriteLine("Numero inválido, tente novamente");
                    Console.Write("Escolha: ");
                }

                switch (escolha) {
                    case 1: Cadastrar(); break;
                    case 2: Exibir(); break;
                    case 3: Atualizar(); break;
                }

            }
        }

        static void MostrarMenu() {
            string[] opcoes = new string[] { "1. Cadastrar Produto", "2. Exibir produtos Cadastrados",
                                     "3. Atualizar o estoque", "4. Realizar vendas", "5. Exibir relatório de vendas" };

            Console.WriteLine();
            Console.WriteLine("Escolha uma das seguintes funções para realizar:");
            foreach (string opcao in opcoes) {
                Console.WriteLine(opcao);
            }
            Console.Write("Escolha: ");
        }

        static void Cadastrar() {
            string nome = ReadString("Digite o nome do produto: ");

            float preco = ReadFloat("Digite o preço do produto: ");

            int qnt = ReadInt("Digite a quantidade de produtos em estoque: ");

            string categoria = ReadString("Digite a categoria do produto: ");

            Produtos novoProduto = new Produtos(nome, preco, qnt, categoria);
            produtos.Add(novoProduto);
        }

        static void Exibir () {
            Console.WriteLine("\nProdutos cadastrados:");
            foreach (Produtos p in produtos) {
                Console.WriteLine(p);
            }
        }

        static void Atualizar() {
            string nomeProduto = ReadString("Digite o nome do produto para atualizar: ");

            Produtos produto = produtos.FirstOrDefault(p => p.Nome == nomeProduto);

            if (produto != null) {
                int mudanca = ReadInt("Digite o número (Retirar = negativo, Adicionar = positivo): ");

                if (produto.Qnt + mudanca < 0) {
                    Console.WriteLine("Erro: Não há produtos suficientes no estoque para essa retirada.");
                } else {
                    produto.AtualizarEstoque(produto.Qnt + mudanca);
                    Console.WriteLine($"Estoque atualizado! Nova quantidade de {produto.Nome}: {produto.Qnt}");
                }
            } else {
                Console.WriteLine("Produto não encontrado.");
            }
        }


        static string ReadString(string s) {
            string digitado;

            while (true) {
                Console.Write(s);
                digitado = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(digitado)) {
                    Console.WriteLine("Espaço vazio, digite novamente:");
                } else {
                    break;
                }
            }
            return digitado;
        }

        static int ReadInt(string s) {
            int result;
            Console.Write(s);
            while (!int.TryParse(Console.ReadLine(), out result)) {
                Console.WriteLine("Valor Inválido, tente novamente");
                Console.Write(s);
            }
            return result;
        }

        static float ReadFloat(string s) {
            float result;
            Console.Write(s);
            while (!float.TryParse(Console.ReadLine(), out result)) {
                Console.WriteLine("Valor Inválido, tente novamente");
                Console.Write(s);
            }
            return result;
        }

    }
}
