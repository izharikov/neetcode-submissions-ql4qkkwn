public class MinStack {
    private readonly Stack<int> _stack = new Stack<int>();
    private readonly Stack<int> _min = new Stack<int>();
    private int _count = 0;

    public MinStack() {
        _min.Push(int.MaxValue);
    }
    
    public void Push(int val) {
        _stack.Push(val);
        _min.Push(Math.Min(_min.Peek(), val));
        _count++;
    }
    
    public void Pop() {
        _stack.Pop();
        _min.Pop();
        _count--;
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _min.Peek();
    }
}
