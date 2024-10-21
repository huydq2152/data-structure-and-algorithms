namespace LeedCode;

public class Problem_1944
{
    public int[] CanSeePersonsCount(int[] heights)
    {
        int heightsLength = heights.Length;
        int[] result = new int[heightsLength];
        Stack<int> stack = new Stack<int>();

        for (int i = heightsLength - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() < heights[i])
            {
                stack.Pop();
                result[i]++;
            }

            if (stack.Count > 0)
            {
                result[i]++;
            }

            stack.Push(heights[i]);
        }

        return result;
    }
}