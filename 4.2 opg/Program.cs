
using System.Diagnostics;

Stopwatch watch = new Stopwatch();
PiCalc calculator = new PiCalc();

Console.WriteLine("Started with 1 person");
watch.Start();
double numPi = calculator.Calculate(100000000);
watch.Stop();
Console.WriteLine("Done");

Console.WriteLine($"Numeric PI = {numPi:0.000000}");
Console.WriteLine($"Real PI    = {Math.PI:0.000000}");
Console.WriteLine($"Took {watch.ElapsedMilliseconds} milliSecs with 1 person");
watch.Reset();
Console.WriteLine();

Console.WriteLine("Started with 4 people");
watch.Start();
double numPi4People = calculator.CalculateWith4People(100000000);
watch.Stop();
Console.WriteLine("Done");

Console.WriteLine($"Numeric PI = {numPi4People:0.000000}");
Console.WriteLine($"Real PI    = {Math.PI:0.000000}");
Console.WriteLine($"Took {watch.ElapsedMilliseconds} milliSecs with 4 people");
Console.WriteLine();