import queue 

'''
class elem:
    def __init__(self, a):
        self.infor = a
    
    def __lt__(self, other):
        return self.infor % 2 < other.infor % 2



if __name__ == '__main__':
    ans = 0
    n, k = [int(x) for x in input().split()]

    Q = queue.PriorityQueue()
    for x in input().split():
        Q.put(int(x))

    while Q.qsize() > 1:
        tmp = 0
        for x in range(k):
            if (Q.qsize() == 0): break
            u = Q.get()
            tmp += u

        ans = ans + tmp
        Q.put(tmp)
    print(ans)
        


# Phần tử trung vị
if __name__ == '__main__':
    R, L = queue.PriorityQueue(), queue.PriorityQueue()

    n = int(input())

    for i, x in enumerate(map(int, input().split()), 1):
        L.put(-x) if i % 2 == 1 else R.put(x)

        if (i >= 2 and -L.queue[0] > R.queue[0]):
            L.put(-R.get())
            R.put(-L.get())
        print(-L.queue[0], end =" ")

'''


#Trinh thám

import queue

if __name__ == '__main__':
    Q = queue.PriorityQueue()
    n, k = [int(x) for x in input().split()]
    for i, x in enumerate(map(int, input().split()), 1):
        while Q.qsize() > 0 and i - Q.queue[0][1] > k - 1:
            Q.get()
        if Q.qsize() > 0 and -Q.queue[0][0] <= x  : Q.queue.clear()
        Q.put((-x, i))
        if i >= k: print(-Q.queue[0][0], end=" ")