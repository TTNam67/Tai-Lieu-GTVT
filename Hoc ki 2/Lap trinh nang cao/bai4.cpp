#include<stdio.h>
#define MAX 100
void nhap(float a[],int n){
	printf("\nmoi nhap vao day so \n");
	for(int i=0;i<n;i++){
		scanf("%f",&a[i]);
	}
}
void xuat(float a[],int n){
	printf("\nday vua nhap la \n");
	for(int i=0;i<n;i++){
		printf("%.2f ",a[i]);
	}
}
float tong(float a[],int n){
	if(n==1) return a[0];
	else return a[n-1]+tong(a,n-1);
}
int count(float a[],int n){
	
    if(n ==(-1)) return 0;
    else
    {
        if(a[n]>0) return  1 + count(a, n-1);
        else return count(a, n-1);
    }
	
}
int max(float a[],int n){
	if(n==1) return a[0];
	if(a[n-1]>max(a,n-1)) return a[n-1];
	return max(a,n-1);
}
int main(){
	float a[MAX];
	int n;
	printf("nhap n");
	scanf("%d",&n);
	nhap(a,n);
	xuat(a,n);
	printf("tong %.2f ",tong(a,n));
	printf("\nso phan tu lon hon 0 la %d",count(a,n-1));
	printf("\ngia tri lon nhat cua day la %d ",max(a,n));
}
