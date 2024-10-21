namespace LeedCode;

public class Problem_075
{
    public void SortColors(int[] nums)
    {
        int numsLength = nums.Length;
        int left = 0;
        int right = numsLength - 1;
        int current = 0;
        while (current <= right)
        {
            if (nums[current] == 0)
            {
                int temp = nums[left];
                nums[left] = 0;
                nums[current] = temp;
                left++;
                current++;
            }
            else if (nums[current] == 2)
            {
                int temp = nums[right];
                nums[right] = 2;
                nums[current] = temp;
                right--;
            }
            else
            {
                current++;
            }
        }
    }
}