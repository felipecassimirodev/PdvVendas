using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto01
{
    class itemmm
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Quantidade { get; set; }

        public itemmm(string nome, int preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
