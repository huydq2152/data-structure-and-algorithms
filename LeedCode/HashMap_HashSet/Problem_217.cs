namespace LeedCode;

public class Problem_217
{
    public bool ContainsDuplicate(int[] nums)
    {
        int numsLength = nums.Length;
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < numsLength; i++)
        {
            if (hashSet.Contains(nums[i]))
            {
                return true;
            }
            hashSet.Add(nums[i]);
        }

        return false;
    }
}