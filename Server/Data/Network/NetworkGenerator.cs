using Server.Data.Network.Models;

namespace Server.Data.Network;
public sealed class NetworkGenerator
{
    private static readonly NetworkGenerator instance = new NetworkGenerator();

    private NetworkGenerator() { }

    public static NetworkGenerator Instance
    {
        get
        {
            return instance;
        }
    }

    public GraphRoot CreateRandomNetwork()
    {
        GraphRoot root = new GraphRoot();

        root.Seeds = new List<Seed>
            {
                new Seed ("A"),
                new Seed ("B"),
                new Seed ("C"),
                new Seed ("D"),
                new Seed ("E"),
                new Seed ("F"),
            };

        // Create a Hamiltonian cycle
        for (int i = 0; i < root.Seeds.Count; i++)
        {
            root.Seeds[i].Connections.Add(root.Seeds[(i + 1) % root.Seeds.Count]);
        }

        var random = new Random();

        // Add additional edges randomly
        for (int i = 0; i < root.Seeds.Count; i++)
        {
            for (int j = i + 2; j < root.Seeds.Count; j++)
            {
                if (random.NextDouble() < 0.5)
                {
                    root.Seeds[i].Connections.Add(root.Seeds[j]);
                    root.Seeds[j].Connections.Add(root.Seeds[i]);
                }
            }
        }

        return root;
    }
}
