using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static bool validarPeso(int peso)
        {
         if(peso > 0 && peso < 500)
            {
                return true;
            }
         else
            {
                Console.WriteLine("El peso debe ser mayor a 0 y menor a 500");
                return false;
            }
        }
        static bool validarSabor(string sabor)
        {
            if (sabor == "Carne" || sabor == "Vegetales" || sabor == "Pollo")
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

            int peso, cantidadBolsasCarne = 0, menorpeso=0;
            string sabor, menorSabor = "";
            double promedioPeso = 0, promedioPesoCarne = 0;
            bool flag;

            Console.WriteLine("----------Bolsas de alimento para mascotas----------");
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("\nBolsa de alimento {0}", i + 1);
                do
                {
                    Console.Write("Peso: ");
                    flag = int.TryParse(Console.ReadLine(), out peso);
                    flag = validarPeso(peso);
                }
                while (!flag);
                promedioPeso += peso;

                do
                {
                    Console.Write(
                        "\nSabores disponibles: \nCarne - Vegetales - Pollo\n\n" +
                        "Opción:");
                    sabor = Console.ReadLine();
                    flag = validarSabor(sabor);
                }
                while (!flag);

                if(i == 0)
                {
                    menorpeso = peso;
                    menorSabor = sabor;
                }
                if (menorpeso > peso)
                {
                    menorpeso = peso;
                    menorSabor = sabor;
                }
                if (sabor == "Carne")
                {
                    cantidadBolsasCarne++;
                    promedioPesoCarne += peso;
                }

                Console.WriteLine("-------------------------------------------------------");
            }

            Console.WriteLine(
                "\nEl promedio de pesos de kilos totales fue: \t{0}\n" +
                "La bolsa mas liviana:                      \t{1} {2}\n" +
                "La cantidad de bolsas de carne:            \t{3}\n" +
                "Promedio de bolsas de carne:               \t{4}",
                promedioPeso, menorpeso, menorSabor, cantidadBolsasCarne, promedioPesoCarne);
        }
    }
}
