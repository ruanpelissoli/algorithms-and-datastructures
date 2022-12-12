namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
// Hash Table
// String
// Sliding Characters
internal class LongestSubstringWithoutRepeatingCharacters : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(LongestSubstringWithoutRepeatingCharacters));
        Console.WriteLine(Solution("abcabcbb"));
        Console.WriteLine();
    }

    static int Solution(string s)
    {
        Dictionary<char, int> chars = new();

        int left = 0, right = 0;

        int res = 0;

        while (right < s.Length)
        {
            char r = s[right];
            chars[r] = chars.GetValueOrDefault(r, 0) + 1;

            while (chars[r] > 1)
            {
                char l = s[left];
                chars[l]--;
                left++;
            }

            res = Math.Max(res, right - left + 1);

            right++;
        }

        return res;
    }
}
