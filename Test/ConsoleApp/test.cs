using System;
using System.Collections.Generic;

class Node
{
    public string Name { get; set; } = string.Empty;
    public List<Node> Connections { get; set; } = new List<Node>();
}

class Test
{
    static void Main()
    {
        var nodes = new List<Node>
        {
            new Node { Name = "A" },
            new Node { Name = "B" },
            new Node { Name = "C" },
            new Node { Name = "D" },
            new Node { Name = "E" },
            new Node { Name = "F" },
        };

        // Create a Hamiltonian cycle
        for (int i = 0; i < nodes.Count; i++)
        {
            nodes[i].Connections.Add(nodes[(i + 1) % nodes.Count]);
        }

        var random = new Random();

        // Add additional edges randomly
        for (int i = 0; i < nodes.Count; i++)
        {
            for (int j = i + 2; j < nodes.Count; j++)
            {
                if (random.NextDouble() < 0.5)
                {
                    nodes[i].Connections.Add(nodes[j]);
                    nodes[j].Connections.Add(nodes[i]);
                }
            }
        }
    }
}