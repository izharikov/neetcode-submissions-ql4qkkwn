public class MinStack {
    private readonly List<int> _stack = new List<int>();
    private readonly List<int> _min = new List<int>();
    private int _count = 0;

    public MinStack() {
        
    }
    
    public void Push(int val) {
        _stack.Add(val);
        _count++;
        if (_count == 1) {
            _min.Add(val);
        } else {
            _min.Add(Math.Min(_min[_count - 2], val));
        }
    }
    
    public void Pop() {
        _stack.RemoveAt(_count - 1);
        _min.RemoveAt(_count - 1);
        _count--;
    }
    
    public int Top() {
        return _stack[_count - 1];
    }
    
    public int GetMin() {
        return _min[_count - 1];
    }
}
