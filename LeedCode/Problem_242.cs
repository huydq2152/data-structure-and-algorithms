namespace LeedCode;

public class Problem_242
{
    public bool IsAnagram(string s, string t)
    {
        int sLength = s.Length;
        int tLength = t.Length;
        int[] countChar = new int[26];

        if (sLength != tLength) return false;
        for (int i = 0; i < sLength; i++)
        {
            countChar[s[i] - 'a']++;
            countChar[t[i] - 'a']--;
        }

        for (int i = 0; i < 26; i++)
        {
            if (countChar[i] != 0) return false;
        }

        return true;
    }
}