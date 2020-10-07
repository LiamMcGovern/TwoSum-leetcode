using System;
using System.Collections.Generic;

namespace TwoSum_leetcode
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {                            
            // <value at index x, index>
            var dict = new Dictionary<int,int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int calc = target - nums[i];

                if (dict.ContainsKey(calc))
                {
                    return new int[] { i, dict[calc]};
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            
            return null;
        }
    }
}