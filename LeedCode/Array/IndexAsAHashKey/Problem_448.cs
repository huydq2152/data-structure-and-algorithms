namespace LeedCode.Array.IndexAsAHashKey;

public class Problem_448
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int numsLength = nums.Length;
        for (int i = 0; i < numsLength; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
            {
                nums[index] = -nums[index];
            }
        }

        IList<int> result = new List<int>();

        for (int i = 0; i < numsLength; i++)
        {
            if (nums[i] > 0)
            {
                result.Add(i + 1);
            }
        }

        return result;
    }
}