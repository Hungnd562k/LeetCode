using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetTest.Test_15;

namespace LeetTest
{
    public class Test_18 : TestInit
    {
        [Fact]
        public void Case1()
        {
            int[] nums = new[] { 1, 0, -1, 0, -2, 2 };
            int target = 0;

            var expected = new List<IList<int>>
            {
                new List<int> { -2,-1,1,2 },
                new List<int> { -2, 0, 0, 2 },
                new List<int> { -1, 0, 0, 1 }
            };

            var actual = _solution.FourSum(nums, target);

            // So sánh không cần đúng thứ tự bộ ba, nhưng cần nội dung giống nhau
            Assert.Equal(
                expected.Select(triplet => triplet.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                actual.Select(triplet => triplet.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                new SequenceEqualComparer<IEnumerable<int>>()
            );
        }

        [Fact]
        public void Case2()
        {
            int[] nums = new[] { 2, 2, 2, 2, 2 };
            int target = 8;

            var expected = new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2}
            };

            var actual = _solution.FourSum(nums, target);

            // So sánh không cần đúng thứ tự bộ ba, nhưng cần nội dung giống nhau
            Assert.Equal(
                expected.Select(triplet => triplet.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                actual.Select(triplet => triplet.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                new SequenceEqualComparer<IEnumerable<int>>()
            );
        }
    }
}
