namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/fibonacci-number/
// Recursion
// Memoization
// Dynamic Programming
internal class FibonacciNumber : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(FibonacciNumber));
        Console.WriteLine(Solution1(5));
        Console.WriteLine(Solution2(13));
        Console.WriteLine();
    }

    // Recusion
    static int Solution1(int n)
    {
        // n <= 1 return n, because we cant calculate fibonacci anymore
        if (n <= 1) return n;

        // Calculate recursively the next number, adding the two last number
        // of the fibonacci sequence
        return Solution1(n - 1) + Solution1(n - 2);
    }

    // Dynamic Programming and Memoization
    static int Solution2(int n)
    {
        // n <= 1 return n, because we cant calculate fibonacci
        if (n <= 1) return n;

        // Start a new array fib with n + 1 size
        var fib = new int[n + 1];

        // Start the first and second position with 0 and 1 respectively
        // So we can start a interation from i = 2 to calculate the previous two values
        fib[0] = 0;
        fib[1] = 1;

        // A for where i = 2 to access the last two positions
        for (int i = 2; i <= n; i++)
            // Just like the recursion call, we add the i - 1 and i - 2 values
            // and store (memoization) in fib[i]
            fib[i] = fib[i - 1] + fib[i - 2];

        // Now we know that fib[n] contains the sum of n sequence
        return fib[n];
    }
}
