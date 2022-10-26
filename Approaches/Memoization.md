**[What is Memoization?](https://www.freecodecamp.org/news/memoization-in-javascript-and-react/)**
In programming, memoization is an optimization technique that makes applications more efficient and hence faster. It does this by storing computation results in cache, and retrieving that same information from the cache the next time it's needed instead of computing it again.
In simpler words, it consists of storing in cache the output of a function, and making the function check if each required computation is in the cache before computing it.

Find fibonacci with memoization
```csharp
public static int Fibonacci(int n)
{
	if (n == 0 || n == 1)
		return n;

	if (memo[n] != 0)
		return memo[n];

	memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
	return memo[n];
}
```