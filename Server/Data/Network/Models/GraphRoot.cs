using System.Collections.Generic;

namespace Server.Data.Network.Models;
public class GraphRoot
{
    public static bool IsGrowing { get; set; }
    public List<Seed> Seeds { get; set; }

    public GraphRoot()
    {
        Seeds = new List<Seed>();
    }

    public Task Grow()
    {
        return Task.Run(()=>
        { 
            var growList = new List<Task>();
            foreach (var seed in Seeds)
            {
                growList.Add(seed.Grow(new Seed[]{seed}, Seeds.Count));
            }
        //    var seed = Seeds.FirstOrDefault();
        //    growList.Add(seed.Grow(new Seed[]{seed}, Seeds.Count));
           Task.WaitAll(growList.ToArray());
        }); 
    }


}