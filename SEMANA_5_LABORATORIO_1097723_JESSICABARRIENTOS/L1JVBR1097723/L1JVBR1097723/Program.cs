using System;
class Program
{
    static void Main(string[] args)
    {
        /*
          Console.WriteLine("Hola mundo");
          Console.WriteLine("Soy Jess");

          Console.Write("Hola mundo ");
          Console.Write("soy Jess");*/

        /*comentarios programa*/
        /*Console.ReadKey();*/

        Console.WriteLine("Ingrese su nombre:");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Hola mundo");
        Console.WriteLine("Soy " + Nombre);

        Console.Write("Hola mundo");
        Console.Write(" soy " + Nombre);
        Console.ReadKey();

    }
}