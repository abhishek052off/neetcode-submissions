public class Solution {
   public int LengthOfLongestSubstring(string s) {
    if(s.Length == 1 || s.Length == 0 ) return s.Length ;
    
    var hs = new HashSet<char>();
    hs.Add(s[0]);
    
    int start = 0;
    int maxLen = 0;
    
    for(int end = 1; end < s.Length; end++) {
        while(hs.Contains(s[end])) {
            hs.Remove(s[start]);
            start++;
        }
        hs.Add(s[end]);
        int len = end - start + 1;
        maxLen = Math.Max(len, maxLen);
    }
    
    return maxLen;
}
}
