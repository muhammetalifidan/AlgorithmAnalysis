namespace ConsoleApp;

public class MaxSubarrayContext
{
    private readonly IMaxSubarrayStrategy _maxSubarrayStrategy;

    public MaxSubarrayContext(IMaxSubarrayStrategy maxSubarrayStrategy)
    {
        _maxSubarrayStrategy = maxSubarrayStrategy;
    }

    public int FindMaxSubarray(int[] nums)
    {
        return _maxSubarrayStrategy.FindMaxSubarray(nums);
    }
}
