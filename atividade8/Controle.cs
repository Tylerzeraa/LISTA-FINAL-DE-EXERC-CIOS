using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade8
{
    public class Controle
    {
        public List<Funcionario> Funcionarios { get; set; }

        public Controle()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(string nome, int idade)
        {
            Funcionario funcionario = new Funcionario(nome, idade);
            Funcionarios.Add(funcionario);
        }

        public void AdicionarDependente(int indiceFuncionario, string nome, int idade)
        {
            Funcionario funcionario = Funcionarios[indiceFuncionario];
            funcionario.AdicionarDependente(nome, idade);
        }

        public void ListarDependentes(int indiceFuncionario)
        {
            Funcionario funcionario = Funcionarios[indiceFuncionario];
            funcionario.ListarDependentes();
        }
    }
}
