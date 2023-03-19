#include<stdio.h>
#include<stdlib.h>

int main()
{
	int i,j, o, aleatorio=1, anterior=0;
	
	srand (time (NULL));
	
	do
	{
		printf("Ingrese '1' para generar una pieza o '2' para finalizar: ");
		scanf(" %d",&o);
		
		while(o!=1 && o!=2)
		{
			printf("Ingreso incorrecto, intentelo nuevamente: ");	
			scanf(" %d",&o);
		}
		
		aleatorio = rand () % 8+1;
		
		//Para que no pueda ser el mismo que salio anteriormente
		while(aleatorio == anterior)
		{
			aleatorio = rand () % 8+1;
		}
		
		//Guardando el numero para que no se repita la siguiente vez
		anterior = aleatorio;
		
		if(o != 2)
		{
			//Los nombres los consegui de la wiki de tetris
			if(aleatorio == 1)
			{
				printf("\n Salio la pieza 'I' !!");
			}
			else if(aleatorio == 2)
			{
				printf("\n Salio la pieza 'O' !!");
			}
			else if(aleatorio == 3)
			{
				printf("\n Salio la pieza 'T' !!");
			}
			else if(aleatorio == 4)
			{
				printf("\n Salio la pieza 'S' !!");
			}
			else if(aleatorio == 5)
			{
				printf("\n Salio la pieza 'Z' !!");
			}
			else if(aleatorio == 6)
			{
				printf("\n Salio la pieza 'J' !!");
			}
			else if(aleatorio == 7)
			{
				printf("\n Salio la pieza 'L' !!");
			}
		}
		
		printf("\n");
		
	}while(o!=2);
		
	return 0;
}
