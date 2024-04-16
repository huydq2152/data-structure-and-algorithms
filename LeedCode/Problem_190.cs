namespace LeedCode;

public class Problem_190
{
    public uint reverseBits(uint n)
    {
        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            res = (res << 1) | (n & 1);
            n >>= 1;
        }

        return res;
    }
}