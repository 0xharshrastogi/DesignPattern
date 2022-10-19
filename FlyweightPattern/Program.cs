using System.Diagnostics;

using FlyweightPattern.Forest;
var treesCount = 100_000;
var threadCount = 1100;
var threads = new List<Thread>();
var forest = new Forest();
var stopwatch = Stopwatch.StartNew();

for (var index = 0; index < threadCount; index++)
{
    var thread = new Thread(() =>
    {
        for (var i = 0; i < treesCount / threadCount; i++)
            forest.PlantTree(i, i, "Tree" + i, "Color" + i, "Variant" + i);
    });

    threads.Add(thread);
}

threads.ForEach(thread => thread.Start());
threads.ForEach(thread => thread.Join());
stopwatch.Stop();

Console.WriteLine("Time Elapsed: {0}", stopwatch.ElapsedMilliseconds);
