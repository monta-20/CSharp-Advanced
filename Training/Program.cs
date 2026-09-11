using Training.Models;

namespace Monta;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating objects...");
        Person person = new Person("Montassar");
        Console.WriteLine($"Generation : {GC.GetGeneration(person)}");
        Console.WriteLine();
        Console.WriteLine("Forcing Gen 0 collection...");
        GC.Collect(0);
        GC.WaitForPendingFinalizers();
        Console.WriteLine($"Generation after Gen 0 GC: {GC.GetGeneration(person)}");
        Console.WriteLine();
        Console.WriteLine("Forcing full collection...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine($"Generation after full GC: {GC.GetGeneration(person)}");
        Console.WriteLine();
        Console.WriteLine("Creating temporary objects...");
        for (int i = 0; i < 100_000; i++)
        {
            var temp = new Person($"Person {i}");
        }
        Console.WriteLine($"Generation of person: {GC.GetGeneration(person)}");
        Console.WriteLine();
        Console.WriteLine("Forcing GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine($"Generation after GC: {GC.GetGeneration(person)}");
    }
}
