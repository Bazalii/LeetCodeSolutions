public class RecentCounter
{
    private readonly List<int> _calls = new();
    private int _indexOfLatestCall = 0;

    public int Ping(int time)
    {
        _calls.Add(time);

        while (_calls[_indexOfLatestCall] < time - 3000)
        {
            _indexOfLatestCall++;
        }

        return _calls.Count - _indexOfLatestCall;
    }
}