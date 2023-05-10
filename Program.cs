using AvaliacaoTecnica.Facio.CMD;

class Program
{
    static void Main(string[] args)
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
                dependenciesList.Add(Console.ReadLine());
            }
        }
        catch (Exception e) {
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
                    string dependent = Console.ReadLine();
                    dependents.Add(dependent);
                }

                dependencies.Add(dependency, dependents);
            }
            catch (Exception e) {
                Console.WriteLine($"Informações inseridas estão incorretas! \n{e}");
                return;
            }
        }

        try
        {
            var resolver = new DependencyResolver(dependencies);
            var order = resolver.GetDependencyOrder();
            Console.WriteLine("Ordem de instalação das Dependências:");
            foreach (var dependency in order)
            {
                Console.WriteLine(dependency);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
