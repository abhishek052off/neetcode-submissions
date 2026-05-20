public class Solution {
    public int CharacterReplacement(string s, int allowedk) {
        int globalMax = 0 ; 

       


        for(int i = 0 ; i<s.Length ; i++){
            for(int j = i ; j<s.Length ; j++){
                
                int[] freq = new int[26];
                int maxFreq = 0;

                for(int k = i ; k<=j ; k++){
                    var index = s[k] - 'A';
                    freq[index]++;
                    maxFreq = Math.Max(freq[index] , maxFreq);
                }

                //
                var strlen = j-i+1;
                if(strlen - maxFreq <= allowedk){
                    globalMax = Math.Max(strlen,globalMax);
                }

            }

        }

        return globalMax;
    }
}
