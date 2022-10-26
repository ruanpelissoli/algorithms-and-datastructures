namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/climbing-stairs/
// Dynamic Programming
// Memoization
// Recursion
internal class ClimbStairs : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ClimbStairs));
        Console.WriteLine(Solution1(5));
        Console.WriteLine(Solution2(5));
        Console.WriteLine(Solution3(5));
        Console.WriteLine();
    }

    // Fibonacci Number
    // Time complexity : O(n). Single loop upto nn is required to calculate n^th     th
    // fibonacci number.
    // Space complexity : O(1). Constant space is used.    
    static int Solution1(int n)
    {
        if (n == 1) return 1;

        var first = 1;
        var second = 2;
        for (int i = 3; i <= n; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }
        return second;
    }

    // Dynamic Programming
    // Time complexity : O(n). Single loop upto n.
    // Space complexity : O(n). dp array of size n is used.
    static int Solution2(int n)
    {
        if (n == 1) return 1;

        int[] dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        return dp[n];
    }

    // Recursion with Memoization
    // Time complexity : O(n). Size of recursion tree can go upto n.
    // Space complexity : O(n). The depth of recursion tree can go upto n.
    static int Solution3(int n)
    {
        int[] memo = new int[n + 1];
        return ClimbStairsHelper(0, n, memo);
    }

    static int ClimbStairsHelper(int i, int n, int[] memo)
    {
        if (i > n) return 0;
        if (i == n) return 1;
        if (memo[i] > 0) return memo[i];

        memo[i] = ClimbStairsHelper(i + 1, n, memo) + ClimbStairsHelper(i + 2, n, memo);

        return memo[i];
    }
}

