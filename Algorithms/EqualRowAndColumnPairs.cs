using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms;

// https://leetcode.com/problems/equal-row-and-column-pairs/
// Array
// Hash Table
// Matrix
// Simulation
internal class EqualRowAndColumnPairs : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(EqualRowAndColumnPairs));
        Console.WriteLine(Solution(new int[][]
        {
            new int[] { 3, 2, 1 },
            new int[] { 1, 7, 6 },
            new int[] { 2, 7, 7 }
        }));
        Console.WriteLine(Solution(new int[][]
        {
            new int[] { 3, 1, 2, 2 },
            new int[] { 1, 4, 4, 5 },
            new int[] { 2, 4, 2, 2 },
            new int[] { 2, 4, 2, 2 }
        }));
        Console.WriteLine(Solution(new int[][]
{
            new int[] { 11, 1 },
            new int[] { 1, 11 },
}));
        Console.WriteLine();
    }

    static int Solution(int[][] grid)
    {
        Dictionary<string, int> rows = new();
        Dictionary<string, int> columns = new();

        StringBuilder
            rowKey = new(),
            columnKey = new();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                columnKey.Append(grid[j][i]);
                columnKey.Append(',');

                rowKey.Append(grid[i][j]);
                rowKey.Append(',');
            }

            var rowKeyString = rowKey.ToString();
            var columnKeyString = columnKey.ToString();

            rows[rowKeyString] = rows.GetValueOrDefault(rowKeyString, 0) + 1;
            columns[columnKeyString] = columns.GetValueOrDefault(columnKeyString, 0) + 1;

            columnKey.Clear();
            rowKey.Clear();
        }

        var ans = 0;

        foreach (var kvp in rows)
        {
            ans += kvp.Value * columns.GetValueOrDefault(kvp.Key, 0);
        }

        return ans;
    }
}
