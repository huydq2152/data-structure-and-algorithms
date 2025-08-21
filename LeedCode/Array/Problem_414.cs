namespace LeedCode;

public class Problem_414
{
    public int ThirdMax(int[] nums)
    {
        long max1 = long.MinValue;
        long max2 = long.MinValue;
        long max3 = long.MinValue;

        foreach (var num in nums)
        {
            if (num == max1 || num == max2 || num == max3) continue;
            if (num > max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (num > max2)
            {
                max3 = max2;
                max2 = num;
            }
            else if (num > max3)
            {
                max3 = num;
            }
        }

        return (int)(max3 == long.MinValue ? max1 : max3);
    }
}