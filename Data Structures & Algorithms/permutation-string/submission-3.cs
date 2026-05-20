public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if(s2.Length < s1.Length) return false;
        
        int[] s1Map = new int[26];
        int[] s2Map = new int[26];


        for(int i = 0 ; i<s1.Length ;i++){
            s1Map[ s1[i] - 'a' ]++;
            s2Map[ s2[i] - 'a' ]++;
        }
        
        if(isMatch(s1Map,s2Map)) return true;
         
        for(int i=s1.Length ; i< s2.Length ; i++)
        {
            int left = i-s1.Length;
            //slide left 
            s2Map[s2[left] - 'a']--;
            s2Map[s2[i] - 'a']++;

            if(isMatch(s1Map,s2Map)) return true;
        }

        return false;

    }

    public bool isMatch(int[] arr1 , int[] arr2){

        for(int i = 0 ; i < Math.Min(arr1.Length,arr2.Length) ; i++ ){
            if(arr1[i] != arr2[i]) return false;
        }

        return true;
    }
}
