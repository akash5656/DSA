public class Solution {
    public void Rotate(int[] nums, int k) {

        if(k > nums.Length) {
            k = k%nums.Length;
        }

        Array.Reverse(nums,0,nums.Length - k);
        Array.Reverse(nums,nums.Length-k,k);
        Array.Reverse(nums,0,nums.Length);
        
    }
}