using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/reverse-words-in-a-string-iii/
// Two-pointes
internal class ReverseWordsInAStringIII : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ReverseWordsInAStringIII));
        Console.WriteLine(Solution("Let's take LeetCode contest"));
        Console.WriteLine();
    }

    static string Solution(string s)
    {
        var words = s.Split(' ');
        var sb = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            int start = 0,
                end = words[i].Length - 1;

            var charArray = words[i].ToCharArray();

            while (start < end)
            {
                (charArray[start], charArray[end]) = (charArray[end], charArray[start]);
                start++;
                end--;
            }

            sb.Append(new string(charArray));

            if (i < words.Length - 1) sb.Append(' ');
        }

        return sb.ToString();
    }
}
