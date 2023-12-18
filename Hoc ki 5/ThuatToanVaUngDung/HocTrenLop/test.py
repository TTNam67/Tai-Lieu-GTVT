from queue import LifoQueue
import math

def Sol(chuoiSo, k):
    list = LifoQueue()
    for so in chuoiSo:
        while k > 0 and list.qsize() > 0 and list.queue[-1] < so:
            list.get()
            k -= 1
    while k > 0:
        list.get()
        k -= 1

    while list.qsize() > 0:
        print(list.gett())
    

if __name__ == '__main__':
    chuoiSo = str(input())
    queryNum = int(input())
    for i in range(queryNum):
        n = int(input())
        Sol(chuoiSo, n)