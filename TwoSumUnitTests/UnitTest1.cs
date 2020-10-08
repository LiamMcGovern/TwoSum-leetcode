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
        
        [Theory]
        [InlineData( new int []{230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789} , 542, new int[]{1,0})]
        public void TwoSum_FindsTarget_When_ListHasDuplicates(int[] nums, int target, int[] expected)
        {
            Console.WriteLine($"[28]:{nums[28]}");
            Console.WriteLine($"[45]:{nums[45]}");
            
            var actual = Solution.TwoSum(nums,target);

            Assert.Equal(expected, actual );
        } 
        
        

    }
}