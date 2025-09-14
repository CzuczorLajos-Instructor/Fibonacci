namespace Fibonacci;

/**
 * Class representing a Fibonacci number and its position in the sequence.
 * Encapsulates the state (index, value, next) and behavior (stepping to the next number).
 * ToString() is overridden for easy printing.
 * Note that this class is mutable, unlike the FiboUnit4 class.
 */
internal class FiboUnit5
{
    internal int Index { get; private set; } // private setter to allow modification within the class
    internal int Value { get; private set; } // private setter to allow modification within the class
    private int next;
    
    private FiboUnit5(int index, int value, int next)
    {
        Index = index;
        Value = value;
        this.next = next;
    }
    
    internal static FiboUnit5 Start = new(0, 0, 1);

    // calculate values belonging to the next Fibonacci number: update the current instance
    internal void StepUp()
    {
        Index++;
        int sum = Value + next;
        Value = next;
        next = sum;
    }
    
    public override string ToString()
    {
        return $"{Index,2}. {Value,14:N0}";
    }
}