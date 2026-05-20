public class Solution {
    public int CharacterReplacement(string s, int k)
{
    int[] freq = new int[26];
    int start = 0;
    int globalMax = 0;

    for (int end = 0; end < s.Length; end++)
    {
        freq[s[end] - 'A']++;

         
        int maxFreq = 0;
        for (int i = 0; i < 26; i++)
        {
            maxFreq = Math.Max(maxFreq, freq[i]);
        } //*

      
        while ((end - start + 1) - maxFreq > k)
        {
            freq[s[start] - 'A']--;
            start++;

            
            maxFreq = 0;
            for (int i = 0; i < 26; i++)
            {
                maxFreq = Math.Max(maxFreq, freq[i]);
            }
        }

        globalMax = Math.Max(globalMax, end - start + 1);
    }

    return globalMax;
}
}
