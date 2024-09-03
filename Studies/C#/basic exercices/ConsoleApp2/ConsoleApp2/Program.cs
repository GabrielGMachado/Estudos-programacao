/* Questão:
Desenvolva um programa que realiza as seguintes operações:

Leitura de Dados: O programa deve ler um número inteiro positivo n, que representa a quantidade de números inteiros que o usuário irá fornecer.

Entrada e Validação: O programa deve ler n números inteiros fornecidos pelo usuário e armazená-los em um array. Durante a leitura, o programa deve validar se cada entrada é um número inteiro positivo. Caso contrário, deve informar o erro e solicitar uma nova entrada.

Cálculos:

Soma e Média: Calcule a soma e a média dos n números fornecidos.
Máximo e Mínimo: Encontre o maior e o menor número no array.
Fatorial: Calcule o fatorial de cada número e armazene os resultados em um array separado.
Exibição dos Resultados:

Exiba a soma, a média, o máximo e o mínimo dos números fornecidos.
Exiba os fatoriais de cada número.
Tratamento de Exceções: O programa deve lidar com possíveis erros de conversão e entrada incorreta. */

using System;

namespace NomeAleatorio {
    class Program {
        static void Main(string[] args) {
            int n;
            Console.WriteLine("Digite um número positivo inteiro para a quantidade de valores existentes:");

            while (true) {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0) {
                    break;
                }
                else {
                    Console.WriteLine("Número inválido, tente novamente.");
                }
            }

            int[] array = new int[n];
            int[] fatoriais = new int[n];
            int soma = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++) {
                while (true) {
                    Console.Write($"Digite o {i + 1}º número positivo inteiro: ");
                    if (int.TryParse(Console.ReadLine(), out int valor) && valor > 0) {
                        array[i] = valor;
                        soma += valor;
                        if (valor > max) max = valor;
                        if (valor < min) min = valor;
                        fatoriais[i] = CalcularFatorial(valor);
                        break;
                    }
                    else {
                        Console.WriteLine("Valor inválido. Digite um número inteiro positivo.");
                    }
                }
            }
            double media = (double)soma / n;

            Console.WriteLine($"A soma dos valores é: {soma}");
            Console.WriteLine($"A média dos valores é: {media:F2}");
            Console.WriteLine($"O maior valor é: {max}");
            Console.WriteLine($"O menor valor é: {min}");

            Console.WriteLine("Fatoriais dos números fornecidos:");
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Fatorial de {array[i]} é {fatoriais[i]}");
            }
        }

        public static int CalcularFatorial(int numero) {
            if (numero == 0) return 1;
            int resultado = 1;
            for (int i = 1; i <= numero; i++) {
                resultado *= i;
            }
            return resultado;
        }
    }
}
