public class Solution {
    public bool IsValid(string s) {
        

        var dict = new Dictionary<char , char> {
            {')','('},
            {'}','{'},
            {']','['}
        };

        var st = new Stack<char>();

        foreach(var c in s){
            Console.WriteLine(c);

            if(dict.ContainsKey(c))
            {   
                Console.WriteLine("Found in Dict , Closing ");
                if(st.Count == 0 || st.Peek() !=  dict[c] ) return false;

                st.Pop();

            }
            else{
                Console.WriteLine("Not Found Pushing");
                Console.WriteLine(string.Join(", ", st));
                st.Push(c);
            }
        }

        

        return st.Count == 0; 
    }
}
