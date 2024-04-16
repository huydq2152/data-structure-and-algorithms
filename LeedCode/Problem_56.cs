namespace LeedCode;

public class Problem_56
{
    public int[][] Merge(int[][] intervals)
    {
        int intervalsLength = intervals.Length;
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        int[] currentInterval = intervals[0];
        for (int i = 1; i < intervalsLength; i++)
        {
            if (intervals[i][0] <= currentInterval[1])
            {
                currentInterval[1] = Math.Max(currentInterval[1], intervals[i][1]);
            }
            else
            {
                result.Add(currentInterval);
                currentInterval = intervals[i];
            }
        }
        
        result.Add(currentInterval);

        return result.ToArray();
    }
}