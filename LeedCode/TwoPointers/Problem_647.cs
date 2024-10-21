namespace LeedCode;

public class Problem_647
{
    public int CountSubstrings(string s)
    {
        int result = 0;
        int sLength = s.Length;
        for (int i = 0; i < sLength; i++)
        {
            result += CountPalindrome(s, i, i) + CountPalindrome(s, i, i + 1);
        }

        return result;
    }

    public int CountPalindrome(string s, int left, int right)
    {
        int sLength = s.Length;
        int result = 0;
        while (left >= 0 && right < sLength && s[left] == s[right])
        {
            left--;
            right++;
            result++;
        }

        return result;
    }
}