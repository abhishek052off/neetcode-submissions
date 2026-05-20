public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var ops = new HashSet<string>{ "+","-","*","/" };
        var st = new Stack<int>();
        foreach(var token in tokens){


            if(ops.Contains(token)){
                
                int numb = st.Pop();
                int numa = st.Pop();

                int res = token switch {
                    "+" => numa + numb,
                    "-" => numa - numb,
                    "*" => numa * numb,
                    "/" => numa/numb,
                };

                st.Push(res);

            }
            else{
                st.Push(int.Parse(token));
            }
        }

        return st.Peek();
    }
}
