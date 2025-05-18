public class Solution {
    public bool Check(int[] nums) {
        
        int decCount = 0;
        int sortCount = 0;

        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] >= nums[i-1]){
                sortCount++;
            }
            else{
                decCount++;
            }
        }

        if(sortCount == nums.Length-1 && decCount == 0 && nums[0] <= nums[nums.Length-1])
            return true;

        if(sortCount == nums.Length-2 && decCount == 1 && nums[0] >= nums[nums.Length-1])
            return true;
        else
            return false;

        return false;
    }
}