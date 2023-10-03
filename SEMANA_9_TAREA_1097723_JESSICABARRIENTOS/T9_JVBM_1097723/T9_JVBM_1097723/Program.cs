
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tarea semana 9");
        Console.WriteLine("Parte a");
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("El número debe ser un entero mayor que 0");
        }
        else
        {
            double suma = 0.0;
            //Según bibliografía y manuales consultados, se coloca el decimal "0.0" para pedir resultados también con decimales y sin aproximaciones.
            int i = 1;

            while (i <= num)
            {
                suma += 1.0 / i;
                i++;
            }
            Console.WriteLine("La primera serie matemática resulta en: " + suma);
        }

        Console.WriteLine("Parte b");
        if (num <= 0)
        {
            Console.WriteLine("El número debe ser un entero mayor que 0");
        }
        else
        {
            double suma2 = 0.0;

            for (int j = 1; j <= num; j++)
            {
                suma2 += 1.0 / Math.Pow(2, j);
                //Según bibliografía y manuales consultados, para indicar una potencia se emplea Math.Pow, colocando primero el número que se desea elevar y de segundo el exponente.
            }
            Console.WriteLine("La primera serie matemática resulta en: " + suma2);
        }
    }
}