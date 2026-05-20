public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int l = 0 ;
        int h = rows * cols - 1;

        while(l <= h){
            int mid = (l+h)/2;
            int midRow = mid/cols,midCol = mid%cols;
            int value = matrix[midRow][midCol];

            if(value == target) return true;
            if( value < target) l = mid+1;
            else h = mid-1;
        }

        return false;
    }
}
