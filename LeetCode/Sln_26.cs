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
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            List<int> lst = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!lst.Contains(nums[i]))
                {
                    lst.Add(nums[i]);
                }
            }

            for (int i = 0; i < lst.Count; i++)
            {
                nums[i] = lst[i];
            }

            return lst.Count;
        }
    }
}
