public class Solution {
    public int BalancedStringSplit(string s) {
        
        int count  = 0;

        int sum = 0;

        foreach(var k in s)
        {
            if(k == 'R')
            {
                sum += 1;
            }
            else
            {
                sum -= 1;
            }
            if(sum == 0)
            {
                count++;
            }

        }

        return count;
    }
}