namespace LeedCode;

public class Problem_643
{
    public double FindMaxAverage(int[] nums, int k) {
        int numsLength = nums.Length;
        double sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double max = sum;

        for (int i = k; i < numsLength; i++)
        {
            sum += nums[i];
            sum -= nums[i - k];

            if (max < sum)
            {
                max = sum;
            }
        }
        
        return max / k;
    }
}