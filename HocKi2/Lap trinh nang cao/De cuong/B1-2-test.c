#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>

typedef long long ll;

void Read(char *fileName, int *m, int *n, int *)
{

    FILE *file;
    file = fopen(fileName, "r");

    int i;
    for (i = 0; i < (*m)*(*n); i++)
    {

    }
}

void Print(int m, int n, float **Matrix)
{
    int i, j;
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            printf("%.3f ", Matrix[i][j]);
        }
        printf("\n");
    }
}

float Mean(int m, int n, float **Matrix)
{
    float sum = 0;
    int cnt = 0;
    for (int i = 0; i < m*n; i++)
    {
        if (*(Matrix+i) < 0)
        {
            sum += *(Matrix+i);
            cnt += 1;
        }
    }
    return sum / n;
}

void check(int n, int m, float *Matrix, float *max)
{
    for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
    {
        if (*(Matrix + ))
    }
}

int main()
{

}