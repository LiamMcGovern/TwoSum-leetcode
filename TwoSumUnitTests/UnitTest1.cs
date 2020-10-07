using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using TwoSum_leetcode;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData( new int []{11,2,3,4,6,2,7,11,15} , 9, new int[]{4,2})]
        [InlineData( new int []{3,2,4} , 6, new int[]{2,1})]
        [InlineData( new int []{3,3} , 6, new int[]{1,0})]
        public void TwoSum_FindsTarget_When_InOrder(int[] nums, int target, int[] expected)
        {
            var actual = Solution.TwoSum(nums,target);

            Assert.Equal(expected, actual );
        } 
        
        
        [Theory]
        [InlineData( new int []{3,5,2,7,8,14} , 9, new int[]{3,2})]
        public void TwoSum_LiamTest(int[] nums, int target, int[] expected)
        {
            var actual = Solution.TwoSum(nums,target);

            Assert.Equal ( expected, actual);
        } 
        
    }
}