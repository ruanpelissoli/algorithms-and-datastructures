**[Two-Pointers](https://leetcode.com/articles/two-pointer-technique/)**

These kind of problems usually involve two pointers:
Onde slow-runner and the other fast-runner

A classic example is to remove duplicates from a sorted array.

There's another variant to that:
One pointer starts from the beginning while the other pointer starts from the end.
They move toward each other until they both meet. 

Let's take a look at a classic problem: reverse the characters in a string:

```csharp
public void Reverse(char[] str)
{
	int i = 0;
	int j = str.Length - 1;

	while (i < j)
	{
		(str[i], str[j]) = (str[j], str[i])
		i++;
		j--;
	}
}
```