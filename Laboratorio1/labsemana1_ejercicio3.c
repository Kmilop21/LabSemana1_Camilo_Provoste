#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int main()
{
	int i=0;
	char carga[19]="---------[dinamita]";
	
	for(i=0; i<19; i++)
	{
		if(i>=9)
		{
			printf("         [BOOM!!!!]");
			i=19;
		}
		if(i<9)
		{
			carga[i]='*';
			
			if(carga>0)
			{
				carga[i-1]=' ';
			
			}
			printf("%s\n",carga);
			sleep(1);
			system("cls");
		}
	}
	
	return 0;
}
