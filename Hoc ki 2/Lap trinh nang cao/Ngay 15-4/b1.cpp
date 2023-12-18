#include <stdio.h>
#include <string.h>

void dem()
{
	char A[1200], a;
	int dem = 0;
	gets(A);
	scanf("%c", &a);
	printf("Length = %d\n", strlen(A));
	for (int i = 0; i < strlen(A); i++)
	{
		if (A[i] == a) dem++;
	}
	printf("%d\n", dem);
}

void weekDay()
{
	int n; scanf("%d", &n);
	switch (n){
		case 1:
			printf("Monday");
			break;
		case 2:
			printf("Tuesday");
			break;
		case 3:
			printf("Wednesday");
			break;
		case 4:
			printf("Thursday");
			break;
		case 5:
			printf("Friday");
			break;
		case 6:
			printf("Saturday");
			break;
		case 7:
			printf("Sunday");
			break;
	}
}

int main()
{	
//	char *p, t[123];
////	t = "atd awrygaerhvs"; //k gan truc tiep g.tri cho 1 mang ki tu
//	scanf("%s", p);	

	dem();
	weekDay();
	
}

