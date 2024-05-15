#include<stdio.h>
#include<math.h>
#include<stdlib.h>
#include<string.h>

typedef long long ll;

ll i, j;
typedef struct
{
    ll degree;
    float *Arr;
} Polynomial;

void insert(Polynomial *poly, ll n)
{
    for (i = 0; i < n; i++)
    {
        printf("%lldth polynomial\n", i + 1);
        printf("insert the degree of the polynomial: ");
        scanf("%lld", &poly[i].degree);

        poly[i].Arr = (float*) calloc(poly[i].degree + 1, sizeof(float));
        printf("insert coefficient-list of polynomial: ");

        for (j = 0; j <= poly[i].degree; j++)
        {
            scanf("%f", &poly[i].Arr[j]);
        }
    }
//    for (i = 0; i < n; i++)
//    {
//        printf("%lldth polynomial: %.1f", i + 1, poly[i].Arr[0]);
//        for (j = 1; j <= poly[i].degree; j++)
//        {
//            printf(" + %.1f*x^%lld", poly[i].Arr[j], j);
//        }
//        printf("\n");
//    }
}

void print(Polynomial *poly, ll n)
{
    for (i = 0; i < n; i++)
    {
        printf("%lldth polynomial: %.1f", i + 1, poly[i].Arr[0]);
        for (j = 1; j <= poly[i].degree; j++)
        {
            printf(" + %.1f*x^%lld", poly[i].Arr[j], j);
        }
        printf("\n");
    }
}

int main()
{
    ll n;
    printf("Num of Polynomials?: ");
    scanf("%lld", &n);
    printf("\n");
	Polynomial *poly;
    if ((poly = (Polynomial *)calloc(n, sizeof(Polynomial))) == NULL)
        printf("Cant allocate memory\n");
    insert(poly, n);
    print(poly, n);
}
