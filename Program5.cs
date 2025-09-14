namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #5: Observe object oriented approach (OOP).
 * The mutable FiboUnit5 assistant class encapsulates the state and behavior of a Fibonacci number.
 */
internal class Program5
{
    const int COUNT = 20;

    static void Main()
    {
        Console.WriteLine("5. programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        for (var fu = FiboUnit5.Start; fu.Index < COUNT; fu.StepUp())
        {
            Console.WriteLine(fu);
        }
    }
}
