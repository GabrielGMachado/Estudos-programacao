namespace EstoqueDeLoja {
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto();

            Console.WriteLine("Digite os seguintes valores de estoque:");
             p1.nome = ReadString("Digite o nome: ");
             p1.valor = ReadDouble("Digite o valor: ");
             p1.quantidade = ReadInt("Digite a quantidade: ");

            p1.DadosDoProduto();

            Console.WriteLine();
            while (true) {
                Console.WriteLine("Deseja adicionar ou remover algum produto?");
                Console.WriteLine("1. Adicionar\n2. Remover\n3. Visualizar\n4. Sair");
                Console.Write("Escolha: "); int escolha = int.Parse(Console.ReadLine());

                switch (escolha) {
                    case 1:
                        p1.AdicionarProdutos();
                        break;
                    case 2:
                        p1.RemoverProdutos();
                        break;
                    case 3:
                        p1.DadosDoProduto();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Numero invalido, Tente novamente");
                        break;
                }
            }
        }

        static string ReadString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static double ReadDouble(string prompt) {
            double result;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out result) || result < 0) {
                Console.WriteLine("Entrada invalida, tente novamente...");
                Console.Write(prompt);
            }
            return result;
        }

        static int ReadInt(string prompt) { 
            int result;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out result) || (result < 0)) {
                Console.WriteLine("Entrada invalida, tente novamente...");
                Console.Write(prompt);
            }
            return result;
        }
    }
}
