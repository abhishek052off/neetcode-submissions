public class Solution {
    public bool IsValid(string s) {
        

        var dict = new Dictionary<char , char> {
            {')','('},
            {'}','{'},
            {']','['}
        };

        var st = new Stack<char>();

        foreach(var c in s){
            

            if(dict.ContainsKey(c))
            {   
                 
                if(st.Count == 0 || st.Peek() !=  dict[c] ) return false;

                st.Pop();

            }
            else{
                 
                st.Push(c);
            }
        }

        

        return st.Count == 0; 
    }
}
