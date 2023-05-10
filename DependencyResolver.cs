namespace AvaliacaoTecnica.Facio.CMD;

public class DependencyResolver
{
    private Dictionary<string, List<string>> _dependencies;

    public DependencyResolver(Dictionary<string, List<string>> dependencies)
    {
        _dependencies = dependencies;
    }

    public List<string> GetDependencyOrder()
    {
        var visited = new List<string>();
        var order = new List<string>();

        foreach (var dependency in _dependencies.Keys)
        {
            if (!visited.Contains(dependency))
                DFS(dependency, visited, order);
        }

        return order;
    }

    private void DFS(string dependency, List<string> visited, List<string> order)
    {
        visited.Add(dependency);

        if (_dependencies.ContainsKey(dependency))
        {
            foreach (var dependent in _dependencies[dependency])
            {
                if (!visited.Contains(dependent))
                    DFS(dependent, visited, order);
            }
        }

        order.Add(dependency);
    }
}
