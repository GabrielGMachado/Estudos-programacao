using System;

namespace EnumXArray {
    class Program {
        enum dificuldade : byte { Baixa = 0, Médio = 1, Alto = 2}

        static void Main() {
            dificuldade nivel = dificuldade.Baixa;
            Console.WriteLine(nivel);

            string[] dificuldade2 = new string[] { "Baixa", "Médio", "Alto" };
            Console.WriteLine(dificuldade2[0]);
        }
    }
}

/*Enum é a melhor escolha quando há um conjunto fixo e conhecido de valores (como "Baixa", "Médio", "Alto"). 
 Ele ocupa menos memória e oferece segurança de tipo.
Array de strings é mais flexível, mas consome mais memória e não é tão seguro em termos de tipo.
Se o foco for eficiência de memória e segurança, enum é superior. Se você precisar de flexibilidade e não se importa com o uso de memória, o array de strings pode ser mais útil.*/