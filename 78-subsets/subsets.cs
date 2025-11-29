public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new();
        List<int> current = new();

        BackTrack(0);

        void BackTrack(int start)
        {
            result.Add(new List<int>(current));

            for(int i = start; i < nums.Length; i++) 
            {
                current.Add(nums[i]);
                BackTrack(i + 1);
                current.RemoveAt(current.Count-1);
            }
        }

        return result;
    }
}