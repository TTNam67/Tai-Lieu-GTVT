#include<bits/stdc++.h>
using namespace std;

typedef long long ll;

const ll maxN = 9; 
ll array[maxN] = {};
ll check[maxN] = {};
ll n; 

void backTrack(ll i)
{
    if (i == n) 
    {
        for (ll i = 0; i < n; i++) cout << array[i] << " ";
        cout << endl;
    }
    else 
    {
        for (ll x = 1; x <= n; x++)
        {
        	if (check[x] == 0)
        	{
        		array[i] = x;
            
            	check[x] = 1;
            	backTrack(i + 1);
            	check[x] = 0;
			}
            
        }  
    }
}

void sol()
{
    cin >> n;
    backTrack(0);
}

int main()
{
	std::ios::sync_with_stdio(NULL); std::cin.tie(0); std::cout.tie(0);
	long long t; t = 1;
	for (long long ca = 1; ca <= t; ca++)
        sol();
}
