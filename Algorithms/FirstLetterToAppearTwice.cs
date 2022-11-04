namespace AlgorithmsAndDataStructures.Algorithms;
internal class FirstLetterToAppearTwice : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(FirstLetterToAppearTwice));
        Console.WriteLine(Solution("abccbaacz"));
        Console.WriteLine();
    }

    static char Solution(string s)
    {
        var result = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (result.Contains(s[i])) return s[i];
            result.Add(s[i]);
        }

        return default;
    }
}
