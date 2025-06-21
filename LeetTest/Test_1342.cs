namespace LeetTest
{
    public class Test_1342 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int input = 14;
            int expected = 6;
            int actual = _solution.NumberOfSteps(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case2()
        {
            int input = 8;
            int expected = 4;
            int actual = _solution.NumberOfSteps(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case3()
        {
            int input = 123;
            int expected = 12;
            int actual = _solution.NumberOfSteps(input);

            Assert.Equal(expected, actual);
        }
    }
}
