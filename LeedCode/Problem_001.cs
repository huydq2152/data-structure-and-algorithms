namespace LeedCode;

public class Problem_001
{
    public int[] TwoSum(int[] nums, int target)
    {
        int numsLength = nums.Length;
        Dictionary<int, int> tempDict = new Dictionary<int, int>();

        for (int i = 0; i < numsLength; i++)
        {
            var temp = nums[i];
            var compliment = target - temp;
            if (tempDict.TryGetValue(compliment, out var complimentIndex))
            {
                return new[] { i, complimentIndex };
            }

            tempDict[temp] = i;
        }

        return Array.Empty<int>();
    }
}