public class Solution {
    public int Trap(int[] height) {
        int res = 0;
        int[] lmax = new int[height.Length];
        int[] rmax = new int[height.Length];
        int n = height.Length;
        lmax[0] = height[0];
        rmax[rmax.Length-1] = height[height.Length-1];

        for(int i = 1;i<n;i++) {
            lmax[i] = Math.Max(lmax[i-1],height[i]);
        }
        for(int j = n-2;j>=0;j--) {
            rmax[j] = Math.Max(rmax[j+1],height[j]);
        }

        for(int i = 1; i<n-1;i++){
            res+= Math.Min(lmax[i],rmax[i])-height[i];
        }
        return res;
    }
}