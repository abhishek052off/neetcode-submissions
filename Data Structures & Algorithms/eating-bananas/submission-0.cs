public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1 ; 

        int high = 0;
        
        foreach(int p in piles) high = Math.Max(p , high);

        while(low < high){

            int mid = (low+high)/2;

            if(IsValid(mid , piles , h)){
                //search left 
                high = mid;
            }
            else{
                low = mid+1;
            }

        }

        return low;
    }

    public bool IsValid(int mid , int[] piles , int h){

        int t=0;

        foreach(var p in piles){
            t += (p+mid -1)/mid;
        }

        return t <= h;
    }
}
