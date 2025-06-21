namespace LeetCode
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.com/problems/3sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        while (left < right && nums[right - 1] == nums[right]) right--;
                        while (left < right && nums[left + 1] == nums[left]) left++;
                        left++; right--;
                    }
                    else if (sum < 0) left++;
                    else right--;
                }
            }
            return res;
        }
    }
}
