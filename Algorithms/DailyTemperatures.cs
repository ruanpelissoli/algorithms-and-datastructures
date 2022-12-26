namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/daily-temperatures/description/
// Array
// Stack
internal class DailyTemperatures : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(DailyTemperatures));
        Console.WriteLine(Solution(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }));
        Console.WriteLine();
    }

    static int[] Solution(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        Stack<int> stack = new();

        for (int currDay = 0; currDay < temperatures.Length; currDay++)
        {
            int currentTemp = temperatures[currDay];

            while (stack.Any() && temperatures[stack.Peek()] < currentTemp)
            {
                int prevDay = stack.Pop();
                answer[prevDay] = currDay - prevDay;
            }
            stack.Push(currDay);
        }

        return answer;
    }
}
