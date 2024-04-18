namespace LeedCode;

public class Problem_049
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] chars = str.ToArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);
            if (!dictionary.ContainsKey(sortedStr))
            {
                dictionary.Add(sortedStr, new List<string>()
                {
                    str
                });
            }
            else
            {
                dictionary[sortedStr].Add(str);
            }
        }

        return new List<IList<string>>(dictionary.Values);
    }
}