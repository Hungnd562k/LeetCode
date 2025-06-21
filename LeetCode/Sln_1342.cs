namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int NumberOfSteps(int num)
        {
            int n = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    n++;
                }
                else
                {
                    num -= 1;
                    n++;
                }
            }
            return n;
        }
    }
}
