using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REFOR_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            //Inicio 
            //Declaramos variables
            long Numero, Digito;
            int Contador = 0;
            long Invertido = 0;

            //Mostramos en pantalla y asignamos a una variable
            Console.WriteLine("Buen díá. Ingrese un número entero: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            long NumeroExistente = Numero;

            while (Numero >= 1) 
            {
                Digito = Numero % 10;
                Numero /= 10;
                Invertido = (Invertido * 10) + Digito;
                Contador += 1;
            }

            Console.WriteLine("El número de dígito es: "+Contador);
            Console.WriteLine("El número de invertido es: " + Invertido);
        }
    }
}
