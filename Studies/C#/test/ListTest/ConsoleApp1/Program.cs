namespace ListTeste {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");

            list.Remove("B");

            for (int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);
            }

            /* Ele apaga a posição, e muda a posição de todos elementos seguintes, provavelmente ocupa mais espaço de memória(pesquisar depois)
             Uma list não precisa ter a quantidade de valores definidos como um array
             */
        }
    }
}
