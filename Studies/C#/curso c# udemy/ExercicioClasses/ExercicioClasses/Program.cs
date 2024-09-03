namespace ExercicioClasses {
    class Program {
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite as Infomações da primeira pessoa");
            p1.nome = ReadString("Nome: ");
            p1.idade = ReadInt("Idade: ");

            Console.WriteLine();

            Console.WriteLine("Digite as Infomações da segunda pessoa");
            p2.nome = ReadString("Nome: ");
            p2.idade = ReadInt("Idade: ");

            if (p1.idade > p2.idade) {
                Console.WriteLine($"Mais velho: {p1.nome}");
            } else if (p2.idade > p1.idade) {
                Console.WriteLine($"Mais velho: {p2.nome}");
            } else {
                Console.WriteLine("As idades são iguais");
            }
        }

        static string ReadString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static int ReadInt(string prompt) {
            int result;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out result)) {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
                Console.Write(prompt);
            }
            return result;
        }

    }
}
