using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    public class Autor
    {
        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public DateTime DataNascimento { get; set; }
        public string IdiomaNativo { get; set; }

        public Autor(string nomeAutor, string paisOrigemAutor, DateTime dataNascimentoAutor, string idiomaNativoAutor)
        {
            Nome = nomeAutor;
            PaisOrigem = paisOrigemAutor;
            DataNascimento = dataNascimentoAutor;
            IdiomaNativo = idiomaNativoAutor;
        }

       


    }
}