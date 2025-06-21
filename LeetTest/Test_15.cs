using LeetCode;

namespace LeetTest
{
    public class Test_15 : TestInit
    {
        // Custom comparer để hỗ trợ Assert.Equal với danh sách lồng nhau
        public class SequenceEqualComparer<T> : IEqualityComparer<T> where T : IEnumerable<int>
        {
            public bool Equals(T x, T y) => x.SequenceEqual(y);
            public int GetHashCode(T obj)
            {
                unchecked
                {
                    return obj.Aggregate(17, (hash, val) => hash * 31 + val.GetHashCode());
                }
            }
        }

        [Fact]
        public void Case1()
        {
            int[] nums = new[] { -1, 0, 1, 2, -1, -4 };

            var expected = new List<IList<int>>
            {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 }
            };

            var actual = _solution.ThreeSum(nums);

            // So sánh không cần đúng thứ tự bộ ba, nhưng cần nội dung giống nhau
            Assert.Equal(
                expected.Select(triplet => triplet.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                actual.Select(triplet => triplet.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                new SequenceEqualComparer<IEnumerable<int>>()
            );
        }

        [Fact]
        public void Case2_NoTripletSumsToZero()
        {
            int[] nums = new[] { 0, 1, 1 };

            var expected = new List<IList<int>>(); // Empty result
            var actual = _solution.ThreeSum(nums);

            Assert.Empty(actual);
        }

        [Fact]
        public void Case3_AllZerosTriplet()
        {
            int[] nums = new[] { 0, 0, 0 };

            var expected = new List<IList<int>>
            {
                new List<int> { 0, 0, 0 }
            };

            var actual = _solution.ThreeSum(nums);

            Assert.Equal(
                expected.Select(t => t.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                actual.Select(t => t.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                new SequenceEqualComparer<IEnumerable<int>>()
            );
        }

        [Fact]
        public void Case4()
        {
            int[] nums = new[] { 1, -1, -1, 0 };

            var expected = new List<IList<int>>
            {
                new List<int> { -1, 0, 1 }
            };

            var actual = _solution.ThreeSum(nums);

            Assert.Equal(
                expected.Select(t => t.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                actual.Select(t => t.OrderBy(x => x)).OrderBy(t => string.Join(",", t)),
                new SequenceEqualComparer<IEnumerable<int>>()
            );
        }
    }
}
