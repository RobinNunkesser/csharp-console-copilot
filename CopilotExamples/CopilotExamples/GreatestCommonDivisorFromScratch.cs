namespace CopilotExamples;

public class GreatestCommonDivisorFromScratch
{
    /// <summary>
    /// Provides various mathematical utility functions
    /// </summary>
    public class MathUtilities
    {
        /// <summary>
        /// Computes the greatest common divisor of two positive integers
        /// </summary>
        /// <param name="a">First positive integer</param>
        /// <param name="b">Second positive integer</param>
        /// <returns>The greatest common divisor of a and b</returns>
        /// <exception cref="ArgumentException">Thrown when either input is not a positive integer</exception>
        public static int GreatestCommonDivisor(int a, int b)
        {
            // Validate inputs
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Both inputs must be positive integers");
            }

            // Using the Euclidean algorithm
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
        
            return a;
        }
    }
}