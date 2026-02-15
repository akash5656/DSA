public class Solution {
    public string AddBinary(string a, string b) {

        int m = a.Length-1;
        int n = b.Length-1;

        int sum = 0;
        int carry = 0;

        List<int> ans = new();

        while(m>=0 || n >=0)
        {
            sum = 0;
            if(m>=0)
            {
                sum += a[m]-'0';
                m--;
            }

            if(n>=0)
            {
                sum += b[n]-'0';
                n--;
            }

            sum+= carry;

            carry = sum > 1 ? 1 : 0;
            
            ans.Add(sum%2);

        }

        if(carry==1)
        {
            ans.Add(carry);
        }

        ans.Reverse();

        return string.Join("",ans);
        
    }
}