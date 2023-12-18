#THuat toan Huffman
import collections
import queue
import math

'''
#THuat toan Huffman
if __name__ == '__main__':
    D = collections.Counter(input())
    Q = queue.PriorityQueue()
    
    for v in D.values():
        Q.put(v)
    res = 0
    
    while Q.qsize() > 1:
        x = Q.get() + Q.get()
        res += x
        Q.put(x)
    
    print(res)


class node:
    def __init__(self, ch, fr, le = None, ri = None):
        self.char, self.freq, self.left, self.right = ch, fr, le, ri

        pass

    def __lt__(self, other):
        return self.freq < other.freq

def inorder(H, p = ""):
    if H == None:
        return

    inorder(H.left, p + "\t\t")
    print("%s%s:%d"%(p, H.char, H.freq))

    inorder(H.right, p + "\t\t")

CODE = {}
def getHuffmanCode(H, p = ""):
    if H.left == None:
        print(H.char, p)
        CODE[H.char] = p
    else:

        getHuffmanCode(H.left, p + "0")
        getHuffmanCode(H.right, p + "1")

if __name__ == '__main__':
    s = input()
    D = collections.Counter(s)
    Q = queue.PriorityQueue()
    for c, f in D.items():
        Q.put(node(c, f))

    while Q.qsize() > 1:
        u = Q.get()
        v = Q.get()
        Q.put(node('$', u.freq + v.freq, u, v))
    root = Q.get()
    inorder(root)
    getHuffmanCode(root)
    for c in s:
        print(CODE[c], end="")


# Cay phan doan (Interval Tree, Segment Tree)
class node:
    def __init__(self, L, R):
        self.lo, self.hi = L, R
        self.elem = -10**9
        if L + 1 == R:
            self.left, self.right = None, None
        else:
            self.left = node(L, (L + R) // 2)
            self.right = node((L + R) // 2, R)

def update(H, i, x):
    H.elem = max(H.elem, x)
    if H.left != None:
        update(H.left if i <= H.left.hi else H.right, i, x)

def get(H, L, R):
    if L == H.lo and R == H.hi:
        return H.elem
    if R <= H.left.hi:
        return get(H.left, L, R)
    if L >= H.right.lo:
        return get(H.right, L, R)
    return max(get(H.left, L, H.left.hi), get(H.right, H.right.lo, R))

if __name__ == '__main__':
    n, m = map(int, input().split())
    root = node(1, n + 1)
    for i, x in enumerate(map(int, input().split(), 1)):
        update(root, i, x)

    for i in range()
'''
def lssLength(a, i, j):
    aj = a[j] if 0 <= j < len(a) else None 