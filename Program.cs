using AvaliacaoTecnica.Facio.CMD;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Olá, seja bem vindo! \n" +
                      "Qualquer duvida leia o README.md, onde se ainda precisar tem o meu email. :)");
        string saida; 
        do
        {
            var dependencies = new Dictionary<string, List<string>>();
            List<string?> dependenciesList = new List<string?>();
            try
            {
                Console.Write("Quantidade de dependências: ");
                int numDependencies = int.Parse(Console.ReadLine());


                for (int i = 0; i < numDependencies; i++)
                {
                    Console.Write($"Informe a dependência {i + 1}º: ");
                    dependenciesList.Add(Console.ReadLine().ToLower());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Informações inseridas estão incorretas! \n{e}");
            }

            foreach (var dependency in dependenciesList)
            {
                try
                {
                    Console.Write($"Quantidade de dependências dependentes de {dependency}: ");
                    int numDependents = int.Parse(Console.ReadLine());

                    var dependents = new List<string>();

                    for (int j = 0; j < numDependents; j++)
                    {
                        Console.Write($"Informe a dependência dependente {j + 1} de {dependency}: ");
                        dependents.Add(Console.ReadLine().ToLower());
                    }

                    dependencies.Add(dependency, dependents);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Informações inseridas estão incorretas! \n{e}");
                    return;
                }
            }

            try
            {
                var resolver = new DependencyResolver(dependencies);
                var order = resolver.GetDependencyOrder();
                Console.WriteLine("Ordem de instalação das Dependências:");
                Console.WriteLine(" ");

                foreach (var dependency in order)
                {
                    Console.WriteLine(dependency);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nDeseja fazer outro teste? (Digite 's' para sim, ou qualquer outra tecla para sair)");
            saida = Console.ReadLine().ToLower();

            if (saida == "s")
            {
                ClearConsole();
            }
            else
            {
                Console.WriteLine("\nFim do programa! Até mais!");
            }
        } while (saida == "s");
    }

    static void ClearConsole()
    {
        Console.Clear(); // Limpa o buffer do console
        Console.SetCursorPosition(0, 0); // Define o cursor na posição (0, 0)
    }
}
