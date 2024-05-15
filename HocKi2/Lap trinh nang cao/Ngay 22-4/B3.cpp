#include<stdio.h>
#include<string.h>
#include<math.h>

const int max = 1e3;

void insertArr(double A[], int n)
{
	for (int i = 0; i < n; i++)
	{
		scanf("%lf", &A[i]);
	}
}

double distance(double x1, double y1, double x2, double y2)
{
	return sqrt(pow(x1-x2, 2) + pow(y1-y2, 2));
}

int countPoints(double B[], double A[], int n)
{
	int dem = 0;
	for (int i = 1; i < n ; i++)
	{
		if (distance(A[0], B[0], A[i], B[i]) < 10.0) dem++;
	}
	return dem;
}

int countLinesCrossY_axis(double A[], double B[], int n)
{
	int countPositive = 0, countNegative = 0, countZero = 0;
	for (int i = 0; i < n; i++)
	{
		if (A[i] > 0) countPositive++;
		else if (A[i] < 0) countNegative++;
		else countZero++;
	}
	
	return countPositive*countNegative + countZero*(countPositive + countNegative);
}

int main()
{
	int n; scanf("%d", &n);
	double A[n], B[n];
	for (int i = 0; i < n; i++)
		scanf("%lf%lf", &A[i], &B[i]);
	
	printf("%d\n", countPoints(B, A, n));
	printf("%d\n", countLinesCrossY_axis(A, B, n));
	
}
