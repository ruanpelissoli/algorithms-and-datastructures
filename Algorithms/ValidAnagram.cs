namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/valid-anagram/
// String
// Hash Table
// Sorting
internal class ValidAnagram : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ValidAnagram));
        Console.WriteLine(Solution("anagram", "nagaram"));
        Console.WriteLine(Solution("rat", "car"));
        Console.WriteLine();
    }

    static bool Solution(string s, string t)
    {
        Dictionary<char, int> counter = new();

        foreach (char c in s)
            counter[c] = counter.GetValueOrDefault(c, 0) + 1;

        foreach (char c in t)
        {
            if (!counter.ContainsKey(c))
                return false;

            counter[c]--;
        }

        return !counter.Any(c => c.Value > 0);
    }
}
