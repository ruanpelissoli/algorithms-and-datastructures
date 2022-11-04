namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/reverse-vowels-of-a-string/
// Two-pointers
internal class ReverseVowelsOfAString : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(ReverseVowelsOfAString));
        Console.WriteLine(Solution("leetcode"));
        Console.WriteLine();
    }

    static string Solution(string s)
    {
        int start = 0,
            end = s.Length - 1;

        var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        var charArr = s.ToCharArray();

        while (start < end)
        {
            while (start < s.Length && !vowels.Contains(charArr[start])) start++;
            while (end >= 0 && !vowels.Contains(charArr[end])) end--;

            if (start < end)
                (charArr[start], charArr[end]) = (charArr[end], charArr[start]);

            start++;
            end--;
        }

        return new string(charArr);
    }
}
