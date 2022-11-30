namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/subarray-sum-equals-k/
// Hashtable
// Counting
// Prefix Sum
internal class SubarraySumEqualsK : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(SubarraySumEqualsK));
        Console.WriteLine(Solution(new int[] { 1, 2, 1, 2, 1 }, 3));
        Console.WriteLine();
    }

    static int Solution(int[] nums, int k)
    {
        var prefix = new Dictionary<int, int>()
        {
            { 0, 1 }
        };

        int ans = 0;
        int curr = 0;

        foreach (int n in nums)
        {
            curr += n;
            ans += prefix.GetValueOrDefault(curr - k, 0);

            if (!prefix.ContainsKey(curr))
                prefix.Add(curr, 1);
            else
                prefix[curr]++;
        }

        return ans;
    }
}
