**Big O Notation:**
How does the number of steps change as the data increases?

Reading data from an array, one step: O(1)
It means that an algorithm takes the same number of steps no matter how much data there is.
Other examples: delete and insertion at the end of the array

Linear search, the process of searching an array for a particular value: O(n)
In worst-case scenario, linear search will take as many steps as there are elements in the array.
In case that the value we are searching for is in the first position, the best-case scenario is O(1), but Big O Notation always refers to the worst-case unless asked otherwise.

Constant time vs Linear time:

O(n) is known as linear time, because for every aditional piece of data, the algorithm take one additional step.

O(1) is referred as constant time, because the steps in the algorithm remains constant no matter how much data there is.

Binary search is not O(1) because the number of steps increses as the data increases. It also does not fit into the O(n) category since the number of steps is much fewer than the number os elements.
Binarty search falls somewhere between O(1) and O(n).

O(log n)
It increses one step each time the data is doubled.

So far, sorted from most effient to less efficient:

- O(1)
- O(log n)
- O(n)

Logarithms:
Logarithms are the inverse of exponents. What exponents are?
2³ is equivalent of:
2 \* 2 \* 2
which happens to be 8.

Now log² 8 is the converse of the above. It means: how many times do you have to multiply 2 by itself to get a result of 8?
Since you have to multiply 2 by itself 3 times to get 8, log² 8 = 3.
Another example, 2^6 translates to:
2 \* 2 \* 2 \* 2 \* 2 \* 2 = 64
Since we had to multiply 2 by itself 6 times to get 64, log² 64 = 6

Another way of explaining log² 8 is: if we kept dividing 8 by 2 until we ended up with 1, how many 2s would we have in the equation?
8 / 2 / 2 / = 1
In other words, how many times do we need to divede 8 by 2 until we end up with 1? In this example, it takes 3 times, therefore log² 8 = 3.

O(log n) means that for N data elements, the algorithm would take log² N steps. If there are eight elements, the algorithm would take three steps, since log² 8 = 3.
Said another way, if we keep dividing the eight elements in half, it would take us three steps until we end up with one element.
At calculator: log(8)/log(2) = 3

O(log n) means that the algorithm takes as many steps as it takes to keep halving the data elements until we remain with one.

O(n²) are functions with nested loops, because we perform an outr loop that must iterante Ntimes to get through the entire array, and for each iteration we must iterate another N times with our inner loop. Thats N steps \* N steps, otherwise known as N².

**Big O Notation ignores constants**

This is simply a mathematical way of saying that Big O Notation never includes regular numbers that aren't an exponent.
What should technically be O(n² / 2) becomes simply O(n²). Similary, O(2n) would become O(n), and O(n /2) would also become O(N). Even O(100n), which is 100 times slower than O(n), would also be referred to as O(n).

**The Role of Big O**

For some amount of data, O(n) will be always faster than O(n²). And this is true no matter whether the O(n) is really O(2n) or even O(100n) under the hood. It is a fact that there is some amount of data at which even O(100n) will become faster than O(n²).

**Hash Tables**

While lookup for an item with a linear search in an unordered array will be O(n), and search in an ordered array using binary search will be O(log n), we can do so much faster with hash tables O(1).
Hash tables have an amazing superpower: fast reading.
Common names in programming languages: hashes, maps, hash maps, dictionaries and associative arrays.
A Hash Table is a list of paired values. The first item is known as the key, and the second item is known as the value.
Looking up a value in a hash table has an efficiency of O(1) on avarage, as it takes just one step.
The process of taking characters and converting them to numbers is known as hashing. And the code that is used to convert those letters into particular numbers is called a hash function.
Hash functions have one criteria to be valid: it must convert the same string to the same number every single time it's applied.
When we try to add data that already exists in our hash table is known as collision.
One classic approach for handling collisions is known as separate chaining. When collision occurs, instead of placing a single value in the cell, it places in it a reference to an array.
When the computer look at the cell and note that it contains an array instead of a value, it does a linear search for the value you asked for. Therefore, in worst-case scenarios, hash tables lookup can be of O(n). Its is import to design hash tables to avoid collisions, otherwise will be no faster than an array.
A good hash table strikes a balance of avoiding collisions while not consuming lots of memory.

**Stacks**
Stacks have the following constants:

- Data can only be inserted at the end of a stack
- Data can only be read from the end of a stack
- Data can only be removed from the end of a stack
- LIFO: Last In, First Out

**Queues**
Just like Stacks, Queues have its restrictions:

- Data can only be inserted at the end of a queue (just like a stack)
- Data can only be read from the front of a queue (opposite of a stack)
- Data can only be removed from the front of a queue (opposite of a stack)
- FIFO: First In, First Out

**Recursion**
Recursion is the official name for when a function calls itself. Recursion allows for solving tricky problems in surprisingly simple ways, often allowing us to write a fraction of the code that we might otherwise write.
Recursion methods need a base case, a condition that avoids infinite loops.

Almost every for-loop situation can be done with recursion, while its interesting it does not really provide an advantage when solving those problems.
However, recursion is a natural fit in any situation where you find yourself having to repeat an algorithm within the same algorithm.

**Linked Lists**
Node-based data structures offer new ways to organize and access data that provide a number of major performance advanteges.
Linked lists does not consist of a bunch of memory cells in a row, like an array is. Instead, they consist of a bunch of memory cells that are _not_ next to each other, but can be spread across many different cells across the computer's memory. These cells that are not adjacent to each other are known as _nodes_. In addition to the data stored within the node, each node also stores the memory address of the next node in the linked list. This extra piece of data -this pointer to the next node's memory addres- is known as a link.

**Doubly Linked Lists**
A doubly linked list is like a linked list, except that each node has two links: onde that points to the next node, and one that points to the preceding node. In addition, the doubly linked list keeps track of both the first and last nodes.

**Binary Trees**
A tree is also a node-based data structure, but within a tree, each node can have links to multiple nodes.
A binary tree is a tree that abides by the following rules:

- Each node has either zero, one, or two children.
- If a node has two children, it must have onde child that has a lesser value than the parent, and one child that has a greater value than the parent.

**Graphs**
Graph is a data structure that specializes in relationships, as it easily conveys how data is connected. Thinking in a social network where people can be friends of each other. Each person is represented by a node, and each line indicates a friendship with another person. In graph jargon, each node is called a vertex and eache line is called an edge. Vertices that are connected by an edge are said to be adjacent to each other.
One of the simplest ways of implementing graphs is using hash tables.

**Bradth-First Search**
There are two ways to traverse a graph: breadth-first search and depth-first search. Both are similar and work equally well for most cases.
The BFS (breadth-first search) is a algorithm that uses queue, which keeps track of which vertices to process next. At the very beginning the queue contains only the starting vertice.

**Space Constraints**
There are situations where we need to measure algorithm efficiency by another measure known as space complexity, which is how much memory an algorithm consumes.
