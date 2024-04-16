namespace LeedCode;

public class Problem_011
{
    public int MaxArea(int[] height)
    {
        int result = 0;
        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                result = Math.Max(result, (right - left) * height[left]);
                left++;
            }
            else
            {
                result = Math.Max(result, (right - left) * height[right]);
                right--;
            }
        }

        return result;
    }
}