using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Produtos
{
    internal class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Produto(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
}

