namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/subarray-product-less-than-k/
// Sliding window
// Return the number os subarrays where the product of all elements in the subarray
// is strictly less than k
internal class NumSubArrayProductLessThanK : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(NumSubArrayProductLessThanK));
        Console.WriteLine(Solution(new int[] { 10, 5, 2, 6 }, 100));
        Console.WriteLine();
    }

    static int Solution(int[] nums, int k)
    {
        // Initialize variable ans which will hold the number of subarrays
        int ans = 0;

        // The left pointer
        int left = 0;

        // The current product of subarray, start with 1
        int curr = 1;

        // Initialize the right pointer as the array variable
        for (int right = 0; right < nums.Length; right++)
        {
            // Multiply the current product with the value in the right pointer
            curr *= nums[right];

            // While left pointer is less or equal than the right pointer
            // And the current product value is greater or equal than K
            while (left <= right && curr >= k)
            {
                // We divide the current product value with the value of the left pointer
                curr /= nums[left];

                // Than we move the left pointer to the right
                left++;
            }

            // Sum the subarrays in the current window using this trick:
            // right - left + 1
            ans += right - left + 1;
        }

        // Return the answer
        return ans;
    }
}
