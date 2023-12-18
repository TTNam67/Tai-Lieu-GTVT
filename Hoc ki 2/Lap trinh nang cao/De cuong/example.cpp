#include<bits/stdc++.h>
#define endl '\n'
#pragma GCC optimize("Ofast")
using namespace std;

typedef unsigned long long ull;
typedef long long ll;

const ll MOD = 1e9+7;
const ll MAX = 1e6;

// http://www.open-std.org/jtc1/sc22/wg21/docs/papers/2016/p0200r0.html
// freopen("Output.txt", "w", stdout);
// freopen("Error.txt", "w", stderr);

ll LowerToGreater(const void* a, const void* b)
{
    const ll* x = (ll*) a;
    const ll* y = (ll*) b;
    if (*x > *y)
        return 1;
    else if (*x < *y)
        return -1;
    return 0;
}

void insertArr(long long A[], long long n)
{
	for (long long i = 0; i < n; i++) cin >> A[i];
}

void printArr(long long *A, long long n)
{
	for (long long i = 0; i < n; i++) cout << A[i];
}

ll Airport[MAX][MAX], Agree[MAX][MAX];

int main()
{
	
 	//freopen("Input.txt", "r", stdin);
	std::ios::sync_with_stdio(NULL); std::cin.tie(0); std::cout.tie(0);
    ll n, q; cin >> n >> q;
    while(q--)
    {
        ll code; cin >> code;
        if (code == 1)
        {
            ll a, b; cin >> a >> b;
            Airport[a][b] = 1;
            Airport[b][a] = 1;
        }
        else if (code == 2)
        {
            ll a, b; cin >> a >> b;
            Agree[a][b] = 1;
            Agree[b][a] = 1;
        }
        else 
        {
            ll a; cin >> a;
            ll cnt = 0;
            for (ll x = 0; x < n; x++)
            {
                if (Airport[a][x] == 1 && Agree[a][x] == 1) cnt++;
            }
            cout << cnt << endl;
        }
    }
    

}
