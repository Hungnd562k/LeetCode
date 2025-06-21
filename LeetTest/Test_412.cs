namespace LeetTest
{
    public class Test_412 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int input = 3;
            IList<string> expected = ["1", "2", "Fizz"];
            IList<string> actual = _solution.FizzBuzz(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case2()
        {
            int input = 5;
            IList<string> expected = ["1", "2", "Fizz", "4", "Buzz"];
            IList<string> actual = _solution.FizzBuzz(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Case3()
        {
            int input = 15;
            IList<string> expected = ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"];
            IList<string> actual = _solution.FizzBuzz(input);

            Assert.Equal(expected, actual);
        }
    }
}
