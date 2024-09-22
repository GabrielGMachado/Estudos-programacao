namespace Funcoes{
    class Program {
        static void Main() {
            
            int soma1 = Soma(7, 3);
            Console.WriteLine(soma1);
            
            var resultado = SomaNome(7, 3);
            Console.WriteLine(resultado.Soma);
            Console.WriteLine(resultado.Nome);

            //ou

            (int soma, string nome) = SomaNome(7, 3); 
            Console.WriteLine(soma);
            Console.WriteLine(nome);
        }

        static int Soma(int v1, int v2) => v1 + v2; //função de uma linha

        static (int Soma, string Nome) SomaNome(int v1, int v2) => (v1 + v2, "Gabriel"); // Função que retorna dois valores
    }
}
