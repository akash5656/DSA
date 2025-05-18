public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 1;
        int res = 0;

        for(int i =1;i < nums.Length;i++)
         {
            if(nums[res]==nums[i]){
                count++;
            }
            else {
                count--;
            }

            if(count == 0) {
                res = i;
                count = 1;
            }
        }

        count = 0;

        for(int i =0;i<nums.Length;i++)
        {
            if(nums[i]==nums[res])
            {
                count++;
            }
        }

        if(count > nums.Length/2)
        {
            return nums[res];
        }
        else
        return -1;
    }
}