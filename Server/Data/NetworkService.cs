using Server.Data.Network;
using Server.Data.Network.Models;

namespace Server.Data;

public class NetworkService
{
   public Task<GraphRoot> GetNetwork()
    {
        return Task.FromResult(NetworkGenerator.Instance.CreateRandomNetwork());
    }
}