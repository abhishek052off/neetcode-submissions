public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int zeroCount=0;
        int tpnz = 1;

        foreach(int num in nums ){

            if(num == 0){
                zeroCount++;
            }
            else{
                tpnz *= num;
            }
        }

        for(int i=0;i<nums.Length ; i++){

            if(zeroCount > 1){
                nums[i] = 0;
                
            }
            else if (zeroCount == 1){
                nums[i] = nums[i] == 0 ? tpnz : 0;
                 
            }
            else{
                nums[i] = tpnz/nums[i];
            }
             
        }

        return nums;


    }
}
