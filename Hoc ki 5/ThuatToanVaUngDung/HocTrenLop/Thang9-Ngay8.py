from functools import reduce
import math

a = [4, 5, 6, 2]
s = reduce(lambda x, y : x * y, a)
s2 = reduce(lambda x, y : x * y, a, 10)
 
print(s)
print(s2)
'''
# Tìm số âm lớn nhất trong 1 dãy
def findMaxNega(a, b):
    if (a < 0 and b < 0):
        return max(a, b)
    else:
        return min(a, b)
    
a2 = [3, 1, 19, 0, 9, 5, 7]
s3 = reduce(findMaxNega, a2)
if (s3 == 0):
    print("Khong co so am")
else:
    print(s3)


# Xoay ma trận 
n, m, alpha = map(int, input().split())
alpha %= 360
alpha //= 90
# A = []
# for i in range (n):
#     a = list(map(int, input().split()))
#     A.append(a)

A = [list(map(int, input().split())) for i in range (n)] #Nhập ma trận 

for i in range(alpha):
    A = list(zip(*A[::-1]))
for x in A:
    print(*x)



# Hình thoi
n = int(input())
X = [((2*i - 1)*'*').center(2*n + 1) for i in range(1, n + 1)]
Y = X + X[::-1][1::]
print(*Y, sep = "\n")


# Tính diện tích đa giác
from collections import namedtuple
Diem = namedtuple("diem", "x y")
def dt(A, B):
    return A.x * B.y - A.y *B.x

A = []
for i in range(4):
    u, v = map(int, input().split())
    A.append(Diem(u, v))

A.append(A[0])
s = abs(sum([dt(N, M) for M, N in zip(A, A[1:])]))/2
print("%0.3f"%s)
'''

a = "Nguyen Tran Duc Huy 1212 CNTT"
x, y, z = a.rsplit(' ', 2)
print(x)
print(y)
print(z)