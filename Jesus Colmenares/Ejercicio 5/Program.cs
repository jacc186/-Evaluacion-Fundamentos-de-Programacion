using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Finales()
        {
            string nombre;
            int edad, i = 1, cantidadVaronesAprobados = 0, cantidadAdelescentes = 0, cantidadMenores = 0, 
                cantidadMayores = 0, cantM = 0, cantF = 0, cantO = 0;
            char sexo, opcion;
            int nota;
            bool flag = true, bandera = false;
            float promedioNotaMenores = 0, promedioAdolescentes = 0, promedioMayores = 0, promedioM = 0, promedioF = 0, promedioO = 0;
            do
            {
                Console.WriteLine("Ingrese el nombre del estudiante {0}:", i);
                nombre = Console.ReadLine();

                do
                {
                    Console.WriteLine("\nEdad:");
                    bandera = int.TryParse(Console.ReadLine(), out edad);
                    bandera = validarEdad(edad);
                }
                while (!bandera);
                do
                {
                    Console.Write(
                        "\nSexo.\nF/M/O\n"+
                        "Opción:");
                    bandera = char.TryParse(Console.ReadLine(), out sexo);
                    bandera = validarSexo(sexo);
                }
                while (!bandera);
                do
                {
                    Console.WriteLine("\nNota Final:");
                    bandera = int.TryParse(Console.ReadLine(), out nota);
                    bandera = validarNota(nota);
                }
                while (!bandera);
                Console.WriteLine("-------------------------------------------------------");
                if(sexo == 'M' && nota >=6)
                {
                    cantidadVaronesAprobados++;
                }
                if(edad < 18)
                {
                    promedioNotaMenores += nota;
                    cantidadMenores++;
                }
                if(edad >13 && edad <18)
                {
                    promedioAdolescentes += nota;
                    cantidadAdelescentes++;
                }
                if(edad >=18)
                {
                    cantidadMayores++;
                    promedioMayores += nota;
                }
                if(sexo == 'M')
                {
                    promedioM += nota;
                    cantM++;
                }
                else if(sexo == 'F')
                {
                    promedioF += nota;
                    cantF++;
                }
                else
                {
                    promedioO += nota;
                    cantO++;
                }
                do
                {
                    Console.Write(
                        "¿Desea continuar?\n" +
                        "Y/N\n"+
                        "Opción:");
                    bandera = char.TryParse(Console.ReadLine(), out opcion);
                }
                while (!bandera);
                if(opcion == 'Y')
                {
                    flag = true;
                    i++;
                }
                else
                {
                    flag = false;
                }
                Console.WriteLine("-------------------------------------------------------");
            }
            while (flag);
            Console.WriteLine(
                "Cantidad de varones aprobados:                    \t{0}\n"+
                "Promedio de notas de los menores de edad:         \t{1}\n"+
                "Promedio de notas de los adolescentes:            \t{2}\n"+
                "Promedio de notas de los mayores de edad:         \t{3}\n"+
                "promedio de notas por sexo:                       \tM:{4} F:{5} O:{6}",
                cantidadVaronesAprobados, promedioNotaMenores/cantidadMenores, 
                promedioAdolescentes/cantidadAdelescentes, promedioMayores/cantidadMayores, promedioM/cantM, promedioF/cantF, promedioO/cantO);

        }
        static bool validarSexo(char sexo)
        {
            if(sexo == 'M' || sexo == 'F' || sexo == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool validarEdad(int edad)
        {
            if(edad > 0 && edad < 120)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool validarNota(int nota)
        {
            if(nota >= 0 && nota <= 10)
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
            Finales();

            Console.ReadKey();

        }
    }
}
