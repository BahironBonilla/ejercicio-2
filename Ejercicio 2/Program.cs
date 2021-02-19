using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;
            float pulsaciones;
            string sexo, click = "s";
            do
            {

                Console.Clear();

                Console.WriteLine("Su sexo es [f|m] \n");

               
                Console.WriteLine("Sexo: ");
                sexo = Console.ReadLine();

                if(sexo == "m" || sexo  == "f")
                {

                    Console.WriteLine("edad: ");
                    edad = Int32.Parse(Console.ReadLine());



                    if (sexo == "m")
                    {

                        pulsaciones = (210 - edad) / 10;
                        Console.WriteLine("el número de pulsaciones que debe tener un hombre por cada 10 segundos de ejercicio aeróbico es " + pulsaciones);
                    }
                    else if (sexo == "f")
                    {
                        pulsaciones = (220 - edad) / 10;
                        Console.WriteLine("el número de pulsaciones que debe tener una mujer por cada 10 segundos de ejercicio aeróbico es " + pulsaciones);
                    }

                }
                else
                {
                    Console.WriteLine("sexo no valido...");
                }


                

                Console.WriteLine("\n\n\n\n ¿Desea continuar?[s|n]");
                click = Console.ReadLine();

            } while (click == "s" || click == "S");


        }
    }
}
