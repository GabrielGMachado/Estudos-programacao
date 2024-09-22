namespace ControledeInventario {
    public class Produtos {

        private string _Nome {  get; set; } 
        private float _Preco { get; set; }
        private int _Qnt { get; set; }
        private string _Categoria { get; set; }

        public Produtos(string nome, float preco, int qnt, string categoria) {
            _Nome = nome;
            _Preco = preco;
            _Qnt = qnt;
            _Categoria = categoria;
        }

        public int Qnt {
            get { return _Qnt; }
        }

        public string Nome {
            get { return _Nome; }
        }

        public void AtualizarEstoque(int novaQnt) {
            _Qnt = novaQnt;
        }

        public override string ToString() {
            return $"Nome: {_Nome}, Preço: {_Preco}, Quantidade: {_Qnt}, Categoria: {_Categoria}";
        }
    }
}
