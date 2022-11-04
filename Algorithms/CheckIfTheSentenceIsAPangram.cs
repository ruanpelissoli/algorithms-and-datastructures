namespace AlgorithmsAndDataStructures.Algorithms;
internal class CheckIfTheSentenceIsAPangram : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(CheckIfTheSentenceIsAPangram));
        Console.WriteLine(Solution("thequickbrownfoxjumpsoverthelazydog"));
        Console.WriteLine();
    }

    static bool Solution(string sentence)
    {
        int alphabetLength = 26;
        var result = new HashSet<char>();

        for (int i = 0; i < sentence.Length; i++)
        {
            if (!result.Contains(sentence[i]))
                result.Add(sentence[i]);
        }

        return result.Count == alphabetLength;
    }
}
