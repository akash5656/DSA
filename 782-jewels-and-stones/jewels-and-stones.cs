public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;

        HashSet<char> set = new HashSet<char>();

        foreach(var j in jewels)
        {
            set.Add(j);
        }

        foreach(var stone in stones)
        {
                if(set.Contains(stone))
                {
                    count++;
                }
        }

        return count;
    }
}