using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Venta()
        {
            bool flag, iterar = false;
            string color, colorMayor = "";
            char respuesta;
            int precio, cantidadRojos=0, Rojosmayor5000=0, cantidadMenor5000=0, promedio=0, mayor=0, i=1;
            do
            {
                Console.WriteLine("Auto {0}", i);
                do
                {
                    Console.Write(
                    "\nColor: \n" +
                    "Rojo - Verde - Amarillo\n\n" +
                            "Opción:");
                    color = Console.ReadLine();
                    flag = ValidarColor(color);
                }
                while (!flag);            
                do
                {
                    Console.Write("\nPrecio:");
                    flag = int.TryParse(Console.ReadLine(), out precio);
                    flag = ValidarPrecio(precio);
                }
                while (!flag);
                if (color == "Rojo")
                {
                    cantidadRojos++;
                    if(precio > 5000)
                    {
                        Rojosmayor5000++;
                    }
                }
                if(precio < 5000)
                {
                    cantidadMenor5000++;
                }
                promedio += precio;
                if(i==1)
                {
                    mayor = precio;
                    colorMayor = color;
                }
                else
                {
                    if(mayor < precio)
                    {
                        mayor = precio;
                        colorMayor = color;
                    }
                }
                Console.WriteLine("-------------------------------------------------------");
                do
                {
                    Console.Write(
                    "Desea seguir?\n" +
                    "Y/N\n"+
                    "Opcion:");
                    respuesta = char.Parse(Console.ReadLine()); 
                }
                while (respuesta != 'Y' && respuesta != 'N');
                if (respuesta == 'Y')
                {
                    iterar = true;
                    i++;
                }
                else
                {
                    iterar = false;
                }
                Console.WriteLine("-------------------------------------------------------");
            }
            while (iterar);
            Console.WriteLine(
                "\nLa cantidad de rojos:                                           \t{0}\n" +
                "La cantidad de rojos con precio mayor a 5000:                   \t{1}\n" +
                "La cantidad de vehículos con precio inferior a 5000:            \t{2}\n" +
                "El promedio de todos los vehículos ingresados:                  \t{3}\n" +
                "El más caro y su color:                                         \t{4} {5}",
                cantidadRojos, Rojosmayor5000, cantidadMenor5000, promedio/i, mayor, colorMayor);
        }
        static bool ValidarColor(string color)
        {
            if(color == "Rojo" || color == "Verde" || color == "Amarillo")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarPrecio(int precio)
        {
            if(precio > 0 && precio < 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----------Venta de coches----------");
            Venta();
            Console.ReadKey();
        }
    }
}
