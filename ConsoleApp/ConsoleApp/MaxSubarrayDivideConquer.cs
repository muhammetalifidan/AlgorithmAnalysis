﻿namespace ConsoleApp;

public class MaxSubarrayDivideConquer : IMaxSubarrayStrategy
{
    public int FindMaxSubarray(int[] nums)
    {
        return MaxSubArrayHelper(nums, 0, nums.Length - 1);
    }

    private static int MaxSubArrayHelper(int[] nums, int left, int right)
    {
        if (left == right)
            return nums[left];

        int mid = (left + right) / 2;

        int leftSum = MaxSubArrayHelper(nums, left, mid);
        int rightSum = MaxSubArrayHelper(nums, mid + 1, right);
        int crossingSum = MaxCrossingSum(nums, left, mid, right);

        return Math.Max(Math.Max(leftSum, rightSum), crossingSum);
    }

    private static int MaxCrossingSum(int[] nums, int left, int mid, int right)
    {
        int leftSum = int.MinValue;
        int sum = 0;
        for (int i = mid; i >= left; i--)
        {
            sum += nums[i];
            leftSum = Math.Max(leftSum, sum);
        }

        int rightSum = int.MinValue;
        sum = 0;
        for (int i = mid + 1; i <= right; i++)
        {
            sum += nums[i];
            rightSum = Math.Max(rightSum, sum);
        }

        return leftSum + rightSum;
    }
}
