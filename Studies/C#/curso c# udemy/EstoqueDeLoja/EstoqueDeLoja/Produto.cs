namespace EstoqueDeLoja {
    internal class Produto {
        public string nome;
        public double valor;
        public int quantidade;

        public void DadosDoProduto() {
            Console.WriteLine($"Dados do produto: Nome: {nome}, Valor total: {valor * quantidade}, Quantidade: {quantidade}");
        }

        public void AdicionarProdutos() {
            Console.WriteLine("Deseja adicionar quantos produtos?");
            int add = int.Parse(Console.ReadLine());
            if (add < 0) {
                Console.WriteLine("A quantidade a ser adicionada não pode ser negativa.");
            }
            else {
                quantidade += add;
                DadosDoProduto();
            }
        }

        public void RemoverProdutos() {
            Console.WriteLine("Deseja remover quantos produtos?");
            int remove = int.Parse(Console.ReadLine());

            if (remove > quantidade) {
                Console.WriteLine("Quantidade de produtos menor que a quantidade à retirar.");
            } else if (remove < 0) {
                Console.WriteLine("A quantidade a ser retirada não pode ser negativa.");
            } else {
                quantidade -= remove;
                DadosDoProduto();
            }
        }
    }
}
