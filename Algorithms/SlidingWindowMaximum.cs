using Nito.Collections;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/sliding-window-maximum/
// Array
// Queue
// Sliding Window
// Heap (Priority Queue)
// Monotonic Queue
internal class SlidingWindowMaximum : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(SlidingWindowMaximum));
        Console.WriteLine(Solution(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums, int k)
    {
        int[] ans = new int[nums.Length - k + 1];
        Deque<int> deque = new();

        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Any() && nums[i] > nums[deque.Last()])
                deque.RemoveFromBack();

            deque.AddToBack(i);

            if (deque.First() + k == i)
                deque.RemoveFromFront();

            if (i >= k - 1)
                ans[i - k + 1] = nums[deque.First()];
        }

        return ans;
    }
}
