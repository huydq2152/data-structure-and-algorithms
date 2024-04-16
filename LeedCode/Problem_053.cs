namespace LeedCode;

public class Problem_053
{
    public int MaxSubArray(int[] nums)
    {
        int numsLength = nums.Length;
        int result = nums[0];
        int currentMaxSum = nums[0];
        for (int i = 1; i < numsLength; i++)
        {
            currentMaxSum = Math.Max(nums[i], currentMaxSum + nums[i]);
            result = Math.Max(currentMaxSum, result);
        }

        return result;
    }
}