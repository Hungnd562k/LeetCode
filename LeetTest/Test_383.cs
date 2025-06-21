namespace LeetTest
{
    public class Test_383 : TestInit
    {
        [Fact]
        public void Case1()
        {
            string ransomNote = "a";
            string magazine = "b";
            bool actual = _solution.CanConstruct(ransomNote, magazine);

            Assert.False(actual);
        }

        [Fact]
        public void Case2()
        {
            string ransomNote = "aa";
            string magazine = "ab";
            bool actual = _solution.CanConstruct(ransomNote, magazine);

            Assert.False(actual);
        }

        [Fact]
        public void Case3()
        {
            string ransomNote = "aa";
            string magazine = "aab";
            bool actual = _solution.CanConstruct(ransomNote, magazine);

            Assert.True(actual);
        }
    }
}
