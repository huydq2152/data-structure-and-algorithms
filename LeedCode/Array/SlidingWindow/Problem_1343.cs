namespace LeedCode;

public class Problem_1343
{
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int arrLength = arr.Length;
        int left = 0;
        int right = 0;
        int sum = 0;
        int result = 0;
        
        for(;right < arrLength; right++){
            
            sum += arr[right];
            int size = right - left + 1;
            
            if(size > k){
                sum -= arr[left];
                left++;
                size--;
            }

            if(size < k){
                continue;
            }

            if(size == k){
                if(sum/k >= threshold){
                    result++;
                }
            }
        }
        return result;
    }
}