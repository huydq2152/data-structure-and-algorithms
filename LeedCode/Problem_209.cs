namespace LeedCode;

public class Problem_209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int numsLength = nums.Length;
        int left = 0;
        int right = 0;
        int currentSum = 0;
        int result = int.MaxValue;
        for (; right < numsLength; right++)
        {
            currentSum += nums[right];
            while (currentSum >= target)
            {
                result = Math.Min(result, right - left + 1);
                currentSum -= nums[left];
                left++;
            }
        }

        return result == int.MaxValue ? 0 : result;
    }
}