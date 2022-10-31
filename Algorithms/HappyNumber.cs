namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/happy-number/
// Two-pointers
// Hash table
internal class HappyNumber : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(HappyNumber));
        Console.WriteLine(Solution(19));
        Console.WriteLine();
    }

    static bool Solution(int n)
    {
        var seen = new HashSet<int>();

        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = GetNextNumber(n);
        }

        return n == 1;
    }

    static int GetNextNumber(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int d = n % 10;
            n /= 10;
            sum += d * d;
        }

        return sum;
    }

}
