using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto01
{
    class Valor1
    {
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int Quantidade { get; set; }

        public Valor1(string nome, string preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Valor1()
        {
        }
    }
}
