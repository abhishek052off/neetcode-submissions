public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false ;

       Dictionary<char , int> dict = new();

       //1. iterate s 

       foreach(char c in s ){
        if( dict.ContainsKey(c) ) dict[c]++;
        else dict[c] = 0;
       }

       //2.Iterate t and substract 

       foreach( char c in t){
            if( !IfContainsAndHasQuantity(c , dict) ) return false;
       }

       return true;

    }

    bool IfContainsAndHasQuantity(char key , Dictionary<char , int> dict){

        if( !dict.ContainsKey(key) ) return false;

        if( dict[key]-- < 0 ) return false;

        return true;
    }
}