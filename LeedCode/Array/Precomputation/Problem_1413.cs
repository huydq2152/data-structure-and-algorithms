namespace LeedCode;

public class Problem_1413
{
    public int MinStartValue(int[] nums)
    {
        var numsLength = nums.Length;
        if (numsLength == 0) return 1;
        var minSum = nums[0];
        var currentSum = nums[0];
        for (int i = 1; i < numsLength; i++)
        {
            currentSum += nums[i];
            minSum = Math.Min(minSum, currentSum);
        }

        if (minSum > 0) return 1;
        return 1 - minSum;
    }
}