#include<stdio.h>
#include <string.h>
bool check(char s[]){
	
	for(int i=0;i<strlen(s);i++){
		if(s[i]>='0'&&s[i]<='9'){
			return  true;
		}else{
			return false;
		}
	}
}
int demtu(char  s[],int length){
	int word = (s[0] != ' ');
    for (int i = 0; i < length - 1; i++)
    {
        if (s[i] == ' ' && s[i + 1] != ' ')
        {
            word++;
        }
    }
    return word;
}
void kituphai(char s[],int n){
	for(int i=0;i<n;i++){
		printf("%c",s[i]);
	}
}
void result(char s[],int n,int m){
	for(int i=m;i<=n;i++){
		printf("%c",s[i]);
	}
}
int main(){
	char s[1000];

	gets(s);
	int length = strlen(s);
	if(check(s)) printf("\nchuoi s la chuoi so");
	else printf("khong");
	printf("\n%d\n ",demtu(s,length));
	int n;
	scanf("%d",&n);
	kituphai(s,n);
	int m;
	scanf("%d",&m);
	result(s,n,m);
	
}
