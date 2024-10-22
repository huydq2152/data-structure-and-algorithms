namespace LeedCode;

public class NumArray
{
    private int[] prefixSum;

    public NumArray(int[] nums)
    {
        int numsLength = nums.Length;
        prefixSum = new int[numsLength + 1];
        for (int i = 0; i < numsLength; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return prefixSum[right + 1] - prefixSum[left];
    }
}