namespace LeedCode;

public class Problem_268
{
    public int MissingNumber(int[] nums)
    {
        // hint: xor 2 number has same value will return 0 
        int numsLength = nums.Length;
        int result = numsLength;
        for (int i = 0; i < numsLength; i++)
        {
            result ^= i ^ nums[i];
        }

        return result;
    }
}