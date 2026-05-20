public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {

        int reqSum = k*threshold;

        int count = 0 ;
        int calcSum = 0;

        int start = 0 ; 

        for(int i = 0 ; i < arr.Length; i++){
            
            calcSum += arr[i];


            if(i - start+1 == k){
                if(calcSum >= reqSum) count++;
                //drop start 
                calcSum -= arr[start];
                start++;
            }
        }

        return count;


        
    }
}