namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/max-consecutive-ones-iii
// Sliding window
internal class MaxConsecutiveOnesIII : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MaxConsecutiveOnesIII));
        Console.WriteLine(Solution(
            new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2));
        Console.WriteLine();
    }

    static int Solution(int[] nums, int k)
    {
        // Start the sliding window pointers
        int left = 0, right;

        // For each with the right pointer
        for (right = 0; right < nums.Length; right++)
        {
            // if the current value at right index is equals to 0,
            // Decrease the value of k (because we find a 0)
            if (nums[right] == 0) k--;

            // If k is less than zero, we reach the max amount of zeroes allowed
            // by the problem
            if (k < 0)
            {
                // If the element at the left most index is 0, we add another
                // zero to the window
                k += 1 - nums[left]; // if (nums[left] == 0) k++

                // Move the left point forward
                left++;
            }
        }

        // Return the size of the window
        return right - left;
    }
}
