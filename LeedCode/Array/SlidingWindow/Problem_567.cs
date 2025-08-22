namespace LeedCode;

public class Problem_567
{
    public bool CheckInclusion(string s1, string s2) {
        int s1Length = s1.Length;
        int s2Length = s2.Length;
        
        if(s1Length > s2Length){
            return false;
        }

        int[] s1Map = new int[26];
        int[] s2Map = new int[26];

        for(int i = 0; i < s1Length; i++){
            s1Map[s1[i] - 'a']++;
            s2Map[s2[i] - 'a']++;
        }

        if(s1Map.SequenceEqual(s2Map)){
            return true;
        }

        for(int i = s1Length; i < s2Length; i++){
            s2Map[s2[i] - 'a']++;
            s2Map[s2[i-s1Length] - 'a']--;

            if(s1Map.SequenceEqual(s2Map)){
                return true;
            }
        }

        return false;
    }
}