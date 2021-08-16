using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execWindFor01
{
    class Item
    {
        public  string Nome { get; set; }
        public  int Preco { get; set; }
        public  int Quantidade { get; set; }

        public Item(string nome, int preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
