namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #2: Compared to version #1, stepping to the next Fibonacci number is extracted to a separate method.
 */
internal class Program2
{
    const int COUNT = 20;

    static void Main()
    {
        Console.WriteLine("\n2. programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        int value = 0, next = 1;
        int index = 0;
        while (index < COUNT)
        {
            Console.WriteLine($"{index,2}. {value,14:N0}");
            index++;
            StepUp(ref value, ref next);
        }
    }

    // parameters are passed by reference to modify the caller's variables
    private static void StepUp(ref int value, ref int next)
    {
        int sum = value + next;
        value = next;
        next = sum;
    }
}
