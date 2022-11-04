using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms;
internal class MajorityElement : IAlgorithmSolver
{
    public void Solve()
    {
        Console.WriteLine(nameof(MajorityElement));
        Console.WriteLine();
        Console.WriteLine();
    }
    
    static int Solution(int[] nums)
    {
        int majority = nums.Length / 2;
        var ans = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (ans.ContainsKey(nums[i]))
                ans[nums[i]]++;
            else
                ans.Add(nums[i], 1);

            if (ans[nums[i]] > majority)
                return nums[i];
        }

        return -1;
    }
}
