namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/next-greater-element-i/description/
// Array
// Hash Table
// Stack
// Monotonic Stack
internal class NextGreaterElementI : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(NextGreaterElementI));
        Console.WriteLine(Solution(
            new int[] { 4, 1, 2 },
            new int[] { 1, 3, 4, 2 }));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums1, int[] nums2)
    {
        Stack<int> stack = new();
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums2.Length; i++)
        {
            while (stack.Any() && nums2[i] > stack.Peek())
                dict.Add(stack.Pop(), nums2[i]);

            stack.Push(nums2[i]);
        }

        while (stack.Any())
            dict.Add(stack.Pop(), -1);

        int[] res = new int[nums1.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            res[i] = dict[nums1[i]];
        }

        return res;
    }
}
