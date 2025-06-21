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
            long sum = 0;
            List<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                    int left = j + 1, right = nums.Length - 1;
                    while (left < right)
                    {
                        sum = (long)nums[i] + nums[j] + nums[left] + nums[right]; // Phải ép nums[i] thành kiểu long để tránh tràn số, chỉ cần 1 phần tử đầu trong biểu thức là đủ vì nó sẽ ép cả tổng luôn
                        if (sum == target)
                        {
                            res.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                            left++; right--;
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
