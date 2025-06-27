public class Solution {
    public int OrangesRotting(int[][] grid) {
        
        int m = grid.Length;
        int n = grid[0].Length;

        Queue<(int,int,int)> queue = new();

        // first all rotten oranges into queue
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==2)
                {
                    queue.Enqueue((i,j,0));
                }
            }
        }

        int maxMin = 0;

        // mark adjacent rows as rotten
        while(queue.Count > 0)
        {
            var (x,y,min) = queue.Dequeue();

            if(x > 0 && grid[x-1][y] == 1) {
                grid[x-1][y] = 2;
                queue.Enqueue((x-1,y,min+1));
            }
            if(x < m-1 && grid[x+1][y] == 1) {
                grid[x+1][y] = 2;
                queue.Enqueue((x+1,y,min+1));
            }
            if(y > 0 && grid[x][y-1] == 1) {
                grid[x][y-1] = 2;
                queue.Enqueue((x,y-1,min+1));
            }
            if(y < n-1 && grid[x][y+1] == 1) {
                grid[x][y+1] = 2;
                queue.Enqueue((x,y+1,min+1));
            }

            maxMin = Math.Max(maxMin,min);
        }

        // push in queue till not empty

        // check each element
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(grid[i][j]==1)
                {
                    return -1;
                }
            }
        }
        return maxMin;
    }
}