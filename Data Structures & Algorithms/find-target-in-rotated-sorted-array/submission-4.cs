public class Solution {
    public int Search(int[] nums, int target) {
    
        int l = 0; 
        int h = nums.Length-1;

    

        while(l <= h){

            int m = (l+h)/2;

            Console.WriteLine($"Entering Low {nums[l]} High {nums[h]} Mid {nums[m]}");

            if(nums[m] == target) return m;
            
            if(nums[l] <= nums[m]) { // Sorted array 
               Console.WriteLine("Left is sorted..");
               if(target <= nums[m] && target >= nums[l]){ //target exists in this range 
                    h = m-1;
                    Console.WriteLine("In Left Sorted Array");
               }
               else{
                 l = m+1;
                 Console.WriteLine("Not In Left Sorted Array");
               }
               
            }
            else{ // Right is sorted 
                 Console.WriteLine("Right is sorted..");
                if(target >= nums[m] && target <= nums[h]) //its in the right sorted array 
                {
                    Console.WriteLine("In Right Sorted Array..");
                    l = m+1;
                }
                else{
                    Console.WriteLine("Not In Right Sorted Array..");
                     h = m-1;
                }
            }

            Console.WriteLine($"Exiting Low {l} High {h} Mid {m}");

        }

        return -1;
    }
}
