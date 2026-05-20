public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        if(len == 1) return 0;

        int profit = 0;
        int min = prices[0];

        for(int i=1 ; i< len ; i++){
            var localProfit = prices[i] - min;
            min = Math.Min(min , prices[i]);
            profit = Math.Max(profit,localProfit);
        }

        return profit;
    }
}
