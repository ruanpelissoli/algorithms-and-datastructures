namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/count-number-of-nice-subarrays/
// Hashtable
// Counting
internal class CountNumberOfNiceSubarrays : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(CountNumberOfNiceSubarrays));
        Console.WriteLine(Solution(new int[] { 1, 1, 2, 1, 1 }, 3));
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
            curr += n % 2;
            ans += prefix.GetValueOrDefault(curr - k, 0);

            if (!prefix.ContainsKey(curr))
                prefix.Add(curr, 1);
            else
                prefix[curr]++;
        }

        return ans;
    }
}
