namespace LeedCode;

public class Problem_152
{
    public int MaxProduct(int[] nums)
    {
        int numsLength = nums.Length;
        int currentMax = nums[0];
        int currentMin = nums[0];
        int result = nums[0];
        for (int i = 1; i < numsLength; i++)
        {
            int tempCurrentMax = currentMax;
            currentMax = Math.Max(nums[i], Math.Max(currentMax * nums[i], currentMin * nums[i]));
            currentMin = Math.Min(nums[i], Math.Min(tempCurrentMax * nums[i], currentMin * nums[i]));

            result = Math.Max(currentMax, result);
        }

        return result;
    }
}