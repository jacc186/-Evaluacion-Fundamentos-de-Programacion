using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Viaje()
        {
            bool flag = false;
            string continente, metodoPago;
            int cantidadDias;
            double descuento, total;

            do
            {
                Console.Write(
                    "\n¿Cual continente le gustaria viajar?\n\n" +
                    "Continentes disponibles:\n" +
                    "América - Asia - Europa - Africa - Oceanía.\n\n" +
                    "Nota: Se toman en cuenta tildes y mayúsculas." + 
                    "\n\nOpcion:");
                continente = Console.ReadLine();
                flag = ValidarContinente(continente);
            }
            while (!flag);

            Console.WriteLine("-------------------------------------------------------");

            do
            {
                Console.WriteLine("\nIngrese la cantidad de dias que desea hospedarse:");
                flag = int.TryParse(Console.ReadLine(), out cantidadDias);
            }
            while (!flag);


            Console.WriteLine("-------------------------------------------------------");

            do
            {
                Console.WriteLine(
                    "\nIngrese un método de pago.\n\n" +
                    "Pagos disponibles:\n" +
                    "Débito - Crédito - Efectivo - Mercado Pago - Cheque - Leliq\n\n" +
                    "Nota: Se toman en cuenta tildes y mayúsculas." +
                    "\n\nOpcion:");
                metodoPago = Console.ReadLine();
                flag = ValidarPago(metodoPago);
            }
            while (!flag);

            Console.WriteLine("-------------------------------------------------------");

            if (continente == "América")
            {
                descuento = 15;
                
                if (metodoPago == "Débito")
                {
                    descuento += 10;
                }
                else if (metodoPago == "Cheque")
                {
                    descuento += -15;
                }
            }
            else if(continente == "Africa" || continente == "Oceanía")
            {
                descuento = 30;
                if(metodoPago == "Mercado Pago" || metodoPago == "Efectivo")
                {
                    descuento += 15;
                }
                else if (metodoPago == "Cheque")
                {
                    descuento += -15;
                }
            }
            else if(continente == "Europa")
            {
                descuento = 20;

                if (metodoPago == "Débito")
                {
                    descuento += 15;
                }
                else if(metodoPago == "Mercado Pago")
                {
                    descuento += 10;
                }
                else if (metodoPago == "Cheque")
                {
                    descuento += -15;
                }
                else
                {
                    descuento += 5;
                }
            }
            else
            {
                descuento = -20;
                if (metodoPago == "Cheque")
                {
                    descuento += -15;
                }
            }           
            total = (cantidadDias * 100) - (cantidadDias * 100)*descuento / 100;

            Console.WriteLine(
                "Cantidad total de dias:      \t{1}\n" +
                "Precio por dia es:       \t$100\n" +
                "-------------------------------------------------------\n" +
                "-------------------------------------------------------" +
                "\nEl  descuento es de:     \t{0}%\n" +                
                "precio final es de:      \t${2}",
                descuento,cantidadDias,total);



        }
        static bool ValidarContinente(string continente)
        {
            if (continente == "América" || continente == "Asia" || continente == "Europa" || continente == "Africa" || continente == "Oceanía")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ValidarPago(string pago)
        {
            if(pago == "Débito" || pago == "Crédito" || pago == "Efectivo" || pago == "Mercado Pago" || pago == "Cheque" || pago == "Leliq")
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

            Console.WriteLine("-----------Empresa de viajes-----------");

            Viaje();

            Console.ReadKey();
        }
    }
}
