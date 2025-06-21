namespace LeetTest
{
    public class Test_26 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int[] nums = [1, 1, 2];
            int[] expectedNums = new int[] { 1, 2 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }

        [Fact]
        public void Case2()
        {
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int[] expectedNums = new int[] { 0, 1, 2, 3, 4 };

            int k = _solution.RemoveDuplicates(nums);

            Assert.Equal(expectedNums.Length, k);
            for (int i = 0; i < k; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }
    }
}
