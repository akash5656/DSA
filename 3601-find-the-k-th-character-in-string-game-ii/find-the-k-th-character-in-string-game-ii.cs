public class Solution {
    public char KthCharacter(long k, int[] operations) {
        
        if(k == 1)
            return 'a';

        long length = 1;

        long newK = -1;

        int operationType = -1;

        for(int i = 0; i < operations.Length; i++)
        {
            length *= 2;
            if(length >= k)
            {
                operationType = operations[i];
                newK = k - length/2;
                break;
            }
        }

        char c = KthCharacter(newK,operations);

        if(operationType == 0)
        {
            return c;
        }
        else
        {
            return c == 'z' ? 'a' : (char)((int)c + 1);
        }

    }
}