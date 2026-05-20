public class Solution {
    public int LargestRectangleArea(int[] heights) {
        
        int maxArea = 0;

        var st = new Stack<(int height,int index)>();

        for(int i = 0 ; i <= heights.Length ; i++){
            
            int hgt = i ==  heights.Length ? 0 : heights[i];
            while( st.Count != 0 && hgt < st.Peek().height  ){
                var val = st.Pop();

                //We popped the actual heigth for which we are calculating, 
                // the boundry is the one smaller and that wont be a part of current recatnagle 

                int leftBoundry = st.Count > 0 ? st.Peek().index  : -1;
                
                int width = i - leftBoundry - 1;
                int area = val.height * width;

                maxArea = Math.Max(area, maxArea);
                
            }

            st.Push((hgt , i ));
            
        }

        return maxArea;
    }
}
