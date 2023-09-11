using System;

class Program
{
    static void Main(string[] args)
    {
        /*if (1>2)
        {
            Console.WriteLine("Instrucción IF");
        }
        else
        {
            Console.WriteLine("Instrucción ELSE");
        }

        Console.ReadKey();*/

        Console.WriteLine("Ejercicio 2");
        int numero; //variable tipo entero
        string entrada; //variable tipo cadena de texto

        Console.WriteLine("Ingrese un número del 1 al 7: ");
        entrada = Console.ReadLine();
        numero = Int32.Parse(entrada);

        if (numero >=1 && numero<=7)
        {
            if (numero==1)
            {
                Console.WriteLine("DÍA: LUNES");
            }
            else if (numero == 2)
            {
                Console.WriteLine("DÍA: MARTES");
            }
            else if (numero == 3)
            {
                Console.WriteLine("DíA: MIÉRCOLES");
            }
            else if (numero == 4)
            {
                Console.WriteLine("DÍA: JUEVES");
            }
            else if (numero == 5)
            {
                Console.WriteLine("DÍA: VIERNES");
            }
            else if(numero==6)
            {
                Console.WriteLine("DÍA: SÁBADO");
            }
            else if(numero == 7)
            {
                Console.WriteLine("DÍA: DOMINGO");
            }
        }
        else
        {
            Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
        }

    }
}