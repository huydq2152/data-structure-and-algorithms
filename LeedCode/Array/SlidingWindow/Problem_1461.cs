namespace LeedCode;

public class Problem_1461
{
    public bool HasAllCodes(string s, int k)
    {
        if (s.Length < k)
        {
            return false;
        }

        var seenSubstrings = new HashSet<string>();
        
        string currentSubstring = s.Substring(0, k);
        seenSubstrings.Add(currentSubstring);

        for (int i = k; i < s.Length; i++)
        {
            currentSubstring = currentSubstring.Substring(1) + s[i];
            seenSubstrings.Add(currentSubstring);
        }

        return seenSubstrings.Count == (long)Math.Pow(2, k);
    }
    
    // can use rolling hash use bits for sliding window
}