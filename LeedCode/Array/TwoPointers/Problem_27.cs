namespace LeedCode;

public class Problem_27
{
    public int RemoveElement(int[] nums, int val) {
        int numLength = nums.Length;
        int resultIndex = 0;

        for (int i = 0; i < numLength; i++)
        {
            if (nums[i] != val)
            {
                nums[resultIndex] = nums[i];
                resultIndex++;
            }
        }
        return resultIndex;
    }
}