using System.Runtime.InteropServices;

Console.WriteLine("QueueLess CLI v0.1" );
Console.WriteLine($"Running on: {RuntimeInformation.FrameworkDescription}");

if(args.Length == 0)
{
    Console.WriteLine("No clinic codes provided.");
}
else
{
    Console.WriteLine($"Clinic codes provided: {string.Join(", ", args)}");
}