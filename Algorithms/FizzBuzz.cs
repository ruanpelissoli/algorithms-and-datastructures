namespace AlgorithmsAndDataStructures.Algorithms;

// https://algolab.so/courses/algorithms-and-data-structure-video-course/lectures/43998975
internal class FizzBuzz : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(FizzBuzz));
        Console.WriteLine(Solution(5));
        Console.WriteLine();
    }

    static string[] Solution(int n)
    {
        var answer = new string[n];

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                answer[i - 1] = "FizzBuzz";
            else if (i % 3 == 0)
                answer[i - 1] = "Fizz";
            else if (i % 5 == 0)
                answer[i - 1] = "Buzz";
            else
                answer[i - 1] = i.ToString();
        }

        return answer;
    }
}
