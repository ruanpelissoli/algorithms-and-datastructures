namespace AlgorithmsAndDataStructures.Algorithms;

internal class PairsWithSumK : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(PairsWithSumK));
        Console.WriteLine(Solution(new int[] { 1, 2, 3, 4, 5 }, 5));
        Console.WriteLine();
    }

    static int Solution(int[] nums, int k)
    {
        int pairs = 0;
        int start = 0;
        int end = nums.Length - 1;

        Array.Sort(nums);

        while (start < end)
        {
            if (nums[start] + nums[end] < k) start++;
            else if (nums[start] + nums[end] > k) end--;
            else
            {
                pairs++;
                start++;
                end--;
            }
        }

        return pairs;
    }
}