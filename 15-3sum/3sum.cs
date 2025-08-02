public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {

        Array.Sort(nums);

        List<IList<int>> ans = new();
        for(int i = 0; i < nums.Length; i++)
        {
            if(i == 0  || nums[i] != nums[i - 1])
                CheckSum(nums,i, ans);
        }

        return ans;
        
    }

    public void CheckSum(int[] nums,int idx,IList<IList<int>> ans)
    {
        int i = idx + 1;
        int j = nums.Length - 1;

        while(i < j)
        {
            int sum = nums[i] + nums[idx] + nums[j];
            if(sum > 0)
            {
                --j;
            }
            else if(sum < 0)
            {
                ++i;
            }
            else
            {
                ans.Add(new List<int>(){nums[i],nums[j],nums[idx]});
                ++i;
                --j;
                while (i < j && nums[i] == nums[i - 1]) ++i;
                while (i < j && nums[j] == nums[j + 1]) --j;
            }
        }
    }
}