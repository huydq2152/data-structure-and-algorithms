namespace LeedCode;

public class Problem_187
{
    public IList<string> FindRepeatedDnaSequences(string s) {
        List<string> result = new List<string>();
        int sLength = s.Length;
        if (sLength < 10)
        {
            return result;
        }

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        for (int i = 0; i + 9 < sLength; i++)
        {
            string temp = s.Substring(i, 10);
            if (dictionary.TryGetValue(temp, out int appearCount))
            {
                if (appearCount == 1)
                {
                    result.Add(temp);
                }

                dictionary[temp]++;
            }
            else
            {
                dictionary.Add(temp, 1);
            }
        }

        return result;
    }
}