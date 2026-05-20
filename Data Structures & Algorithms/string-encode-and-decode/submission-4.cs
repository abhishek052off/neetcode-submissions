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
        int digitCount = 0;

        while (i < s.Length)
        {
            if (s[i] == separator)
            {
                
                string lenStr = s.Substring(i - digitCount, digitCount);
                int len = int.Parse(lenStr);

                
                int payloadStart = i + 1;
                string word = s.Substring(payloadStart, len);
                result.Add(word);

               
                i = payloadStart + len;

                
                digitCount = 0;
            }
            else
            {
                digitCount++;
                i++;
            }
        }

        return result;
    }
}
