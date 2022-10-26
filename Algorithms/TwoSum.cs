namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/two-sum/
// Classic two pointer algorithm if array is sorted
// Array is not sorted, so we cant use pointers starting from start to end
// If we sort the array, we lost track of the indexes needed to return as output
// Hash table (dictionary)
internal class TwoSum : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(TwoSum));
        Console.WriteLine(
            string.Join(" ", Solution(new int[] { 1, 2, 4, 6, 8, 9, 14, 15 }, 13)));
        Console.WriteLine(
            string.Join(" ", Solution(new int[] { 3, 2, 4 }, 6)));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums, int target)
    {
        // We will use hash table for O(1) lookup
        // Storing the index value as Key, and the index key as Value
        var result = new Dictionary<int, int>();

        // Single iteration into input array
        for (int i = 0; i < nums.Length; i++)
        {
            // We check if element complement (target - nums[i]) exists in the table
            int complement = target - nums[i];

            // If contains, we return the current elements index and its complmement index
            if (result.ContainsKey(complement))
                return new int[2] { result[complement], i };
            // Check for duplicate key
            else if (!result.ContainsKey(nums[i]))
                // Then we add the nums[i] value as Key, and i index as Value to the table
                result.Add(nums[i], i);
        }

        return new int[2] { -1, -1 };
    }
}
