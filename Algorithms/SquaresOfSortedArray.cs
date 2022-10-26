namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/squares-of-a-sorted-array/
// Array is ordered in non-decreasing order
// Two-pointer approach
internal class SquaresOfSortedArray : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(SquaresOfSortedArray));
        Console.WriteLine(
           string.Join(" ", Solution1(new int[] { -4, -1, 0, 3, 10 })));
        Console.WriteLine(
           string.Join(" ", Solution2(new int[] { -4, -1, 0, 3, 10 })));
        Console.WriteLine();
    }

    static int[] Solution1(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int n = nums[i] < 0 ? nums[i] * -1 : nums[i];
            nums[i] = n * n;
        }

        Array.Sort(nums);

        return nums;
    }

    // Two pointer
    static int[] Solution2(int[] nums)
    {
        // Create a new array to store result with the size of nums
        int[] result = new int[nums.Length];

        // Create two points variables, left and right. Where rigth begins from the end
        int left = 0;
        int right = nums.Length - 1;

        // Iterate the nums array backwards, i = right; i >= 0; i--
        for (int i = right; i >= 0; i--)
        {
            // Square variable to store the value that we need to square
            int square;
            // If math.abs(left) is lower than math.abs(right)
            // This is how we create the new array already sorted
            // The input array must be sorted for this to work
            if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
            {
                // Set the square variable to nums[right]
                square = nums[right];
                // Move the right pointer to the left
                right--;
            }
            else
            {
                // Set the square variable to nums[left]
                square = nums[left];
                // Move the left pointer to the right
                left++;
            }
            // Store the square result at result[i]
            result[i] = square * square;
        }
        // Return ordered array with numbers squared
        return result;
    }
}
