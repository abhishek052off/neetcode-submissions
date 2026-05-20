public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int left = 0 ;
        int right = numbers.Length -1 ;

        while(left < right){

            int sum = numbers[left] + numbers[right];
            Console.WriteLine($"Left {numbers[left]} Right {numbers[right]} SUM {sum}");
            if( sum == target) return [left+1 , right+1];
            if(sum > target) right--;
            else if(sum < target) left++;
        }


        return new int[0];

    }
}
