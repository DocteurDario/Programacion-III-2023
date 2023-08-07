using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro(); // Ejemplo de como crear una variable de la clase perro
            
            perro1.color = "Blanco";
            perro1.nombre = "Starck ";
            perro1.origen = "de una casa, una amiga de la mamá del tío nico.";

            Console.WriteLine("Nombre : ");
            Console.WriteLine(perro1.nombre);
            Console.WriteLine("Color :");
            Console.WriteLine(perro1.color);
            Console.WriteLine("Origen :");
            Console.WriteLine(perro1.origen);

            Perro perro2=new Perro();

            perro2.color = "Negro";
            perro2.nombre = "Sultan ";
            perro2.origen = "de la calle.";

            Console.WriteLine("Nombre : ");
            Console.WriteLine(perro2.nombre);
            Console.WriteLine("Color :");
            Console.WriteLine(perro2.color);
            Console.WriteLine("Origen :");
            Console.WriteLine(perro2.origen);



            Console.ReadKey();
        }
    }
} 
