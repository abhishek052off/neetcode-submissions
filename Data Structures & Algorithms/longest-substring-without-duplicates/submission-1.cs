public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int globalMax = 0;

        var hs = new Dictionary<char,int>();
        int start = 0 ; 

        for(int i=0 ; i< s.Length ;i++){

            if(hs.ContainsKey(s[i])){
                bool inWindow =  hs[s[i]] >= start;
                if(inWindow){
                    start = hs[s[i]]+1 ;
                }
            }
            hs[s[i]] = i;

            var localMax = i-start+1;
            globalMax = Math.Max(localMax,globalMax);

        }

        return globalMax;
    }
}
