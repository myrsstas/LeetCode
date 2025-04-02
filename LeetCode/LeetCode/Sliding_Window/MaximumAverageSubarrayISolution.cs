namespace LeetCode.Sliding_Window;

/*
 You are given an integer array nums consisting of n elements, and an integer k.
Find a contiguous subarray whose length is equal to k that has the maximum average value 
and return this value. Any answer with a calculation error less than 10-5 will be accepted.

Example :
Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
 */

public class MaximumAverageSubarrayISolution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double maxAverage = sum;

        for (int i = k; i < nums.Length; i++)
        {
            sum = sum - nums[i - k] + nums[i];
            maxAverage = Math.Max(maxAverage, sum);
        }

        return maxAverage / k;
    }
}