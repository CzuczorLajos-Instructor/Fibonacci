namespace Fibonacci;

/**
 * Class representing a Fibonacci number and its position in the sequence.
 * Encapsulates the state (index, value, next) and behavior (stepping to the next number).
 * ToString() is overridden for easy printing.
 * Note that this class is immutable with constructor being private and StepUp() returning a new instance.
 */
internal class FiboUnit4
{
    internal int Index { get; private init; } // index of the Fibonacci number; no setter is present, only init
    internal int Value { get; private init; } // the Fibonacci number itself; no setter is present, only init
    private readonly int next; // the next Fibonacci number, needed also to calculate the following unit

    // private constructor to disallow external instantiation
    private FiboUnit4(int index, int value, int next)
    {
        Index = index;
        Value = value;
        this.next = next;
    }
    
    internal static FiboUnit4 Start = new(0, 0, 1); // the initial Fibonacci unit as a static variable

    // calculate values belonging to the next Fibonacci number: create new instance
    internal FiboUnit4 StepUp()
    {
        return new FiboUnit4(Index + 1, next, Value + next);
    }
    
    // overridden ToString() for easy printing
    public override string ToString()
    {
        return $"{Index,2}. {Value,14:N0}"; // fully formatted output (width plus thousand separator)
    }
}