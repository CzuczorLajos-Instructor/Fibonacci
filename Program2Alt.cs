namespace Fibonacci;

/**
 * Program to print the first some Finonacci numbers.
 * 
 * Version #2: Compared to version #2, value and next are fields and stepping to the next number is a no-parameter method.
 */
internal class Program2Alt
{
    const int COUNT = 20;
    
    static int value = 0, next = 1;

    static void Main()
    {
        Console.WriteLine("2.Alt programváltozat\n");
        Console.WriteLine($"Az első {COUNT} Fibonacci-szám:");
        int index = 0;
        while (index < COUNT)
        {
            Console.WriteLine($"{index}. {value}");
            index++;
            StepUp();
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
