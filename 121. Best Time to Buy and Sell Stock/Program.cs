public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var minPrice = int.MaxValue;
        var maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
                continue;
            }
            var profit = prices[i] - minPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}