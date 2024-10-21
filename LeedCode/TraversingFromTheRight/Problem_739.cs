namespace LeedCode;

public class Problem_739
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int tempLength = temperatures.Length;
        int[] result = new int[tempLength];
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < tempLength; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int index = stack.Pop();
                result[index] = i - index;
            }
            stack.Push(i);
        }

        return result;
    }
}