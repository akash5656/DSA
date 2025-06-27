public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        Stack<int> stack = new();
        Dictionary<int,int> map = new();

        for(int i = nums2.Length-1;i>=0;i--)
        {

            if(stack.Count == 0)
            {
                stack.Push(nums2[i]);
                map.Add(nums2[i],-1);
            }
            else if(stack.Peek() > nums2[i])
            {
                map.Add(nums2[i],stack.Peek());
                stack.Push(nums2[i]);
            }
            else
            {
                while(stack.Count !=0 && stack.Peek() < nums2[i])
                {
                    stack.Pop();
                }
                if(stack.Count == 0)
                {
                    stack.Push(nums2[i]);
                    map.Add(nums2[i],-1);
                }
                else
                {
                    map.Add(nums2[i],stack.Peek());
                    stack.Push(nums2[i]);
                }
            }
        }

        // foreach(var k in map)
        // {
        //     Console.Write(k.Key+" "+k.Value);
        // }

        List<int> ans = new();
        foreach(var num in nums1)
        {
            ans.Add(map[num]);
        }

        return ans.ToArray();

    }
}