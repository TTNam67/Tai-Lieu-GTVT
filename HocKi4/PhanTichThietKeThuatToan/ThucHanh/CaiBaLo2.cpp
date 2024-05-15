#include<bits/stdc++.h>
#define endl '\n'
#pragma GCC optimize("Ofast")
using namespace std;

typedef long long ll;

class item
{
    public:
        int sz, val; 
};

void sol()
{
    int n, m; cin >> n >> m;
    item A[n + 1];
    for (ll i = 1 ; i <= n; i++) cin >> A[i].sz >> A[i].val;

    
    int Dp[n+1][m + 1];
    
    for (ll i = 0; i <= n; i++)
    {
    	for (ll j = 0; j <= m; j++)
	    {
	        
	        if (i == 0 || j == 0) Dp[i][j] = 0;
	
	        else if (j < A[i].sz) Dp[i][j] = Dp[i - 1][j];
	
	
	        else Dp[i][j] = max(Dp[i - 1][j], Dp[i - 1][j - A[i].sz] + A[i].val);
	    }
	}

    cout << Dp[n][m] << endl;
}


int main()
{
	
	sol();
}
