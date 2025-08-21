namespace LeedCode;

public class Problem_1876
{
    public int CountGoodSubstrings(string s) {
        int sLength = s.Length;
        int left = 0;
        int right = 2;
        int result = 0;
        while(right < sLength){
            if(s[right] != s[left] && s[right] != s[left + 1] && s[left] != s[left + 1]){
                result++;
            }
            left++;
            right++;
        }
        return result;
    }
}