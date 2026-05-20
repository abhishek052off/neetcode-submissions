public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        

        var km = new Dictionary<string , List<string>>();

        foreach(var item in strs){
            var key = GetKey(item);

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

    public static string GetKey(string input){
        var chArr = input.ToCharArray();
        Array.Sort(chArr);
        return new string(chArr);
    }
}
