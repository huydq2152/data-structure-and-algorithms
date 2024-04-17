namespace LeedCode;

public class Problem_020
{
    public bool IsValid(string s)
    {
        int sLength = s.Length;
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < sLength; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0) return false;
                char temp = stack.Pop();
                if ((s[i] == ')' && temp != '(') ||
                    (s[i] == '}' && temp != '{') ||
                    (s[i] == ']' && temp != '[')) return false;
            }
        }

        return stack.Count == 0;
    }
}