namespace LeedCode;

public class Problem_435
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        int intervalsLength = intervals.Length;
        System.Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int result = 0;
        int prevEnd = intervals[0][1];
        for (int i = 1; i < intervalsLength; i++)
        {
            if (intervals[i][0] < prevEnd)
            {
                result++;
            }
            else
            {
                prevEnd = intervals[i][1];
            }
        }

        return result;
    }
}