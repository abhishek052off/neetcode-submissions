public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        var freq = new int[26];

        foreach(var c in s){
            freq[GetIndex(c)]++;
        }

        foreach(char c in t){
            if(freq[GetIndex(c)] == 0) return  false;
            freq[GetIndex(c)]--;
        }

        return true;
    }

    public static int GetIndex(char c){
        return (c-'a');
    }
}
