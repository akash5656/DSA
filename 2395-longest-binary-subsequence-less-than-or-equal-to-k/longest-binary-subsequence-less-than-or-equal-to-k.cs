public class Solution {
    public int LongestSubsequence(string s, int k) {
        
        int n = s.Length;
        long val = 0;
        int count = 0;
        int power = 0;

        for(int i=n-1;i>=0;i--)
        {
            if(s[i] == '0')
            {
                count++;
            }
            else
            {
                if(power < 32)
                {
                    long tempValue = val + (1L << power);
                    if(tempValue <= k)
                    {
                        val = tempValue;
                        count++;
                    }

                }
            }
            power++;
        }

        return count;

    }
}