using System;
using System.Collections.Generic;

namespace Stocks
{
    /// <summary>
    /// Best Time to Buy and Sell Stock
    /// </summary>
    public class Stocks
    {
        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// 
        /// If you were only permitted to complete at most one transaction(ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        /// </summary>
        /// <![CDATA[
        /// Input: [7, 1, 5, 3, 6, 4]
        /// Output: 5
        /// 
        /// Max Difference = 6-1 = 5 (not 7-1 = 6, as selling price needs to be larger than buying price)
        /// ]]>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <see cref="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/"/>
        public static int BestTimeI( int[] input )
        {
            var profit = 0;

            var minPrice = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {
                profit = ( input[i] - minPrice ) > profit ? input[i] - minPrice : profit; //Math.Max(profit, prices[i] - minPrice);
                minPrice = input[i] < minPrice ? input[i] : minPrice;  //Math.Min(minPrice, prices[i]);
            }

            return profit;
        }

        /// <summary>
        /// Design an algorithm to find the maximum profit. You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times). However, you may 
        /// not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int BestTimeII( int[] input )
        {
            var profit = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < input[i + 1])
                {
                    profit = profit + ( input[i + 1] - input[i] );
                }
            }

            return profit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int BestTimeIII( int[] input )
        {
            var profit = 0;
            var profits = new int[input.Length];

            var minPrice = int.MaxValue;
            var maxPrice = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                profit = Math.Max ( profit, input[i] - minPrice );
                minPrice = Math.Min ( minPrice, input[i] );
                profits[i] = profit;
            }

            for (int i = input.Length - 1; i > 0; i--)
            {
                maxPrice = Math.Max ( maxPrice, input[i] );
                profit = Math.Max ( profit, maxPrice - input[i] + profits[i] );
            }

            return profit;
        }
    }
}
