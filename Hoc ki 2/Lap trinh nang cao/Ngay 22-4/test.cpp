#include<bits/stdc++.h>
#define endl '\n'
#pragma GCC optimize("Ofast")
using namespace std;

typedef unsigned long long ull;
typedef long long ll;

#define pb push_back
#define all(c) (c).begin(), (c).end()
#define rall(c) (c).rbegin(), (c).rend()
#define sz(x) (int)(x).size()
#define ff first
#define ss second
#define ii pair <int, int>
#define llll pair <ll, ll>

const ll MOD = 1e9+7;

// http://www.open-std.org/jtc1/sc22/wg21/docs/papers/2016/p0200r0.html
// freopen("Input.txt", "r", stdin);
// freopen("Output.txt". "w", stdout);

void InsertArr(int A[], int n)
{
	for (int i = 0; i < n; i++) cin >> A[i];
}

double phepchia(int a, int b)
{
   if( b == 0 )
   {
      throw "Chu y: Ban dang chia cho so 0!!!";
   }
   return (a/b);
}

int main()
{
	ios::sync_with_stdio(NULL); cin.tie(0); cout.tie(0);
	
	int day, month, year; cin >> day >> month >> year;
	if (cin.fail()) cout << "You do not have a birthday";
	else cout << day << "/" << month << "/" << year;

}

