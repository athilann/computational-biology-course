// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



GraphRoot root = new GraphRoot();
Seed seedA = new Seed("A");
Seed seedB = new Seed("B");
Seed seedC = new Seed("C");
Seed seedD = new Seed("D");
Seed seedE = new Seed("E");
Seed seedF = new Seed("F");


seedA.Connections.Add(seedB);
seedA.Connections.Add(seedC);
seedA.Connections.Add(seedF);

seedB.Connections.Add(seedA);
seedB.Connections.Add(seedC);
seedB.Connections.Add(seedD);

seedC.Connections.Add(seedA);
seedC.Connections.Add(seedB);
seedC.Connections.Add(seedD);
seedC.Connections.Add(seedF);

seedD.Connections.Add(seedB);
seedD.Connections.Add(seedC);
seedD.Connections.Add(seedF);
seedD.Connections.Add(seedE);

seedE.Connections.Add(seedD);
seedE.Connections.Add(seedF);

seedF.Connections.Add(seedA);
seedF.Connections.Add(seedC);
seedF.Connections.Add(seedD);
seedF.Connections.Add(seedE);

root.Seeds.Add(seedA);
root.Seeds.Add(seedB);
root.Seeds.Add(seedC);
root.Seeds.Add(seedD);
root.Seeds.Add(seedE);
root.Seeds.Add(seedF);


root.Grow().Wait();


