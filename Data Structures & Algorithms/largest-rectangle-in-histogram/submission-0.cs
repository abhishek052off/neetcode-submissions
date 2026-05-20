public class Solution {
    public int LargestRectangleArea(int[] heights) {
        //BRUTE : 
        //For any sub array its area will be length of the sub array * min height 
        int maxArea = 0; 
        for(int i = 0 ; i<heights.Length ;i++){

            var minHeight  = int.MaxValue; 

            for(int j = i ; j< heights.Length ; j++){
                minHeight = Math.Min(minHeight , heights[j]);
                int area = minHeight * (j - i +1);
                maxArea = Math.Max(maxArea, area);
            }

        }

        return maxArea;

    }
}
