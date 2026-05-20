public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int globalMax = 0;

        for(int i=0 ; i< s.Length ;i++){
            var st = new HashSet<char>();
            var j = i ; 

            while(j < s.Length ){

                if(st.Contains(s[j])){
                    break;
                }
                else{
                    st.Add(s[j]);
                }

                j++;
            }

            var localMax = j - i;
            globalMax = Math.Max(localMax,globalMax);

        }

        return globalMax;
    }
}
