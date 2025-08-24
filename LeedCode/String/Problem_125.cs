namespace LeedCode.String;

public class Problem_125
{
    public bool IsPalindrome(string s)
    {
        int sLength = s.Length;
        int left = 0;
        int right = sLength - 1;
        s = s.ToLower();

        while (left < right)
        {
            if (!char.IsLetter(s[left]) && !char.IsNumber(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetter(s[right]) && !char.IsNumber(s[right]))
            {
                right--;
                continue;
            }

            if (s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}