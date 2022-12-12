namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/ransom-note/description/
// Hash Table
// String
// Counting
internal class RansomNote : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(RansomNote));
        Console.WriteLine(Solution("a", "b"));
        Console.WriteLine(Solution("aa", "aab"));
        Console.WriteLine();
    }

    static bool Solution(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length)
            return false;

        Dictionary<char, int> magazineCounts = new();

        foreach (var c in magazine)
            magazineCounts[c] = magazineCounts.GetValueOrDefault(c, 0) + 1;

        foreach (var c in ransomNote)
        {
            int countInMagazine = magazineCounts.GetValueOrDefault(c, 0);

            if (countInMagazine == 0) return false;

            magazineCounts[c] = countInMagazine - 1;
        }

        return true;
    }
}
