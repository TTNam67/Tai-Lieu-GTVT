#include<bits/stdc++.h>

using namespace std;

int N;

int dx[] = {-2, -1, 1, 2, 2, 1, -1, -2};
int dy[] = {1, 2, 2, 1, -1, -2, -2, -1};

bool is_valid(int x, int y, vector<vector<int>> &board)
{
    return x >= 0 && x < N && y >= 0 && y < N && board[x][y] == -1;
}

bool solve(int x, int y, int step, vector<vector<int>> &board)
{
    if (step == N * N)
    {
        return true;
    }

    for (int i = 0; i < 8; i++)
    {
        int nx = x + dx[i];
        int ny = y + dy[i];

        if (is_valid(nx, ny, board))
        {
            board[nx][ny] = step;

            if (solve(nx, ny, step + 1, board))
            {
                return true;
            }

            board[nx][ny] = -1;
        }
    }

    return false;
}

void print_board(vector<vector<int>> &board)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            cout << setw(4) << board[i][j] + 1 << " ";
        }
        cout << endl;
    }
}

int main()
{
	cin >> N;
	
    int x, y;
    cin >> x >> y;

    vector<vector<int>> board(N, vector<int>(N, -1));

    board[x][y] = 0;

    if (solve(x, y, 1, board))
        print_board(board);
    else
        cout << "No solution found" << endl;
}

