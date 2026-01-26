public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> result = new();
        List<int> current = new();
        BackTrack();

        void BackTrack()
        {
            if(current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
            }
            for(int i = 0;i < nums.Length; i++)
            {
                if(!current.Contains(nums[i]))
                {
                    current.Add(nums[i]);
                    BackTrack();
                    current.RemoveAt(current.Count-1);
                }
            }
        }

        return result;
    }
}