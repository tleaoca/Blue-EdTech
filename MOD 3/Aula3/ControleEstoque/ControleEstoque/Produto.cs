namespace ControleEstoque
{
    public class Produto
    {

        private double _preco;
        
        // atalho para criar a variavel publica, escrever "prop" e apertar tab duas vezes
        public string Nome { get; set; } 
        public double Preco { get => _preco; set => _preco = value > 0 ? value : 0; }
        public string Descricao { get => $"Nome: {Nome} - Preço R${Preco:0.00}"; }
    }
}
