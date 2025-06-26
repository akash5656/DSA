public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string,List<string>> map = new();

        for(int i = 0;i<strs.Length;i++)
        {
            var array = strs[i].ToCharArray();
            Array.Sort(array);
            var str = new string(array);

            if(!map.ContainsKey(str))
            {
                map[str] = new List<string>();
            }
                map[str].Add(strs[i]);
        }

        return map.Values.ToList<IList<string>>();
    }
}