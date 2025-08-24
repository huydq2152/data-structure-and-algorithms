namespace LeedCode.HashMap_HashSet
{
    public class Problem_387
    {
        public int FirstUniqChar(string s)
        {
            int sLength = s.Length;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < sLength; i++)
            {
                if (!dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i], 1);
                }
                else
                {
                    dictionary[s[i]]++;
                }
            }

            for (int i = 0; i < sLength; i++)
            {
                if (dictionary[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}