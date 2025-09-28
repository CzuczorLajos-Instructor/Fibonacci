namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #1: Use primitive types and while loop.
 */
internal class Program1
{
    const int COUNT = 20; // number of Fibonacci numbers to print as a constant: immutable field, implicitly private and static

    static void Main()
    {
        Console.WriteLine("\n1. programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        int value = 0, next = 1; // the very first two Fibonacci numbers
        int index = 0;
        while (index < COUNT)
        {
            Console.WriteLine($"{index,2}. {value,14:N0}"); // interpolated string with formatting
            index++;
            int sum = value + next;
            value = next;
            next = sum;
        }
    }
}
