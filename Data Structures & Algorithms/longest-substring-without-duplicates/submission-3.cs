public class Solution {
     public int LengthOfLongestSubstring(string s) {
        int globalMax = 0;

        var hs = new HashSet<char>();
        int start = 0 ; 

        for(int i=0 ; i< s.Length ;i++){

            while(hs.Contains(s[i])){
                hs.Remove(s[start]);
                start++;
            }
            hs.Add(s[i]); 

            globalMax = Math.Max(globalMax, i-start+1);

        }

        return globalMax;
    }
}
