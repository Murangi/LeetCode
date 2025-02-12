public class MinStack {
    
    List<int> StackList = new List<int>();

    public MinStack() {
        
    }
    
    public void Push(int val) {

        StackList.Add(val);
    }
    
    public void Pop() {

        StackList.RemoveAt(StackList.Count -1);
    }
    
    public int Top() {

        return StackList.Last();
    }
    
    public int GetMin() {
        
        return StackList.Min();
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