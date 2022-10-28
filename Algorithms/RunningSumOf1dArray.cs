namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/running-sum-of-1d-array/
// Prefix Sum
internal class RunningSumOf1dArray : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(RunningSumOf1dArray));
        Console.WriteLine(Solution(new int[] { 3, 1, 2, 10, 1 }));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums)
    {
        var prefix = new int[nums.Length];
        prefix[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
            prefix[i] = nums[i] + prefix[i - 1];

        return prefix;
    }
}
