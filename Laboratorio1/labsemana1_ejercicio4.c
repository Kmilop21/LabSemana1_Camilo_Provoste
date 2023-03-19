#include<stdio.h>
#include<stdlib.h>

int main(){
	
	int i, j;
	char gato[5][5];
	
	//Cargando el tablero
	for(i=0; i<5; i++)
	{
		for(j=0; j<5; j++)
		{
			if(i%2==0)
			{
				if(j%2==0)
				{
					gato[i][j]=' ';
				}
				else
				{
					gato[i][j]='|';
				}
			}
			else
			{
				if(j%2==0)
				{
					gato[i][j]='-';
				}
				else
				{
					gato[i][j]='|';
				}
			}
		}
	}
	
	//Mostrando el tablero
	for(i=0; i<5; i++)
	{
		for(j=0; j<5; j++)
		{
			printf("%c",gato[i][j]);
		}
		printf("\n");
	}
	
	
	return 0;
}
