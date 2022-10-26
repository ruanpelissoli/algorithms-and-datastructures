namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/is-subsequence/
// Two-pointer example
// Two int variable to iterate through two arrays
internal class IsSubsequence : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(IsSubsequence));
        Console.WriteLine(Solve("abc", "ahbgdc"));
        Console.WriteLine(Solve("ace", "abcde"));
        Console.WriteLine(Solve("axc", "ahbgdc"));
        Console.WriteLine();
    }

    static bool Solve(string s, string t)
    {
        // Start two-pointer variables starting from zero
        int i = 0,
            j = 0;

        // While to check if variables reach the end of any of the arrays
        while (i < s.Length && j < t.Length)
        {
            // If s[i] char is contained in t array
            if (s[i] == t[j])
                i++; // Increment i to move the the next letter of s
            j++; // Always increment j to move to the next letter of t
        }

        // Is i == s.Length, means that all of the letters were contained in t
        return i == s.Length;
    }
}
