namespace LeedCode;

public class Problem_153
{
    public int FindMin(int[] nums)
    {
        int numsLength = nums.Length;
        int left = 0;
        int right = numsLength - 1;

        if (nums[left] < nums[right]) return nums[left];
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left];
    }
}