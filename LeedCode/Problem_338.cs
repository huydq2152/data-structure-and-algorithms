namespace LeedCode;

public class Problem_338
{
    public int[] CountBits(int n)
    {
        int[] result = new int[n + 1];
        result[0] = 0;
        int offset = 1;
        for (int i = 1; i < n + 1; i++)
        {
            if (offset * 2 == i) offset = i;
            result[i] = 1 + result[i - offset];
        }

        return result;
    }
}