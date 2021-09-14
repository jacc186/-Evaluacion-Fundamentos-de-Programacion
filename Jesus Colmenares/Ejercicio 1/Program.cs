using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
         static int Ingresar()
         {
            bool numeroCorrecto = false;
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            do
            {
                numeroCorrecto = int.TryParse(Console.ReadLine(), out numero);
            }
            while (!numeroCorrecto);
            return numero;
         }

        static void Main(string[] args)
        {
            double valor1 = Ingresar();  
            double valor2 = Ingresar();

            if (valor1 == valor2)
            {
                Console.WriteLine("Imprimo el cuadrado del numero: {0}", Math.Pow(valor1, 2));
            }
            else if(valor1 % valor2 == 0)
            {
                Console.WriteLine("El primero es divisible por el segundo\nResto los dos numeros: {0}", valor1 - valor2);
            }
            else
            {
                Console.WriteLine("El primero no es divisible por el segundo\nMuestro el resto: {0}", valor1 % valor2);
                if(valor1 % valor2 >3)
                    Console.WriteLine("El resto es mayor a 3(tres)");
            }
            Console.ReadKey();

        }
    }
}

