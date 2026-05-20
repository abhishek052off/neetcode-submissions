public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var foundWhere = new Dictionary<int,int>();

        for(int i = 0 ; i < nums.Length ; i++){

            int counterPart = target - nums[i];

            if(foundWhere.ContainsKey(counterPart)){ // counter part exists 
                return [foundWhere[counterPart],i];
            }
            else{
                foundWhere[nums[i]] = i;
            }
        }

        return [0,0];
    }
}
