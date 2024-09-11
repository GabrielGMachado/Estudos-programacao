using System.ComponentModel.DataAnnotations;

namespace CifradeCesar {
    class Program {
        static void Main(string[] args) {
            var validador = new Validador();
            string mensagem = validador.LerString("Digite a mensagem que deverá ser criptografada: ");
            int chave = validador.LerInt("Digite a chave de deslocamento: ");

            var cifra = new CifraDeCesar();
            string mensagemCriptografada = cifra.Criptografar(mensagem, chave);
            Console.WriteLine($"Mensagem Criptografada: {mensagemCriptografada}");

            string mensagemDescriptografada = cifra.Descriptografar(mensagemCriptografada, chave);
            Console.WriteLine($"Mensagem Descriptografada: {mensagemDescriptografada}");
        }
    }
}