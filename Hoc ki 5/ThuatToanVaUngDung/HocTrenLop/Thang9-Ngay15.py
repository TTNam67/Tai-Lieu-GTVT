# D = {'e': 6, 'f': 12, -4: 6}
# print(D['e'])

'''
# Tìm dãy con khác biệt có độ dài lớn nhất
n = int(input())
A = [int(x) for x in input().split()]

D = {A[0]: 0}
ans = 1
tmpAns = 1
indexFlag = 0

for i, x in enumerate(A):
    if x in D.keys() and D[x] >= indexFlag:
        indexFlag = D[x] + 1
    ans = max(ans, i - indexFlag)
    D[x] = i
print(ans + 1)


# Cổ vũ - laptrinhonline, chua AC
A = input()
D = {0 : 0}

ans = 0
tmpAns = 0

for i, x in enumerate(A, 1):
    tmpAns += (1 if x == 'X' else -1)
    if tmpAns in D.keys():
        ans = max(ans, i - D[tmpAns])
    else: D[tmpAns] = i
print(ans)

# 
import collections
a = "somethinginthe"
D = collections.Counter(a)
print(D)



import math


D = {}
n = int(input())

for i in range(n):
    x, y = map(int, input().split())
    d = abs(math.gcd(x, y))
    x //= d
    y //= d
    if (x*2000 + y) not in D.keys(): D[(x*2000 + y)] = True
print(len(D))


 



for i in range(10):
    t = str(input())
    if t == "0": print('khong')
    elif t == "o": print('thuong')
    else: print('hoa')
'''

from selenium import webdriver

print(webdriver.__version__)
