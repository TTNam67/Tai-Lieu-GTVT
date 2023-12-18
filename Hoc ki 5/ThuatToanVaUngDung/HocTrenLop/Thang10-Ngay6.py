from queue import LifoQueue
import math
import queue

'''
if __name__ == '__main__':
    S = LifoQueue()
    for x in [4, 6, 4, 3, 2, 1] : S.put(x)

    print(S.qsize())
    print(S.queue)
    print(S.get())
    print(S.queue)

#Chao don tan sinh vien K59

def Find(studentList):
    tmpStack = LifoQueue()
    list = []

    tmpStack.put([math.inf, -1])

    for i, x in enumerate(studentList):
        while x >= tmpStack.queue[-1][0]:
            tmpStack.get()
        list.append(tmpStack.queue[-1][1])
        tmpStack.put([x, i])
    return list

if __name__ == '__main__':
    n = int(input())
    studentList = [int(x) for x in input().split()]
    L = Find(studentList)
    R = Find(studentList[::-1])

    # R = [n - 1 - i if i >= 0 else -1 for i in R][::-1]
    R = [(n - i) * (i >= 0) - 1 for i in R][::-1]
    

    # for i in range(n):
    #     if (L[i] == -1 or R[i] == -1):  
    #         print(L[i] + R[i] + 1, end = " ")
    #     else:
    #         if (i - L[i] <= R[i] - i): print(L[i], end = " ")
    #         else: print(R[i], end = " ")

    for i, (u, v) in enumerate(zip(L, R)):
        if (u + 1)*(v + 1) == 0: print(u + v + 1, end = " ")
        else: print(u if i - u <= v - i else v, end = " ")



#Xep hang: Có n người. Hai người không nhìn thấy nhau nếu không có ai cao hơn 1 trong 2 người ở giữa 
#Đếm số cặp nhìn thây nhau 
if __name__ == '__main__':
    n = int(input())
    heightList = [int(x) for x in input().split()]
    res = 0
    S = LifoQueue()

    for height in heightList:
        while S.qsize() > 0 and S.queue[-1][0] < height:
            res = res + S.queue[-1][1]
            S.get()
        
        if S.qsize() > 0 and S.queue[-1][0] == height:
                res = res + S.queue[-1][1] + (S.qsize() > 1)
                S.queue[-1][1] += 1
        else:
            res += S.qsize() > 0
            S.put([height, 1])

    print(res)
'''



# Xoa k chu so duoc so lon nhat

def Sol(chuoiSo, k):
    list = LifoQueue()
    for so in chuoiSo:
        while k > 0 and list.qsize() > 0 and list.queue[-1] < so:
            list.get()
            k -= 1
        list.put(so)
    while k > 0:
        list.get() 
        k -= 1

    ans = LifoQueue()
    while list.qsize() > 0:
        ans.put(list.get())

    while ans.qsize() > 0:

        print(ans.get(), end = "" )
    print()
    

def xoa(x, k):
    S.queue.LifoQueue()
    for c in x:
        while k > 0 and S.qsize() > 0 and S.queue[-1] < c:
            S.get()
            k -= 1
        S.put(c)

    while k > 0:
        S.get()
        k -= 1
    print("".join(S.queue))

if __name__ == '__main__':
    chuoiSo = str(input())
    queryNum = int(input())
    for i in range(queryNum):
        n = int(input())
        xoa(chuoiSo, n)



