namespace LeetTest
{
    public class Test_1672 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int[][] input = [[1, 2, 3], [3, 2, 1]];
            int expected = 6;
            int actual = _solution.MaximumWealth(input);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case2()
        {
            int[][] input = [[1, 5], [7, 3], [3, 5]];
            int expected = 10;
            int actual = _solution.MaximumWealth(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case3()
        {
            int[][] input = [[2, 8, 7], [7, 1, 3], [1, 9, 5]];
            int expected = 17;
            int actual = _solution.MaximumWealth(input);

            Assert.Equal(expected, actual);
        }
    }
}
