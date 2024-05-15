from queue import *
import math
import timeit

Ox = [1, -1, 2, -2, 1, -1, 2, -2]
Oy = [2, 2, 1, 1, -2, -2, -1, -1]

def Step(m, n, s1, s2, f1, f2):
    stepList = Queue()
    stepList.put([s1, s2])

    A = [[0] * (n + 1) for i in range(m + 1)]

    while stepList.qsize():
        curr = stepList.get()
        x1 = curr[0]
        x2 = curr[1]
        
        if x1 == f1 and x2 == f2:
            return A[f1][f2]

        for i in range(8):
            tmp1 = x1 + Ox[i]
            tmp2 = x2 + Oy[i]

            if  1 <= tmp1 <= m and 1 <= tmp2 <= n and A[tmp1][tmp2] == 0:
                stepList.put([tmp1, tmp2])
                A[tmp1][tmp2] = A[x1][x2] + 1

    if (A[f1][f2] == 0): return -1
    else: return A[f1][f2]

if __name__ == '__main__':
    n, m = [int(x) for x in input().split()]
    s1, s2 = [int(x) for x in input().split()]
    f1, f2 = [int(x) for x in input().split()]
    print(Step(n, m, s1, s2, f1, f2))
    