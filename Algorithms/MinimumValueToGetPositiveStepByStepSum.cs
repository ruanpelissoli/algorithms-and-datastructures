namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
// Prefix Sum
internal class MinimumValueToGetPositiveStepByStepSum : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MinimumValueToGetPositiveStepByStepSum));
        Console.WriteLine(Solution(new int[] { -3, 2, -3, 4, 2 }));
        Console.WriteLine(Solution2(new int[] { -3, 2, -3, 4, 2 }));
        Console.WriteLine();
    }

    static int Solution(int[] nums)
    {
        int startValue = 1;
        int sum = startValue;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum < 1)
            {
                startValue++;
                sum = startValue;
                i = -1;
            }
        }

        return startValue;
    }

    static int Solution2(int[] nums)
    {
        // We use "total" for current step-by-step total, "minVal" for minimum 
        // step-by-step total among all sums. Since we always start with 
        // startValue = 0, therefore the initial current step-by-step total is 0, 
        // thus we set "total" and "minVal" be 0. 
        int minVal = 0;
        int total = 0;

        // Iterate over the array and get the minimum step-by-step total.
        foreach (int num in nums)
        {

            total += num;
            minVal = Math.Min(minVal, total);
        }

        // We have to let the minimum step-by-step total equals to 1, 
        // by increasing the startValue from 0 to -minVal + 1, 
        // which is just the minimum startValue we want.
        return -minVal + 1;
    }
}
