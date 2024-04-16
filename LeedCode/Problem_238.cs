namespace LeedCode;

public class Problem_238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int numsLength = nums.Length;
        int[] result = new int[numsLength];
        var leftProduct = 1;
        for (int i = 0; i < numsLength; i++)
        {
            result[i] = leftProduct;
            leftProduct *= nums[i];
        }

        int rightProduct = 1;
        for (int i = numsLength - 1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return result;
    }
}