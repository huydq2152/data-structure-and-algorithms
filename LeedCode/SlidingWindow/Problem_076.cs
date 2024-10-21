namespace LeedCode;

public class Problem_076
{
    public string MinWindow(string s, string t)
    {
        int sLength = s.Length;
        Dictionary<char, int> targetCharCount = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!targetCharCount.ContainsKey(c))
            {
                targetCharCount[c] = 0;
            }

            targetCharCount[c]++;
        }

        int requiredCharCount = targetCharCount.Count; // number of distinct char need form
        int formedCharCount = 0; // number of distinct char formed ( a char formed if number of this char in s' substring equal number of this char in t
        int left = 0;
        int minLength = int.MaxValue;
        int resultStartIndex = 0;

        for (int right = 0; right < sLength; right++)
        {
            char rightChar = s[right];
            if (targetCharCount.ContainsKey(rightChar))
            {
                targetCharCount[rightChar]--;
                if (targetCharCount[rightChar] == 0)
                {
                    formedCharCount++;
                }
            }

            while (left <= right && formedCharCount == requiredCharCount)
            {
                if (right - left + 1 < minLength)
                {
                    minLength = right - left + 1;
                    resultStartIndex = left;
                }

                char leftChar = s[left];
                if (targetCharCount.ContainsKey(leftChar))
                {
                    targetCharCount[leftChar]++;
                    if (targetCharCount[leftChar] > 0)
                    {
                        formedCharCount--;
                    }
                }

                left++;
            }
        }

        return minLength == int.MaxValue ? "" : s.Substring(resultStartIndex, minLength);
    }
}