namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/richest-customer-wealth/
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public int MaximumWealth(int[][] accounts)
        {
            int count = accounts.Length;
            int result = 0;

            for (int i = 0; i < count; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum += accounts[i][j];
                }

                if (sum > result)
                {
                    result = sum;
                }
            }

            return result;
        }
    }
}
