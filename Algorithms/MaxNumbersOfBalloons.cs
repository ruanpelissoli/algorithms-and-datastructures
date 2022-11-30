namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/maximum-number-of-balloons/
// Hashtable
// String
// Counting
internal class MaxNumbersOfBalloons : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MaxNumbersOfBalloons));
        Console.WriteLine(Solution("nlaebolko"));
        Console.WriteLine(Solution("loonbalxballpoon"));
        Console.WriteLine();
    }

    static int Solution(string text)
    {
        int bCount = 0, aCount = 0, lCount = 0, oCount = 0, nCount = 0;

        foreach (var c in text)
        {
            switch (c)
            {
                case 'b':
                    bCount++; break;
                case 'a':
                    aCount++; break;
                case 'l':
                    lCount++; break;
                case 'o':
                    oCount++; break;
                case 'n':
                    nCount++; break;
            }
        }

        int count = Math.Min(bCount, aCount);
        count = Math.Min(count, lCount / 2);
        count = Math.Min(count, oCount / 2);
        count = Math.Min(count, nCount);

        return count;
    }
}
