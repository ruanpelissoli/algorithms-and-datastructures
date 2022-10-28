namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/valid-palindrome-ii/
// Two-pointers
internal class ValidPalindromeII : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ValidPalindromeII));
        Console.WriteLine(Solution("aba")); // true
        Console.WriteLine(Solution("abca")); // true
        Console.WriteLine(Solution("abc")); // false
        Console.WriteLine();
    }

    static bool Solution(string s)
    {
        int start = 0;
        int end = s.Length - 1;

        while (start < end)
        {
            if (s[start] != s[end])
                return CheckPalindrome(s, start, end - 1)
                    || CheckPalindrome(s, start + 1, end);

            start++;
            end--;
        }

        return true;
    }

    static bool CheckPalindrome(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j]) return false;

            i++;
            j--;
        }

        return true;
    }
}
