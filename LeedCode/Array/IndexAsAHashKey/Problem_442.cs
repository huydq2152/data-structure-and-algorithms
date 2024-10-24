namespace LeedCode.Array.IndexAsAHashKey;

public class Problem_442
{
    public IList<int> FindDuplicates(int[] nums)
    {
        int numsLength = nums.Length;
        IList<int> result = new List<int>();
        for (int i = 0; i < numsLength; i++)
        {
            int positiveNum = Math.Abs(nums[i]);
            int index = positiveNum - 1;
            if (nums[index] < 0)
            {
                result.Add(positiveNum);
            }
            else
            {
                nums[index] = -nums[index];
            }
        }

        return result;
    }
}