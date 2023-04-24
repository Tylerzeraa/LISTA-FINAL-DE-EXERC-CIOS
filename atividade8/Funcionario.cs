using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Dependente> Dependentes { get; set; }

        public Funcionario(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Dependentes = new List<Dependente>();
        }

        public void AdicionarDependente(string nome, int idade)
        {
            Dependente dependente = new Dependente(nome, idade);
            Dependentes.Add(dependente);
        }

        public void ListarDependentes()
        {
            Console.WriteLine("Dependentes do funcionário " + Nome + ":");
            foreach (Dependente dependente in Dependentes)
            {
                Console.WriteLine(dependente.Nome + " - " + dependente.Idade + " anos");
            }
        }
    }
}
