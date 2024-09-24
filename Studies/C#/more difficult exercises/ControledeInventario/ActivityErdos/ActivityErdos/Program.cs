using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main() {
        int caseNumber = 1;

        while (true) {
            int A = int.Parse(Console.ReadLine().Trim());
            if (A == 0)
                break;

            var artigos = new List<string>();
            for (int i = 0; i < A; i++) {
                artigos.Add(Console.ReadLine().Trim());
            }

            var resultado = CalcularNumerosErdos(artigos);

            Console.WriteLine($"Teste {caseNumber}");
            foreach (var autor in resultado.OrderBy(a => a.Item1).ThenBy(a => a.Item2)) {
                Console.WriteLine($"{autor.Item1}: {autor.Item3}");
            }
            Console.WriteLine();
            caseNumber++;
        }
    }

    static List<Tuple<string, string, string>> CalcularNumerosErdos(List<string> artigos) {
        var grafo = new Dictionary<string, HashSet<string>>();
        var autoresSet = new HashSet<string>();

        foreach (var artigo in artigos) {
            var autores = artigo.TrimEnd('.').Split(", ");
            foreach (var autor in autores) {
                if (!grafo.ContainsKey(autor))
                    grafo[autor] = new HashSet<string>();

                autoresSet.Add(autor);

                foreach (var coautor in autores) {
                    if (coautor != autor) {
                        grafo[autor].Add(coautor);
                    }
                }
            }
        }

        var numerosErdos = new Dictionary<string, int>();
        var queue = new Queue<Tuple<string, int>>();
        queue.Enqueue(new Tuple<string, int>("P. Erdos", 0));
        var visited = new HashSet<string>();

        while (queue.Count > 0) {
            var current = queue.Dequeue();
            var autor = current.Item1;
            var numero = current.Item2;

            if (visited.Contains(autor))
                continue;

            visited.Add(autor);
            numerosErdos[autor] = numero;

            foreach (var vizinho in grafo[autor]) {
                if (!visited.Contains(vizinho)) {
                    queue.Enqueue(new Tuple<string, int>(vizinho, numero + 1));
                }
            }
        }

        var resultado = new List<Tuple<string, string, string>>();
        foreach (var autor in autoresSet) {
            if (autor != "P. Erdos") {
                if (numerosErdos.TryGetValue(autor, out int erdosNumber)) {
                    resultado.Add(new Tuple<string, string, string>(autor, "", erdosNumber.ToString()));
                } else {
                    resultado.Add(new Tuple<string, string, string>(autor, "", "infinito"));
                }
            }
        }

        return resultado;
    }
}
