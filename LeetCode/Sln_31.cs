using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    public partial class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2, startPoint = 0;
            int flag = -1; // Nếu duyệt hết mảng mà vẫn -1 thì nghĩa là mảng giảm dần, đảo ngược lại là đủ
            while (i >= 0)
            {
                if (nums[i] < nums[i + 1])
                {
                    startPoint = i;
                    flag = 0;

                    // Tìm phần tử nhỏ nhất trong đoạn [nums[i + 1], .., end]
                    for (int j = nums.Length - 1; j > i; j--)
                    {
                        if (nums[j] > nums[i])
                        {
                            Swap(nums, i, j);
                            Reverse(nums, i + 1);
                            return;
                        }
                    }
                }
                i--;
            }

            if (flag == -1)
            {
                Reverse(nums, 0);
                return;
            }
        }

        public void Reverse(int[] nums, int startPoint)
        {
            int i = startPoint, j = nums.Length - 1;
            while (i < j)
            {
                if (nums[i] > nums[j]) Swap(nums, i, j);
                i++; j--;
            }
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = 0;
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
