#include<bits/stdc++.h>
using namespace std;

template <class T>
class node
{
    public: 
        T val;
        node *left, *right, *next;

        node(T x)
        {
            left = right = next = NULL;
            val = x;
        }
};

template <class T, class CMP>
bool Insert(node<T> *&H, CMP cmp, T x)
{
    if (!H) 
    {
        H = new node<T>(x);
        return 1;
    }

    if (H->val == x) return 0;
    return Insert(cmp(x, H->val) ? H->left : H->right, cmp, x);
}


template <class T>
node<T> *find(node<T> *H, T x)
{
    if (!H or H->val == x) return H;
    return find(x < H->val ? H->left : H->right, x);
}

template <class T>
void Inorder(node<T> *H, node<T> *&p) // Tạo các mối nối next trên cây
{
    if (!H) return; 
    if (H->left) Inorder(H->left, p);
    if (p) p->next = H;

    p = H;
    if (H->right) Inorder(H->right, p);
}

template<class T>
class set_it
{
    node<T> *curr;
    public:
        set_it (node<T> *c = 0) { curr = c; }
        T operator*() { return curr->val;}
        bool operator != (set_it<T> it) { return curr != it.curr; }

        set_it<T> &operator = (set_it<T> it)
        {
            this->curr = it->curr;
            return *this;
        }

        set_it<T> operator ++ (int) //it++
        {
            curr = curr->next;
            return curr;
        }

        set_it<T> operator ++ () //++it
        {
            node<T> *p = curr;
            curr = curr->next;
            return p;
        }
};

template <class T, class CMP = less<T>>
class Set
{
    private:
        int n;
        node<T> *root;
        CMP cmp;


    public: 
        Set()
        {
            root = NULL;
            n = 0;
        }      

        ~Set()
        {
            delete root;
        }

        int size(){return n;}
        bool empty(){return n == 0;}
        int max_size(){return 214748364;}
        void insert(T x) { n += Insert(root, cmp, x);}

        typedef set_it<T> iterator;
        iterator begin()
        {
            if (!root) return NULL;
            node<T> *q = NULL;
            Inorder<T>(root, q);

            node<T> *p = root;
            if (p->left) 
            {
                while(p->left)
                    p = p->left;
            }

            return p;
        }

        iterator end() { return NULL; }
        void erase(iterator it)
        {
            
        }
        void clear()
        {
            n = 0;
            node<T> *it = begin();
            while(it->next)
            {
                node<T> *tmp = it->next();
                // erase(it);
                it = tmp;
            }
        }
};

int main()
{
    set<int, greater<int>> A;
    for (int i  : {1, 3, 5, 6, 12, 0, -8, 4, -5}) A.insert(i);
    for (auto i : A) cout << i << " ";
    // for (int i : {1, 2, 3, 5, 7, 8}) A.insert(i);
    // cout << *A.upper_bound(3) << endl;
    // cout << A.max_size() << endl;
}
