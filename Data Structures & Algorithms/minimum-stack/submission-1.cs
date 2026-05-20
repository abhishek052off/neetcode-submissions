public class MinStack {

    private readonly Stack<int> stNormal;
    private readonly Stack<int> stMin;


    public MinStack() {
        stNormal =  new Stack<int>();
        stMin =  new Stack<int>();
    }
    
    public void Push(int val) {
        stNormal.Push(val);

        if(stMin.Count == 0 || stMin.Peek() >= val) stMin.Push(val);
    }
    
    public void Pop() {
        
        var elem = stNormal.Pop();
        if(stMin.Count != 0  && stMin.Peek() == elem) stMin.Pop();
    }
    
    public int Top() {
        return stNormal.Peek();
    }
    
    public int GetMin() {
        return stMin.Peek();
    }
}
