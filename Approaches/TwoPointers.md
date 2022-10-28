﻿**[Two-Pointers](https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4501/)**

Two-pointers is an extremely common technique used to solve array and string problems. It involves having two integer variables that both move along an iterable. In this article, we are focusing on arrays and strings. This means we will have two integers, usually named something like i and j, or left and right which each represent an index of the array or string.

There are several ways to implement two-pointers. To start, let's look at the following method:

Start one pointer at the first index 0 and the other pointer at the last index input.length - 1.
Use a while loop until the pointers are equal to each other.
At each iteration of the loop, move the pointers towards each other. This means either increment the pointer that started at the first index, decrement the pointer that started at the last index, or both. Deciding which pointers to move will depend on the problem we are trying to solve.
Here's some pseudocode illustrating the concept:

```function fn(arr):
    left = 0
    right = arr.length - 1

    while left < right:
        Do some logic here depending on the problem
        Do some more logic here to decide on one of the following:
            1. left++
            2. right--
            3. Both left++ and right--```

The strength of this technique is that we will never have more than O(n)O(n) iterations for the while loop. Therefore, if we can keep the work inside each iteration at O(1)O(1), this technique will result in a linear runtime. Let's look at some examples.