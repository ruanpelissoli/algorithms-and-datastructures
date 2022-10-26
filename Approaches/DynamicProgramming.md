**[Dynamic Programming Defined](https://www.freecodecamp.org/news/demystifying-dynamic-programming-3efafb8d4296/#:~:text=Dynamic%20Programming%20Defined,example%20of%20a%20sub%2Dproblem.)**

Dynamic programming amounts to breaking down an optimization problem into simpler sub-problems, and storing the solution to each sub-problem so that each sub-problem is only solved once.
Those problems that seek the maximum or minimum solution given certain constraints, because it looks through all possible sub-problems and never recomputes the solution to any sub-problem. This guarantees correctness and efficiency, which we cannot say of most techniques used to solve or approximate algorithms. This alone makes DP special.

**Sub-problems on Sub-problems on Sub-problems**
Sub-problems are smaller versions of the original problem. In fact, sub-problems often look like a reworded version of the original problem. If formulated correctly, sub-problems build on each other in order to obtain the solution to the original problem.

Find Fibonacci value using recursion
```csharp
public int Fibonacci(int n)
{
	if (n <= 1)
		return n;
	return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

Find Fibonacci value using dynamic programming
```csharp
public int Fibonacci(int n)
{
	int[] fib = new int[n + 1];
	fib[0] = 0;
	fib[1] = 1;
	for (int i = 2; i <= n; i++)
		fib[i] = fib[i - 1] + fib[i - 2];
	return fib[n];
}
```