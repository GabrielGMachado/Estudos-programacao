using System.Text;

public class CifraDeCesar {
    private const int TamanhoAlfabeto = 26;

    public string Criptografar(string mensagem, int chave) {
        return ProcessarMensagem(mensagem, chave, true);
    }

    public string Descriptografar(string mensagemCriptografada, int chave) {
        return ProcessarMensagem(mensagemCriptografada, chave, false);
    }

    private string ProcessarMensagem(string mensagem, int chave, bool criptografar) {
        var resultado = new StringBuilder();
        foreach (char c in mensagem) {
            if (char.IsLetter(c)) {
                char base_char = char.IsUpper(c) ? 'A' : 'a';
                int deslocamento = criptografar ? chave : -chave;
                char deslocado = (char)((((c - base_char) + deslocamento + TamanhoAlfabeto) % TamanhoAlfabeto) + base_char);
                resultado.Append(deslocado);
            } else {
                resultado.Append(c);
            }
        }
        return resultado.ToString();
    }
}