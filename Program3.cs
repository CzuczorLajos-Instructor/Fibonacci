namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #3: Compared to version #2Hi, value and next are fields and stepping to the next number is a no-parameter method.
 */
internal class Program3
{
    const int COUNT = 20;

    static int value = 0, next = 1;

    static void Main()
    {
        Console.WriteLine("3. programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        for (int index = 0; index < COUNT; index++, StepUp())
        {
            Console.WriteLine($"{index,2}. {value,14:N0}");
        }
    }

    // no parameters are passed as value and next are fields (static fields i.e. class-level variables)
    private static void StepUp()
    {
        int sum = value + next;
        value = next;
        next = sum;
    }
}
