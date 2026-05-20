public class Solution {
    public int Search(int[] nums, int target) {
        

        int l = 0 ;
        int r = nums.Length-1;

        while(l <= r){


            int mid = (l+r)/2;
            //Console.WriteLine($"LEFT {l} RIGHT {r} MID {mid}");

            int value = nums[mid];

            if(value == target) return mid;
            else if ( value < target) l = mid+1 ;
            else r =  mid-1 ;
        }

        return -1;
    }
}
