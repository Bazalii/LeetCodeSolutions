public class MyStack
{
    private readonly Queue<int> _queue = new();
    private int _lastElement;

    public void Push(int x)
    {
        _lastElement = x;

        _queue.Enqueue(x);
    }

    public int Pop()
    {
        if (_queue.Count <= 1)
        {
            return _queue.Dequeue();
        }
        
        var numberOfElementsToSave = _queue.Count - 1;

        while (numberOfElementsToSave != 1)
        {
            _queue.Enqueue(_queue.Dequeue());

            numberOfElementsToSave--;
        }

        _lastElement = _queue.Dequeue();

        _queue.Enqueue(_lastElement);

        return _queue.Dequeue();
    }

    public int Top()
    {
        return _lastElement;
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}