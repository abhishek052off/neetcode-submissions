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

      

        foreach(char c in t){
            tMap[c] = tMap.GetValueOrDefault(c , 0)+1;
        }


        for(int i = 0 ; i<=s.Length-t.Length ; i++){

            for(int j= i+t.Length -1 ; j< s.Length ; j++ ){

                var sMap = new Dictionary<char , int>();
                //i have i anf j pointers , make Freq Map chedk if valid 
                for(int k = i ; k<= j ; k++){
                     sMap[s[k]] = sMap.GetValueOrDefault(s[k] , 0)+1;
                }

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
