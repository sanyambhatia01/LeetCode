using LeetCode;

namespace UnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4, 6, 9, 13 }, 2, 1)]
        [InlineData(new int[] { 1, 2, 4, 6, 9, 13 }, 3, 2)]
        [InlineData(new int[] { 1, 2, 4, 6, 9, 13 }, 6, 3)]
        [InlineData(new int[] { 1, 2, 4, 6, 9, 13 }, 8, 4)]
        [InlineData(new int[] { 1, 2, 4, 6, 9, 13 }, 13, 5)]

        public void SearchInsertPositionTest(int[] nums, int target, int expected)
        {
            var actual = SearchInsertPosition.SearchPoition(nums, target);

            Assert.Equal(expected, actual);
        }
    }
}