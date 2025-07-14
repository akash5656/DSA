public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int n = arr.Length;
        int l = 0;
        int r = n-1;
        int mid = 0;
        while(l<r)
        {
            mid = l + (r-l)/2;
            if(arr[mid]<arr[mid+1])
            {
                l = mid+1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }
}