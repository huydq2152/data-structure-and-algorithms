namespace DataStructuresAndAlgorithms.LeetCode.HashMap_HashSet
{
    public class Problem_349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            int nums1Length = nums1.Length;
            int nums2Length = nums2.Length;
            HashSet<int> hashSet = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < nums1Length; i++)
            {
                if (!hashSet.Contains(nums1[i]))
                {
                    hashSet.Add(nums1[i]);
                }
            }

            for (int i = 0; i < nums2Length; i++)
            {
                if (hashSet.Contains(nums2[i]) && !result.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
            }

            return result.ToArray();
        }
    }
}