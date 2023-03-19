using System;

namespace labsemana1_ejercicio6.models
{
    public class jugador
    {
        public string Tipo = string.Empty;

        public string Nombre = string.Empty;

        public uint Vida;

        public uint VidaMax;

        public string Poder = string.Empty;

        public uint Velocidad;

        public string eleccion = string.Empty;

        public string RecibeTipo()
        {
            System.Console.WriteLine("Ingrese su tipo: ");

            Tipo = System.Console.ReadLine() ?? "fin"; 
            System.Console.WriteLine();

            return Tipo;
        }

        public string RecibeNombre()
        {
            System.Console.WriteLine("Ingrese nombre: ");

            Nombre = System.Console.ReadLine() ?? "fin";
            System.Console.WriteLine();
            
            return Nombre;
        }

        public uint RecibeVida()
        {
            System.Console.WriteLine("Ingrese su vida maxima: ");

            Vida = Convert.ToUInt16(Console.ReadLine());
            VidaMax = Vida;
            System.Console.WriteLine();         

            return Vida;
        }

        public string RecibePoder()
        {
            System.Console.WriteLine("Ingrese su poder: ");

            Poder = System.Console.ReadLine() ?? "fin";
            System.Console.WriteLine();

            return Poder;
        }

        public uint RecibeVelocidad()
        {
            System.Console.WriteLine("Ingrese su velocidad: ");

            Velocidad = Convert.ToUInt16(Console.ReadLine());
            System.Console.WriteLine();

            return Velocidad;
        }

        public uint Descanzar()
        {
            Vida = VidaMax;
            System.Console.WriteLine("Ha recuperado toda su vida");
            
            return Vida;
        }

        public string Atacar(string eleccion)
        {
            if(eleccion == "espada")
            {
                System.Console.WriteLine("Has atacado con tu espada");
            }
            else if(eleccion == "hechizo")
            {
                System.Console.WriteLine("Has lanzado un hechizo a tu enemigo");
            }
            else if(eleccion == "poder")
            {
                if (eleccion != string.Empty)
                {
                    System.Console.WriteLine("Has usado {0} en tu enemigo",Poder);  
                }
                else
                {
                    System.Console.WriteLine("Necesita crear su poder primero");
                }
            }
            else
            {
                System.Console.WriteLine("Su eleccion no existe");
            }

            System.Console.WriteLine();

            return eleccion;
        }

        public uint dano()
        {
            System.Console.WriteLine("Tu enemigo te ha herido");
            System.Console.WriteLine("Vida -1");
            Vida = Vida-1;

            return Vida;
        }
        public string mostrar()
        {
            System.Console.WriteLine("\nTipo: {0}\nNombre: {1}\nVida: {2}/{3}\nPoder: {4}\nVelocidad: {5}",Tipo,Nombre,Vida,VidaMax,Poder,Velocidad);
            System.Console.WriteLine();

            return "a";
        }
    }
}