public class Solution {
    public int MaxFreqSum(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(var c in s)
        {
            if(map.ContainsKey(c)) 
            {
                map[c]++;
            }
            else
            {
                map[c] = 1;
            }
        }

        int maxVowel = 0;
        int maxConsonant = 0;

        foreach(var k in map)
        {

            if(k.Key == 'a' || k.Key == 'e' || k.Key == 'i' || k.Key == 'o' || k.Key == 'u' )
            {
                maxVowel = Math.Max(maxVowel,k.Value);
            }
            else
            {
                maxConsonant = Math.Max(maxConsonant,k.Value);
            }
        }

        return maxConsonant + maxVowel;
    }
}