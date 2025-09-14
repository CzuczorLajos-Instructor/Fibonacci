namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Baseline version using primitive types and while loop.
 */
internal class Program1
{
    const int COUNT = 20; // number of Fibonacci numbers to print as a constant: immutable field, implicitly private and static

    static void Main()
    {
        Console.WriteLine("1. programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        int value = 0, next = 1; // the very first two Fibonacci numbers
        int index = 0;
        while (index < COUNT)
        {
            Console.WriteLine($"{index}. {value}"); // interpolated string with no special formatting
            index++;
            int sum = value + next;
            value = next;
            next = sum;
        }
    }
}
