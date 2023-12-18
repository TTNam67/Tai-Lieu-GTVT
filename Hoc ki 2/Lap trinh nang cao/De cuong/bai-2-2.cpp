#include<stdio.h>
#include<math.h>
#include<string.h>
#include<stdlib.h>
#include<conio.h>
typedef struct{
	char TenSach[50];
	char NhaXB[50];
	int Gia;
}Book;

void remove(char *a)
{
	int n = strlen(a);
	if (a[n-1] == '\n')
	{
		a[n-1] = '\0';
	}
}

Book *Nhap(char *Filename, int *n){
	FILE *f;
	Book *s;
	if((f = fopen(Filename, "rt")) == NULL){
		printf("\nKiem tra lai file %s", Filename);
		getch();
		exit(1);
	}
	fscanf(f,"%d\n",n);
	s = (Book*)calloc(*n+1, sizeof(Book));
	for(int i = 1; i <= *n; i++){
		fflush(stdin);
		fgets(s[i].TenSach,50,f); remove(s[i].TenSach);
		fflush(stdin);
		fgets(s[i].NhaXB,50,f); remove(s[i].NhaXB);
		fscanf(f,"%d\n", &s[i].Gia);
	}
	return s;
	fclose(f);
}
void in(int n, Book *s){
	for (int i = 1; i <= n; i++)
    {
        printf("%30s || %30s || %30d\n", s[i].TenSach, s[i].NhaXB, s[i].Gia);
    }
}
int dem(int n, Book *s, char *nxb){
	int cnt = 0;
	for(int i = 1; i <= n; i++){
		remove(nxb);
		remove(s[i].NhaXB);
		if(strcmp(nxb, s[i].NhaXB) == 0) cnt++;
	}
	return cnt;
}
void sx(int n, Book *s){
	for(int i = 1; i <= n - 1; i++){
		for(int j = i + 1; j <= n; j++){
			if(s[i].Gia < s[j].Gia){
				Book tmp = s[i];
				s[i] = s[j];
				s[j] = tmp;
			}
		}
	}
	in(n,s);
}
void luu(int n, Book *s){
	FILE *f;
	f = fopen("output.txt", "wt");
	for(int i = 1; i <= n; i++){
		fprintf(f,"%30s||",s[i].TenSach);
		fprintf(f,"%30s|0|",s[i].NhaXB);
		fprintf(f,"%d\n",s[i].Gia);
	}
	fclose(f);
}
int main(){
	int n;
	Book *s;
	char tenfile[20];
	printf("Nhap ten file du lieu: "); gets(tenfile);
	s = Nhap(tenfile, &n);
	in(n,s);
	char nxb[20];
	printf("\nmoi nhap NXB: ");
	fflush(stdin);
	gets(nxb);
	printf("\n so cuon sach cua %s la: %d\n", nxb, dem(n,s,nxb));
	printf("\ndanh sach da sap xep la: \n");
	sx(n,s);
	luu(n,s);
	return 0;
}
