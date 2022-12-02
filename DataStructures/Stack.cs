namespace AlgorithmsAndDataStructures.DataStructures;

internal class Stack<T>
{
    public int Count { get; private set; }

    private T[] _stack;
    private int _capacity;
    private readonly int _initialCapacity = 10;

    public Stack()
    {
        _capacity = _initialCapacity;
        _stack = new T[_capacity];
    }

    public void Push(T value)
    {
        if (Count == _capacity)
        {
            _capacity *= 2;
            Array.Resize(ref _stack, _capacity);
        }

        _stack[Count++] = value;
    }

    public T? Pop()
    {
        if (IsEmpty())
            return default;

        return _stack[--Count];
    }

    public T Peek()
    {
        return _stack[Count - 1];
    }

    public void Clear()
    {
        _stack = new T[_initialCapacity];
    }

    public void Print()
    {
        for (int i = Count - 1; i >= 0; i--)
            Console.WriteLine(_stack[i]);
    }

    public bool IsEmpty() => Count == 0;
}
