namespace ExerciciosClasses2 {
    class Program {
        static void Main(string[] args) {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Digite as informações do primeiro funcionario");
            f1.nome = ReadString("Nome: ");
            f1.salario = ReadFloat("salario: ");

            Console.WriteLine("Digite as informações do segundo funcionario");
            f2.nome = ReadString("Nome: ");
            f2.salario = ReadFloat("salario: ");

            float media = (f1.salario + f2.salario) / 2;

            Console.WriteLine($"O salario médio dos funcionarios é: {media:F2}");
        }

        static string ReadString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static float ReadFloat(string prompt) {
            float result;
            Console.Write(prompt);
            while (!float.TryParse(Console.ReadLine(), out result) && result < 0) {
                Console.Write("Entrada invalida, tente novamente");
                Console.Write(prompt);
            }
            return result;
        }
    }
}
