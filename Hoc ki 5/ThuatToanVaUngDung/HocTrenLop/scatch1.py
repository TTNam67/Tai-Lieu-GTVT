'''
b = (1, 2, 3)
c = (9, 5, 6)
a = b + b
print(a)

t1 = [1, 1, 1]
t2 = [t1]*2
print(t2)
t2[0][0] = 2
print(*t2)

b = []
for i in range(3):
	b.append([0]*2)
b[0][0] = 6
print(*b)

t1 = [2, 5, 6, 12, 0, 90, -2, 3, 4]
print(t1[::-2])

t1 = list(range(12))
print(*t1, sep = " w ", end = "\n")

t1 = [2, 5, 6, 12, 0, 90, -2, 3, 4]
t2 = list(enumerate(t1))
print(t2)

t1 = [2, 5, 6, 12, 0, 90, -2]
t2 = "home"
a1 = "something"
t3 = tuple(zip(t1, t2))
print(t3)
t4 = list(zip(t1, a1, t1[::-1]))
print(t4)


m = int(input())
a = list(map(float, input().split()))

n = int(input())
b = list(map(float, input().split()))

k = int(input())
c = list(map(float, input().split()))

z = max(n, m, k)
a = a + [0]*(z - m)
b = b + [0]*(z - n)
c = c + [0]*(z - k)

d = [u + v + t for u, v, t in zip(a, b, c)]
while len(d) > 1 and d[-1] == 0: d.pop()
for x in d:
	print("%0.2f"%x, end = " ")


a = [4, 7, 2, 8, 3, 7, 2, 1]
b = filter(lambda x : x % 2 == 0, a)
print(list(b))


def chinhphuong(n):
	if (n > 0) or (n % 3 > 1) or (n % 4 > 1) : return 0
	m = math.trunc(math.sqrt(n))
	return (m*m) == n

a = [4, 7, 2, 8, 3, 7, 2, 1, 16]
b = filter(lambda x : x%2 == 0, a) #loc so chan
print(list(b))
c = list(filter(chinhphuong, a))
print(c)

#Dem so nghiem cua phuong trinh trung phuong: phan cmt
#Giai phuong trinh trung phuong: phan khong cmt
import math

def dem(t):
	# if t > 0: return 2
	# return t == 0
	if (t > 0) : return [-math.sqrt(t), math.sqrt(t)]
	return [] if t < 0 else [0]

def pttp(a, b, c):
	if a == b == c == 0: return "vo so nghiem"
	d = b*b - 4*a*c

	# if a == b == 0 or d < 0: return 0
	if a == b == 0 or d < 0: return []
	if a == 0: return dem(-c/b)
	if d == 0: return dem(-b/(2.0*a))

	d = math.sqrt(d)
	return dem((-b - d)/(2.0*a)) + dem((- b + d)/(2.0*a))

a, b, c = map(float, input().split())
print(pttp(a, b, c))
'''
