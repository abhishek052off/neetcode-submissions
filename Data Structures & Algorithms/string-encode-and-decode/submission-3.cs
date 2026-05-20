public class Solution {

    private const char separator = '#';

    public string Encode(IList<string> strs) {
        var stb = new StringBuilder();

        foreach(var str in strs){
            var tmp = $"{str.Length}{separator}{str}";
            stb.Append(tmp);
        }
        var st = stb.ToString();
       
        return st;
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();

        int i = 0;
     

        while (i < s.Length)
        {
            int j = i ; 

            while(s[j] != separator) j++; //this give the len of number 

            //extract digit 
            int digit =  int.Parse(s.Substring(i,j-i));

            var word = s.Substring(j+1,digit);
            result.Add(word);

            i = j+digit+1;
        }

        return result;
    }
}
