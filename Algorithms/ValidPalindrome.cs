using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/valid-palindrome/
// Two-pointer
internal class ValidPalindrome : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ValidPalindrome));
        Console.WriteLine(Solution("A man, a plan, a canal: Panama"));
        Console.WriteLine();
    }

    static bool Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return true;

        StringBuilder sb = new();

        foreach (char c in s.ToLower())
        {
            if (char.IsLetterOrDigit(c))
                sb.Append(c);
        }

        for (int i = 0; i < sb.Length / 2; i++)
        {
            if (sb[i] != sb[sb.Length - 1 - i])
                return false;
        }

        return true;
    }
}
