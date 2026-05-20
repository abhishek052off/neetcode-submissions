public class Solution {
    public string MinWindow(string s, string t) {
        
        if(t.Length > s.Length ) return string.Empty;

        int bestStart = -1 ; 
        int bestLen = int.MaxValue;

        var tMap = new Dictionary<char,int>();
        var sMap = new Dictionary<char,int>();


        for(int i = 0 ; i < t.Length ; i++){
            tMap[t[i]] = tMap.GetValueOrDefault(t[i],0)+1;
            
        }
      
        int left = 0;
        for(int i= 0 ; i<s.Length ; i++){

            sMap[s[i]] = sMap.GetValueOrDefault(s[i],0)+1;
            while(IsContains(tMap,sMap)){

                 var winLen = i - left+1;
                    if(winLen < bestLen) {
                        bestStart = left;
                        bestLen = winLen;
                    }


                 sMap[s[left]]--;
                 left++; 

                
            }
            
            
            
        }
        
        return bestStart == -1? string.Empty: s.Substring(bestStart , bestLen);
    }

    public bool IsContains(
    Dictionary<char, int> tMap,
    Dictionary<char, int> sMap)
    {
        foreach (var kvp in tMap)
        {
            char key = kvp.Key;
            int required = kvp.Value;

            if (!sMap.ContainsKey(key) || sMap[key] < required)
                return false;
        }

        return true;
    }
}
