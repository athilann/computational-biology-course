using System.Collections.Generic;

namespace Server.Data.Network.Models;
public class Seed
{
    public string Name { get; set; }
    public List<Seed> Connections { get; set; }

    public Seed(string name)
    {
        Name = name;
        Connections = new List<Seed>();
    }

    internal Task Grow(Seed[] path, int pathSize)
    {
        return Task.Run(() =>
        {
            var growList = new List<Task>();
            foreach (var connection in Connections)
            {
                if (!path.Contains(connection))
                {
                    growList.Add(connection.Grow(path.Append(connection).ToArray(), pathSize));
                }
            }
            if (growList.Count == 0)
            {
                PrintName(path);
            }
            Task.WaitAll(growList.ToArray());
        });

    }

    private static void PrintName(Seed[] path)
    {
        Console.Write("Generation name:");
        foreach (Seed i in path)
        {
            Console.Write("\t{0}", i.Name);
        }
        Console.Write("\n");
    }
}

