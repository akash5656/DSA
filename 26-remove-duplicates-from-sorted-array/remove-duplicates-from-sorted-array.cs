public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int res = 1;
        int count = 1;
        for(int i =1 ;i < nums.Length; i++){
            if(nums[res-1]!=nums[i]) {
                nums[res] = nums[i];
                res++;
                count++;
            }
        }
        return count;
    }
}