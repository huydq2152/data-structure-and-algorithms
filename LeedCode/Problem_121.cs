namespace LeedCode;

public class Problem_121
{
    public int MaxProfit(int[] prices)
    {
        int pricesLength = prices.Length;
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        for (int i = 0; i < pricesLength; i++)
        {
            if (minPrice > prices[i])
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }
}