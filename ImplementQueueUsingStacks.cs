public class MyQueue
{
    private readonly Stack<int> _mainStack = new();
    private readonly Stack<int> _auxiliaryStack = new();
    private int _peek;

    public void Push(int element)
    {
        if (_mainStack.Count == 0)
        {
            _peek = element;
        }

        _mainStack.Push(element);
    }

    public int Pop()
    {
        if (_mainStack.Count <= 1)
        {
            return _mainStack.Pop();
        }

        while (_mainStack.Count > 2)
        {
            _auxiliaryStack.Push(_mainStack.Pop());
        }

        _peek = _mainStack.Pop();

        _auxiliaryStack.Push(_peek);

        var oldPeek = _mainStack.Pop();

        while (_auxiliaryStack.Count != 0)
        {
            _mainStack.Push(_auxiliaryStack.Pop());
        }

        return oldPeek;
    }

    public int Peek()
    {
        return _peek;
    }

    public bool Empty()
    {
        return _mainStack.Count == 0;
    }
}