public class Solution {
    public int MaxProfit(int[] prices) {
        // likely to be a two pointer solution

        // Brute for for reference
        var n=prices.Count();
        
        var minPrice=prices[0];
        var maxProfit=0;
        for (int i=1; i<n; i++) {
            
            maxProfit=Math.Max(maxProfit, prices[i]-minPrice);
            minPrice=Math.Min(minPrice, prices[i]);
        }

        return maxProfit;
    }
}
