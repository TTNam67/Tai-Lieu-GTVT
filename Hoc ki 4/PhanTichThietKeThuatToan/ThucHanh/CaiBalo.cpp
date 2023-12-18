#include<bits/stdc++.h>
#define endl '\n'
#pragma GCC optimize("Ofast")
using namespace std;


int main()
{
	long long a, b, c, d;
    cin >> a >> b >> c >> d;

    long long tmp = (b*d)/__gcd(b, d);
    cout << min(tmp - a, tmp - c);
}
