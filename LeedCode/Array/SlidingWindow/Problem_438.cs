namespace LeedCode;

public class Problem_438
{
    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        var sLength = s.Length;
        var pLength = p.Length;
        if (sLength < pLength)
        {
            return result;
        }

        int[] sMap = new int[26];
        int[] pMap = new int[26];

        for (int i = 0; i < pLength; i++)
        {
            sMap[s[i] - 'a']++;
            pMap[p[i] - 'a']++;
        }

        if (sMap.SequenceEqual(pMap))
        {
            result.Add(0);
        }

        for (int i = pLength; i < sLength; i++)
        {
            sMap[s[i] - 'a']++;
            sMap[s[i - pLength] - 'a']--;

            if (sMap.SequenceEqual(pMap))
            {
                result.Add(i - pLength + 1);
            }
        }

        return result;
    }
}