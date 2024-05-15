#Giao hàng
import queue



if __name__ == '__main__':
    A = [[] for i in range(1000005)]


    for i in range(int(input())):
        t, v = [int(x) for x in input().split()]
        A[t] = v

    Q = queue.PriorityQueue()
    res = 0

    for i in range(1000005, 0, -1):
        for x in A[i]:
            Q.put(-x)
        if Q.qsize():
            res -= Q.get()

    print(res)

# Cây khung nhỏ nhất
