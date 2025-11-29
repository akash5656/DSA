public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> res = new();
        List<int> current =  new();

        BackTrack(1);

        void BackTrack(int start)
        {
            if(current.Count == k)
                res.Add(new List<int>(current));
            
            for(int i = start; i <= n; i++)
            {
                current.Add(i);
                BackTrack(i+1);
                current.RemoveAt(current.Count-1);
            }
        }

        return res;
    }
}