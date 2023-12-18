
from queue import *
import math
'''
#Buôn dưa lê
if __name__ == '__main__':
    Q = queue.Queue()
    n, k, m = map(int, input().split())
    res = 0
    A = list(map(int, input().split())) + [0] * (k - 1)
    for i, x in enumerate(A, 1):
        Q.put([i, x])
        while i - Q.queue[0][0] >= k: Q.get()
        t = 0
        while Q.qsize() and t + Q.queue[0][1] <= m:
            t += Q.queue[0][1]
            Q.get()
        if Q.qsize():
            Q.queue[0][1] -= m - t
            t = m
        res += t
    print(res)  

#Buôn dưa lê
if __name__ == '__main__':
    n, k, m = map(int, input().split())
    a = list(map(int, input().split()))
    a = a + [0] * (k - 1)
    Q = Queue()
    res = 0
    for x in a:
        Q.put(x)
        while Q.qsize() > k: Q.get()
        t = 0
        while Q.qsize() and t + Q.queue[0] <= m: t += Q.get()
        if Q.qsize():
            Q.queue[0] -= m - t
            t = m
        res += t
    print(res)
    

# Liệt kê những số đi được trong bài mọi con đường về không
def bfs(n):
    Q = Queue()
    d = [0] * (n + 5)
    Q.put(n)
    d[n] = 1
    while Q.qsize():
        u = Q.get()
        for i in range(1, int(math.sqrt(u) + 1)):
            if u % i == 0:
                v = (i - 1)*(u // i+1)
                if d[v] == 0:
                    Q.put(v)
                    d[v] = 1
    for i in range(n + 1):
        if d[i] == 1: print(i, end = " ")
if __name__ == '__main__':
    bfs(int(input()))


# Robot: https://www.laptrinhonline.club/problem/tichpxrobot
def Sol(x, y):
    Q = Queue()
    Q.put((x, y))
    d = 1
    M = {(x, y): 1}
    while (Q.qsize()):
        x1, y1 = Q.get()
        if x1 % 2 == 0:
            if (y1, x1 / 2) not in M.keys():
                M[(y1, x1 / 2)] = 1
                Q.put((y1, x1 / 2))
                d += 1
        if y1 % 2 == 1:
            if ((y1 + 1) / 2, x1) not in M.keys():
                M[((y1 + 1) / 2, x1)] = 1
                Q.put(((y1 + 1) / 2, x1))
                d += 1
    print(d)



if __name__ == '__main__':
    x, y = map(int, input().split())
    Sol(x, y)
'''
    

