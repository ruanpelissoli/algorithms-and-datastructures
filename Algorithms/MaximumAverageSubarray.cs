namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/maximum-average-subarray-i
// Sliding window
internal class MaximumAverageSubarray : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MaximumAverageSubarray));
        Console.WriteLine(Solution(new int[] { 1, 12, -5, -6, 50, 3 }, 4));
        Console.WriteLine();
    }

    public double Solution(int[] nums, int k)
    {
        double sum = 0;

        for (int i = 0; i < k; i++)
            sum += nums[i];

        double ans = sum;

        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            ans = Math.Max(ans, sum);
        }

        return ans / k;
    }
}
