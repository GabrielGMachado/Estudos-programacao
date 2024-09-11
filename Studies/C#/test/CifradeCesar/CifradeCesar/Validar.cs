public class Validador {
    public string LerString(string prompt) {
        string resultado;
        do {
            Console.Write(prompt);
            resultado = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(resultado)) {
                Console.WriteLine("Entrada inválida. Por favor, digite algo.");
            }
        } while (string.IsNullOrEmpty(resultado));
        return resultado;
    }

    public int LerInt(string prompt) {
        int resultado;
        do {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out resultado)) {
                return resultado;
            }
            Console.WriteLine("Número inválido. Por favor, digite um número inteiro válido.");
        } while (true);
    }
}