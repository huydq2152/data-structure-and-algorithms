namespace LeedCode;

public class Problem_371
{
    public int GetSum(int a, int b)
    {
        while (b != 0)
        {
            int carry = a & b;
            a ^= b;
            b = carry << 1;
        }
        return a;
    }
}