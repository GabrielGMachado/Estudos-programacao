using NomeAleatorio;

class Program {
    static void Main(string[] args) {
        Triangulo x = new Triangulo();
        Triangulo y = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X:");
        x.A = ReadDouble("Medida A: ");
        x.B = ReadDouble("Medida B: ");
        x.C = ReadDouble("Medida C: ");

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        y.A = ReadDouble("Medida A: ");
        y.B = ReadDouble("Medida B: ");
        y.C = ReadDouble("Medida C: ");

        Console.WriteLine($"Triângulo X - Perímetro: {x.CalcularPerimetro()}");
        Console.WriteLine($"Triângulo X - Área: {x.CalcularArea():F2}");

        Console.WriteLine($"Triângulo Y - Perímetro: {y.CalcularPerimetro()}");
        Console.WriteLine($"Triângulo Y - Área: {y.CalcularArea():F2}");
    }

    static double ReadDouble(string prompt) {
        double result;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out result)) {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
            Console.Write(prompt);
        }
        return result;
    }
}