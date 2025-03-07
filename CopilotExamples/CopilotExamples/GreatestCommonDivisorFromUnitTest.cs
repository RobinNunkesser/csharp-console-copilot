namespace CopilotExamples;

/// <summary>
/// Class for calculating the greatest common divisor (GCD) of two integers.
/// </summary>
public class GreatestCommonDivisorFromUnitTest
{
    /// <summary>
    /// Calculates the GCD of two numbers using Euclidean algorithm.
    /// </summary>
    /// <param name="a">First integer</param>
    /// <param name="b">Second integer</param>
    /// <returns>Greatest common divisor of a and b</returns>
    public static int Calculate(int a, int b)
    {
        // Ensure we work with absolute values
        a = Math.Abs(a);
        b = Math.Abs(b);
        
        // Base case
        if (b == 0)
            return a;
            
        // Recursive case using Euclidean algorithm
        return Calculate(b, a % b);
    }
}
