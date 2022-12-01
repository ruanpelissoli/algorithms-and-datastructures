namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/unique-number-of-occurrences/
// Array
// Hashtable
internal class UniqueNumberOfOccurrences : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(UniqueNumberOfOccurrences));
        Console.WriteLine(Solution(new int[] { 1, 2, 2, 1, 1, 3 }));
        Console.WriteLine(Solution(new int[] { 1, 2 }));
        Console.WriteLine();
    }

    static bool Solution(int[] arr)
    {
        Dictionary<int, int> count = new();

        foreach (var n in arr)
            count[n] = count.GetValueOrDefault(n, 0) + 1;

        foreach (var kvp in count)
        {
            if (count.Any(entry => entry.Key != kvp.Key && entry.Value == kvp.Value))
                return false;
        }

        return true;
    }
}
