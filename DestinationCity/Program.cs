namespace DestinationCity;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Test(solution, new List<IList<string>> {
            new List<string> { "London", "New York" },
            new List<string> { "New York", "Lima" },
            new List<string> { "Lima", "Sao Paulo" }
        }); // Output: "Sao Paulo"

            Test(solution, new List<IList<string>> {
                new List<string> { "B", "C" },
                new List<string> { "D", "B" },
                new List<string> { "C", "A" }
            }); // Output: "A"
    }

    static void Test(Solution solution, IList<IList<string>> paths)
    {
        var result = solution.DestCity(paths);
        Console.WriteLine($"[{result}]");
    }
}


public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var destinations = new HashSet<string>();
        var sources = new HashSet<string>();

        foreach (var path in paths)
        {
            sources.Add(path[0]);
            destinations.Add(path[1]);
        }

        foreach (var destination in destinations)
        {
            if (!sources.Contains(destination))
            {
                return destination;
            }
        }

        return string.Empty;
    }
}