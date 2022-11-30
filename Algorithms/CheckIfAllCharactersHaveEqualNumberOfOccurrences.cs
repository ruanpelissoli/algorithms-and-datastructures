namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
// Hashtable
// Counting
internal class CheckIfAllCharactersHaveEqualNumberOfOccurrences : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(CheckIfAllCharactersHaveEqualNumberOfOccurrences));
        Console.WriteLine(Solution("abacbc")); // Output: true
        Console.WriteLine(Solution("aaabb")); // Output: false
        Console.WriteLine();
    }

    static bool Solution(string s)
    {
        var count = new Dictionary<char, int>();
        var set = new HashSet<int>();

        foreach (char c in s)
        {
            if (!count.ContainsKey(c))
                count.Add(c, 1);
            else
                count[c]++;
        }

        foreach (var kvp in count)
            set.Add(kvp.Value);

        return set.Count == 1;
    }
}
