public class Solution {
     public int[] ProductExceptSelf(int[] nums) {
        
        int[] prefix = new int[nums.Length];

      

        for(int i = 0 ; i <nums.Length ;i++){
            if(i == 0){
                prefix[i] =1;
            }
            else{
                prefix[i] =  nums[i-1] * prefix[i-1];
            }
            
        }

        int runingBwProd = 1;
        var result = new int[nums.Length];

        for(int i= nums.Length-1 ; i >= 0 ; i--){
            result[i] = prefix[i] * runingBwProd;
            runingBwProd *= nums[i];
        }

        

        return result;


    }
}
