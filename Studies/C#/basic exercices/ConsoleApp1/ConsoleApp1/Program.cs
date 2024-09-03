// Soma de Números: Crie um programa que receba dois números inteiros e exiba a soma deles.
// Média de Três Números: Escreva um programa que calcule a média de três números fornecidos pelo usuário.
// Conversão de Temperatura: Construa um programa que converta uma temperatura de Celsius para Fahrenheit.
// Área de um Círculo: Implemente um programa que calcule a área de um círculo com base no raio fornecido pelo usuário.
// Fatorial de um Número: Escreva um programa que calcule o fatorial de um número inteiro positivo.

namespace estruturabasica {
    class Program {
        static void Main(String[] args) {
            /* 1) int n1 = int.Parse(Console.ReadLine());
             int n2 = int.Parse(Console.ReadLine());

             int result = n1 + n2;
             Console.WriteLine(result); */

            /* 2) int[] valores = new int[3];
            double result = 0;
            for (int i = 0; i < valores.Length; i++) {
                valores[i] = int.Parse(Console.ReadLine());
                result += valores[i];
            }

            result /= 3;
            Console.WriteLine(result); */

            /* 3) float cel = float.Parse(Console.ReadLine());
            double fah = cel * 1.8 + 32;

            Console.WriteLine($"{fah:F2}"); */

            /* 4)double raio = double.Parse(Console.ReadLine());
            double area = double.Pi * (raio * raio); 
            Console.WriteLine($"{area:F2}"); */

            /* 5)int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i < n + 1; i++) {
                result *= i;
            }

            Console.WriteLine(result); */
        }
    }
}

// Imprimir Números de 1 a 10: Escreva um programa que use um loop for para imprimir os números de 1 a 10.
// Soma de Números Pares: Crie um programa que some todos os números pares de 1 a 100 usando um loop for.
// Tabuada: Escreva um programa que exiba a tabuada de um número escolhido pelo usuário, utilizando um loop for.
// Números Primos: Implemente um programa que identifique e exiba todos os números primos entre 1 e 50 usando um loop for.
// Potências de 2: Crie um programa que exiba as potências de 2, de 2^1 até 2^10, usando um loop for.

namespace nomealeatorio {
    class Program2 {
        static void Main(string[] args) {
            for (int i = 1; i < 10; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
