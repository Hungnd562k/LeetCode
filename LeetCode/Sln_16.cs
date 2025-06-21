using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum-closest/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            int closet = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {                    
                    sum = nums[i] + nums[left] + nums[right];
                    if (Math.Abs(sum - target) < Math.Abs(closet - target))
                    {
                        closet = sum;
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else if (sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        return closet;
                    }
                }
            }

            return closet;
        }
    }
}
