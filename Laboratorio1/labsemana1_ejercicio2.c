#include<stdio.h>

int main()
{
	double a,b,suma,resta,multiplicacion,division;
	
	printf("Ingrese un primer numero: ");
	scanf(" %lf",&a);
	
	printf("Ingrese un segundo numero: ");
	scanf(" %lf",&b);
	
	suma = a+b;
	resta = a-b;
	multiplicacion = a*b;
	division = a/b;
	
	printf("\nResultados: \n");
	
	printf("Ambos numeros sumados da: %0.2lf\n",suma);
	printf("Ambos numeros restados da: %0.2lf\n",resta);
	printf("Ambos numeros multiplicados da: %0.2lf\n",multiplicacion);
	printf("Ambos numeros divididos da: %0.2lf\n",division);
	
	return 0;
}
