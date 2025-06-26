public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;

        foreach(var j in jewels)
        {
            foreach(var st in stones)
            {
                if(j == st)
                {
                    count++;
                }
            }
        }

        return count;
    }
}