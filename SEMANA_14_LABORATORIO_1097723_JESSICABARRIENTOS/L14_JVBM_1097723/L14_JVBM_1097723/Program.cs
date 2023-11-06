using System;
using System.Numerics;

internal class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Semana 14");

        int[] vector = new int[7];
        int valores = 0;
        int Max = 0;
        int Min = 0;
        int P = 0;
        int N = 0;
        int continuar = 0;

       
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Ingresar 7 números: ");
                valores = int.Parse(Console.ReadLine());
                vector[i] = valores;

                if (vector[i] > Max)
                {
                    Max = vector[i];
                }

                if (vector[i] < Min )
                {
                    Min = vector[i];
                }
            }

        Console.WriteLine("Nota más alta: " + Max);
        Console.WriteLine("Nota más baja: " + Min);

        Console.ReadKey();


    }
}