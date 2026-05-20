public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        

        var km = new Dictionary<string , List<string>>();

        foreach(var item in strs){
            var key = KeyHelper.GetKey(item);

            bool containsKey = km.ContainsKey(key);

            if(containsKey){
                km[key].Add(item);
            }
            else{
                km[key]=  new List<string>(){item};
            }
 
        }

        return km.Values.ToList();
    }

    
}


public static class KeyHelper{
    
    public static string GetKey(string value){

        var map = GetFrequencyMap(value);

        return MapToString(map);
    }

    private static int[] GetFrequencyMap(string value){

        int[] freq = new int[26];

        foreach(char c in value){
            freq[GetIndex(c)]++;
        };

        return freq;
    }

    private static string MapToString(int[] map){
        var str = new StringBuilder();

        for(int i=0 ; i< map.Length;i++){
            
            var repr = $"{map[i]}#";
            str.Append(repr);
        }

        return str.ToString();
    }

    private  static int GetIndex(char c) => (c - 'a');



}
