namespace LeedCode;

public class Problem_026
{
    public int RemoveDuplicates(int[] nums)
    {
        int numsLength = nums.Length;
        int result = 1;
        for (int i = 1; i < numsLength; i++)
        {
            if(nums[i] == nums[i-1]) continue;
            nums[result] = nums[i];
            result++;
        }

        return result;
    }
}