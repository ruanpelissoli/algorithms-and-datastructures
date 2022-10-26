namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4687/
// Two-pointers exemple
internal class MergeStringsAlternately : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MergeStringsAlternately));
        Console.WriteLine(Solution("abc", "pqr"));
        Console.WriteLine(Solution("ab", "pqrs"));
        Console.WriteLine();
    }

    static string Solution(string word1, string word2)
    {
        string ans = string.Empty;
        int i = 0,
            j = 0;

        while (i < word1.Length && j < word2.Length)
        {
            ans += word1[i].ToString() + word2[j].ToString();
            i++;
            j++;
        }

        while (i < word1.Length)
        {
            ans += word1[i];
            i++;
        }

        while (j < word2.Length)
        {
            ans += word2[j];
            j++;
        }

        return ans;
    }
}
