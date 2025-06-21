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
        /// https://leetcode.com/problems/4sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            int sum = 0;
            List<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = 0; j < nums.Length - 4; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        continue;
                    }
                    int left = j + 1, right = nums.Length - 1;
                    while (left < right)
                    {
                        sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            res.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[right - 1] == nums[right]) right--;
                            while (left < right && nums[left + 1] == nums[left]) left++;
                            right--; left++;
                        }
                        else if (sum < target) left++;
                        else right--;                        
                    }
                }
            }

            return res;
        }
    }
}
