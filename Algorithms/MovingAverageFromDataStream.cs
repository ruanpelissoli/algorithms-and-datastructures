namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/moving-average-from-data-stream/description/
// Queue
internal class MovingAverageFromDataStream : IAlgorithmSolver
{
    double Sum = 0;
    int Size = 0;
    Queue<double> queue = new Queue<double>();

    public void Solve()
    {
        Console.WriteLine(nameof(MovingAverageFromDataStream));

        MovingAverage(3);

        Console.WriteLine();
        Console.WriteLine();
    }

    void MovingAverage(int size)
    {
        Size = size;
    }

    double Next(int val)
    {
        Sum += val;
        queue.Enqueue(val);

        while (queue.Count > Size)
            Sum -= queue.Dequeue();

        return Sum / (queue.Count == Size ? Size : queue.Count);
    }
}
