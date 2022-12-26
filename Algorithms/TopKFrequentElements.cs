namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/top-k-frequent-elements/
// Array
// Hash Table
// Sorting
// Heap (Priority Queue)
// Quickselect
internal class TopKFrequentElements : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(TopKFrequentElements));
        Console.WriteLine(Solution(new int[] { 1, 1, 1, 2, 2, 3 }, 2));
        Console.WriteLine();
    }

    static int[] Solution(int[] nums, int k)
    {
        Dictionary<int, int> counter = new();

        Array.Sort(nums);

        foreach (int n in nums)
            counter[n] = counter.GetValueOrDefault(n, 0) + 1;

        var t = counter.OrderByDescending(i => i.Value)
            .Take(k)
            .Select(d => d.Key).ToArray();

        return t;
    }
}
