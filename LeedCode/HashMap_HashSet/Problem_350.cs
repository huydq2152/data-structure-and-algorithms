namespace DataStructuresAndAlgorithms.LeetCode.HashMap_HashSet
{
    public class Problem_350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            int nums1Length = nums1.Length;
            int nums2Length = nums2.Length;

            List<int> result = new List<int>();

            Array.Sort(nums1);
            Array.Sort(nums2);

            int i = 0;
            int j = 0;

            while (i < nums1Length && j < nums2Length)
            {
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result.ToArray();
        }
    }
}