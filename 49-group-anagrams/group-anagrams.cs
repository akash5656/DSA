public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> map = new();

        for(int i = 0;i<strs.Length;i++)
        {
            int[] freqArray = new int[26];
            string s = strs[i];
            for(int j =0;j<s.Length;j++)
            {
                int index = (int)s[j] - (int)'a';
                ++freqArray[index];
            }

            StringBuilder sb = new StringBuilder();
            for(int j = 0; j<freqArray.Length;j++)
            {
                char c = (char)('a' + j);
                sb.Append(c);
                sb.Append(freqArray[j]);
            }

            string key = sb.ToString();

            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        return map.Values.ToList<IList<string>>();
    }
}