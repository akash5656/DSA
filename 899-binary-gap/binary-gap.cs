public class Solution {
    public int BinaryGap(int n) {

        int current = 0;
        int prev = 0;
        int max = 0;

        while(n!=0)
        {
            int r = n & 1;
            current++;
            if(r == 1)
            {
                if(prev!=0)
                {
                    max = Math.Max(max,current-prev);
                }
                prev = current;
            }
            n = n>>1;
        }

        return max;
        
    }
}