using System;

namespace JogodaForca {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Jogo da forca.");

            Random random = new Random();
            int aleatorio = random.Next(0, 9);

            string[] array = new string[] { "monge", "cachorro", "ovo frito", "japonegro", "criminoso", "astralopiteco", "maratona", "arroz", "procastinar" };
            string palavraSecreta = array[aleatorio];
            char[] palavra = new char[palavraSecreta.Length];

            for (int i = 0; i < palavraSecreta.Length; i++) {
                palavra[i] = '_';
            }

            int tentativasRestantes = 10;
            bool venceu = false;

            while (tentativasRestantes > 0 && !venceu) {
                Console.WriteLine($"\nPalavra: {new string(palavra)}");
                Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
                Console.Write("Digite uma letra: ");
                char tentativa = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool acertou = false;

                for (int i = 0; i < palavraSecreta.Length; i++) {
                    if (palavraSecreta[i] == tentativa) {
                        palavra[i] = tentativa;
                        acertou = true;
                    }
                }

                if (!acertou) {
                    tentativasRestantes--;
                }
                
                if (new string(palavra) == palavraSecreta) {
                    venceu = true;
                }
            }

            if (venceu) {
                Console.WriteLine($"Parabéns! Você descobriu a palavra: {palavraSecreta}");
            }
            else {
                Console.WriteLine($"Você perdeu! A palavra era: {palavraSecreta} seu merda");
            }
        }
    }
}
