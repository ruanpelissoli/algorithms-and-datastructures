namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/find-players-with-zero-or-one-losses/
// Array
// Hashtable
// Sorting
// Counting
internal class FindPlayersWithZeroOrOneLosses : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(FindPlayersWithZeroOrOneLosses));
        Solution(new int[][] {
            new[] { 1, 3 },
            new[] { 2, 3 },
            new[] { 3, 6 },
            new[] { 5, 6 },
            new[] { 5, 7 },
            new[] { 4, 5 },
            new[] { 4, 8 },
            new[] { 4, 9 },
            new[] { 10, 4 },
            new[] { 10, 9 }
        });
        Console.WriteLine();
    }

    static IList<IList<int>> Solution(int[][] matches)
    {
        SortedDictionary<int, int> count = new();

        foreach (var match in matches)
        {
            count[match[0]] = count.GetValueOrDefault(match[0], 0);
            count[match[1]] = count.GetValueOrDefault(match[1], 0) + 1;
        }

        List<IList<int>> ans = new(2)
        {
            new List<int>(),
            new List<int>()
        };

        foreach (var kvp in count)
        {
            if (kvp.Value == 0)
                ans[0].Add(kvp.Key);
            else if (kvp.Value == 1)
                ans[1].Add(kvp.Key);
        }

        return ans;
    }
}
