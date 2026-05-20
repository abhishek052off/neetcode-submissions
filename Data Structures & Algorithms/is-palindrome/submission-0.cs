public class Solution {
    public bool IsPalindrome(string s) {

        int left = 0 ;
        int right = s.Length -1;

        while(left < right){

            //Console.WriteLine($"Left Before {s[left]} Right {s[right]}");
            while(!IsAlphaNumeric(s[left])  && left < right) left++;
            while( !IsAlphaNumeric(s[right]) && right > left) right-- ;

            //Console.WriteLine($"Left After {s[left]} Right {s[right]}");

            if( char.ToUpperInvariant(s[left]) != char.ToUpperInvariant(s[right]) ) return false;
            left++;
            right--;
        }

        return true;
    }

    public static bool IsAlphaNumeric(char c){
      return Char.IsLetterOrDigit(c);
    }
}
