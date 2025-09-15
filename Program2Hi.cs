namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #2Hi: Compared to version #2, for loop is used with two statement expressions in the update segment.
 */
internal class Program2Hi
{
    const int COUNT = 20;

    static void Main()
    {
        Console.WriteLine("2Hi programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        int value = 0, next = 1;
        for (int index = 0; index < COUNT; index++, StepUp(ref value, ref next)) // here, index is local to the for loop
        {
            Console.WriteLine($"{index}. {value}");
        }
    }

    private static void StepUp(ref int value, ref int next)
    {
        int sum = value + next;
        value = next;
        next = sum;
    }
}
