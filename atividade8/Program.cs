using Atividade8;

class Program
{
    static void Main(string[] args)
    {
        Controle controle = new Controle();

        
        controle.AdicionarFuncionario("João", 30);
        controle.AdicionarFuncionario("Maria", 35);

       
        controle.AdicionarDependente(0, "Pedro", 5);
        controle.AdicionarDependente(0, "Paula", 3);
        controle.AdicionarDependente(1, "Carlos", 10);
        controle.AdicionarDependente(1, "Ana", 7);

       
        controle.ListarDependentes(0);
        Console.WriteLine();
        controle.ListarDependentes(1);
    }
}
