using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        //// a. Definición e inicialización de variables

        //int a, b, c;

        //a = 7;
        //b = a;
        //c = b++;

        //// b. Diferencias entre tipos de datos numéricos, booleanos y cadenas

        //string cadena;
        //int entero;
        //float flotante;
        //decimal dec;
        //bool boleano;

        //cadena = "texto";

        //entero = 100;

        //flotante = 3.1416f;

        //dec = 10.00m;

        //boleano = true;

        //// c. Operaciones Aritméticas (incliyendo DIV y MOD)

        //int dividendo, divisor, cociente, residuo;

        //dividendo = 50;
        //divisor = 4;
        //cociente = dividendo / divisor;
        //residuo = dividendo % divisor;

        //Console.WriteLine("DIV: " + cociente);
        //Console.WriteLine("MOD: " + residuo);


        Console.WriteLine("Ejercicio 1: Operaciones aritméticas");

        Console.WriteLine("Ingrese un número");
        string numero1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numero1);

        Console.WriteLine("Ingrese otro número: ");
        string numero2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numero2);

        int suma = num1 + num2;

        Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + suma);

        int resta = num1 - num2;

        Console.WriteLine("Resta: " + num1 + " - " + num2 + " = " + resta);

        int multiplicacion = num1 * num2;

        Console.WriteLine("Multiplicación: " + num1 + " * " + num2 + " = " + multiplicacion);

        int division = num1 / num2;

        Console.WriteLine("División: " + num1 + " / " + num2 + " = " + division);

        int residuo = num1 % num2;

        Console.WriteLine("Residuo: " + num1 + " % " + num2 + " = " + residuo);

        Console.WriteLine("Ejercicio 2: Operaciones booleanas");
        if (num1 > num2)
        {
            Console.WriteLine(num1 + " es mayor que: " + num2);
        }
        else if (num1 > num2)
        {
            Console.WriteLine(num1 + "es menor que: " + num2);
        }
        else if (num1 == num2)
        {
            Console.WriteLine(num1 + " es igual a: " + num2);

        }

        Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");

        Console.WriteLine("Ingrese un número extra: ");
        string numero3 = Console.ReadLine();
        int num3 = Convert.ToInt32(numero3);

        int operacion1 = num1 * num2 + num3;

        Console.WriteLine("Operación 1: " + num1 + " * " + num2 + " + " + num3 + " = " + operacion1);

        int operacion2 = num1 * (num2 + num3);

        Console.WriteLine("Operación 2: " + num1 + " * (" + num2 + " + " + num3 + ") = " + operacion2);

        Console.ReadKey();
    }
}