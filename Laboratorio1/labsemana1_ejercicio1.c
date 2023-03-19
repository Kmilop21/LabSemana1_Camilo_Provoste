#include<stdio.h>
#include<stdlib.h>

int main()
{
	int entero=0;
	float decimalA=0,decimalB=0;
	double GranDecimal=0;
	char caracter[100];
	
	printf("Ingrese un numero entero: ");
	scanf(" %d",&entero);

	printf("Ingrese un numero decimal A: ");
	scanf(" %f",&decimalA);
	
	printf("Ingrese un numero decimal B: ");
	scanf(" %f",&decimalB);
	
	float convertir = decimalA * decimalB;
	
	GranDecimal = (double)convertir;

	printf("Ingrese una palabra o frase: ");
	scanf(" %[^\n]s",caracter);
	
	printf("\n----Resultados----\n");
	
	printf("Su numero entero ingresado es: %d\n",entero);
	printf("La multiplicacion de los dos decimales en double es: %lf\n",GranDecimal);
	printf("Su palabra o frase ingresada es: %s",caracter);
	
	return 0;
}
