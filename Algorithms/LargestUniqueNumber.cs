namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/largest-unique-number/
// Array
// Hashtable
// Sorting
internal class LargestUniqueNumber : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(LargestUniqueNumber));
        Console.WriteLine(Solution(new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 }));
        Console.WriteLine(Solution(new int[] { 9, 9, 8, 8 }));
        Console.WriteLine();
    }

    static int Solution(int[] nums)
    {
        Dictionary<int, int> count = new();

        foreach (var n in nums)
            count[n] = count.GetValueOrDefault(n, 0) + 1;

        var ans = -1;

        foreach (var kvp in count)
        {
            if (kvp.Value == 1)
                ans = Math.Max(ans, kvp.Key);
        }

        return ans;
    }
}
