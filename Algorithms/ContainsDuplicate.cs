namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/contains-duplicate/
// Array
// Hash Table
// Sorting
internal class ContainsDuplicate : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ContainsDuplicate));
        Console.WriteLine(Solution(new int[] { 1, 2, 3, 1 }));
        Console.WriteLine(Solution(new int[] { 1, 2, 3, 4 }));
        Console.WriteLine(Solution(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        Console.WriteLine();
    }

    static bool Solution(int[] nums)
    {
        HashSet<int> counter = new();

        foreach (var n in nums)
        {
            if (counter.Contains(n))
                return true;

            counter.Add(n);
        }

        return false;
    }
}
