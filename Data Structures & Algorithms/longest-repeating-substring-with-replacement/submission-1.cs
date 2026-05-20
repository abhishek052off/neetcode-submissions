public class Solution {
    public int CharacterReplacement(string s, int allowedk) {
        int globalMax = 0 ; 

        for(int i = 0 ; i<s.Length ; i++){

             int[] freq = new int[26];
             int maxFreq = 0;

            for(int j = i ; j<s.Length ; j++){
             
                var index = s[j] - 'A';
                freq[index]++;
                maxFreq = Math.Max(freq[index], maxFreq);
                
                int length = j - i + 1;

                if (length - maxFreq <= allowedk)
                {
                    globalMax = Math.Max(globalMax, length);
                }
            }

        }

        return globalMax;
    }
}
