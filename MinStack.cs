public class MinStack
{
    private List<int> _elements = new();

    private int _minElement = 0;

    private int _length = 0;

    public void Push(int val)
    {
        _elements.Add(val);
        if (val < _elements[_minElement])
        {
            _minElement = _length;
        }

        _length++;
    }

    public void Pop()
    {
        _elements.RemoveAt(--_length);
        if (_minElement == _length)
        {
            _minElement = 0;
            for (int i = 0; i < _length; i++)
            {
                if (_elements[i] < _elements[_minElement])
                {
                    _minElement = i;
                }
            }
        }
    }

    public int Top()
    {
        return _elements[_length - 1];
    }

    public int GetMin()
    {
        return _elements[_minElement];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */