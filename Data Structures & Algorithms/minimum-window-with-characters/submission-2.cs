public class Solution {
    public class Shortest{
        public int Len {get;set;}
        public int Start {get;set;}
        public int End {get;set;}
    }
    public string MinWindow(string s, string t) {

        if(s.Length < t.Length) return string.Empty;

        var shortest =  new Shortest{
            Len = int.MaxValue,
            Start = -1,
            End = -1 ,
        };

        //build freq map 
        var tMap = new Dictionary<char , int>();
        

        for(int i = 0 ; i<t.Length ; i++){
            tMap[t[i]] = tMap.GetValueOrDefault( t[i] ,0)+1;
           
        }
        


        for(int i = 0 ; i<=s.Length-t.Length ; i++){

            var sMap = new Dictionary<char , int>();
            var endIndex = i+t.Length -1;

            //Create the first min len HMap
            for(int x = i ; x < endIndex ; x++){
                sMap[s[x]] = sMap.GetValueOrDefault( s[x] , 0) +1;
            }
            //Keep Adding to it , valid substring starts here 
            for(int j= endIndex ; j< s.Length ; j++ ){
                sMap[s[j]] = sMap.GetValueOrDefault( s[j] , 0) +1;

                var localLen = j-i+1;

                if(IsContains(tMap , sMap) && localLen < shortest.Len){
                    shortest.Len = localLen;
                    shortest.Start = i ; 
                    shortest.End = j;
                }
            }
        }

        if(shortest.Start == -1) return string.Empty;

        return s[shortest.Start..(shortest.End+1)];
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
