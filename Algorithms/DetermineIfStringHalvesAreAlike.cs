namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/determine-if-string-halves-are-alike/
// String
// Counting
internal class DetermineIfStringHalvesAreAlike : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(DetermineIfStringHalvesAreAlike));
        Console.WriteLine(Solution("book"));
        Console.WriteLine(Solution("textbook"));
        Console.WriteLine();
    }

    static bool Solution(string s)
    {
        HashSet<char> vowels = new(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
        int leftCount = 0, rightCount = 0;

        int rightPivot = s.Length - 1;

        for (int leftPivot = 0; leftPivot < s.Length / 2; leftPivot++)
        {
            if (vowels.Contains(s[leftPivot])) leftCount++;
            if (vowels.Contains(s[rightPivot])) rightCount++;

            rightPivot--;
        }

        return leftCount == rightCount;
    }
}
