
Solution solution = new();
solution.MaxProfit([2, 1, 2, 1, 0, 1, 2]);
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int minValue = prices[0];


        foreach (var price in prices)
        {
            if (price < minValue)
            {
                minValue = price;
            }
            if ((price - minValue) > profit)
            {
                profit = price - minValue;
            }
        }

        return profit;

    }
}