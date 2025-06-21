namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/maximum-difference-between-increasing-elements/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumDifference(int[] nums)
        {
            int i = 0, j = nums.Length - 1;
            int temp = 0;
            int largestNum = -1;
            
            while (j > 0)
            {
                while (i < j)
                {
                    temp = nums[j] - nums[i];
                    largestNum = temp > largestNum ? temp : largestNum;
                    ++i;
                }
                i = 0;
                --j;
            }

            return largestNum == 0 ? -1 : largestNum;
        }
    }
}
