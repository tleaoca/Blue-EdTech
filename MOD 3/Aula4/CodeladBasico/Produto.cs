using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeladBasico
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get => $"Nome: {Nome} - Preço R${Preco:0.00} - Quantidade: {Quantidade}"; }
    }
}
