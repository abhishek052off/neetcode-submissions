public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if(s2.Length < s1.Length) return false;
        
        int[] s1Map = new int[26];
        int[] s2Map = new int[26];

        foreach(char c in s1){
            var index = c -'a';
            s1Map[index]++;
        }

        int start = 0;
        


        for(int i=0 ; i< s2.Length ; i++)
        {
            s2Map[s2[i] -'a']++;

                if(i - start + 1 > s1.Length){
                    s2Map[s2[start] -'a']--;
                    start++;
                }
            //once window is full sized
            if(i - start + 1 == s1.Length ){
                if(isMatch(s1Map , s2Map)) return true;
            }

           

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
