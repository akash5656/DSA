public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {

        List<IList<int>> result = new();
        List<int> current = new();

        Array.Sort(nums);

        bool[] used = new bool[nums.Length];

        BackTrack();

        void BackTrack()
        {
            if(current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for(int i=0;i<nums.Length;i++)
            {

                if(used[i])
                    continue;

                if(i>0 && nums[i]==nums[i-1] && !used[i-1])
                    continue;
                
                used[i]= true;
                current.Add(nums[i]);
                BackTrack();
                current.RemoveAt(current.Count-1);
                used[i]=false;
            }
        }

        return result;
        
    }
}