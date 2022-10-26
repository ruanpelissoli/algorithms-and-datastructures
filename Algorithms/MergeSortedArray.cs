namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/merge-sorted-array/
// Two-pointers
// Arrays are sorted in ascending order
// Store the merged array inside nums1

// nums1 length = m + n

internal class MergeSortedArray : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MergeSortedArray));
        Solution1(
            new int[] { 1, 2, 3, 0, 0, 0 }, 3,
            new int[] { 2, 5, 6 }, 3);
        Solution2(new int[] { 1, 4, 7, 20, 38 },
                  new int[] { 3, 5, 6, 17 });
        Console.WriteLine();
    }

    // Without create a new array instance
    static void Solution1(int[] nums1, int m, int[] nums2, int n)
    {
        int length = m + n;
        int j = 0;
        for (int i = m; i < length; i++)
        {
            nums1[i] = nums2[j];
            j++;
        }

        Array.Sort(nums1);

        Console.WriteLine(string.Join(" ", nums1));
    }

    // Classic two-pointer example, merge sorted array
    static void Solution2(int[] nums1, int[] nums2)
    {
        // Create a list ans to store the result
        var ans = new List<int>();

        // Start i and j pointers from zero
        int i = 0;
        int j = 0;

        // While we did not reach the end of any array
        while (i < nums1.Length && j < nums2.Length)
        {
            // If value of nums1[i] is lower the the values at nums2[j]
            if (nums1[i] < nums2[j])
            {
                // Add nums1[i] to ans and move the i to the next number
                ans.Add(nums1[i]);
                i++;
            }
            else
            // Otherwise, add nums2[j] to ans and move the j to the next number
            {
                ans.Add(nums2[j]);
                j++;
            }
        }

        // Check for nums1 exhaustion
        while (i < nums1.Length)
        {
            ans.Add(nums1[i]);
            i++;
        }

        // Check for nums2 exhaustion
        while (j < nums2.Length)
        {
            ans.Add(nums2.Length);
            j++;
        }

        Console.WriteLine(string.Join(" ", ans));
    }
}
