namespace LeedCode;

public class Problem_015
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        int numsLength = nums.Length;
        List<IList<int>> result = new List<IList<int>>();
        System.Array.Sort(nums);
        for (int i = 0; i < numsLength; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int twoSum = -nums[i];
            int left = i + 1;
            int right = numsLength - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] == twoSum)
                {
                    result.Add(new List<int>()
                    {
                        nums[i], nums[left], nums[right]
                    });
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (nums[left] + nums[right] < twoSum) left++;
                else right--;
            }
        }

        return result;
    }
}