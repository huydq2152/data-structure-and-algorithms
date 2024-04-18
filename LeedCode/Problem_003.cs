namespace LeedCode;

public class Problem_003
{
    public int LengthOfLongestSubstring(string s)
    {
        int sLength = s.Length;

        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        int result = 0;
        int left = 0;
        int right = 0;
        while (right < sLength)
        {
            if (dictionary.ContainsKey(s[right]) && dictionary[s[right]] >= left)
            {
                left = dictionary[s[right]] + 1;
            }
            dictionary[s[right]] = right;

            result = Math.Max(result, right - left + 1);
            right++;
        }

        return result;
    }
}