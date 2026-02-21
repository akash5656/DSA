public class Solution {
    public bool Exist(char[][] board, string word) {
        bool result = new();

        int m = board.Length;
        int n = board[0].Length;

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(board[i][j]==word[0])
                {
                    BackTrack(i,j,1);
                }
            }
        }

        void BackTrack(int x,int y,int nextIndex)
        {
            if(nextIndex == word.Length)
            {
                result = true;
                return;
            }

            var temp = board[x][y];
            board[x][y] = '#';
            if(y < n-1 && board[x][y+1] == word[nextIndex])
            {
                BackTrack(x,y+1,nextIndex + 1);
            }

            if(y > 0 && board[x][y-1] == word[nextIndex])
            {
                BackTrack(x,y-1,nextIndex + 1);
            }

            if(x > 0 && board[x-1][y] == word[nextIndex])
            {
                BackTrack(x-1,y,nextIndex + 1);
            }

            if(x < m-1 && board[x+1][y] == word[nextIndex])
            {
                BackTrack(x+1,y,nextIndex + 1);
            }
            board[x][y] = temp;
        }

        return result;
    }
}