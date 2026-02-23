public class Solution {
    public bool LemonadeChange(int[] bills) {

        Dictionary<int,int> map = new();
        map.Add(5,0);
        map.Add(10,0);
        map.Add(20,0);

        foreach(int bill in bills)
        {
            if(bill == 5)
            {
                map[5]++;
            }
            else if(bill == 10)
            {
                if(map[5]==0)
                    return false;
                else
                {
                    map[5]--;
                    map[10]++;
                }
            }
            else
            {
                if(map[5] > 0 && map[10] > 0)
                {
                    map[20]++;
                    map[5]--;
                    map[10]--;
                }
                else if (map[5] > 2)
                {
                    map[20]++;
                    map[5] = map[5] - 3;
                }
                else
                    return false;
            }
        }

        return true;
        
    }
}