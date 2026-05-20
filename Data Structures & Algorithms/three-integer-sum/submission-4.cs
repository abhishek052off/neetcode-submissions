public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        int arrlen = nums.Length;

        var store = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0 ; i< arrlen ; i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int left = i+1;
            int right = arrlen-1 ;

            int key = 0-nums[i];
            Console.WriteLine($"nums i  {nums[i]} Key {key}");

            while(left < right){
                int sum = nums[left] + nums[right];
                Console.WriteLine($"left {nums[left]} right {nums[right]} SUM {sum}");
                if(sum == key){

                    Console.WriteLine($"Found left {nums[left]} right {nums[right]} SUM {sum} Key {key}");
                    store.Add(new List<int>{nums[i] , nums[left] , nums[right]});
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }

                else if(sum < key) left++;
                else right--;
            }
        }

        return store;
    }
}
