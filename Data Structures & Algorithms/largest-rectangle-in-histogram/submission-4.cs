public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        Stack<(int Index, int Height)> stack = new Stack<(int Index, int Height)>();

        for (int i = 0; i < heights.Length; i++) {
            int start = i;
            while (stack.Count > 0 && stack.Peek().Height > heights[i]) {
                var (index, height) = stack.Pop();
                maxArea = Math.Max(maxArea, height * (i - index));
                start = index;
            }
            stack.Push((start, heights[i]));
        }

        int len = heights.Length;
        while (stack.Count > 0) {
            var (index, height) = stack.Pop();
            maxArea = Math.Max(maxArea, height * (len - index));
        }

        return maxArea;
    }
}
