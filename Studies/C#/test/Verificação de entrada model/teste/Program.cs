namespace teste {
    class Program {
        static void Main(string[] args) {
            sbyte mn = ReadSbyte("sbyte: ");
            Console.WriteLine($"Você inseriu: {mn}");
        }

        static sbyte ReadSbyte(string prompt) {
            sbyte result;
            string input;
            Console.Write(prompt);
            while (true) {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || !sbyte.TryParse(input, out result)) {
                    Console.WriteLine("Número inválido. Insira um valor entre -128 e 127.");
                    Console.Write(prompt);
                } else {
                    return result;
                }
            }
        }
    }
}
