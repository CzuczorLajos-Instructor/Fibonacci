namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #4: Observe object oriented approach (OOP).
 * The immutable FiboUnit4 assistant class encapsulates the state and behaviour of a Fibonacci number.
 * Notice how simple OOP made the code.
 */
internal class Program4
{
    const int COUNT = 20;

    static void Main()
    {
        Console.WriteLine("4. programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        for (var fu = FiboUnit4.Start; fu.Index < COUNT; fu = fu.StepUp()) // use object as loop variable
        {
            Console.WriteLine(fu); // calls fu.ToString() implicitly
        }
    }
}
