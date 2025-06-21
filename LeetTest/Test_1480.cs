namespace LeetTest
{
    public class Test_1480 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int[] input = [1, 2, 3, 4];
            int[] expected = [1, 3, 6, 10];
            int[] actual = _solution.RunningSum(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case2()
        {
            int[] input = [1, 1, 1, 1, 1];
            int[] expected = [1, 2, 3, 4, 5];
            int[] actual = _solution.RunningSum(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case3()
        {
            int[] input = [3, 1, 2, 10, 1];
            int[] expected = [3, 4, 6, 16, 17];
            int[] actual = _solution.RunningSum(input);

            Assert.Equal(expected, actual);
        }
    }
}