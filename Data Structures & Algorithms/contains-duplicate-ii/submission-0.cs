public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        var hs = new HashSet<int>();

        for(int i = 0 ; i < k ; i++){
            if(hs.Contains(nums[i])) return true;
            hs.Add(nums[i]);
        }


        for(int i = k ;i<nums.Length ; i++){

            int start = i-k;
            if( hs.Contains(nums[i]) ) return true;

            //drop left 
            hs.Remove(nums[start]);
            //add new right 
            hs.Add(nums[i]);



        }

        return false;
    }
}