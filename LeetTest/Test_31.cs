using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTest
{
    public class Test_31 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int[] nums = new int[] { 1, 2, 3 };
            int[] expected = new int[] { 1, 3, 2 };

            _solution.NextPermutation(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void Case2()
        {
            int[] nums = new int[] { 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3 };

            _solution.NextPermutation(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void Case3()
        {
            int[] nums = new int[] { 1, 1, 5 };
            int[] expected = new int[] { 1, 5, 1 };

            _solution.NextPermutation(nums);
            Assert.Equal(expected, nums);
        }

        [Fact]
        public void Case4()
        {
            int[] nums = new int[] { 1, 3, 5, 4, 2 };
            int[] expected = new int[] { 1, 4, 2, 3, 5 };

            _solution.NextPermutation(nums);
            Assert.Equal(expected, nums);
        }
    }
}
