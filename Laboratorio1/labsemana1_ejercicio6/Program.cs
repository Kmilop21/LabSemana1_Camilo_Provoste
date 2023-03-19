using System;
using labsemana1_ejercicio6.models;

jugador jugador1 = new jugador();

int opcion = -1;
int personalizar= -1;
int ataque;

while (opcion != 0)
{
    System.Console.WriteLine("Bienvenido, para personalizar a su personaje ingrese 1, para luchar ingrese 2, para mostrar detalles ingrese 3,para reducir vida precione 4 y para descanzar ingrese 5. Para salir ingrese 0");
    opcion = Convert.ToInt32(Console.ReadLine());

    if(opcion == 1)
    {
        personalizar = -1;

        System.Console.WriteLine("Ingrese el numero del aspecto que desea seleccionar");
        System.Console.WriteLine("(1)-------> Tipo\n(2)-------> Nombre\n(3)-------> Vida Maxima\n(4)-------> Poder\n(5)-------> Velocidad Maxima");

        personalizar = Convert.ToInt32(Console.ReadLine());

        if(personalizar == 1)
        {
            jugador1.RecibeTipo();
        }
        else if(personalizar == 2)
        {
            jugador1.RecibeNombre();
        }
        else if(personalizar == 3)
        {
            jugador1.RecibeVida();
        }
        else if(personalizar == 4)
        {
            jugador1.RecibePoder();
        }
        else if(personalizar == 5)
        {
            jugador1.RecibeVelocidad();
        }
        else
        {
            System.Console.WriteLine("Opcion incorrecta");
        }
    }
    else if(opcion == 2)
    {
        ataque = -1;

        System.Console.WriteLine("Ingrese el metodo de lucha a utilizar");
        System.Console.WriteLine("(1)-------> Espada\n(2)-------> Hechizo\n(3)-------> Poder");

        ataque = Convert.ToInt32(Console.ReadLine());

        if(ataque == 1)
        {
            jugador1.eleccion = "espada";
            jugador1.Atacar(jugador1.eleccion);
        }
        else if(ataque == 2)
        {
            jugador1.eleccion = "hechizo";
            jugador1.Atacar(jugador1.eleccion);
        }
        else if(ataque == 3)
        {
            jugador1.eleccion = "poder";
            jugador1.Atacar(jugador1.eleccion);
        }
        else
        {
            System.Console.WriteLine("Opcion incorrecta");
        }
    }
    else if(opcion == 3)
    {
        jugador1.mostrar();
    }
    else if(opcion == 4)
    {
        jugador1.dano();
    }
    else if (opcion == 5)
    {
        jugador1.Descanzar();
    }
    else
    {
        System.Console.WriteLine("Ingreso incorrecto");
    }
}
