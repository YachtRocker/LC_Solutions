// LC 121
// Best Time to Buy and Sell Stock

using System;

static int MaxProfit(int[] prices) 
{
    int l = 0;
    int r = 0;
    int maxP = 0;
    int profit = 0;
     while (r < prices.Length)
    {
        if (prices[l] < prices[r])
        {
            profit = prices[r] - prices[l];
            maxP = Math.Max(maxP, profit);
        }
        else
        {
            l = r;
        }
        r++;
    }

    return maxP;
}

int[] prices = { 7, 1, 5, 3, 6, 4 };

int result = MaxProfit(prices);
Console.WriteLine(result);